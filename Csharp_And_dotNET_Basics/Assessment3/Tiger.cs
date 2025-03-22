namespace Assessment3
{
    public class Tiger : Animal
    {
        public Tiger(string name, string sponsor, string breed, int age)
            : base(name, sponsor, breed, age)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} roars.");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat.");
        }

        public override object Clone()
        {
            return new Tiger(Name, Sponsor, Breed, Age);
        }
    }
}
