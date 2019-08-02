using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotSimGR
{
    abstract class Robot
    {
        private string Name;
        protected int X;
        protected int Y;
        protected double Energy = 100;
        protected double MoveCost = 1;
        protected double ActCost = 5;

        public Robot(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{Name} ({X},{Y}) {Energy}";
        }

        public abstract void Move(int xDistance, int yDistance);

        public abstract void Act();

        public void Recharge(int energy)
        {
            Energy += energy;
        }

        public void Shutdown ()
        {
            Console.WriteLine("Initiating shutdown...");
            Thread.Sleep(2000);
            Console.WriteLine("Shutdown complete. Good night!");
        }
    }
}
