using System;

namespace TMS.Kunina.Logic.Interfaces
{
    public interface IMoving
    {

        public double Move(double distance);

        public double WalkingSpeed();

    }
}
