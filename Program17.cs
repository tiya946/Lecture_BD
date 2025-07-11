using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lecture_BD
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (input.Length >= 5)
            {
                string masked = input.Substring(0, input.Length - 5) + new string('X', 5);
                Console.WriteLine("Output: " + masked);
            }
            else
            {
                Console.WriteLine("Input too short to mask last 5 digits.");
            }
        }
    }
}
