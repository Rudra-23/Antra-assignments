using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopConcepts.Models;

namespace OopConcepts.Models.Interfaces;

public interface IStudentService : IPersonService
{
    public void TakeCourse(Course course);

    public void RemoveCourse(Course course);
    public void UpdateGrades(Course course, char grade);
    public double CalculateGPA();

    public List<Course> GetAllCourses();
}
