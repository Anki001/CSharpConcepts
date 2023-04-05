namespace SingleResponsibility
{
    internal class SrpCustomer
    {
        private FileLogger _fileLogger = new FileLogger();
        internal void Add()
        {
            try
            {
                Console.WriteLine("Data validation");
                Console.WriteLine("Logic to add customer in database");

                throw new Exception("Following Single Responsibility");
            }
            catch (Exception ex)
            {
                _fileLogger.Handle(ex.ToString());
            }
        }
    }
}

//Now customer class can happily delegate the logging activity to the “FileLogger”
//class and he can concentrate on customer related activities.

//Now architecture thought process is an evolution. For some people who are seniors looking
//at above SRP example can contradict that even the try catch should not be handled by the
//customer class because that is not his work.