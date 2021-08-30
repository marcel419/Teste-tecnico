using System;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que receba um número do usuário e diga se ele é divisível por 3, 6 ou 7.

            int numero1;
            Console.WriteLine("Digite o numero: ");
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 % 3 == 0)
            {
                Console.WriteLine("É divisivel por 3.");

            }
            if (numero1 % 6 == 0)
            {
                Console.WriteLine("É divisivel por 6. ");
            }
            if (numero1 % 7 == 0)
            {
                Console.WriteLine("É divisivel por 7.");
            }

            Console.ReadKey();
        }
    }
}
