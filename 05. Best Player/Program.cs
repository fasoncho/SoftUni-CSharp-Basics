using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            string bestPlayer = "";
            int mostGoals = 0;
            while (player != "END")
            {
                int goalsScored = int.Parse(Console.ReadLine());
                if (goalsScored > mostGoals)
                {
                    bestPlayer = player;
                    mostGoals = goalsScored;
                }
                if (goalsScored >=10)
                {
                    break;
                }
                player = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (mostGoals >= 3)
            {
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostGoals} goals.");
            }

        }
    }
}
