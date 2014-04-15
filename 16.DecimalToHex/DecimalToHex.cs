using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal Number= ");
            int decNum = int.Parse(Console.ReadLine());
            int rem;
            List<string> listHex = new List<string>();
            do
            {
                int temp = decNum;
                decNum = decNum / 16;
                
                rem = temp - (decNum * 16);
                switch (rem)
                {
                    case 1: listHex.Add("1");
                        break;
                    case 2: listHex.Add("2");
                        break;
                    case 3: listHex.Add("3");
                        break;
                    case 4: listHex.Add("4");
                        break;
                    case 5: listHex.Add("5");
                        break;
                    case 6: listHex.Add("6");
                        break;
                    case 7: listHex.Add("7");
                        break;
                    case 8: listHex.Add("8");
                        break;
                    case 9: listHex.Add("9");
                        break;
                    case 10: listHex.Add("A");
                        break;
                    case 11: listHex.Add("B");
                        break;
                    case 12: listHex.Add("C");
                        break;
                    case 13: listHex.Add("D");
                        break;
                    case 14: listHex.Add("E");
                        break;
                    case 15: listHex.Add("F");
                        break;
                    default: listHex.Add("0");
                        break;
                    
                }
                
                    rem = 0;
                
                
                
            } while (decNum > 16);
            switch (decNum)
            {
                case 1: listHex.Add("1");
                    break;
                case 2: listHex.Add("2");
                    break;
                case 3: listHex.Add("3");
                    break;
                case 4: listHex.Add("4");
                    break;
                case 5: listHex.Add("5");
                    break;
                case 6: listHex.Add("6");
                    break;
                case 7: listHex.Add("7");
                    break;
                case 8: listHex.Add("8");
                    break;
                case 9: listHex.Add("9");
                    break;
                case 10: listHex.Add("A");
                    break;
                case 11: listHex.Add("B");
                    break;
                case 12: listHex.Add("C");
                    break;
                case 13: listHex.Add("D");
                    break;
                case 14: listHex.Add("E");
                    break;
                case 15: listHex.Add("F");
                    break;
                default: listHex.Add("0");
                    break;

            }
            Console.Write("Hexadecimal Number= ");
            for (int i = listHex.Count-1; i >= 0; i--)
            {
                Console.Write(listHex[i]);
            }
            Console.WriteLine();
            
        }
    }
}
