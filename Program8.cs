﻿using System;
namespace Lecture_BD
{
    class Program8
    {
        public static void Main(string[] args)
        {
            int num1, res, i;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1; //Initialization

            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; //Increment by one
            }
            Console.ReadLine();
        }
    }
}

