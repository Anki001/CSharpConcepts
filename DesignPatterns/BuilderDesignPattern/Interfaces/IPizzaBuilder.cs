namespace BuilderDesignPattern.Interfaces
{
    // Builder Interface
    public interface IPizzaBuilder
    {
        void SetCrust(string crust);
        void SetSauce(string sauce);
        void SetToppings(IEnumerable<string> toppings);

        Pizza Build();
    }
}
