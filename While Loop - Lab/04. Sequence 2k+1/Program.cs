using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitNo = int.Parse(Console.ReadLine());
            int num = 1;
            while (limitNo>=num)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
