using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_BD
{
    internal class Program4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1 : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2 :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of both number is : " + (a + b));

            Console.WriteLine($"The sum of {a} and {b} is : " + (a + b));

        }
    }
}
