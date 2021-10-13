using System;
using TMS.Kunina.Data;
using TMS.Kunina.Logic.Interfaces;
using TMS.Kunina.Logic.Manager;

namespace TMS.Kunina.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTiger = "Raf";
            string nameCat = "Barsik";

            string placeTiger = "Forest";
            string placeCat = "Flat";

            double distance = 5;

            PredatorManager predatorManager = new PredatorManager();
            IMoving move;

            // Create new Animal = Tiger
            Tiger tiger = new Tiger(nameTiger);

            IPredator predator = predatorManager;
            move = predatorManager;
            Action(move, distance, nameTiger);
            predator.Eat();
            predator.Habitat(placeTiger);

            // Create new Animal = Cat
            Console.WriteLine("________________________");

            PetManager petManager = new PetManager();

            Cat cat = new Cat(nameCat);

            IPet pet = petManager;
            move = petManager;
            Action(move, distance, nameTiger);
            pet.Eat();
            pet.Habitat(placeCat);
            pet.Cost(100);


        }

        public static void Action(IMoving move, double distance, string name)
        {
            Console.WriteLine($"Move of {name} with distance = {distance}: {move.Move(distance)} km");
            Console.WriteLine($"Walkin speed: {move.WalkingSpeed()} km/hour");
        }

    }
}
