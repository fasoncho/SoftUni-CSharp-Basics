using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0;
            string installmentInput = Console.ReadLine();

            while (installmentInput != "NoMoreMoney")
            {
                double installment = double.Parse(installmentInput);
                if (installment <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {(installment):f2}");
                    total += installment;
                    installmentInput = Console.ReadLine();
                }
            }
            
            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
