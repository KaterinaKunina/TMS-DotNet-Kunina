using System;

namespace WhatDayIsToday
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Date:");
            string str = Console.ReadLine();

            try
            {
                var date = DateTime.Parse(str);
                Console.WriteLine($"Day is   \"{date.DayOfWeek}\"\n");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
                return;
            }


        }
    }
}
