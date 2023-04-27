namespace Learning.DataStore.Interfaces
{
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// Start the transaction
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits the active transaction
        /// </summary>
        void Commit();

        /// <summary>
        /// Sets the named save point in the transaction
        /// </summary>
        /// <param name="name"></param>
        void SetSavePoint(string name);

        /// <summary>
        /// Removes the save point set in the transaction
        /// </summary>
        /// <param name="name"></param>
        void RemoveSavePoint(string name);

        /// <summary>
        /// Rolls back the active transaction
        /// </summary>
        void Rollback();

        /// <summary>
        /// Rollback to the save point without rolling back the entier transaction
        /// </summary>
        /// <param name="name"></param>
        void RollbackToSavePoint(string name);

        /// <summary>
        /// Fetches data from the database into a model class and handles database exception
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetResultSetAsync<T>(string sqlCommand, object parameters = null);

        /// <summary>
        /// Fetches data from the database into a model class and handles database exception
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>        
        Task<T> GetResultAsync<T>(string sqlCommand, object parameters = null);

        /// <summary>
        /// Execute the command and handles any db exception with retries.
        /// Returns the count of the records affected
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> ExecuteCommandAsync<T>(string sqlCommand, object parameters = null);

        /// <summary>
        /// Execute the command and handles any db exception with retries.
        /// Returns the id of the affected record.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> ExecuteScalarAsync<T>(string sqlCommand, object parameters = null);
    }
}
