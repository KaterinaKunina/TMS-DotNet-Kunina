using System;
using TMS.Kunina.Logic.Interfaces;

namespace TMS.Kunina.Logic.Manager
{
    public class PetManager : IPet, IMoving
    {
        string[] meal = { "meat", "fish" };

        double IMoving.Move(double distance) { return distance * 2; }
        double IMoving.WalkingSpeed() { return 2.4; }

        void IPet.Eat()
        {
            Console.Write("Pet like to eat: ");

            foreach (string str in meal)
            {
                Console.Write($"{str}, ");
            }
            Console.WriteLine();

        }

        void IPet.Cost(double price)
        {
            Console.WriteLine($"The Cost of Cat is {price}$");
        }

        void IPet.Habitat(string place)
        {
            Console.WriteLine($"Habitat: {place}");
        }

    }
}
