using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopConcepts.Models;

namespace OopConcepts.Models.Interfaces;

public interface ICourseService
{
    public List<Student> GetAllStudents();
    public void AddStudent(Student student);
    public void RemoveStudent(Student student);
}
