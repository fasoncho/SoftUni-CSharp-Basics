using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetNeeded = double.Parse(Console.ReadLine());
            double avaialbleAmount = double.Parse(Console.ReadLine());
            double amount = 0;
            int spendSpree = 0;
            string action = "";
            int daysCount = 0;
            while (budgetNeeded > avaialbleAmount)
            {
                daysCount++;
                action = Console.ReadLine();
                amount = double.Parse(Console.ReadLine());
                bool should_continue = true;
                switch (action)
                {
                    case "spend":
                        if (amount <= avaialbleAmount)
                        {
                            avaialbleAmount -= amount;
                        }
                        else
                        {
                            avaialbleAmount = 0;
                        }
                        spendSpree++;
                        if (spendSpree >=5)
                        {
                            Console.WriteLine("You can't save the money.");
                            Console.WriteLine(daysCount);
                            should_continue = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    case "save":
                        spendSpree = 0;
                        avaialbleAmount += amount; 
                        break;
                }
                if (should_continue == false)
                {
                    break;
                }
            }
            if (budgetNeeded<=avaialbleAmount)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
