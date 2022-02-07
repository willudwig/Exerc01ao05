using System;

namespace _05_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário: ");
            double sal = Convert.ToDouble(Console.ReadLine());
            double aum = (sal * 0.15) + sal;
            Console.WriteLine("O salário com aumento de 15% é: " + aum.ToString("N2"));
            double imp = Math.Abs((aum * 0.08) - aum);
            Console.WriteLine("O salário final com redução de 8% do imposto ficou: " + imp.ToString("N2"));

            Console.WriteLine("\n\n\nTecle para sair...");
            Console.ReadKey();
        }
    }
}
