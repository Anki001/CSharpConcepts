// See https://aka.ms/new-console-template for more information

using LiskovSubstitution;

// As per the inheritance hierarchy the “Customer” object can point to any one of its child objects and we do not expect any unusual behavior.

// But when “Add” method of the “Enquiry” object is invoked it leads to below error because our “Equiry” object
// does save enquiries to database as they are not actual customers.

List<Customer> lstCust = new();
lstCust.Add(new SilverCustomer());
lstCust.Add(new GoldCustomer());
lstCust.Add(new Enquiry());

Console.WriteLine("Add customer of each type");

foreach (var cust in lstCust)
{
    cust.Add(); // Not Allowed exception for Enquiry at runtime
}


// Now there is no confusion, we can create a list of “Idatabase” interface and add the relevant classes to it.
// In case we make a mistake of adding “Enquiry” class to the list compiler would complain as shown in the below code snippet.

List<LsCustomer> lstCustomer = new();
lstCustomer.Add(new LsSilverCustomer());
lstCustomer.Add(new LsGoldCustomer());
// lstCustomer.Add(new LsEnquiry()); // Compile time error

Console.WriteLine("Add customer of each type");

foreach (var cust in lstCustomer)
{
    cust.Add();
}
