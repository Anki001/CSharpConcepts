using OpenClose;

namespace OpenClose
{
    internal class Customer
    {
        private int _custType;

        public int CustType { get => _custType; set => _custType = value; }

        internal void Add()
        {
            throw new NotImplementedException();
        }

        internal double GetDiscount(double totalBillAmpunt)
        {
            if (_custType == 1)
            {
                return totalBillAmpunt - 100;
            }
            else
            {
                return totalBillAmpunt - 50;
            }
        }
    }
}

//The problem is if we add a new customer type we need to go and add one more “IF” condition
//in the “getDiscount” function, in other words we need to change the customer class.

//If we are changing the customer class again and again, we need to ensure that the previous
//conditions with new one’s are tested again , existing client’s which are referencing this class are working properly as before.