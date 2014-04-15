using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate
{
    class CalculateS
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("X=");
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            for (int j = n; j > 0; j--)
            {


                for (int i = j; i > 0; i--)
                {
                    factorial = factorial * i;
                }
                sum = sum + (factorial / Math.Pow(x, j));
                factorial = 1;
            }
            
            Console.WriteLine("S=" + sum);
        }
    }
}
