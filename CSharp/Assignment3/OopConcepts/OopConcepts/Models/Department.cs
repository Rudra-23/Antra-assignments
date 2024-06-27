using OopConcepts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models;

public class Department : IDepartmentService
{
    public int DepartmentId { get; private set; }
    public string DepartmentName { get; private set; }
    public Instructor HeadInstructor { get; private set; }
    private int budget { get; set; }
    private List<Course> courses { get; set; }

    public Department(int id, string name, Instructor instructor, int budget)
    {
        DepartmentId = id;
        this.budget = budget;
        courses = new List<Course>();
        DepartmentName = name;
        HeadInstructor = instructor;
    }

    public List<Course> GetAllCourses()
    {
        return courses;
    }

    public void ChangeHead(Instructor instructor)
    {
        if (HeadInstructor != null) HeadInstructor.IsHead = false;
        instructor.IsHead = true;
        HeadInstructor = instructor;
    }

    public void ChangeBudget(int budget)
    {
        this.budget = budget;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        if (courses.Contains(course)) courses.Remove(course);
    }
}
