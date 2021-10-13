using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year in Four Digits : ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
            {
                Console.WriteLine("tis is a Leap Year{0} ", year);
            }
            else
            {
                Console.WriteLine("this is not a Leap Year {0}", year);
                Console.ReadLine();

            }

        }
    }
}