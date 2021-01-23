using System;
using System.Collections.Generic;

namespace Twisted_Sum
{
    // https://www.codewars.com/kata/527e4141bb2ea5ea4f00072f/train/csharp
    public class Program
    {
        static void Main(string[] args)
        {
            TwistedSum.Solution(4);
            TwistedSum.Solution(10);
            TwistedSum.Solution(12);
        }
    }

    public class TwistedSum
    {
        public static long ErgebnisSumme { get; set; }
        public static long Solution(long n)
        {
            ErgebnisSumme = 0;

            for (var i = 1; i <= n; i++)
            {
                if (CheckNumberLength(i) == 1)
                {
                    ErgebnisSumme += i;
                }
                else
                {
                    var einstelligeZahlen = SplitLongNumbers(i);
                    foreach (var zahl in einstelligeZahlen)
                    {
                        ErgebnisSumme += zahl;
                    }
                }
                Console.WriteLine("i = " + i);
                Console.WriteLine("Ergebnis = " + ErgebnisSumme);
                Console.WriteLine();
            }

            return ErgebnisSumme;
        }

        /// <summary>
        /// Trennt Zahlen ab der Größe 10 in ihre Bestandteile auf
        /// </summary>
        /// <param name="longNumber"></param>
        /// <returns>Einstellige Zahlen als Liste</returns>
        private static List<long> SplitLongNumbers(long longNumber)
        {
            List<long> splitNumber = new List<long>();
            var longNumberText = longNumber.ToString().ToCharArray();

            //Zweiter Check
            if (longNumber >= 10)
            {
                foreach (var c in longNumberText)
                {
                    long.TryParse(c.ToString(), out var temp);
                        
                    splitNumber.Add(temp);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            return splitNumber;
        }

        private static int CheckNumberLength(long longNumber)
        {
            var textLongNumber = longNumber.ToString().Length;

            return textLongNumber;
        }
    }
}
