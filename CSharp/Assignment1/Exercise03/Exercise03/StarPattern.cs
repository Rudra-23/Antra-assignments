using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class StarPattern
    {
        public void PrintPattern(int rows)
        {
            int cols = 2 * rows - 1;

            int spaces = cols / 2;
            int stars = 1;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < spaces; j++)
                {
                    Console.Write(' ');
                }
                for(int k = 0; k < stars; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                stars += 2;
                spaces -= 1;
            }
        }
    }
}
