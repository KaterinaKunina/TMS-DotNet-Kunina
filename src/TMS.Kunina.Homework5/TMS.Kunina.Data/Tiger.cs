using System;

namespace TMS.Kunina.Data
{
    public class Tiger : Animal
    {

        public Tiger(string name)
            : base(name)
        {
            Name = name;
        }

        public Tiger(string name, DateTime birthday)
            : base(name, birthday)
        {
            Console.WriteLine($"The name our Tiger is {name}");
            Name = name;
            Birthday = birthday;
        }

        void Voice()
        {
            Console.WriteLine("Tiger says: ARRrrr...");
        }

    }

}
