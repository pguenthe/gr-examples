using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square(0, 0, "red", false, 5));
            shapes.Add(new Circle(0, 0, "blue", true, 5));
            shapes.Add(new Triangle(5, 5, "green", false, 5, 5));
            shapes.Add(new TriangleRotatable(-5, -5, "yellow", true, 5, 5));

            foreach (Shape s in shapes)
            {
                s.Move(3, 3);

                if (s is Rotatable)
                {
                    ((Rotatable)s).Rotate(45);
                }

                Console.WriteLine("Perimeter: " + s.GetPerimeter());
                Console.WriteLine("Area: " + s.GetArea());
                s.Draw();
            }
        }
    }
}
