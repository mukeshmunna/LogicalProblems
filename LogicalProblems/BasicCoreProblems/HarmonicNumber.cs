using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class HarmonicNumber
    {
        public double HarmonicNum(int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }
        public void Harmonic()
        {
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Invalid value for N. N should be a positive integer.");
                return;
            }

            double harmonicNumber = HarmonicNum(N);

            Console.WriteLine("The " + N + "th harmonic number is: " + harmonicNumber);
        }

    }
}