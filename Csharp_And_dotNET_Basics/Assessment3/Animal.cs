namespace Assessment3
{
    public abstract class Animal : ICloneable
    {
        private string name;
        private string sponsor;
        private string breed;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public string Sponsor
        {
            get { return sponsor; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Sponsor is set to null.");
                    sponsor = "None";
                }
                else
                {
                    sponsor = value;
                }                 
            }
        }

        public string Breed
        {
            get { return breed; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Breed cannot be empty.");
                }
                
                breed = value;
            }
        }

        public string AgeCategory
        {
            get
            {
                if (Age < 5)
                    return "Young";
                else if (Age < 10)
                    return "Adult";
                else
                    return "Old";
            }
        }

        protected int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                age = value;
            }
        }

        public Animal(string name, string sponsor, string breed, int age)
        {
            Name = name;
            Sponsor = sponsor; 
            Breed = breed;
            Age = age;
        }

        public abstract void Sound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public abstract object Clone();
    }
}
