using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesInNfact
{
    class TrailingZeroesInNfact
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            for (int i = n; i > 0; i--)
            {
                nFact = nFact * i;
                
            }
            Console.WriteLine("Factorial = " + nFact);
            string str = nFact.ToString();
            char[] numArrey = str.ToCharArray();
            
            int counter = 0;
            for (int i = numArrey.Length - 1; i >= 0; i--)
            {
                if (numArrey[i] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Trailing Zeroes = " + counter);
        }
    }
}
