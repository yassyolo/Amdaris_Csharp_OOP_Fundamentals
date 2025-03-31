using Assessment14.Models;

namespace Assessment14.Factories
{
    public class RegularMilkFactory : MilkFactory
    {
        public override Milk UseMilk() => new RegularMilk();
    }
}
