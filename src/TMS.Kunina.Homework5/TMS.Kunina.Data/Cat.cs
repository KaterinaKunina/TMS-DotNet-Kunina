using System;
namespace TMS.Kunina.Data
{
    public class Cat : Animal
    {

        public Cat(string name)
            : base(name)
        {
            Name = name;
        }

        public Cat(string name, DateTime birthday)
            : base(name, birthday)
        {
            Console.WriteLine($"The name our Cat is {name}");
            Name = name;
            Birthday = birthday;
        }

        void Voice()
        {
            Console.WriteLine("Cat says: meow, meow");
        }

    }
}
