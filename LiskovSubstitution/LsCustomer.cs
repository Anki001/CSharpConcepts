namespace LiskovSubstitution
{
    // So LISKOV principle says the parent should easily replace the child object.
    // So to implement LISKOV we need to create two interfaces one is for discount and other for database as shown below.

    interface IDiscount
    {
        double GetDiscount(double totalBillAmount);
    }

    interface IDatabaseOperation
    {
        void Add();
    }

    internal class LsCustomer : IDatabaseOperation, IDiscount
    {
        internal virtual double GetDiscount(double totalBillAmount)
        {
            return totalBillAmount;
        }
        internal virtual void Add()
        {
            //Console.WriteLine("Data validation");
            //Console.WriteLine("Logic to add customer in database");
        }

        void IDatabaseOperation.Add()
        {
            throw new NotImplementedException();
        }

        double IDiscount.GetDiscount(double totalBillAmount)
        {
            throw new NotImplementedException();
        }
    }

    internal class LsGoldCustomer : LsCustomer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 100;
        }
    }

    internal class LsSilverCustomer : LsCustomer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 50;
        }
    }

    internal class LsEnquiry : IDiscount
    {        
        double IDiscount.GetDiscount(double totalBillAmount)
        {
            return totalBillAmount - 5;
        }
    }

}
