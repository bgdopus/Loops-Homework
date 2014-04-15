using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinMaxSumAverageOfNnumbers
{
    class MinMaxSumAverageOfNnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to input?-->");
            int numbers = int.Parse(Console.ReadLine());
            int[] numArrey = new int[numbers];
            for (int i = 0; i < numArrey.Length; i++)
            {
                Console.Write("Input a number=");
                numArrey[i] = int.Parse(Console.ReadLine());
                
            }
            int sum = 0;
            Array.Sort(numArrey);
            foreach (var num in numArrey)
            {
                Console.WriteLine(num);
                sum = sum + num;
                
            }
            Console.WriteLine("Sum=" + sum);
            Console.WriteLine("Average="+(sum/numbers));
            Console.WriteLine("Min=" + numArrey[0]);
            Console.WriteLine("Max=" + numArrey[numbers-1]);
            
        }
    }
}
