using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int floorsCounter = floors;
            char roomType = ' ';

            for (int i = floorsCounter; i > 0; i--)
            {
                if (i == floors)
                {
                    roomType = 'L';
                }
                else if (i % 2 == 0)
                {
                    roomType = 'O';
                }
                else
                {
                    roomType = 'A';
                }
                for (int j = 0; j < rooms; j++)
                {
                    Console.Write($"{roomType}{i}{j} ");

                }
                Console.WriteLine();
            }
        }
    }
}
