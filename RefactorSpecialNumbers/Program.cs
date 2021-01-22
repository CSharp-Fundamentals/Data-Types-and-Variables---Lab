using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 0;
            bool check = false;
            for (int i = 1; i <= number; i++)
            {
                temp = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", temp, check);
                sum = 0;
                i = temp;
            }
        }
    }
}