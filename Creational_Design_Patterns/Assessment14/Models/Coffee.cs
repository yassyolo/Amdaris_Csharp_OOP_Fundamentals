using System.Text;

namespace Assessment14.Models
{
    public abstract class Coffee
    {
        public List<string> Ingredients { get; private set; } = new List<string>() { "Black coffee" };
        public string Name { get; protected set; }
        public int Sugars { get; private set; }
        public Coffee()
        {
        }
        public void AddIngredient(string ingredient)
        {
            if(ingredient == "Sugar")
            {
                Sugars++;
                return;
            }
            Ingredients.Add(ingredient);
        }
        public override string ToString()
        {
            string result = $"{Name} = {string.Join(" + ", Ingredients)}";
            if (Sugars > 0)
                result += " + " + string.Join(" + ", Enumerable.Repeat("Sugar", Sugars));

            return result;
        }
    }
}
