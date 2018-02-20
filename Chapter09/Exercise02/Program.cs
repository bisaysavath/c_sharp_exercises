using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of Shapes to serialize
            var listOfShapes = new List<Shape>
            {
                new Circle { Color = "Red", Radius = 2.5 },
                new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Color = "Green", Radius = 8 },
                new Circle { Color = "Purple", Radius = 12.3 },
                new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0  }
            };

            string path = Path.Combine(Environment.CurrentDirectory, "test.xml");

            FileStream fs = File.Create(path);

            XmlSerializer serializerXml = new XmlSerializer(typeof(List<Shape>));

            serializerXml.Serialize(fs, listOfShapes);

            fs.Close();

            FileStream fileXml = File.Open(path, FileMode.Open);

            List<Shape> loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;
            foreach (Shape item in loadedShapesXml)
            {
                WriteLine($"{item.GetType().Name} is {item.Color} and has an area of { item.Area}"); 
            }

            fileXml.Close();
        }
    }
}
