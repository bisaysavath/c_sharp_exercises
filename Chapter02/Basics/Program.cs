using System.Linq;
using System.Reflection;
using System;

namespace Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //var a = Assembly.Load(new AssemblyName(r.FullName));
                //int methodCount = 0;

                //foreach (var t in a.DefinedTypes)
                //{
                //    methodCount += t.GetMethods().Count();
                //}

                //System.Console.WriteLine($"{a.DefinedTypes.Count():N0} types with {methodCount:N0} methods in {r.Name} assembly.");

                double heightInMeters = 1.88;
                Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");
            }
        }
    }
}
