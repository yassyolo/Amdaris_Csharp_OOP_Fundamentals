namespace Assessment14.Models
{
    public class Cappuccino : Coffee
    {
        public Cappuccino() : base()
        {
            Name = "Cappuccino";
            Ingredients.Add("Regular milk");
        }
    }
}
