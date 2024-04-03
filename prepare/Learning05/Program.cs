using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", "square", 3);
        Rectangle rectangle = new Rectangle("blue", "rectangle", 3, 4);
        Circle circle = new Circle("yellow", "circle", 3);

        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            DisplayShapeInformation(shape);
        }
    }

    public static void DisplayShapeInformation(Shape shape)
    {
        Console.WriteLine($"The {shape.GetColor()} {shape.GetName()} area is {shape.GetArea()}.");
    }
}