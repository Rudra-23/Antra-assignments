using OopConcepts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models;

public class Course : ICourseService
{
    private int id { get; set; }
    private string name { get; set; }
    private List<Student> students { get; set; }

    public int Id { get { return id; } private set { id = value; } }
    public string Name { get { return name; } private set { name = value; } }
    public Course(int id, string Name)
    {
        Id = id;
        this.Name = Name;
        students = new List<Student>();
    }

    public List<Student> GetAllStudents()
    {
        return this.students;
    }

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        if (students.Contains(student)) students.Remove(student);
    }
}
