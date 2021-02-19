using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitAmount = int.Parse(Console.ReadLine());
            int amount = 0;
            int number = 0;
            while (limitAmount > amount)
            {
                number = int.Parse(Console.ReadLine());
                amount += number;
            }
            Console.WriteLine(amount);
        }
    }
}
