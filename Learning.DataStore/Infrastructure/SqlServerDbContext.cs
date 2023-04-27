using Dapper;
using Learning.DataStore.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Learning.DataStore.Infrastructure
{
    public class SqlServerDbContext : IDbContext
    {
        private SqlConnection _dbConnection;
        private SqlTransaction _dbTransaction;

        public void BeginTransaction()
        {
            if (_dbConnection is null)
            {
                Connect().Wait();
            }
            _dbTransaction = _dbConnection.BeginTransaction();
        }

        public void Commit()
        {
            _dbTransaction?.Commit();
            _dbTransaction = null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<int> ExecuteCommandAsync<T>(string sqlCommand, object parameters = null)
        {
            return await ExecuteAction(() => _dbConnection.ExecuteAsync(sqlCommand, parameters));
        }

        public async Task<int> ExecuteScalarAsync<T>(string sqlCommand, object parameters = null)
        {
            return await ExecuteAction(() => _dbConnection.ExecuteScalarAsync<int>(sqlCommand, parameters));
        }

        public async Task<T> GetResultAsync<T>(string sqlCommand, object parameters = null)
        {
            return await ExecuteAction(() => _dbConnection.QuerySingleOrDefaultAsync<T>(sqlCommand, parameters));
        }

        public async Task<IEnumerable<T>> GetResultSetAsync<T>(string sqlCommand, object parameters = null)
        {
            return await ExecuteAction(() => _dbConnection.QueryAsync<T>(sqlCommand, parameters));
        }

        public void RemoveSavePoint(string name)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            _dbTransaction?.Rollback();
            _dbTransaction = null;
        }

        public void RollbackToSavePoint(string name)
        {
            throw new NotImplementedException();
        }

        public void SetSavePoint(string name)
        {
            throw new NotImplementedException();
        }

        #region [Private Functions]
        private async Task Connect()
        {
            if (_dbConnection is not null)
            {
                if (_dbConnection.State == ConnectionState.Closed)
                {
                    _dbConnection.Dispose();
                    _dbConnection = null;
                }
                else
                {
                    return;
                }
            }

            _dbConnection = new SqlConnection("ConnectionString");

            await _dbConnection.OpenAsync();
        }

        /// <summary>
        /// Execute the function, returns the result-set and handles any db exception with retries
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="execFunction"></param>
        /// <returns></returns>
        private async Task<T> ExecuteAction<T>(Func<Task<T>> execFunction)
        {
            // int.TryParse(_appConfiguration.Database.MinRetries, out var maxRetries)

            int maxRetries = 3;

            var retriesPerformed = 0;
            var result = default(T);

            while (retriesPerformed < maxRetries)
            {
                retriesPerformed++;

                try
                {
                    await Connect();

                    result = await execFunction();
                    return result;
                }
                catch (SqlException ex)
                {
                    if (!CanRetryOperation(ex.SqlState) || retriesPerformed == maxRetries - 1)
                    {
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    if (retriesPerformed == maxRetries - 1)
                        throw;

                    Thread.Sleep(250); // All other errors, sleep for a while
                }
            }

            return result;
        }

        private static bool CanRetryOperation(string state)
        {
            // Need to write logic to check for what type of errors only need to retry connecting DB
            if (state is null)
                return false;
            return true;
        }
        #endregion
    }
}
