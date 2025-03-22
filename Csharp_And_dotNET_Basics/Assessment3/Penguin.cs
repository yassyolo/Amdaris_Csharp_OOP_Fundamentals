namespace Assessment3
{
    public class Penguin : Animal
    {
        public Penguin(string name, string sponsor, string breed, int age)
            : base(name, sponsor, breed, age)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} makes a honking sound.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fish.");
        }

        public override object Clone()
        {
            return new Penguin(Name, Sponsor, Breed, Age);
        }
    }
}
