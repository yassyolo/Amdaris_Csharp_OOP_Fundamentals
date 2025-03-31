using Assessment14.Models;

namespace Assessment14.Factories
{
    public class EspressoFactory : CoffeeFactory
    {
        public override Coffee MakeCoffee() => new Espresso();
    }
}
