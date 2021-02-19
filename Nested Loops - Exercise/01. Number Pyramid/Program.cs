using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            for (int row = 1;  row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    if (currentNumber>number)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
