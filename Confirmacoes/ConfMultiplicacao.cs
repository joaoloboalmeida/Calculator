using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfMultiplicacao
    {
        public static void Multiplicacao()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de multiplicação? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Multiplicacao.Mult();
                    }
                    break;

                case "n":
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Principal.Menu();
                    }
                    break;

                default:
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Multiplicacao();
                    }
                    break;
            }
        }
    }
}