using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = "";
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                current += symbol;
            }
            Console.WriteLine(current);
        }
    }
}