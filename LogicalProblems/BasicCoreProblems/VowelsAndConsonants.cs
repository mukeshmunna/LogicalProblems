using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class VowelsAndConsonants
    {
        public static void vow()
        {
            Console.WriteLine("Enter a letter");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("constant");
            }


        }
    }
}
