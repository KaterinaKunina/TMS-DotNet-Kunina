using System;

namespace TMS.Kunina.Homework3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Date:");
            string str = Console.ReadLine();

            MainClass mc = new MainClass();
            mc.whatDayOfWeek(str);

        }

        public void whatDayOfWeek (string str)
        {
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
