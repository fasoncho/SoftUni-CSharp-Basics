using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failsAllowed = int.Parse(Console.ReadLine());
            int fails = 0;
            string excerciseName = Console.ReadLine();
            string lastExcercise = "";
            int grade = 0;
            int count = 0;
            double score = 0;
            double averageScore = 0;

            while(excerciseName != "Enough")
            {
                count++;
                
                
                lastExcercise = excerciseName;
                grade = int.Parse(Console.ReadLine());
                score += grade;
                if (grade <=4)
                {
                    fails++;
                    if (fails>=failsAllowed)
                    {
                        Console.WriteLine($"You need a break, {fails} poor grades.");
                        break;
                    }
                }
                excerciseName = Console.ReadLine();

            }
            if (excerciseName == "Enough")
            {
                averageScore = score / count;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastExcercise}");
            }
        }
    }
}
