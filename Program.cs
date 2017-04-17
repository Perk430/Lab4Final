using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputIsValid = false, play = true;
            string _upTo; int upTo;
            Console.WriteLine("Welcome to the Factorial Calculator!");
            do
            {
                do
                {
                    Console.Write("What number will we work with today? (max 10)\t");
                    _upTo = Console.ReadLine();
                    upTo = Convert.ToInt16(_upTo);

                    if (upTo < 11) inputIsValid = true;
                    else Console.WriteLine("That number is too big, trust me--please try again");
                } while (!inputIsValid);

                long result = 1; int i;
                for (i = upTo; i > 0; i--)
                {
                    result *= i;
                }

                Console.WriteLine("Your result for the factorial of {0} is {1}", upTo, result);
                Console.Write("\nWould you like to continue? y/n\t");
                play = Console.ReadLine()[0] == 'y';
            } while (play);

            Console.Write("\nBye...(Press Enter to exit)");
            Console.ReadLine();
        }

    }
}

