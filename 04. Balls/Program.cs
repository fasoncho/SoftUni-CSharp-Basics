using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsNumber = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int othersCounter = 0;
            for (int i = 0; i < ballsNumber; i++)
            {
                string ballColor = Console.ReadLine();
                switch (ballColor)
                {
                    case "red":
                        totalPoints += 5;
                        redCounter++;
                        break;
                    case "orange":
                        totalPoints += 10;
                        orangeCounter++;
                        break;
                    case "yellow":
                        totalPoints += 15;
                        yellowCounter++;
                        break;
                    case "white":
                        totalPoints += 20;
                        whiteCounter++;
                        break;
                    case "black":
                        totalPoints /= 2;
                        blackCounter++;
                        break;
                    default:
                        othersCounter++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redCounter}");
            Console.WriteLine($"Points from orange balls: {orangeCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowCounter}");
            Console.WriteLine($"Points from white balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {othersCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
