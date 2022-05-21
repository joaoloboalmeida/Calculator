using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfDerivada
    {
        public static void Derivada()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de derivada? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Derivada.Deriv();
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
                        Derivada();
                    }
                    break;
            }
        }
    }
}