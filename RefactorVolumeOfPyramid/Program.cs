using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, hight = 0;
            double volume = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            hight = double.Parse(Console.ReadLine());
            volume = (length * width) * hight / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
