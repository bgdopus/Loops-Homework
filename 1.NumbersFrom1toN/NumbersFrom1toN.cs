using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Number=>");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
}
