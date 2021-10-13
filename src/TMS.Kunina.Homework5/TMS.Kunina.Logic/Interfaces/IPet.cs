using System;
namespace TMS.Kunina.Logic.Interfaces
{
    public interface IPet
    {
        void Eat();

        void Cost(double price);

        void Habitat(string place);

    }
}
