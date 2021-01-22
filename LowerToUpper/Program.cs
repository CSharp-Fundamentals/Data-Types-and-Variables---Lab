using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            int casted = (int)letter;

            if (casted>64 && casted<91)
            {
                Console.WriteLine("upper-case");
            }
            else if (casted>96 && casted<123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
