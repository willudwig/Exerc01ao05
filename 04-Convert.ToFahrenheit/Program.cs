using System;

namespace _04_Convert.ToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 1.8) + 32;
            Console.Write("A temperatura convertida em Fahrenheit é: " + f + "º F");

            Console.Write("\n\nTecle para finalizar...");
            Console.ReadKey();
        }
    }
}
