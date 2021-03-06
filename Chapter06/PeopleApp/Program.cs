﻿using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var harry = new Person() { Name = "Harry" };
            //var mary = new Person() { Name = "Marry" };
            //var jill = new Person() { Name = "Jill" };

            //var baby1 = mary.ProcreateWith(harry);

            //var baby2 = Person.Procreate(harry, jill);

            //var baby3 = harry * mary;

            //WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            //WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            //WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            //WriteLine($"{mary.Name}'s first child is named {mary.Children[0].Name}.");
            //WriteLine($"5! is {Person.Factorial(5)}");

            //harry.Shout += Harry_Shout;
            //harry.poke();
            //harry.poke();
            //harry.poke();
            //harry.poke();

            //Person[] people =
            //{
            //    new Person { Name = "Simon" },
            //    new Person { Name = "Jenny" },
            //    new Person { Name = "Adam" },
            //    new Person { Name = "Richard" }
            //};

            //WriteLine("Initial list of people:");
            //foreach (var person in people)
            //{
            //    WriteLine($"{person.Name}");
            //}

            //WriteLine($"Use Person's IComparable implementation to sort:");
            //Array.Sort(people);
            //foreach (var person in people)
            //{
            //    WriteLine($"{person.Name}");
            //}

            //WriteLine("Use PersonComparer's IComparer implementation to sort:");
            //Array.Sort(people, new PersonComparer());
            //foreach (var person in people)
            //{
            //    WriteLine($"{person.Name}");
            //}

            //var t = new Thing();
            //t.Data = 42;
            //WriteLine($"Thing: {t.Process("42")}");

            //var gt = new GenericThing<int>();
            //gt.Data = 42;
            //WriteLine($"GenericThing: {gt.Process("42")}");

            //string number1 = "4";
            //WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            //byte number2 = 3;
            //WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

            //var dv1 = new DisplacementVector(3, 5);
            //var dv2 = new DisplacementVector(-2, 7);
            //var dv3 = dv1 + dv2;
            //WriteLine($"({dv1.X}, {dv1.Y}) + ({dv1.Y}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            //Employee e1 = new Employee
            //{
            //    Name = "Jonh Jones",
            //    DateOfBirth = new DateTime(1990, 7, 28)
            //};

            //e1.WriteToConsole();

            //e1.EmployeeCode = "JJ001";
            //e1.HireDate = new DateTime(2014, 11, 23);
            //WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");

            //WriteLine(e1.ToString());

            //Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123" };
            //Person aliceInPerson = aliceInEmployee;
            //aliceInEmployee.WriteToConsole();
            //aliceInPerson.WriteToConsole();
            //WriteLine(aliceInEmployee.ToString());
            //WriteLine(aliceInPerson.ToString());

            ////Employee e2 = (Employee)aliceInPerson;
            //if (aliceInPerson is Employee)
            //{
            //    WriteLine($"{nameof(aliceInPerson)} IS an Employee");
            //    Employee e2 = (Employee)aliceInPerson;
            //    // do something with e2
            //}

            //Employee e3 = aliceInPerson as Employee;
            //if (e3 != null)
            //{
            //    WriteLine($"{nameof(aliceInPerson)} AS an Employee");
            //    // do something with e3
            //}

            //try
            //{
            //    e1.TimeTravel(new DateTime(1999, 12, 31));
            //    e1.TimeTravel(new DateTime(1950, 12, 25));
            //}
            //catch (PersonException ex)
            //{
            //    WriteLine(ex.Message);
            //}

            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            WriteLine($"{email1} is a valid e-mail address: {StringExtensions.IsValidEmail(email1)}.");
            WriteLine($"{email2} is a valid e-mail address: {StringExtensions.IsValidEmail(email2)}.");

            WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}.");
            WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}.");
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
