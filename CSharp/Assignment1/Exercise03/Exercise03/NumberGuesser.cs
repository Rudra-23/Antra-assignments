using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class NumberGuesser
    {
        public void GuessNumber()
        {
            int correctNumber = new Random().Next(3) + 1;

            while(true)
            {
                Console.WriteLine("Guess a number between 1 and 3: ");
                int guessedNumber = int.Parse(Console.ReadLine());

                if(guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Number should be between 1 and 3 (inclusive)");
                }
                else if(guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your number is smaller than correct number");
                }
                else if(guessedNumber > correctNumber)
                {
                    Console.WriteLine("Your number is greater than correct number");
                }
                else
                {
                    Console.WriteLine("Correct guess!!");
                    break;
                }
            }
            return;
        }
    }
}
