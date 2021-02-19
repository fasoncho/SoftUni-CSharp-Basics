using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int productCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            string productType = Console.ReadLine();
            string delivery = Console.ReadLine();
            if (productCount < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {

                switch (productType)
                {
                    case "90X130":
                        totalPrice = productCount * 110;
                        if (productCount > 60)
                        {
                            totalPrice *= 0.92;
                        }

                        else if (productCount > 30)
                        {
                            totalPrice *= 0.95;
                        }
                        break;
                    case "100X150":
                        totalPrice = productCount * 140;
                        if (productCount > 80)
                        {
                            totalPrice *= 0.90;
                        }

                        else if (productCount > 40)
                        {
                            totalPrice *= 0.94;
                        }
                        break;
                    case "130X180":
                        totalPrice = productCount * 190;
                        if (productCount > 50)
                        {
                            totalPrice *= 0.88;
                        }

                        else if (productCount > 20)
                        {
                            totalPrice *= 0.93;
                        }
                        break;
                    case "200X300":
                        totalPrice = productCount * 250;
                        if (productCount > 50)
                        {
                            totalPrice *= 0.86;
                        }

                        else if (productCount > 25)
                        {
                            totalPrice *= 0.91;
                        }
                        break;
                }
                switch (delivery)
                {
                    case "With delivery":
                        totalPrice += 60;
                        break;
                }
                if (productCount > 99)
                {
                    totalPrice *= 0.96;
                }
                Console.WriteLine($"{totalPrice:f2} BGN");
            }
        }
    }
}
