using Questao1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste_Tecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> total = new();  

            var gato = new Gato("Daphne", 20);
            total.Add(gato.QuantidadeDeRacao());

            gato = new Gato("Artemis", 3);
            total.Add(gato.QuantidadeDeRacao());


            var cachorro = new Cachorro("Xereta", 10);
            total.Add(cachorro.QuantidadeDeRacao());

            cachorro = new Cachorro("Victor Hugo", 5);
            total.Add(cachorro.QuantidadeDeRacao());

            Console.WriteLine( total.Sum());
        }
      
    }


   
}
