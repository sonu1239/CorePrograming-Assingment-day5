using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class QuotientAndRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter Two Numbers :");
            Console.WriteLine("\nEnter Dividend Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Divisor Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result1 = num1 / num2;
            int result2 = num1 % num2;

            Console.WriteLine("\nQuotient is " + result1);
            Console.WriteLine("\nRemainder is " + result2);
            Console.ReadLine();
        }
    }
}