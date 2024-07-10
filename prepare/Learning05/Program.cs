using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        // Calculate area of a square (e.g. side * side)
        Square square = new Square("brown", 5.5);
        string squareColor = square.GetColor();
        double squareArea = square.GetArea();
        Console.WriteLine(squareColor);
        Console.WriteLine(squareArea);

        // Calculate area of a rectangle (e.g. length * width)
        Rectangle rectangle = new Rectangle("gray", 3, 5.5);
        string rectColor = rectangle.GetColor();
        double rectArea = rectangle.GetArea();
        Console.WriteLine(rectColor);
        Console.WriteLine(rectArea);

        // Calculate area of a circle (e.g. PI * radius^2)
        Circle circle = new Circle("yellow", 6);
        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();
        Console.WriteLine(circleColor);
        Console.WriteLine(circleArea);

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }

    }

}
