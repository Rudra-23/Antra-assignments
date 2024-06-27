using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopConcepts.Models;

namespace OopConcepts.Models.Interfaces;

public interface IDepartmentService
{
    public List<Course> GetAllCourses();
    public void ChangeHead(Instructor instructor);
    public void ChangeBudget(int budget);
    public void AddCourse(Course course);
    public void RemoveCourse(Course course);
}
