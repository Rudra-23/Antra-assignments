using OopConcepts.Models;
using System;
namespace OopConcepts;

public class Program
{

    /*
     Test your knowledge attached here. (Questions.txt)

     1. All concepts implemented successfully.
     2. Used interface for abstractions. All classes implements interface.
     3. Used private variable and public variable with private setters for encapsulations.
     4. Student and Instructor inherits from Person. 
     5. GetTotalCompensation is overrided from Person's method. CalculateAge overloads in Person. 
     6. Implemented successfully.
     
     */
    static void Main(string[] args)
    {
        Person person1 = new Person(1, "John", new DateTime(2000, 11, 23), 0, new string[] { "Los Angeles", "NYC" });
        Person person2 = new Person(1, "James", new DateTime(1985, 5, 15), 50000, new string[] { "Seattle" });

        // Create a Student from the Person
        Student student = new Student(person1);
        Console.WriteLine($"Student {student.Name} created with ID: {student.Id} and Birthdate: {student.BirthDate}");

        // Create Courses
        Course math = new Course(101, "Mathematics");
        Course science = new Course(102, "Science");

        // Add courses to the student
        student.TakeCourse(math);
        student.TakeCourse(science);

        math.AddStudent(student);
        science.AddStudent(student);

        Console.WriteLine($"{student.Name} has taken the courses: ");
        foreach(var course in student.GetAllCourses())
        {
            Console.WriteLine(course.Name);
        }

        Console.WriteLine($"{math.Name} has students:");
        foreach (var s in math.GetAllStudents())
        {
            Console.WriteLine(s.Name);
        }

        // Update Grades
        student.UpdateGrades(math, 'A');
        student.UpdateGrades(science, 'B');
        Console.WriteLine($"{student.Name}'s GPA: {student.CalculateGPA()}");

        // Create an Instructor from the Person
        Department department = new Department(1, "Computer Science", null, 100000);
        Instructor instructor = new Instructor(person2, department, new DateTime(2022, 2, 1));
        department.ChangeHead(instructor);
        Console.WriteLine($"Instructor {instructor.Name} is head of the {department.DepartmentName} department.");

        // Add courses to the Department
        department.AddCourse(math);
        department.AddCourse(science);
        department.RemoveCourse(math);
        Console.WriteLine($"{department.DepartmentName} department has total courses: {department.GetAllCourses().Count}");

        // Display Instructor's total compensation
        Console.WriteLine($"{instructor.Name} has {instructor.GetYearsOfExperience()} years of experience.");
        Console.WriteLine($"{instructor.Name}'s total compensation with bonus: {instructor.GetTotalCompensation(5000)}");

        // validate Instructor's Salary
        instructor.ValidateSalary();
        Console.WriteLine($"{instructor.Name}'s validated salary: {instructor.Salary}");        
    }
}
