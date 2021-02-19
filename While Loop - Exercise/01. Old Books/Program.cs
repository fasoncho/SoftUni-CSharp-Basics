using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string book = Console.ReadLine();
            int count = 0;
            while (book != "No More Books")
            {
                
                if (book == favBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                else
                {
                    book = Console.ReadLine();
                }
                count++;
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            
        }
    }
}
