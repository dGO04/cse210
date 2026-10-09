using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(color:"Blue", side:10);
        Rectangle rectangle = new Rectangle(color:"Green", length:15, width:7.5);
        Circle circle = new Circle(color:"Yellow", radius:2);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string[] areaParts = shape.GetArea().ToString().Split(".");
            int intPart = int.Parse(areaParts[0]);
            double area = shape.GetArea();

            if (area / intPart > 1)
            {
                Console.WriteLine($"Color: {shape.GetColor()}. Area: {area.ToString("F2")}");
            } else
            {
                Console.WriteLine($"Color: {shape.GetColor()}. Area: {area}");   
            }
        }
    }
}