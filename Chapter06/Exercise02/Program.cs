using System;

namespace Exercise02
{
    public abstract class Shape
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public Shape(int inputHeight, int inputWidth)
        {
            Height = inputHeight;
            Width = inputWidth;
        }

        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width) { }
        public override double Area() => Height * Width;
    }

    public class Square : Shape
    {
        public Square(int width) : base(0, width) { }
        public override double Area() => Width * Width;
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius) : base(0, 0) { Radius = radius; }
        public override double Area() => Radius * Radius * Math.PI;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int option = default;

            do
            {
                Console.WriteLine("Hello! Welcome to an area calculator.");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. To quit");
                Console.Write("Please select a shape: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        RectangleCal();
                        break;
                    case 2:
                        SquareCal();
                        break;
                    case 3:
                        CircleCal();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again!");
                        break;
                }

                Console.WriteLine();
            } while (option != 4);
        }

        public static void RectangleCal()
        {
            int height = default;
            int width = default;

            Console.Write("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());

            var r = new Rectangle(height, width);

            Console.WriteLine($"The area of the {nameof(Rectangle)} is {r.Area()}");
        }

        public static void SquareCal()
        {
            int width = default;

            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());

            var r = new Square(width);

            Console.WriteLine($"The area of the {nameof(Square)} is {r.Area()}");
        }

        public static void CircleCal()
        {
            int radius = default;

            Console.Write("Enter the radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            var r = new Circle(radius);

            Console.WriteLine($"The area of the {nameof(Circle)} is {r.Area()}");
        }
    }
}
