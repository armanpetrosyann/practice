using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace practice
{
    internal class Program
    {

        public static void FindSameSymbols(string text, string textTwo)
        {
            var firstChars = text.Substring(text.Length - 2);
            var secondChars = textTwo.Substring(textTwo.Length - 2);

            if (firstChars.Equals(secondChars))
            {
                Console.WriteLine("Are equals");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            var text = Convert.ToString(Console.ReadLine());

            Console.Write("Enter second string: ");
            var textTwo = Convert.ToString(Console.ReadLine());

            FindSameSymbols(text, textTwo); 
            
        }
    }
}
