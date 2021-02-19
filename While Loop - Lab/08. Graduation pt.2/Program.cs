using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 0;
            double grade = 0;
            double sumGrade = 0;
            double averageScore = 0;
            int fails = 0;
            while (year<12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >=4)
                {
                    sumGrade += grade;

                    
                }
                else
                {
                    fails++;
                    if (fails >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {year} grade");
                        break;
                    }
                    
                }
                year++;
            }
            if (fails<2)
            {
                averageScore = sumGrade / year;
                Console.WriteLine($"{name} graduated. Average grade: {averageScore:f2}");
            }
            
        }
    }
}
