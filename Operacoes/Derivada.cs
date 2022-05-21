using System;
using System.Threading;
using Calculadora.Confirmacoes;

namespace Calculadora.Operacoes
{
    public static class Derivada
    {
        public static void Deriv()
        {
            //Fórmula -> a^n = n*a^n-1
            //podem ter operações em que não existe o expoente (ou seja, ele vale 1)
            //a -> função;  
            //n->expoente da função

            Console.Clear();
            Console.WriteLine("Cálculo de Derivada");
            Console.WriteLine(" ");

            /*
             A seguir, irei solicitar um valor double, convertê-lo para string e concatená-lo com uma string de valor X.
             Em seguida, irei separar o número da string X e retorná-lo para double
            */

            Console.WriteLine("Defina o valor da função: ");

            try
            {
                double valorDouble = double.Parse(Console.ReadLine());
                if (valorDouble != 0)
                {
                    string valorX = "x";
                    string conversaoValorParaString = valorDouble.ToString();
                    string juntarNumeroComString = string.Format("{0}{1}", conversaoValorParaString, valorX);

                    Console.WriteLine(" ");
                    Console.WriteLine($"Valor convertido para string: {juntarNumeroComString}"); //linha opcional

                    //Abaixo, o valor é retornado para double
                    double pegarApenasValorDouble = double.Parse(juntarNumeroComString.Substring(0, juntarNumeroComString.Length - 1));

                    Console.WriteLine(" ");
                    Console.WriteLine("Defina o expoente da função: ");

                    try
                    {
                        double valorExpoente = double.Parse(Console.ReadLine());
                        if (valorExpoente != 0)
                        {
                            if (valorExpoente != 1)
                            {
                                if (valorExpoente == 2)
                                {
                                    double derivada = valorExpoente * pegarApenasValorDouble;
                                    double expoenteDoResultadoFinal = valorExpoente - 1; //2-1 = 1

                                    string conversaoDaDerivadaParaString = derivada.ToString();
                                    string juntarResultadoComX = $"{conversaoDaDerivadaParaString}{valorX}";
                                    Console.WriteLine();
                                    Console.WriteLine($"O resultado da derivada {juntarNumeroComString}^{valorExpoente} é {juntarResultadoComX}");

                                    ConfDerivada.Derivada();
                                }
                                else
                                {
                                    double derivada = valorExpoente * pegarApenasValorDouble;
                                    double expoenteDoResultadoFinal = valorExpoente - 1;


                                    string conversaoDaDerivadaParaString = derivada.ToString();
                                    string conversaoDoExpoenteDoResultadoFinal = expoenteDoResultadoFinal.ToString();


                                    string juntarResultadoComX = $"{conversaoDaDerivadaParaString}{valorX}^{conversaoDoExpoenteDoResultadoFinal}";
                                    Console.WriteLine();
                                    Console.WriteLine($"O resultado da derivada {juntarNumeroComString}^{valorExpoente} é {juntarResultadoComX}");

                                    ConfDerivada.Derivada();
                                }
                            }
                            else
                            {
                                double derivada = valorExpoente * pegarApenasValorDouble;
                                double expoenteDoResultadoFinal = valorExpoente - 1;  //1-1 = 0

                                string conversaoDaDerivadaParaString = derivada.ToString();
                                Console.WriteLine();
                                Console.WriteLine($"O resultado da derivada é {conversaoDaDerivadaParaString}");

                                ConfDerivada.Derivada();
                            }
                        }
                        else
                        {
                            /*
                             * se o expoente for zero, significa que é um número constante
                             * portanto a derivada vale zero
                            */

                            Console.WriteLine("O valor da derivada é 0, pois trata-se de uma constante.");
                            Thread.Sleep(2200);
                            ConfDerivada.Derivada();
                        }
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
                    Console.WriteLine("O valor da função deve ser DIFERENTE de zero! Tente novamente");
                    Thread.Sleep(2200);
                }
            }
            catch
            {
                Console.WriteLine("Ops, algo deu errado :( Tente novamente");
                Thread.Sleep(2200);
                Console.Clear();
            }
            finally
            { Deriv(); }
        }
    }
}