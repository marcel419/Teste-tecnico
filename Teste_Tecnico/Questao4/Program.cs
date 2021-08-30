using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine($"Informe o nome da {i}º Pessoa: ");
                pessoa.SetNome(Console.ReadLine());

                Console.WriteLine($"Informe o cargo da {i}º Pessoa: (Starter, Junior e Sênior) ");
                pessoa.SetNome(Console.ReadLine().ToLower());

            }
        }

    }
}
