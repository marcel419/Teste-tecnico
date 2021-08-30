using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        protected Animal(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public abstract string Som();
        public abstract double QuantidadeDeRacao();
    }
}
