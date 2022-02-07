using System;

namespace _01_Imobilis.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double larg, comp;
            Console.Write("Digite a largura: ");
            larg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o comprimento: ");
            comp = Convert.ToDouble(Console.ReadLine());

            string medida = comp != larg ? "\nMedida do terreno: " + (larg * comp).ToString() + "m²\n" : "\nTerreno irregular.\n";

            Console.WriteLine(medida);
            Console.WriteLine("Tecle qualquer para finalizar.");
            Console.ReadKey();
        }
    }
}
