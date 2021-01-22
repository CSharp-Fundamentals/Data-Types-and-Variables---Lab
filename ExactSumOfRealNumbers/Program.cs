using System;
using System.Numerics;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            while (n>0)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
                n--;
            }
            Console.WriteLine(sum);
        }
    }
}
