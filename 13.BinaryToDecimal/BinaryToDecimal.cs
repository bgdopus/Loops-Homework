using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            char[] numArrey = str.ToCharArray();
            int lenght = numArrey.Length;
            double finnalNum = 0;
            for (int i = lenght - 1; i >= 0; i--)
            {
                int binNum = (int)Char.GetNumericValue(numArrey[lenght - i - 1]);

                if (binNum == 1)
                {
                    finnalNum = finnalNum + 1 * Math.Pow(2, i);
                }

            }
            Console.WriteLine(finnalNum);
        }
    }
}
