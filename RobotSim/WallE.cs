using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimGR
{
    class WallE : Robot
    {
        public WallE(string name, int x, int y) : base(name, x, y)
        {
            Energy = 50;
            MoveCost = .5;
            ActCost = 1;
        }

        public override void Act()
        {
            Console.WriteLine("Compacting now!");
            Energy -= ActCost;
        }

        public override void Move(int xDistance, int yDistance)
        {
            X += xDistance;
            Y += yDistance;
            Energy -= MoveCost;
        }
    }
}
