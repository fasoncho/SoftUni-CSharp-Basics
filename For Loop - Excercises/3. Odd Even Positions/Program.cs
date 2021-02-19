using System;

namespace _3._Odd_Even_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = -1000000;
            double evenMax = -1000000;
            double oddMin = 1000000;
            double evenMin = 1000000;
            double number = 0;
            
            for (int i = 1; i <= count; i++)
            {
                number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                
                
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == 1000000)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == -1000000)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == 1000000)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == -1000000)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
