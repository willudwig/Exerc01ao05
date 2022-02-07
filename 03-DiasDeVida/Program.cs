using System;

namespace _03_DiasDeVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string n = Console.ReadLine();
            Console.Write("Digite a idade: ");
            ushort idade = ushort.Parse(Console.ReadLine());

            int diasvividos = idade * 365;

            Console.WriteLine("\n\nParabéns " + n + "! Você viveu " + diasvividos + " dias.");
            Console.WriteLine("\nTecle para encerrar...");
            Console.ReadKey();
        }
    }
}
