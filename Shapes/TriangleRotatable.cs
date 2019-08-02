using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class TriangleRotatable : Triangle, Rotatable
    {
        public TriangleRotatable(int top, int left, string color, bool filled, int w, int h) :
            base(top, left, color, filled, w, h)
        {
            angle = 0;
        }

        private int angle;
        public void Rotate(int degrees)
        {
            angle += degrees;
        }

        //TODO: implement draw with angled triangle
    }
}
