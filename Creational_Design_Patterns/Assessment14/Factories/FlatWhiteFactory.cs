using Assessment14.Models;

namespace Assessment14.Factories
{
    public class FlatWhiteFactory : CoffeeFactory
    {
        public override Coffee MakeCoffee() => new FlatWhite();
    }
}
