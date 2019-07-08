using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // PLANETS AND SPACESHIPS...
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Add Jupiter and Saturn to the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Create new list of last 2 planets and add to planetList
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwoPlanets);

            // Use insert to add Earth and Venus in the correct order
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // Add Pluto to the end of the list
            planetList.Add("Pluto");

            // Create a new list of the rocky planets
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            // Remove Pluto from the list
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));


            // RANDOM NUMBERS...
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if (numbers.Contains(i))
                {
                    Console.WriteLine($"Numbers List contains {i}");
                }
                else
                {
                    Console.WriteLine($"Numbers List does not contain {i}");
                }
            }
        }
    }
}
