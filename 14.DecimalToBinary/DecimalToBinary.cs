using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal Number=");
            int decNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            List<int> listBin = new List<int>();
            do
            {
                int printNum = decNumber % 2;
                listBin.Add(printNum);
                decNumber = decNumber / 2;
                counter++;
                
            } while (decNumber > 0);

            Console.Write("Binary Number=");
            for (int i = listBin.Count - 1; i >= 0; i--)
            {
                Console.Write(listBin[i]);
            }
            Console.WriteLine();

            

        }
    }
}
