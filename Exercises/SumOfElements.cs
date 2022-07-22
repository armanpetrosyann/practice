using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    internal class SumOfElements
    {
        public static void SumOfAllElements(int[] array)
        {
            int checkElementsQuantity = 0;
            int element = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element - {checkElementsQuantity} : {array[i]}");
                checkElementsQuantity++;
                element += array[i];
            }
        }
    }
}
