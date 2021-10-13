using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class EvenOdd
    {
        //Check Whether a Number is Even or Odd

        static void Main(string[] args)
        {
            int a = 2;
            Console.Write("Enter one number ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("This  number is Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This number is odd");
                Console.ReadLine();
            }
        }
    }
}