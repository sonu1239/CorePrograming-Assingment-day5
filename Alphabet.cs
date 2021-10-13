using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Functional_Programing.core_program
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("Enter an Alphabet :");
            char ch = Convert.ToChar(Console.ReadLine()); //converted to chararcter

            //if else condition for checking of vowels or consonants
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is a Vowel", ch);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", ch);
            }

        }
    }
}