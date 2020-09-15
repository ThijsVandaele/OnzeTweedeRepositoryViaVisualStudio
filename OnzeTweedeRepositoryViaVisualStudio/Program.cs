using System;

namespace OnzeTweedeRepositoryViaVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een eerste getal:");
            var getal1 = ConsoleHelper.GetFloat();

            Console.WriteLine("Geef een tweede getal:");
            var getal2 = ConsoleHelper.GetFloat();

            var som = getal1 + getal2;

            Console.WriteLine($"De som van de twee getallen is {som}");
        }
    }
}
