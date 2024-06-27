using OopConcepts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> grades { get; set; }
    private List<Course> courses { get; set; }

    public Student(Person person) : base(person.Id, person.Name, person.BirthDate, person.Salary, person.Address)
    {
        courses = new List<Course>();
        grades = new Dictionary<Course, char>();
    }
    private int GetPoints(char grade)
    {
        switch (grade)
        {
            case 'A': return 10;
            case 'B': return 9;
            case 'C': return 8;
            case 'D': return 7;
            case 'E': return 6;
            case 'F': return 5;
            default: return 0;
        }
        return 0;
    }
    public double CalculateGPA()
    {
        double gpa = 0.0;
        int count = 0;

        foreach (var grade in grades)
        {
            if (grade.Value != ' ')
            {
                gpa += GetPoints(grade.Value);
                count++;
            }
        }
        if (count > 0) gpa = gpa / count;

        return gpa;
    }

    public List<Course> GetAllCourses() { return this.courses; }

    public void TakeCourse(Course course)
    {
        courses.Add(course);
        grades.Add(course, ' ');
    }

    public void UpdateGrades(Course course, char grade)
    {
        if (grades.ContainsKey(course))
            grades[course] = grade;
    }

    public void RemoveCourse(Course course)
    {
        if (courses.Contains(course)) courses.Remove(course);
    }
}
