namespace Assessment4
{
    public class Student : Person
    {
        public double FinalGrade { get; private set; }
        public List<Student> Friends { get; set; }

        public Student(string name, int age, string address, double finalGrade, List<Student> friends) : base(name, age, address)
        {
            FinalGrade = finalGrade;
            Friends = friends;
        }

        public void AddFriend(Student friend)
        {
            Friends.Add(friend);
            Console.WriteLine($"{Name} and {friend.Name} are now friends.");
        }

        public override string GetDetails(string introduction = "Hello, ")
        {
            return $"{base.GetDetails(introduction)}, and my grade is {FinalGrade}";
        }

        public void ChangeGrade(double newGrade)
        {
            FinalGrade = newGrade;
        }

        public void DisplayFinalGrade()
        {
            Console.WriteLine($"{Name}'s final grade is {FinalGrade}");
        }

        public bool CompareGrades(Student otherStudent)
        {
            return this.FinalGrade == otherStudent.FinalGrade;
        }
    }
}
