using System;

namespace Book.For.Kids.KeyConcepts
{
    public class Program
    {
        public static void Main()
        {
            Operators.Sample();
        }
    }

    /// <summary>
    /// Text in the book ;D
    /// </summary>
    public static class Operators
    {
        public static void Sample()
        {
            int oldSolarSystem = 9;
            int newSolarSystem = 8;
            string plutaoResult = !true ? "é" : "não é";

            Console.WriteLine(
                $"O sistema solar tinha {oldSolarSystem} planetas mas agora tem "
                    + $"{newSolarSystem} e Plutão {plutaoResult} um deles."
            );
        }
    }
}
