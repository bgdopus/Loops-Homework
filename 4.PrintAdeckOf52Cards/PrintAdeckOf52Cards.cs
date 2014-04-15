using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrintAdeckOf52Cards
{
    class PrintAdeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] colorArrey = { "♣", "♦", "♥", "♠" };
            string[] bigCards = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 2; i < 15; i++)
            {
                
                for (int j = 0; j <= 3; j++)
                {
                    if (i > 10)
                    {
                        Console.Write(bigCards[i-1] + " " + colorArrey[j]);
                    }
                    else
                    {
                        Console.Write(i + " " + colorArrey[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
