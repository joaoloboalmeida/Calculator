using System;
using System.Threading;
using Calculadora.Confirmacoes;

namespace Calculadora.Operacoes
{
    public static class Subtracao
    {
        public static void Sub()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o primeiro valor: ");

            try
            {
                double v1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                try
                {
                    Console.WriteLine("Digite o segundo valor: ");
                    double v2 = double.Parse(Console.ReadLine());

                    double result = v1 - v2;

                    Console.WriteLine(" ");
                    Console.WriteLine($"O resultado da SUBTRAÇÃO de {v1} - {v2} = {result}");

                    ConfSubtracao.Subtracao();
                }
                catch
                {
                    Console.WriteLine("Ops, algo deu errado :( Tente novamente");
                    Thread.Sleep(2200);
                    Console.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Ops, algo deu errado :( Tente novamente");
                Thread.Sleep(2200);
                Console.Clear();
            }

            finally
            { Sub(); }
        }
    }
}