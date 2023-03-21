using BuilderDesignPattern.Interfaces;

namespace BuilderDesignPattern.Concrete
{
    // Concrete Builder
    public class VeggiePizza : IPizzaBuilder
    {
        private string _crust;
        private string _sauce;
        private List<string> _toppings;

        public Pizza Build()
        {
            return new Pizza(_crust, _sauce, _toppings);
        }

        public void SetCrust(string crust)
        {
            _crust = crust;
        }

        public void SetSauce(string sauce)
        {
            _sauce = sauce;
        }

        public void SetToppings(IEnumerable<string> toppings)
        {
            _toppings = toppings.ToList();
        }
    }
}
