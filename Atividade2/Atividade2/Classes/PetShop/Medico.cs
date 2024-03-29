using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2.Classes.PetShop
{
    internal class Medico
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}
