using System;
using TMS.Kunina.Logic.Interfaces;

namespace TMS.Kunina.Logic.Manager
{
    public class PredatorManager: IPredator, IMoving
    {
        string[] meal = { "meat", "grass", "other predator" };

        double IMoving.Move(double distance) { return distance * 5; }
        double IMoving.WalkingSpeed() { return 2.4; }

        void IPredator.Eat()
        {
            Console.Write("Predator like to eat: ");

            foreach (string str in meal)
            {
                Console.Write($"{str}, ");
            }
            Console.WriteLine();

        }

        void IPredator.Habitat(string place)
        {
            Console.WriteLine($"Habitat: {place}");
        }
    }

}
