using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, double peso): base(nome, peso)
        {
            this.Nome = nome;
            this.Peso = peso;
        }
        public override double QuantidadeDeRacao()
        {
            if (this.Peso <= 4 )
            {
                return 40 * this.Peso;
            }
            else if (this.Peso > 4 && this.Peso <= 12)
            {
                return 45 * this.Peso;
            }
            else
            {
                return 55 * this.Peso;
            }
        }

        public override string Som()
        {
            return "auau";
        }
    }
}
