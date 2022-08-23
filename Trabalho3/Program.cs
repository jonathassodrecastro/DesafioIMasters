using System;
using System.Text;

namespace Trabalho3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exibir o caractere e o valor decimal na tabela ASCII");

            char ch;
            int i = 0;

            do
            {
                Console.Write(i);
                Console.Write(" ");
                ch = (char)i;  
                i++;   
                Console.WriteLine(ch);

            } while (i <= 255);
            
            Console.ReadKey();
        }
    }
}