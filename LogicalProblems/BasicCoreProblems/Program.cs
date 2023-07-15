using BasicCoreProblems;
using System;
namespace BasicCoreProblems
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("BasicCoreProblem!");
            FlipCoinPercentage flipCoinPercent = new FlipCoinPercentage();
            //  flipCoinPercent.coinPercent();
            LargestAmongThree largestAmongThree = new LargestAmongThree();
            // largestAmongThree.Largest();

            QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
            //  divide.divide();

            LeapYear leapYear = new LeapYear();
            // leapYear.Lyear();

            HarmonicNumber harmoncNumber = new HarmonicNumber();
            //  harmoncNumber.Harmonic();

            PowerOfTwo powerOfTwo = new PowerOfTwo();
            // powerOfTwo.checkPowerOfTwo();

            PerfectNumber perfectNuber = new PerfectNumber();
            // perfectNuber.isPerfectNuber();

            ReverseNumber reverseNumber = new ReverseNumber();
            // reverseNumber.checkReverseNumber();

             Factors PrimeFactor= new Factors();
            PrimeFactor.PrimeFactor();





        }
    }
}
