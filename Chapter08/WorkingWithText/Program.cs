﻿using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (var item in citiesArray)
            {
                WriteLine(item);
            }

            string fullname = "Alan Jones";
            int indexOfTheSpace = fullname.IndexOf(' ');
            string firstname = fullname.Substring(0, indexOfTheSpace);
            string lastname = fullname.Substring(indexOfTheSpace + 1);
            WriteLine($"{lastname}, {firstname}");

            string fullname2 = "Jones, Alan";
            firstname = fullname2.Substring(fullname2.IndexOf(' ') + 1);
            lastname = fullname2.Substring(0, fullname2.IndexOf(','));
            WriteLine($"{firstname} {lastname}");

            string company = "Microsoft";
            bool startsWithM = company.StartsWith('M');
            bool containN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}, contains an N: {containN}");

            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            string fruit = "Apples";
            decimal price = 0.39M;
            DateTime when = DateTime.Today;

            WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");

            WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.", fruit, price, when));
        }
    }
}
