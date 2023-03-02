namespace LiskovSubstitution
{
    internal class Customer
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
    }

    internal class GoldCustomer : Customer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 100;
        }
    }

    internal class SilverCustomer : Customer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 50;
        }
    }

    internal class Enquiry : Customer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 5;
        }

        internal override void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}

//Let’s continue with the same customer. Let’s say our system wants to calculate discounts for Enquiries.
//Now Enquiries are not actual customer’s they are just leads. Because they are just leads we do not want to save them to database for now.

//So we create a new class called as Enquiry which inherits from the “Customer” class.
//We provide some discounts to the enquiry so that they can be converted to actual customers
//and we override the “Add’ method with an exception so that no one can add an Enquiry to the database.
