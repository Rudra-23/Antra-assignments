using OopConcepts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models;

public class Instructor : Person, IInstructorService
{
    private Department department { get; set; }
    private bool isHead { get; set; }
    private DateTime joinDate { get; set; }

    public bool IsHead { get { return isHead; } set { isHead = value; } }

    public Instructor(Person person, Department department, DateTime joinDate) : base(person.Id, person.Name, person.BirthDate, person.Salary, person.Address)
    {
        this.department = department;
        isHead = true;
        this.joinDate = joinDate;
    }

    public override decimal GetTotalCompensation(decimal bonus)
    {
        return this.Salary + this.GetYearsOfExperience() * bonus;
    }

    public int GetYearsOfExperience()
    {
        return DateTime.Today.Year - joinDate.Year;
    }
}
