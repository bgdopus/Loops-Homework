using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RamdomNumbersInRange
{
    class RandomNumbersInRange
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min= ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max= ");
            int max = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();
            int number;
            for (int i = 1; i < n + 1 ; i++)
            {
                number = randomNumber.Next(min, max);
                Console.WriteLine(number);

            }
        }
    }
}
