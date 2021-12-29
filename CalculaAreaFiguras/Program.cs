using System;
using System.Globalization;
using System.Collections.Generic;
using CalculaAreaFiguras.Entities;
using CalculaAreaFiguras.Entities.Enums;

namespace CalculaAreaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CI));
            }
        }
    }
}
