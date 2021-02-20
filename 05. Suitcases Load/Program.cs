using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkVolume = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int suitcaseCounter = 0;
            while (input != "End")
            {
                suitcaseCounter++;
                double suitcaseVolume = double.Parse(input);
                if (suitcaseCounter % 3 == 0)
                {
                    suitcaseVolume *= 1.1;
                }
                trunkVolume -= suitcaseVolume;
                if (trunkVolume < 0)
                {
                    Console.WriteLine("No more space!");
                    suitcaseCounter -= 1;
                    break;
                }
                input = Console.ReadLine();
            }
            if (trunkVolume >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
        }
    }
}
