using System;
using System.Xml.Serialization;

namespace Exercise02
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Shape
    {
        public string Color { get; set; }
        public abstract double Area { get; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area
        {
            get
            {
                var sqrt = Math.Sqrt(Radius);
                return Math.Pow(Radius, 2.0f) * Math.PI;
            }
        }
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
