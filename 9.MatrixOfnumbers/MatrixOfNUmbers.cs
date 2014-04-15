using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MatrixOfnumbers
{
    class MatrixOfNUmbers
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            

                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n + i; j++)
                    {
                        Console.Write("{0,5}", j);
                    }
                    Console.WriteLine();
                }

            
        }
    }
}

