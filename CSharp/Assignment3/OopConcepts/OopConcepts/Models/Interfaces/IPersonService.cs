using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models.Interfaces;

public interface IPersonService
{
    public string[] GetAddresses();
    public int CalculateAge();
    public void ValidateSalary();
    public decimal GetTotalCompensation(decimal bonus);

}
