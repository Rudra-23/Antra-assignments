using OopConcepts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models;

public class Person : IPersonService
{
    private int id { get; set; }
    private string name { get; set; }
    private DateTime birthdate { get; set; }
    private decimal salary { get; set; }
    private string[] address { get; set; }

    public int Id { get { return id; } private set { id = value; } }
    public string Name { get { return name; } private set { name = value; } }

    public DateTime BirthDate { get { return birthdate; } private set { birthdate = value; } }
    public decimal Salary { get { return salary; } protected set { salary = value; } }
    public string[] Address { get { return address; } set { address = value; } }

    public Person(int id, string name, DateTime dateTime, decimal salary, string[] address)
    {
        Id = id;
        Name = name;
        BirthDate = dateTime;
        Salary = salary;
        Address = address;
    }

    public string[] GetAddresses()
    {
        return address;
    }

    public int CalculateAge()
    {
        int age = DateTime.Today.Year - birthdate.Year;
        return age;
    }

    public int CalculateAge(DateTime date)
    {
        if (date.Year < birthdate.Year) return -1;

        int age = date.Year - birthdate.Year;
        return age;
    }

    public virtual void ValidateSalary()
    {
        if (salary < 0) salary = 0;
    }

    public virtual decimal GetTotalCompensation(decimal bonus)
    {
        return this.salary + bonus;
    }

}
