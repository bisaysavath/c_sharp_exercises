using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Program
    {
        public static string PrimeFactors(int number)
        {
            string strBuilder = string.Empty;
            int factorNumber = number;
            int[] primeList = getPrimeList(number);

            for (int index = primeList.Length - 1; index >= 0; index--)
            {
                if (primeList[index] != 0)
                {
                    while (factorNumber % primeList[index] == 0)
                    {
                        strBuilder = $"{primeList[index]}x{strBuilder}";

                        factorNumber /= primeList[index];

                        if (factorNumber == 1)
                        {
                            break;
                        }
                    }
                }
            }

            return $"Prime factors of {number} are:" + strBuilder.Substring(0, strBuilder.Length - 1);
        }

        public static int[] getPrimeList(int number)
        {
            int[] list = new int[number];
            int index = 0;

            for (int num = 2; num <= number; num++)
            {
                if ((num % 2 != 0 || num == 2) && (num % 3 != 0 || num == 3) && (num % 5 != 0 || num == 5) && (num % 7 != 0 || num == 7))
                {
                    list[index] = num;
                    index++;
                }
            }
            return list;
        }

        public static void Main(string[] args)
        {
            System.Console.WriteLine(PrimeFactors(50));
        }
    }
}
