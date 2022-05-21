using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfSubtracao
    {
        public static void Subtracao()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de subtração? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Subtracao.Sub();
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
                        Subtracao();
                    }
                    break;
            }
        }
    }
}