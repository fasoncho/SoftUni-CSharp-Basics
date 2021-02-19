using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int totalSteps = 0;
            int goal = 10000;
            string input = Console.ReadLine();
            while (input != "Going home")
            {
                steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps > goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps -goal} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (totalSteps < 10000)
            {
                input = Console.ReadLine();
                steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps > goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
                }
            }
        }
    }
}
