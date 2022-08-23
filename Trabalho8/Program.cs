using System;

namespace Trabalho8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que receba 2 números de um usuário e retorne qual dos números é o maior e depois verifique se esse número é primo ou não.");

            Program program = new Program();    

            int num1, num2;
            int numeroEscolhido;
            int metodoEscolhido;

            Console.WriteLine("Escolha o método:");
            Console.WriteLine("1 - Número maior:");
            Console.WriteLine("2 - Número primo:");
            metodoEscolhido = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (metodoEscolhido)
                {
                    case 1:
                        Console.WriteLine("Informe o primeiro número para comparar:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número para comparar:");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        program.NumeroMaior(num1, num2);
                        break;
                    case 2:
                        Console.WriteLine("Informe o número a ser analisado:");
                        numeroEscolhido = Convert.ToInt32(Console.ReadLine());

                        program.NumeroPrimo(numeroEscolhido);
                        break;
                    
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;



                }

                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

           


        }

        private void NumeroMaior(int num1, int num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine("O primeiro número: "+num1+" é maior!");
            }  else if (num2 > num1)
            {
                Console.WriteLine("O segundo número: " + num2 + " é maior!");
            }
            else { Console.WriteLine("Os números são iguais"); }
        }

        private void NumeroPrimo(int numeroEscolhido)
        {
            int i = 2;
            while (i < numeroEscolhido)
            {
                if(numeroEscolhido % i == 0)
                {
                    Console.WriteLine("\nEste número é um número Composto.");
                    break;
                }
                i++;
            }

            if (i == numeroEscolhido)
            {
                Console.WriteLine("\nEste número é um número Primo.");
            }
            if (numeroEscolhido == 0 || numeroEscolhido == 1)
            {
                Console.WriteLine("\nEste número não Composto nem Primo.");
            }
        }
    }
}