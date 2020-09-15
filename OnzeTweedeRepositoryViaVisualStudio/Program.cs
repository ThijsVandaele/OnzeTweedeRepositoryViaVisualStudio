using System;

namespace OnzeTweedeRepositoryViaVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een eerste getal:");
            var getal1 = ConsoleHelper.GetDecimal();

            Console.WriteLine("Geef een tweede getal:");
            var getal2 = ConsoleHelper.GetDecimal();

            var product = getal1 * getal2;

            Console.WriteLine($"Het Product van de twee getallen is {som}");
        }
    }
}
