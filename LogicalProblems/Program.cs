﻿using LogicalProblem;
using System;
namespace LogicalProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input :");
            Console.WriteLine("1.Fibonacci series\n2.PerfectNumber\n3.PrimeNUmber\n4.Reverse a number\n5.coupon Number");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Fibonacci.Fib();
                    break;
                case 2:
                    PerfectNumber.IsPerfect();
                    break;
                case 3:
                    PrimeNumber.IsPrime();
                    break;
                case 4:
                    ReverseNumber.Reverse();
                    break;
                case 5:
                    Coupon.GetCoupon();
                    break;
                case 6:
                    Stopwatchs.GetTime();
                    break;
                default:
                    break;

            }
        }
    }
}