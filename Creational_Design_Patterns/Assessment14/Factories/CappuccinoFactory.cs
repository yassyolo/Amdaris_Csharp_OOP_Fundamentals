using Assessment14.Models;

namespace Assessment14.Factories
{
    public class CappuccinoFactory : CoffeeFactory
    {
        public override Coffee MakeCoffee() => new Cappuccino();
    }
}
