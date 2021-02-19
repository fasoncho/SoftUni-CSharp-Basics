using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalVolume = height * lenght * widht;
            string input = Console.ReadLine();
            int boxes = 0;

            while (input != "Done")
            {
                boxes = int.Parse(input);
                totalVolume -= boxes;
                if (totalVolume<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalVolume)} Cubic meters more.");
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }

            if (totalVolume>=0)
            {
                Console.WriteLine($"{totalVolume} Cubic meters left.");
            }
             
        }
    }
}
