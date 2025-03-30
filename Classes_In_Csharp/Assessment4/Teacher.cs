namespace Assessment4
{
    public class Teacher : Person
    {
        public string Subject { get; init; }
        public int YearsOfExperience { get; private set; }

        public Teacher(string name, int age, string address, string subject, int yearsOfExperience)
            : base(name, age, address)
        {
            Subject = subject;
            YearsOfExperience = yearsOfExperience;
        }

        public override string GetDetails(string introduction = "Hello, ")
        {
            return $"{base.GetDetails(introduction)}, I teach {Subject} and have {YearsOfExperience} years of work experience.";
        }

        public string GetDetails(bool includeSubject = true)
        {
            if (includeSubject)
            {
                return $"{base.GetDetails()}, I teach {Subject}.";
            }
            else
            {
                return base.GetDetails();
            }
        }

        public void AddExperience()
        {
            YearsOfExperience++;
        }

        public void DisplayExperience()
        {
            Console.WriteLine($"{Name} has {YearsOfExperience} years of work experience.");
        }

        public void AssignHomework(string assignment, int dueDate = 7)
        {
            Console.WriteLine($"{Name} assigned homework: {assignment}. Due in {dueDate} days.");
        }
    }
}

