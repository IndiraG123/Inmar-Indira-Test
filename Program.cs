using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMarLogicalTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userInput = Console.ReadLine();

            ReversName();
            LoopBasedOnConditions();
            Console.ReadLine();
        }

        //Rever functionality
        public static void ReversName()
        {
            string userInput = "InMar";
            char[] charArray = userInput.ToArray();
            string reverseUserInput = string.Empty;
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reverseUserInput += charArray[i];
            }
            Console.WriteLine(reverseUserInput);
        }
        //Looping Functionality
        public static void LoopBasedOnConditions()
        {
            for(int i = 0; i>= 100; i++)
            {
                if( i % 3 == 0)
                {
                    Console.WriteLine( "fizz");
                }
                if( i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if( i %3 ==0 && i%5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else  continue;
            }
            
        }

    }
}
