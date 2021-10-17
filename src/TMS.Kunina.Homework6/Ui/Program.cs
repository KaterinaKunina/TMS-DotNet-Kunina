using System;
using Manager;

namespace Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount person1 = new BankAccount(1000, "Kris Boil");
            BankAccount person2 = new BankAccount(5000, "Dominique Francon");

            person1.ProcessCompleted += ProcessCompleted;
            person2.ProcessCompleted += ProcessCompleted;

            person1.getInfo();
            person1.AddMoney(10);
            person1.Subtract(5000);
            person1.getInfo();

            person2.getInfo();
            person2.AddMoney(10);
            person2.Subtract(5000);
            person2.Subtract(500);
            person2.getInfo();

            person1.Subtract(500);
            person1.getInfo();

            Console.WriteLine("\n****************************");
            Console.WriteLine("Added person without event");
            Console.WriteLine("****************************");
            BankAccount person3 = new BankAccount(0, "Elizabeth Olsen");
            person3.Subtract(10);

        }

        public static void ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? $"Completed Successfully for {sender}" : "failed"));
            Console.WriteLine("___________________________________________");
        }

    }
}