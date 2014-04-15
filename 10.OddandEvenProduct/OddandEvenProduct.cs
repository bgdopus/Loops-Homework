using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddandEvenProduct
{
    class OddandEvenProduct
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] numberString = str.Split(' ');
            int[] numbers = new int[numberString.Length];
            for (int i = 0; i < numberString.Length; i++)
            {
                numbers[i] = int.Parse(numberString[i]);
                
            }

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            int product = 1;
            for (int j = 0; j < numbers.Length; j+=2)
            {
                product = product * numbers[j];
                
            }
            Console.WriteLine("Product = " + product);

            if (product % 2 == 0)
            {
                Console.WriteLine("Product is Even");
            }
            else
            {
                Console.WriteLine("Product is Odd");
            }

            
        }
    }
}
