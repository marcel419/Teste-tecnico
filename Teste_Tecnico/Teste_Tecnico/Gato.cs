using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class Gato : Animal
    {
        public Gato(string nome, double peso) : base(nome, peso)
        {
            this.Nome = nome;
            this.Peso = peso;
        }
        public override double QuantidadeDeRacao()
        {
            if (this.Peso <= 3)
            {
                return 10 * this.Peso;
            }
            else 
            {
                return 13 * this.Peso;
            }
          
        }

        public override string Som()
        {
            return "miau";
        }
    }
}
