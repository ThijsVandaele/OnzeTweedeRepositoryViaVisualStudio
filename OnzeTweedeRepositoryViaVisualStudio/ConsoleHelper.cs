using System;
using System.Collections.Generic;
using System.Text;

namespace OnzeTweedeRepositoryViaVisualStudio
{
    public static class ConsoleHelper
    {
        public static int GetInteger()
        {
            if (!int.TryParse(Console.ReadLine(), out int integer))
            {
                Console.WriteLine("Foute invoer, geef een integer getal");
            }

            return integer;
        }

        public static float GetFloat()
        {
            if (!float.TryParse(Console.ReadLine(), out float f))
            {
                Console.WriteLine("Foute invoer, geef een float getal");
            }

            return f;
        }

        public static void PrintMenuWithTitle(Dictionary<int, string> menuItems, string title)
        {
            PrintTitle(title); // Print titel
            PrintMenu(menuItems); // Print menu items
        }

        public static void PrintMenu(Dictionary<int, string> menuItems)
        {
            foreach (KeyValuePair<int, string> menuItem in menuItems)
            {
                Console.WriteLine($"{menuItem.Key}) {menuItem.Value}");
            }
        }

        public static void PrintLine(int length, char c)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static void PrintTitle(string title)
        {
            Console.WriteLine(title);
            PrintLine(title.Length, '-');
            Console.WriteLine();
        }

        public static int GetIntegerBetweenValues(int minIncl, int maxIncl)
        {
            int getal = GetInteger();

            while (getal < minIncl || getal > maxIncl)
            {
                Console.WriteLine($"Getal moet tussen {minIncl} en {maxIncl} liggen.");
                getal = GetInteger();
            }

            return getal;
        }
    }
}
