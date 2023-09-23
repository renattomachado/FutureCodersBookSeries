using System;

namespace Book.For.Kids.KeyConcepts
{
    public class Program
    {
        public static void Main()
        {
            ControlStructures.Sample();
        }
    }

    /// <summary>
    /// Text in the book ;D
    /// </summary>
    public static class ControlStructures
    {
        public static void Sample()
        {
            bool planetIsLikeEarth = false;
            bool findNewPlanet = false;
            while (!findNewPlanet)
            {
				Console.Write("O planeta encontrado é parecido com a Terra? ");
                planetIsLikeEarth = Console.ReadLine() == "SIM";
                if (planetIsLikeEarth)
                {
                    findNewPlanet = true;
                    Console.WriteLine("Huston, já não temos mais um problema!");
                }
            }
        }
    }
}
