using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _12.RadomizeNumbers1toN
{
    class RadomizeNumbers1toN
    {

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random randomNum = new Random();
            int numberToPrint;
            for (int i = 1; i <= n; i++)
            {
                numberToPrint = randomNum.Next(1, n + 1);
                if (!printed[numberToPrint])
                {
                    Console.Write(numberToPrint + " ");
                    printed[numberToPrint] = true;
                }
                else
                {
                    i--;
                }


            }
            Console.WriteLine();
        }
    }
}

