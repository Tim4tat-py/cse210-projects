using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "Red");
        Rectangle rectangle = new Rectangle (2, 5, "Blue");
        Circle circle = new Circle(1, "Orange");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}