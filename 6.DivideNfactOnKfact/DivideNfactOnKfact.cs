using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivideNfactOnKfact
{
    class DivideNfactOnKfact
    {
        static void Main(string[] args)
        {
            
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K=");
            int k = int.Parse(Console.ReadLine());
            if (n < 100 && k < 100)
            {
                if (n > 1 && k > 1)
                {
                    if (k < n)
                    {
                        int nFact = 1;
                        for (int i = n; i > 0; i--)
                        {
                            nFact = nFact * i;
                        }
                        int kFact = 1;
                        for (int j = k; j > 0; j--)
                        {
                            kFact = kFact * j;
                        }
                        Console.WriteLine("Result=" + (nFact / kFact));
                    }
                    else
                    {
                        Console.WriteLine("out of boundary");
                    }
                }
                else
                {
                    Console.WriteLine("out of boundary");
                }
            }
            else
            {
                Console.WriteLine("out of boundary");
            }
        }
    }
}
