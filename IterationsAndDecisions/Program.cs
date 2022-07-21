using System;
using System.Linq;

namespace IterationsAndDecisions
{
    internal class Program
    {

        // ForLoopExample
        static void ForLoopExample()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is {0} ", i);
            }
        }


        // ForEachLoopExample
        static void ForEachLoopExample()
        {
            string[] carTypes = new string[] { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string car in carTypes)
            {
                Console.WriteLine(car);
            }

            int[] myInts = new int[] { 10, 20, 30, 40 };
            foreach (int number in myInts)
            {
                Console.WriteLine(number);
            }

        }

        // LinqQueryOverInts 
        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subSet = from i in numbers where i < 10 select i;

            foreach (var item in subSet)
            {
                Console.Write("{0} ", item);
            }
        }

        // while and do/while

        // WhileLoopExample

        static void WhileLoopExample()
        {
            string userIsDone = " ";

            while (userIsDone.ToLower() != "yes")
            {
                if (userIsDone.ToLower() == "ok")
                {
                    Console.WriteLine("Done");
                    break;
                }

                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language oreference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

     

        static void Main(string[] args)
        {
            //ForLoopExample();
            //ForEachLoopExample();
            //LinqQueryOverInts();
            //WhileLoopExample();
            //SwitchOnStringExample();
        }   
    }

}
