using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sumAverageGrades = 0;
            double presentationCounter = 0;
            while (presentation != "Finish")
            {
                double sumGrades = 0;
                
                for (int i = 0; i < juryMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                }
                double averageGrade = sumGrades / juryMembers;
                presentationCounter++;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                sumAverageGrades += averageGrade;
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(sumAverageGrades/presentationCounter):f2}.");
        }
    }
}
