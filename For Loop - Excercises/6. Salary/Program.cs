﻿using System;

namespace _6._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string site = "";
            for (int i = 0; i < tabCount; i++)
            {
                site = Console.ReadLine();

                if (site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
