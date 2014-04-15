using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
               
                
            }
        }
    }
}
