using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Models.Interfaces;

public interface IInstructorService : IPersonService
{
    public int GetYearsOfExperience();
    public decimal GetTotalCompensation(decimal bonus);

}
