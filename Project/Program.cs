using System;
using System.Globalization;
using System.Collections.Generic;
using Project.Entities;
using Project.Entities.Enums;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            System.Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Shape #{i} data: ");
                System.Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                System.Console.Write("Color (Black/ Blue/ Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    System.Console.Write("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, widht, heigth));
                }
                else if(ch == 'c')
                {
                    System.Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, radius));
                }
                else
                {
                    System.Console.WriteLine("Invalid Value!");
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}