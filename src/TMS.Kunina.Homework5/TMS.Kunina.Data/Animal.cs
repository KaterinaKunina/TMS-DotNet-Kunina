using System;

namespace TMS.Kunina.Data
{
    public abstract class Animal
    {
        public static string Name { get; set; }
        public static DateTime Birthday { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
