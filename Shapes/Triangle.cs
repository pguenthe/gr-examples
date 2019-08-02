using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        private int width;
        private int height;

        
        public Triangle (int top, int left, string color, bool filled, int w, int h) :
            base (top, left, color, filled)
        {
            width = w;
            height = h;
        }

        public override void Draw()
        {
            ; //todo: Write this
        }

        public override double GetArea()
        {
            return .5 * width * height;
            //return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetPerimeter()
        {
            return 3 * width; //TODO: Fix this
        }
    }
}
