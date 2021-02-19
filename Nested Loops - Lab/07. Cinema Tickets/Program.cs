using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = "";
            int freePlaces = 0;
            string ticket = "";
            double studentTickets = 0;
            double kidsTikets = 0;
            double standardTickets = 0;
            double totalTickets = 0;
            double movieTotalTickets = 0;


                movie = Console.ReadLine();
                while (movie != "Finish")
                {
                    freePlaces = int.Parse(Console.ReadLine());
                    movieTotalTickets = 0;
                    ticket = Console.ReadLine();
                    while (ticket != "End")
                    {
                        movieTotalTickets++;
                        totalTickets++;
                        if (ticket == "student")
                        {
                            studentTickets++;
                        }
                        else if (ticket == "kid")
                        {
                            kidsTikets++;
                        }
                        else if (ticket == "standard")
                        {
                            standardTickets++;
                        }
                        if (movieTotalTickets >= freePlaces)
                        {
                            break;
                        }
                        ticket = Console.ReadLine();
                    }
                    Console.WriteLine($"{movie} - {((movieTotalTickets/freePlaces)*100):f2}% full.");
                    movie = Console.ReadLine();
                }
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{((studentTickets/totalTickets) * 100):f2}% student tickets.");
                Console.WriteLine($"{((standardTickets/totalTickets) * 100):f2}% standard tickets.");
                Console.WriteLine($"{((kidsTikets/totalTickets) * 100):f2}% kids tickets.");
            
        }

    }
}
