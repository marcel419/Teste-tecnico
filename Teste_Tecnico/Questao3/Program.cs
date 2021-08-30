using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite o numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
            {

                if (numero > 11)
                {
                    Console.WriteLine("inválido.");
                }
                if (true)
                {

                }

                Console.WriteLine(numero + " * " + x + " = " + numero * x);
            }
            Console.ReadKey();
        }
    }
}
