using System;
using Calculadora.Operacoes;
using System.Threading;

namespace Calculadora

{
    class Principal
    {
         static void Main(string[] args)
         { Menu(); }
         
        public static void Menu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"Bem-vindo à calculadora");
            Console.WriteLine("Selecione qual das operações abaixo deseja fazer: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Calcular Integral");
            Console.WriteLine("6 - Calcular Derivada");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("----------------");


            try
            {
                short option = short.Parse(Console.ReadLine());

                switch (option)
                {
                   case 1: Soma.Sum(); break;
                   case 2: Subtracao.Sub(); break;
                   case 3: Divisao.Div(); break;
                   case 4: Multiplicacao.Mult(); break;
                   case 5: Integral.Integ(); break;
                   case 6: Derivada.Deriv(); break;
                   case 0: Environment.Exit(0); break;
                   default:
                      {
                        Console.Clear();
                        Menu();
                       };
                       break;
                }
            }
            catch
            {
               Console.WriteLine("");
               Console.WriteLine("Ops, algo deu errado :( Tente novamente");

                Thread.Sleep(2000);
                Console.Clear();
                Menu();
            }
        }
    }
}