using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1001; i <= 9999; i++)
            {
                bool magicNumber = true;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    
                    if (currentDigit == 0 || num % currentDigit != 0)
                    {
                        magicNumber = false;
                        break;
                    }
                }
                if (magicNumber == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
