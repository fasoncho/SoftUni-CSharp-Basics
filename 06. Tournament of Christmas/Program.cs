using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            int days = 0;
            int daysWon = 0;
            double moneyRaised = 0;
            
            while (tournamentDays > days)
            {
                int dayGames = 0;
                int gamesWon = 0;
                double dayMoneyRaised = 0;
                days++;
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    dayGames++;
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        gamesWon++;
                        dayMoneyRaised += 20;
                    }
                    sport = Console.ReadLine();
                }
                if (gamesWon > dayGames - gamesWon)
                {
                    daysWon++;
                    moneyRaised += dayMoneyRaised * 1.1;    
                }
                else
                {
                    moneyRaised += dayMoneyRaised;
                }
                
            }
            if (daysWon > days - daysWon)
            {
                moneyRaised *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyRaised:f2}");

            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyRaised:f2}");
            }
        }
    }
}
