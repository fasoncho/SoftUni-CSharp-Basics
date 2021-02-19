using System;

namespace _5._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            int number = 0;
            double noRemainder2 = 0;
            double noRemainder3 = 0;
            double noRemainder4 = 0;

            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 ==0)
                {
                    noRemainder2++;
                }
                if (number % 3 == 0)
                {
                    noRemainder3++;
                }
                if (number % 4 == 0)
                {
                    noRemainder4++;
                }
            }
            Console.WriteLine($"{(noRemainder2 / count * 100):f2}%");
            Console.WriteLine($"{(noRemainder3 / count * 100):f2}%");
            Console.WriteLine($"{(noRemainder4 / count * 100):f2}%");
        }
    }
}
