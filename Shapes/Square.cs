using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        private int side;

        public int Side { get => side; set => side = value; }

        public Square (int top, int left, string color, bool filled, int s) :
            base(top, left, color, filled)
        {
            side = s;
        }

        public override void Draw()
        {
            ;//TODO: draw it
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetPerimeter()
        {
            return side * 4;
        }
    }
}
