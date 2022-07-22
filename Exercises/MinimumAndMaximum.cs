using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    internal class MinimumAndMaximum
    {
        public static void FindMinimumValueInArray(int[] array)
        {
            int minimumValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimumValue)
                {
                    minimumValue = array[i];
                }
            }
            Console.WriteLine($"Minumum value in the array is: {minimumValue}");
        }

        public static void FindMaximumValueInArray(int[] array)
        {
            int maximumValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximumValue)
                {
                    maximumValue = array[i];
                }
            }
        }
    }
}
