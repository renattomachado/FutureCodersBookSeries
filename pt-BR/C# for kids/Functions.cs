using System;
using System.Collections.Generic;

namespace Book.For.Kids.KeyConcepts
{
    /// <summary>
    /// Text in the book ;D
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            List<string> planets = new List<string>
            {
                "Mercúrio",
                "Vênus",
                "Terra",
                "Marte",
                "Júpter",
                "Saturno",
                "Urano",
                "Netuno"
            };
            Console.Write("Informe um nome para descobrir se é planeta");
            string targetPlanet = Console.ReadLine();
            bool found = SearchPlanets(planets, targetPlanet);
            Console.WriteLine($"{targetPlanet} é um planeta? {found}");
        }

        public static bool SearchPlanets(List<string> planets, string target, int? index = null)
        {
            if (planets.Count == 0)
                return false;

            index = index is null ? 0 : index + 1;
            if (planets[index ?? 0] == target)
                return true;

            return SearchPlanets(planets, target, index!);
        }
    }
}
