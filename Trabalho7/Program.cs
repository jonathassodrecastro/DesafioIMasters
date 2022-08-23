using System;

namespace Trabalho7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um programa que receba n valores do usuário e em seguida ordene os valores em ordem ascendente.");

            int tamanhoArray;
            int temp;

            Console.WriteLine("Informe o número de elementos que o array comportará");
            tamanhoArray = Convert.ToInt32(Console.ReadLine());
            
            int[] numeros = new int[tamanhoArray];

            Console.WriteLine("Informe os valores de cada posição:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());   
            }
           // for (int i = 0; i < numeros.Length; i++)
            //{
             //   Console.WriteLine(numeros[i]);
            //}

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < tamanhoArray - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ordenando em Ordem Ascendente : ");
            //imprime os numeros ordenados
            for (int i = 0; i < tamanhoArray; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();

        }
    }
}
          