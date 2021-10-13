using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class SwapTowNumbers
    {


        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Enter first number :");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("1st number " + a);
            Console.ReadLine();
            Console.WriteLine("2nd number " + b);
            Console.ReadLine();

        }
    }
}