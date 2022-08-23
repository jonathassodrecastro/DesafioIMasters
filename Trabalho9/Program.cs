// See using System;
namespace Trabalho9
{
    class Program
    {
        public static void PorValor(int num)
        {
            num++;
        }
        public static void PorReferencia(ref int num)
        {
            num++;
        }
        static void Main(string[] args)
        {
            
            int num;
            try
            {
                Console.Write("Informe um número :\t");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n\tTipo por Valor");
                Console.WriteLine("--------------------------");
                Console.Write("\nValor Anterior:\t{0}", num);
                Program.PorValor(num);
                Console.Write("\nValor Atual:\t{0}", num);
                Console.WriteLine("\n\n\n--------------------");
                Console.WriteLine("\tTipo por Referência");
                Console.WriteLine("--------------------------");
                Console.Write("\nValor Anterior:\t{0}", num);
                Program.PorReferencia(ref num);
                Console.Write("\nValor Atual:\t{0}", num);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}