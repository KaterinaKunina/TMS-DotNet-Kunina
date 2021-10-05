using System;

namespace TMS.Kunina.Homework3._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Date:");
            string str = Console.ReadLine();

            Program program = new Program();
            program.whatDayOfWeek(str);

        }

        public void whatDayOfWeek(string str)
        {
            try
            {
                var date = DateTime.Parse(str);
                Console.WriteLine($"Day is   \"{date.DayOfWeek}\"\n");

                Program program = new Program();
                program.countDaysOfWeekInMonth(date);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
                return;
            }
        }

        public void countDaysOfWeekInMonth(DateTime date)
        {
            int count = 1;
            for (int i = 7; i <= 35; i += 7)
            {
                if (date.Month == date.AddDays(i).Month)
                    count++;


                if (date.Month == date.AddDays(-i).Month)
                    count++;
            }

            Console.WriteLine($"{count} of {date.DayOfWeek} is in {date.ToString("MMM")} {date.Year}\n");
        }
    }
}
