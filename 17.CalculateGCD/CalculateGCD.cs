using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b= int.Parse(Console.ReadLine());
            int maxNum = Math.Max(a,b);
            int maxDiv = 0;
            for (int i = 1; i < maxNum; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    maxDiv = i;
                }

            }
            Console.WriteLine("GCD= " + maxDiv);
        }
    }
}
