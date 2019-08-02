using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private int radius;

        public int Radius { get => radius; set => radius = value; }

        public Circle(int top, int left, string color, bool filled, int radius) :
            base (top, left, color, filled)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            ; //todo: Write this
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
            //return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * radius * 2; //diameter
        }
    }
}
