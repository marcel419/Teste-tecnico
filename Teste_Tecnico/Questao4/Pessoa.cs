using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    public class Pessoa
    {
        private string nome;
        private string cargo;

     
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            if (value == "junior" || value == "starter")
            {
                nome = value;
            }
            nome = "senior";
        }


        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string value)
        {
            cargo = value;
        }
    }
}
