using static System.Console;
using System.IO;
using Packt.CS7;
using System.Xml;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlStr = File.ReadAllText("UserInfo.xml");

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlStr)))
            {
                while (reader.Read())
                {
                   switch (reader.NodeType)
                   {
                    case XmlNodeType.Element:
                        WriteLine($"Element: {reader.Name}");
                        break;
                    case XmlNodeType.Text:
                        var secret = Protector.Encrypt(reader.Value, "ABC");
                        WriteLine($"Text: {secret}");
                        WriteLine($"Text: {Protector.Decrypt(secret, "ABC")}");
                        break;
                   }
                }
            }
        }
    }
}
