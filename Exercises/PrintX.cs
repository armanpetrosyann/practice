using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    internal class PrintX
    {
        static void PrintInConsoleX()
        {
            int i;
            int j;
            char symOne = '*';
            char symTwo = '#';

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (i == j || (i + j == 10))
                    {
                        Console.Write(symOne);
                    }
                    Console.Write(symTwo);
                }
                Console.WriteLine();
            }

        }
    }
}
