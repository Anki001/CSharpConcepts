using System.Text;

namespace DependencyInversion
{
    // In our customer class if you see we had created a logger class to satisfy SRP.
    // Down the line let’s say new Logger flavor classes are created.

    //Now depending on configuration settings different logger classes will used at given moment.
    //So to achieve the same we have kept a simple IF condition which decides which logger class to be used, see the below code.

    //The above code is again violating SRP but this time the aspect is different, its about deciding which objects should be created.
    //Now it’s not the work of “Customer” object to decide which instances to be created, he should be concentrating only on Customer
    //class related functionalities.

    //If you watch closely the biggest problem is the “NEW” keyword. He is taking extra responsibilities of which object needs to be created.

    //So if we INVERT / DELEGATE this responsibility to someone else rather the customer class doing it that would really
    //solve the problem to a certain extent.
    //Refer to DiCustomer class

    interface IDatabaseOperationV1
    {
        void Add();
    }

    internal class Customer : IDatabaseOperationV1
    {
        private ILogger _logger;
        int exHandle = 1;        

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
                if(exHandle == 1)
                    _logger = new FileLogger(); 
                else
                    _logger = new EmailLogger();

                _logger.Handle(ex.ToString());
            }
        }
    }
}
