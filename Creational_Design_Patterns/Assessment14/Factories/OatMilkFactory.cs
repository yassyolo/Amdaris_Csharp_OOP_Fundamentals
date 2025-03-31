using Assessment14.Models;

namespace Assessment14.Factories
{
    public class OatMilkFactory : MilkFactory
    {
        public override Milk UseMilk() => new OatMilk();
    }
}
