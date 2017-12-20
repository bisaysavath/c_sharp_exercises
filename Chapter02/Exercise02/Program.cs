using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("----------------------------------------------------------------------------");
            WriteLine("{0,-8}{1}{2,20}{3,31}", "Type", "Byte(s) of memory", "Min", "Max");
            WriteLine("----------------------------------------------------------------------------");
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "sbyte", sizeof(short), short.MinValue, short.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "sbyte", sizeof(int), int.MinValue, int.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(uint), uint.MinValue, uint.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "sbyte", sizeof(long), long.MinValue, long.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(float), float.MinValue, float.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "sbyte", sizeof(double), double.MinValue, double.MaxValue);
            WriteLine("{0,-8}{1,-2}{2,35}{3,31}", "byte", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            WriteLine("----------------------------------------------------------------------------");
        }
    }
}
