using System;
namespace Trabalho10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string numero;
            int a;
            int tamanho;
            
            try
            {
                Console.WriteLine("Informe um número inteiro : ");
                numero = Console.ReadLine();
                tamanho = numero.Length;
                a = int.Parse(numero);
                p.calcular(a, tamanho);
                Console.ReadKey();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        private void calcular(int numero, int tamanho)
        {
            int a;
            int soma = 0;
            for (int i = 1; i <= tamanho; i++)
            {
                a = numero % 10;
                numero = numero / 10;
                Console.Write(a);
                if (tamanho > i)
                    Console.Write(" + ");
                soma = soma + a;
            }
            Console.WriteLine("\n");
            Console.WriteLine("A soma dos dígitos individuais deste número é => " + soma);
        }
    }
}