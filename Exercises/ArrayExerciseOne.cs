using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class ArrayExerciseOne
    {
        public static void PrintAllElementsInArray(int[] arrayList)
        {
            int elements = 0;

            for (int i = 0; i < arrayList.Length; i++)
            {
                elements++;
                Console.WriteLine($"element - {elements} : {arrayList[i]} ");
            }
        }
    }
}
