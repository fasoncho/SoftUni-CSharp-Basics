using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int total = width * length;
            string input = Console.ReadLine();
            int pieces = 0;
            while (input != "STOP")
            {
                pieces = int.Parse(input);
                total -= pieces;
                if (total < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(total)} pieces more.");
                    break;
                }
                input = Console.ReadLine(); 
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{total} pieces are left.");
            }
        }
    }
}
