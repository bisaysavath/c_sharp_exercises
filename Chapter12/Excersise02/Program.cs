using static System.Console;
using System.Linq;

namespace Excersise02
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                var queryCity = db.Customers
                    .Select(c => c.City)
                    .Distinct();

                foreach (var cityName in queryCity)
                {
                    Write($"{cityName}, ");
                }

                WriteLine();

                Write("Enter the name of a city: ");
                string city = ReadLine();

                var queryCompanyName = db.Customers
                    .Where(c => c.City == city)
                    .Select(c => c.CompanyName);

                foreach (var companeyName in queryCompanyName)
                {
                    WriteLine(companeyName);
                }
            }
        }
    }
}
