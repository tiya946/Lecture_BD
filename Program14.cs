using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_BD
{
    internal class Program14
    {
        public static void Main(string[] args)
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars with space
                for (int k = 1; k <= i; k++)
                {
                    Console.WriteLine(k);
                }

                Console.WriteLine();
            }
        }
    }
}
