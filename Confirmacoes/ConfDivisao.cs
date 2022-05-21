using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfDivisao
    {
        public static void Divisao()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de divisão? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Divisao.Div();
                    }
                    break;

                case "n":
                    {
                        Thread.Sleep(1000);
                        Principal.Menu();
                    }
                    break;

                default:
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Divisao();
                    }
                    break;
            }
        }
    }
}