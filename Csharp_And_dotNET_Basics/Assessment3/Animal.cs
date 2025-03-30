namespace Assessment3
{
    public abstract class Animal : ICloneable
    {
        private string _name;
        private string _sponsor;
        private string _breed;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _name = value;
            }
        }

        public string Sponsor
        {
            get { return _sponsor; }
            set
            {
                if (value == null)
                {
                    _sponsor = "None";
                }
                else
                {
                    _sponsor = value;
                }                 
            }
        }

        public string Breed
        {
            get { return _breed; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Breed cannot be empty.");
                }
                
                _breed = value;
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
            get { return _age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                _age = value;
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

        public override string ToString()
        {
            return $"Animal: {Name}, Age: {AgeCategory}, Breed: {Breed}, Sponsor: {Sponsor}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Animal animal = (Animal)obj;
            return Name == animal.Name && Breed == animal.Breed && Age == animal.Age;
        }
    }
}
