using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class CopyArrayElements
    {
        public static void CopyElementsToAnotherArray(int[] originalArray, int[] copiedArray)
        {
            int copiedElement = 0;

            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = copiedElement;
            }
            for (int i = 0; i < copiedArray.Length; i++)
            {
                copiedArray[i] = copiedElement;
                Console.WriteLine(copiedElement);
            }

        }
    }
}
