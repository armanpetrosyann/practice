using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class Reverse
    {
        public static void ReversedArrayValues(int[] array)
        {
            // Reverse before loop
            Array.Reverse(array);

            // Element quantity checker in method
            int checker = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element - {checker} : {array[i]}");
                checker++;
            }
        }
    }
}
