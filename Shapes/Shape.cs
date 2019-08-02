using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        private int top;
        private int left;
        private string color;
        private bool filled;

        public int Top { get => top; set => top = value; }
        public int Left { get => left; set => left = value; }
        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public Shape(int top, int left, string color, bool filled)
        {
            this.top = top;
            this.left = left;
            this.color = color;
            this.filled = filled;
        }

        public void Move (int x, int y)
        {
            top += y;
            left += x;
        }

        //abstract methods
        public abstract void Draw();

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
