using Assessment14.Models;

namespace Assessment14.Factories
{
    public class SoyMilkFactory : MilkFactory
    {
        public override Milk UseMilk() => new SoyMilk();
    }
}
