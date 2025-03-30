namespace Assessment4
{
    public class Classroom
    {
        public string RoomNumber { get; init; }
        public int Capacity { get; private set; }
        public Teacher HeadTeacher { get; set; }
        public List<Student> Students { get; private set; }

        public Classroom(string roomNumber, Teacher headTeacher, List<Student> students)
        {
            RoomNumber = roomNumber;
            Capacity = students.Count;
            HeadTeacher = headTeacher;
            Students = students;
        }

        public void DisplayClassroomInfo()
        {
            Console.WriteLine($"Classroom {RoomNumber} has a capacity of {Capacity} students. Head teacher is {HeadTeacher.Name}");
        }

        public void AssignTeacher(Teacher teacher)
        {
            HeadTeacher = teacher;
            Console.WriteLine($"{teacher.Name} has been assigned to classroom {RoomNumber}.");
        }

        public void AddStudent(Student student)
        {
            if (Students.Count() < Capacity)
            {
                Students.Add(student);
                Capacity++;
                Console.WriteLine($"{student.Name} has been added to classroom {RoomNumber}.");
            }
            else
            {
                Console.WriteLine($"Classroom {RoomNumber} is full.");
            }
        }

        public void DisplayStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.GetDetails());
            }
        }

        public void IdentifyPerson(Person person)
        {
            if (person is Student)
            {
                Console.WriteLine($"{person.Name} is a student.");
            }
            else if (person is Teacher)
            {
                Console.WriteLine($"{person.Name} is a teacher.");
            }

            if (person is Student student)
            {
                Console.WriteLine(student.GetDetails());
            }

            if (person is Teacher teacher)
            {
                Console.WriteLine(teacher.GetDetails());
            }
        }
    }
}
