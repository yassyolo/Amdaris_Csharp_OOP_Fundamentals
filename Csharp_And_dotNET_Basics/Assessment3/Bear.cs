namespace Assessment3
{
    public class Bear : Animal
    {
        public Bear(string name, string sponsor, string breed, int age)
            : base(name, sponsor, breed, age)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} growls.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating berries and fish.");
        }

        public void Hibernate()
        {
            Console.WriteLine($"{Name} is hibernating.");
        }

        public override object Clone()
        {
            return new Bear(Name, Sponsor, Breed, Age);
        }
    }
}
