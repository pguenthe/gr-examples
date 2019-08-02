using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimGR
{
    sealed class Eve : Robot
    {
        private int Altitude;

        public Eve(string name, int x, int y) : base(name, x, y)
        {
            Energy = 500;
            MoveCost = 10;
            ActCost = 3;
            Altitude = 0;
        }

        public override void Act()
        {
            Console.WriteLine("Looking for plants!");
            Energy -= ActCost;
        }

        public override void Move(int xDistance, int yDistance)
        {
            X += xDistance;
            Y += yDistance;
            Energy -= MoveCost;
        }

        public void Fly (int xDist, int yDist, int altDist)
        {
            X += xDist;
            Y += yDist;
            Altitude += altDist;
        }

        public override string ToString()
        {
            return base.ToString() + " Altitude: " + Altitude;
        }
    }
}
