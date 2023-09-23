using System;

namespace Book.For.Kids.KeyConcepts
{
    public class Program
    {
        public static void Main()
        {
            Variables.Sample();
        }
    }

    public static class Variables
    {
        public static void Sample()
        {
            string starName = "Sol";
            int planetsCount = 8;
            double starAge = 4.5;

            Console.WriteLine(
                $"O {starName} é uma estrela e está no centro do nosso sistema solar que "
                    + $"possui {planetsCount} planetas e tem {starAge} bilhões de anos."
            );
        }
    }
}
