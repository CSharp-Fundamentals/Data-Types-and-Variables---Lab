using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int sum = 0;
            int digit = 0;

            for (int i = 1; i <=n; i++)
            {
                digit = i;
                while (digit != 0)
                {
                    sum += (digit % 10);
                    digit /= 10;
                }
                if (sum==5 ||sum==7 ||sum==11)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;
            }
        }
    }
}
