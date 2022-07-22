using System;

namespace Exercises
{
    internal class Program
    {
        static public void findSymbolInArray(char[] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ('a'.Equals(array[i]))
                {
                    quantity++;
                }
            }
            Console.WriteLine(quantity);
        }

        static void Main(string[] args)
        {
            // Find how many 'a' symbols in array 

            //char[] chars = { 'a', 'b', 'c', 'd', 'a', 'f', 'a', 'v', 'c', 'h', 'a', 'k', 'a', 'l', 'c', 'd', 'a', 'f', };

            //findSymbolInArray(chars);

            // Check how many integers in the array and print in the console

            //int[] array = { 1, 10, 20, 32, 55, 9, 8, 42, 90, 12 };

            //ArrayExerciseOne.PrintAllElementsInArray(array);


            // Print reversed elements in array

            //int[] listOfNumbers = { 2, 5, 7 };

            //Reverse.ReversedArrayValues(listOfNumbers);

            //SumOfElements.SumOfAllElements(listOfNumbers);

            // 4. Write a program in C# Sharp to copy the elements one array into 
            // another array.

            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] copiedArray = new int[originalArray.Length];

            CopyArrayElements.CopyElementsToAnotherArray(originalArray, copiedArray);
        }
    }
}
