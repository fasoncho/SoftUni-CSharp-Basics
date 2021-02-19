using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i <= result; i++)
            {
                for (int j = 0; j <= result; j++)
                {
                    for (int k = 0; k <= result; k++)
                    {
                        if (i + j + k == result)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
