﻿namespace seriesFiveProgram
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter the Number");
                int number = int.Parse(Console.ReadLine());


                for (int i = 1; i<number; i++)
                {
                if (i % 4 != 0 )
                {
                    Console.WriteLine($"{i * i}");
                }
                }


        }
    }
}