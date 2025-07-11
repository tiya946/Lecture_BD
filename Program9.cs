using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_BD
{
    internal class Program9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string input = Console.ReadLine();

            string toggled = "";

            foreach(char c in input)
            {
                if (char.IsUpper(c))
                {
                    toggled += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    toggled += char.ToUpper(c);

                }
                else
                {
                    toggled += c;

                }
            }
            Console.WriteLine("Toggled Class :" + toggled);
        }
    }
}
