﻿using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airplaneCompany = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double kidsTicketPrice = adultTicketPrice * 0.3;
            double serviceFee = double.Parse(Console.ReadLine());
            double totalProfit = ((adultTickets + kidsTickets) * serviceFee + adultTicketPrice * adultTickets + kidsTicketPrice * kidsTickets) * 0.2;
            Console.WriteLine($"The profit of your agency from {airplaneCompany} tickets is {totalProfit:f2} lv.");
            
        }
    }
}
