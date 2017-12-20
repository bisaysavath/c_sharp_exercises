using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person() { Name = "Harry" };
            var mary = new Person() { Name = "Marry" };
            var jill = new Person() { Name = "Jill" };

            var baby1 = mary.ProcreateWith(harry);

            var baby2 = Person.Procreate(harry, jill);

            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
        }
    }
}
