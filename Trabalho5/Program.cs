using System;

namespace Trabalho5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Trabalho 5: Escreva um programa que calcule e exiba a soma da seguinte série : 1*x + 2*x^2 + 3*x^3 + 4*x^4 + 5*x^5 + … + n*xn. \n\n");

            int numero;
            double soma = 0;
            double x;

            Console.WriteLine("Informe o valor de n para definir o tamanho da série:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numero+1; i++)
            {
                Console.Write(i + "*x^" + i);
                if (i < numero)
                {
                    Console.Write(" + ");
                }
                x = (double)i;
                soma = soma + (i * Math.Pow(x,x));
            
            }

            Console.WriteLine("\nA soma da série é : " + soma);

            Console.ReadKey();
        }
    }
}
