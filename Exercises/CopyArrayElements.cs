using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class CopyArrayElements
    {
        public static void CopyElementsToAnotherArray(int[] originalArray, int[] copiedArray)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
                //Console.WriteLine(copiedArray[i]);
            }
        }
    }
}