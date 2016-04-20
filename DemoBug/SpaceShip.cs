using System;

namespace DemoBug
{
    public class SpaceShip
    {
        public bool Start(IParameter parameter)
        {
            if (string.IsNullOrEmpty(parameter.Text))
            {
                throw new Exception("Spaceship explosion");
            }
            return true;
        }
    }
}
