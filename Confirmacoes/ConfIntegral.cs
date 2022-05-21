using System;
using System.Threading;

namespace Calculadora.Confirmacoes
{
    public static class ConfIntegral
    {
        public static void Integral()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja efetuar outro cálculo de Integral? (S/N)");

            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    {
                        Thread.Sleep(1000);
                        Operacoes.Integral.Integ();
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
                        Integral();
                    }
                    break;
            }
        }
    }
}