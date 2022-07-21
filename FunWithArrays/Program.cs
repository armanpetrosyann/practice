using System;

namespace FunWithArrays
{
    internal class Program
    {
        static void SimpleArrays()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            SimpleArrays();
        }
    }
}
