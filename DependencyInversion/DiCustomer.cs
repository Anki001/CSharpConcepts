namespace DependencyInversion
{    
    internal class DiCustomer: IDatabaseOperationV1
    {
        private ILogger _logger;
        
        public DiCustomer(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            try
            {
                Console.WriteLine("Data validation");
                Console.WriteLine("Logic to add customer in database");

                throw new Exception("Following Single Responsibility");
            }
            catch (Exception ex)
            {
                _logger.Handle(ex.ToString());
            }
        }
    }
}
