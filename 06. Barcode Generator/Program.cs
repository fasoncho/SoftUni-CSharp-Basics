﻿using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            for (int i = int.Parse(start[0].ToString()); i <= int.Parse(end[0].ToString()); i++)
            {
                for (int j = int.Parse(start[1].ToString()); j <= int.Parse(end[1].ToString()); j++)
                {
                    for (int k = int.Parse(start[2].ToString()); k <= int.Parse(end[2].ToString()); k++)
                    {
                        for (int l = int.Parse(start[3].ToString()); l <= int.Parse(end[3].ToString()); l++)
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                    }


                }
            }
        }
    }
}
