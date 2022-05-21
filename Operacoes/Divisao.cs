using System;
using System.Threading;
using Calculadora.Confirmacoes;

namespace Calculadora.Operacoes
{
    public static class Divisao
    {
        public static void Div()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
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

                    if (v2 != 0)
                    {
                        /*
                            Math.Round(v1 / v2, 4);
                            Optei por tirar o Math.Round para conseguir maior precisão ao efetuar os cálculos
                        */

                        double result = v1 / v2;

                        Console.WriteLine(" ");
                        Console.WriteLine($"O resultado da DIVISÃO de {v1} / {v2} = {result}");

                        ConfDivisao.Divisao();
                    }
                    else
                    {
                        Console.WriteLine($"Não é possível dividir por zero (0)");
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
            }
            catch
            {
                Console.WriteLine("Ops, algo deu errado :( Tente novamente");
                Thread.Sleep(2200);
                Console.Clear();
            }

            finally
            { Div(); }
        }
    }
}