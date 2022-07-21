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
            char[] chars = { 'a', 'b', 'c', 'd', 'a', 'f', 'a', 'v', 'c', 'h', 'a', 'k', 'a', 'l', 'c', 'd', 'a', 'f', };

            findSymbolInArray(chars);
        }
    }
}
