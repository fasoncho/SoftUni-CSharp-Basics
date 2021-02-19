using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            int maxNumber = -1000000000;
            while (input != "Stop")
            {
                number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
