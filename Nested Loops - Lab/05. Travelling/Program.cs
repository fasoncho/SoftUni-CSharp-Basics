using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double budget = 0;
            double saving = 0;
            double totalSavings = 0;

            while (true)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                else
                {
                budget = double.Parse(Console.ReadLine());
                while (totalSavings < budget)
                {
                    saving = double.Parse(Console.ReadLine());
                    totalSavings += saving;
                }
                Console.WriteLine($"Going to {destination}!");
                totalSavings = 0;
                }
            }
        }
    }
}
