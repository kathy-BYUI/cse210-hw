using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red",3.5);
        // Console.WriteLine($"Shape: Square - Color: {square.GetColor()} - Area: {square.GetArea()} ");
        shapes.Add(square);

        Circle circle = new Circle("Pink",7);
        // Console.WriteLine($"Shape: Circle - Color: {circle.GetColor()} - Area: {circle.GetArea()} ");
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("Black", 3,6);
        // Console.WriteLine($"Shape: Rectangle - Color: {rectangle.GetColor()} - Area: {rectangle.GetArea()} ");
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape: Rectangle - Color: {color} - Area: {area} ");
        }
    }
}