using System;
using System.Threading;
using Calculadora.Confirmacoes;

namespace Calculadora.Operacoes
{
    public static class Integral
    {
        // Fórmula -> a^n+1/n+1
        //O limite de integração 2 (lim2) SEMPRE tem que ser MAIOR que o limite de integração 1 (lim1)
        public static void Integ()
        {
            Console.Clear();
            Console.WriteLine("Cálculo de Integral");
            Console.WriteLine(" ");
            Console.WriteLine("Defina o limite de integração 1: ");

            try
            {
                double lim1 = double.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine("Defina o limite de integração 2: ");
                    double lim2 = double.Parse(Console.ReadLine());

                    if (lim2 > lim1)
                    {
                        try
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Defina o expoente da função que irá integrar: ");

                            //x^expoentedeX
                            double expoenteDeX = double.Parse(Console.ReadLine());

                            double funcaoX = lim1;

                            double formulaIntegralLim1 = Math.Pow(funcaoX, (expoenteDeX + 1)) / (expoenteDeX + 1);
                            Console.WriteLine($"Valor da integral com limite de integração 1 ({lim1}): {formulaIntegralLim1}");


                            funcaoX = lim2;

                            double formulaIntegralLim2 = Math.Pow(funcaoX, (expoenteDeX + 1)) / (expoenteDeX + 1);
                            Console.WriteLine($"Valor da integral com limite de integração 2 ({lim2}): {formulaIntegralLim2}");


                            double integral = formulaIntegralLim2 - formulaIntegralLim1;

                            Console.WriteLine(" ");
                            Console.WriteLine($"O valor da integral é {integral}");

                            ConfIntegral.Integral();
                        }
                        catch
                        {
                            Console.WriteLine("Ops, algo deu errado :( Tente novamente");
                            Thread.Sleep(2200);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("O limite de integração 2 precisa ser MAIOR que o limite de integração 1! Tente novamente");
                        Thread.Sleep(2000);
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
            { Integ(); }
        }
    }
}