using System;

namespace _2._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int number = 0;
            int maxNumber = 0;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    sum += maxNumber;
                    maxNumber = number;
                }
                else
                {
                    sum += number;
                }
            }
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNumber)}");
            }

        }
    }
}
