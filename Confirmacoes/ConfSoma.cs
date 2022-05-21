using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfSoma
    {
        public static void Soma()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de soma? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Soma.Sum();
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
                        Soma();
                    }
                    break;
            }
        }
    }
}