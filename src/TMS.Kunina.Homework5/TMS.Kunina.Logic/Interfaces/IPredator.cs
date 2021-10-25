using System;
using System.Collections.Generic;
using TMS.Kunina.Data;

namespace TMS.Kunina.Logic.Interfaces
{
    public interface IPredator
    {

        void Eat();

        void Habitat(string place);
    }
}
