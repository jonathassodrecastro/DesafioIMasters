using System;

namespace Trabalho4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Trabalho 4: Imprimir a matriz onde o 1 fique na diagonal e 0 nas demais posições\n\n");

            Console.WriteLine("Informe o tamanho da matriz. Ex: 10");
            int valor = Convert.ToInt32(Console.ReadLine());
               

        

            for(int i = 0; i < valor; i++)
            {
                for(int j = 0; j < valor; j++)
                {
                    if(i == j) { 
                        Console.Write("1"); 
                    }
                    else { Console.Write("0");}
                }
                Console.WriteLine("");
            }    


            Console.ReadKey();
        }
    }
}