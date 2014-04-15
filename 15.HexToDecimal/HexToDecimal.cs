using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("HexValue = ");
            string str = Console.ReadLine();
            char[] numArrey = str.ToCharArray();
            int lenght = numArrey.Length;
            double finnalNum = 0;
            int hexValue;
            for (int i = lenght - 1; i >= 0; i--)
            {
                switch (numArrey[i])
                {
                    case '1': hexValue = 1;
                        break;
                    case '2': hexValue = 2;
                        break;
                    case '3': hexValue = 3;
                        break;
                    case '4': hexValue = 4;
                        break;
                    case '5': hexValue = 5;
                        break;
                    case '6': hexValue = 6;
                        break;
                    case '7': hexValue = 7;
                        break;
                    case '8': hexValue = 8;
                        break;
                    case '9': hexValue = 9;
                        break;
                    case 'A': hexValue = 10;
                        break;
                    case 'B': hexValue = 11;
                        break;
                    case 'C': hexValue = 12;
                        break;
                    case 'D': hexValue = 13;
                        break;
                    case 'E': hexValue = 14;
                        break;
                    case 'F': hexValue = 15;
                        break;
                    default: hexValue = 0;
                        break;
                }
                    finnalNum = finnalNum + hexValue * Math.Pow(16, lenght - i - 1);
                

            }
            Console.WriteLine("Binary Value = " + finnalNum);
        }
    }
}
