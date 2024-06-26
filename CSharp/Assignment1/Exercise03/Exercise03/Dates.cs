using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Dates
    {
        public void CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;

            TimeSpan age = currentDate - birthDate;
            int daysOld = (int) age.TotalDays;

            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

            Console.WriteLine($"Today is {currentDate}. You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000 day anniversary is on: {nextAnniversary.ToShortDateString()}");
        }

        public void Greet()
        {
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;
            string greeting = "";

            if (hour >= 5 && hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                greeting = "Good Afternoon";
            }

            else if (hour >= 17 && hour < 21)
            {
                greeting = "Good Evening";
            }
            else
            {
                greeting = "Good Night";
            }

            Console.WriteLine($"The current time is: {currentTime}");
            Console.WriteLine(greeting);
        }

    }

}
