using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test Square
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Test Rectangle
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Test Circle
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");

        Console.WriteLine();
        Console.WriteLine("--- Iterating through List<Shape> ---");

        // Build a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Purple", 7));
        shapes.Add(new Rectangle("Orange", 3, 8));
        shapes.Add(new Circle("Yellow", 4));

        // Iterate and display color and area for each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} - Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}