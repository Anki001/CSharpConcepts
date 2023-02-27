namespace BuilderDesignPattern
{
    // Product
    public class Pizza
    {
        public string Crust { get; private set; }
        public string Sauce { get; private set; }
        public List<string> Toppings { get; private set; }

        public Pizza(string crust, string sauce, List<string> toppings)
        {
            Crust = crust;
            Sauce = sauce;
            Toppings = toppings;
        }
    }
}
