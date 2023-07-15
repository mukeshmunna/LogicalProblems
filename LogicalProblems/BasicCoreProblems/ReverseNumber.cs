using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class ReverseNumber
    {
        public void ToReverseNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ToReverseNumber(number);

            Console.WriteLine("Reversed number: " + reversedNumber);
        }
        public int ToReverseNumber(int number)
        {
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return reversedNumber;
        }
    }
}