using Assignment03;

Color redColor = new Color(255, 0, 0);
Ball ball1 = new Ball(10, redColor);
Ball ball2 = new Ball(20, new Color(0, 255, 0));

ball1.Throw();
ball1.Throw();
ball1.Throw();
ball1.Pop();
ball1.Throw(); 

ball2.Throw();
ball2.Throw();
ball2.Throw();
ball2.Throw();
ball2.Throw();
ball2.Throw();
ball2.Pop();
ball2.Throw();
ball2.Throw();

Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");
Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");


Student student = new Student();
student.Name = "Raju";
student.DateOfBirth = new DateTime(2000, 7, 28);
student.AddAddress("123 St");
Course math = new Course { CourseName = "Math", Grade = 'A' };
student.AddCourse(math);
Course physics = new Course { CourseName = "Physics", Grade = 'B' };
student.AddCourse(physics);
Course chem = new Course { CourseName = "Chemistry", Grade = 'D' };
student.AddCourse(chem);

Instructor instructor = new Instructor
{
    Name = "Jane Smith",
    DateOfBirth = new DateTime(1961, 5, 5),
    Salary = 50000,
    JoinDate = new DateTime(2002, 8, 1),
    Department = "Science",
    IsHead = true
};

Console.WriteLine($"{student.Name} is {student.CalculateAge()} years old.");
Console.WriteLine($"{student.Name} has a GPA of {student.CalculateGPA()}.");

Console.WriteLine($"{instructor.Name} is {instructor.CalculateAge()} years old.");
Console.WriteLine($"{instructor.Name} has a salary of {instructor.CalculateSalary():C}.");