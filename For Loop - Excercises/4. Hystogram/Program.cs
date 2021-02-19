using System;

namespace _4._Hystogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double number = 0;
            double below200 = 0;
            double below400 = 0;
            double below600 = 0;
            double below800 = 0;
            double below1000 = 0;
            double percentage = 0;
            for (int i = 0; i < count; i++)
            {
                number = double.Parse(Console.ReadLine());
                if (number < 200)
                {
                    below200++;
                }
                else if (number < 400)
                {
                    below400++;
                }
                else if (number < 600)
                {
                    below600++;
                }
                else if (number < 800)
                {
                    below800++;
                }
                else 
                {
                    below1000++;
                }

                
            }
            percentage = below200 / count * 100;
            Console.WriteLine($"{(percentage):f2}%");
            percentage = below400 / count * 100;
            Console.WriteLine($"{percentage:f2}%");
            Console.WriteLine($"{(below600 / count * 100):f2}%");
            Console.WriteLine($"{(below800 / count * 100):f2}%");
            Console.WriteLine($"{(below1000 / count * 100):f2}%");
        }
    }
}
