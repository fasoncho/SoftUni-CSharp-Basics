using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double above20Price = double.Parse(Console.ReadLine());
            double between10and20kg = 0.5;
            double below10kg = 0.2;
            double luggageWeight = double.Parse(Console.ReadLine());
            double morethan30days = 1.1;
            double between7and30days = 1.15;
            double lessthan7days = 1.4;
            double totalPrice = 0;
            int daystiltravel = int.Parse(Console.ReadLine());
            int luggageCount = int.Parse(Console.ReadLine());

            if (luggageWeight > 20)
            {
                totalPrice = above20Price * luggageCount;
            }
            else if (luggageWeight >= 10)
            {
                totalPrice = above20Price * between10and20kg * luggageCount;
            }
            else
            {
                totalPrice = above20Price * below10kg * luggageCount;
            }
            if (daystiltravel > 30)
            {
                totalPrice *= morethan30days;
            }
            else if (daystiltravel >= 7)
            {
                totalPrice *= between7and30days;
            }
            else
            {
                totalPrice *= lessthan7days;
            }
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }

        }
    }

