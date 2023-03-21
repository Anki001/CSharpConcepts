namespace OpenClose
{
    internal class OcCustomer
    {
        internal virtual double GetDiscount(double totalBillAmount)
        {
            return totalBillAmount;
        }
    }

    internal class GoldCustomer : OcCustomer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 100;
        }
    }

    internal class SilverCustomer : OcCustomer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 50;
        }
    }

    internal class PlatinumCustomer : OcCustomer
    {
        internal override double GetDiscount(double totalBillAmount)
        {
            return base.GetDiscount(totalBillAmount) - 399;
        }
    }

}

//Putting in simple words the “Customer” class is now closed for any new modification but
//it’s open for extensions when new customer types are added to the project.