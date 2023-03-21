using BuilderDesignPattern.Interfaces;

namespace BuilderDesignPattern
{
    // Director
    public class Waiter
    {
        private IPizzaBuilder _pizzaBuilder;

        public void SetBuilder(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.Build();
        }
    }
}
