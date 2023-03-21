namespace SingleResponsibility
{
	internal class Customer
    {
        internal void Add()
        {
			try
			{
                Console.WriteLine("Data validation");
                Console.WriteLine("Logic to add customer in database");

                throw new Exception("Not Following Single Responsibility");
            }
			catch (Exception ex)
			{
				File.WriteAllText(@"c:\error.txt", ex.ToString());
			}
		}
	}
}

// The above customer class is doing things WHICH HE IS NOT SUPPOSED TO DO.
// Customer class should do customer datavalidations, call the customer data access layer etc,
// but if you see the catch block closely it also doing LOGGING activity.
// In simple words its over loaded with lot of responsibility.