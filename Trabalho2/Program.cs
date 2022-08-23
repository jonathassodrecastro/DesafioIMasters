using System;

namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Escrever uma matriz com 7 linhas e até 4 asteriscos por linha\n");
            //o primeiro for escreve a matriz na crescente até o valor máximo
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }  
                Console.WriteLine("\n");
            }

            //o segundo for escreve a parte decrescente
            for (int i = 0; i <= 3; i++)
            {
                for(int j = 3; j > i; j--)
                {
                    Console.Write("*");
               }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}