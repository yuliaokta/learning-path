﻿using System;

namespace continuestatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
        }
    }
}
