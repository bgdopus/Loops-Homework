using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _8.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            if (n > 1 && n < 100)
            {
                BigInteger factOne = 1;
                for (int i = 2 * n; i > 0; i--)
                {
                    factOne = factOne * i;
                }
                BigInteger factTwo = 1;
                for (int j = n + 1; j > 0; j--)
                {
                    factTwo = factTwo * j;
                }
                BigInteger factThree = 1;

                for (int h = n ; h > 0; h--)
                {
                    factThree = factThree * h;
                }

                BigInteger res = factOne / (factTwo * factThree);
                Console.WriteLine("Result= " + res);
                
            }
        }
    }
}
