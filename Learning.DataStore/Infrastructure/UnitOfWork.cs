using Learning.DataStore.Interfaces;
using Learning.DataStore.Repositories;
using Microsoft.Extensions.Logging;

namespace Learning.DataStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<UnitOfWork> _logger;
        public IDbContext _dbContext;

        public UnitOfWork(IServiceProvider serviceProvider,
            IDbContext dbContext,
            ILogger<UnitOfWork> logger)
        {
            _serviceProvider = serviceProvider;
            _dbContext = dbContext;
            _logger = logger;
        }

        public WeatherForecastRepository WeatherForecastRepository => WeatherForecastRepository ?? GetRepository<WeatherForecastRepository>();

        /// <summary>
        /// Start the transaction
        /// </summary>
        public void BeginTransaction()
        {
            _dbContext.BeginTransaction();
            _logger.LogDebug("Begin Transaction");
        }

        /// <summary>
        /// Commits the active transaction
        /// </summary>
        public void CommitTransaction()
        {
            _dbContext.Commit();
            _logger.LogDebug("Transaction Commited");
        }

        /// <summary>
        /// Rolls back the active transaction
        /// </summary>
        public void RollbackTransaction()
        {
            _logger.LogDebug("Rollback Transaction");

            try
            {
                _dbContext.Rollback();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Rollback Failed");
            }
        }

        private T GetRepository<T>()
        {
            return (T)_serviceProvider.GetService(typeof(T));
        }

    }
}
