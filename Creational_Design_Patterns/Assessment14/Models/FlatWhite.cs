using Assessment14.Factories;

namespace Assessment14.Models
{
    public class FlatWhite : Coffee
    {
        public FlatWhite() : base()
        {
            Name = "Flat White";
            Ingredients.Add("Black coffee");
            Ingredients.Add("Regular milk");
        }
    }
}
