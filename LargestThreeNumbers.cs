using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers : ");
            Console.Write("\nEnter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Number 3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("\nLargest number is : " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("\nLargest number is : " + num2);
            }
            else
            {
                Console.WriteLine("\nLargest number is : " + num3);
                Console.ReadLine();
            }


        }
    }
}