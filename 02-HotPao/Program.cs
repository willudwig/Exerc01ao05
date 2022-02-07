using System;

namespace _02_HotPao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, saldo, poup;
            const double pfran = 0.12;
            const double broa = 1.50;
            char op;
            ushort qtdPfran, p;
            ushort qtdBroa, b;
            double[] vendaPfran = new double[999];
            double[] vendaBroa = new double[999];

            ushort contVendas = 0;

            p = 0;
            b = 0;
            s1 = 0;
            s2 = 0;

            do
            {
                Console.WriteLine("...... Venda diária HOTPÃO\n\n");
                Console.WriteLine("Registrar Venda:\n");
                Console.WriteLine("Digite 0 para CAIXA:\nDigite 1 para PÃO FRANCÊS:\nDigite 2 para BROA:\nDigite 3 para SAIR:\n");
                op = Convert.ToChar(Console.ReadLine());


                switch (op)
                {
                    case '0':
                        Console.Clear();
                        Console.WriteLine("...... Venda diária HOTPÃO\n\n");
                        foreach (double paes in vendaPfran)
                        {
                            s1 += paes;
                        }
                        foreach (double broas in vendaBroa)
                        {
                            s2 += broas;
                        }
                        saldo = s1 + s2;
                        poup = saldo * 0.10;
                        Console.WriteLine("Vendas total do dia: " + contVendas);
                        Console.WriteLine("Seu saldo hoje é: " + saldo.ToString("N2"));
                        Console.WriteLine("Valor sugerido para depódito em poupança: " + poup.ToString("N2"));
                        Console.WriteLine("\n\nTecle para volta ao Menu de Opções...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '1':
                        Console.WriteLine("PÃO FRANCÊS:\n");
                        Console.Write("Quantidade: ");
                        qtdPfran = ushort.Parse(Console.ReadLine());
                        vendaPfran[p] = qtdPfran * pfran;
                        Console.Write("Valor a cobrar: R$" + vendaPfran[p].ToString("N2"));
                        Console.WriteLine("\n\nTecle para finalizar o pedido...");

                        p++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '2':
                        Console.WriteLine("BROA:\n");
                        Console.Write("Quantidade: ");
                        qtdBroa = ushort.Parse(Console.ReadLine());
                        vendaBroa[b] = qtdBroa * broa;
                        Console.Write("Valor a cobrar: R$" + vendaBroa[b].ToString("N2"));
                        Console.WriteLine("\n\nTecle para finalizar o pedido...");

                        b++;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Programa Finalizado!");
                        break;

                    default:
                        if (op != '3')
                            Console.WriteLine("Opção inválida!\n\nTecle para voltar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                contVendas++;

            } while (op != '3');

            Console.ReadKey();



        }
    }
}
