using Assessment4;

var student1 = new Student("Mariela", 17, "Dragan Cankov 2", 4.5, new List<Student>());
var student2 = new Student("Yoana", 17, "Sini kamani 28", 6.0, new List<Student>());
var student3 = new Student("Hristina", 18, "Stoyan Zaimov 17", 6.0, new List<Student>());

student1.AddFriend(student2);
student1.AddFriend(student3);
student2.AddFriend(student3);

student1.CompareAges(student2);
student1.CompareGrades(student2);

var teacher = new Teacher("Teodora Soserova", 45, "Drujba 2", "German", 20);
teacher.GetDetails(true);
teacher.GetDetails("Good morning classroom, ");
teacher.AddExperience();
teacher.DisplayExperience();

var classroom = new Classroom("1105", teacher, new List<Student> { student1, student2 });

classroom.DisplayClassroomInfo();

classroom.AddStudent(student3);

classroom.DisplayStudents();

teacher.AssignHomework("Solve the exercises", dueDate: 10);

student1.ChangeGrade(5.0);
student1.DisplayFinalGrade();

classroom.IdentifyPerson(student1);
Console.WriteLine();
classroom.IdentifyPerson(teacher);

student2.CelebrateBirthday();
student2.ChangeAddress("Vilna zona");
Console.WriteLine(student2.PersonalizedReport());

Console.ReadLine();

