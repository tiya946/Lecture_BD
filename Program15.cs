using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_BD
{
    internal class Program15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Gender(F or M):");
            char gender = Char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine();

            if (gender == 'F')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Mr. " + name);
            }
        }
    }
}
