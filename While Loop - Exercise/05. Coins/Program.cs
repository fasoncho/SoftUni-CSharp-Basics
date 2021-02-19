using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            double twoLevs = 0;
            double oneLevs = 0;
            double fifties = 0;
            double twenties = 0;
            double tens = 0;
            double fives = 0;
            double twos = 0;
            double ones = 0;
            while (amount > 0)
            {
                twoLevs = Math.Floor(amount / 2);
                amount -= 2 * twoLevs;
                oneLevs = Math.Floor(amount / 1);
                amount -= 1 * oneLevs;
                fifties = Math.Floor(amount / 0.5);
                amount = Math.Round(amount - fifties * 0.5, 2);
                twenties = Math.Floor(amount / 0.2);
                amount = Math.Round(amount - twenties * 0.2, 2);
                tens = Math.Floor(amount / 0.1);
                amount = Math.Round(amount - tens * 0.1, 2);
                fives = Math.Floor(amount / 0.05);
                amount = Math.Round(amount - fives * 0.05, 2);
                twos = Math.Floor(amount / 0.02);
                amount = Math.Round(amount - twos * 0.02, 2);
                ones = Math.Floor(amount / 0.01);
                amount = Math.Round(amount - ones * 0.01, 2);
            }
            Console.WriteLine(twoLevs + oneLevs + fifties + twenties + tens + fives + twos + ones);
        }
    }
}
