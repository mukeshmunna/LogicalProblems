﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class LeapYear
    {
        public void Leapyear()
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isLeapYear = CheckLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }

        public bool CheckLeapYear(int year)
        {
            // A year is a leap year if it is divisible by 4,
            // except for years that are divisible by 100 but not divisible by 400.
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }
}
