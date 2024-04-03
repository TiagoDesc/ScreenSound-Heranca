using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2.Classes.Oficina
{
    internal class Mecanico
    {

        public string Nome { get; set; }
        public string Especialidade { get; set;}

        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
            
        }
    }

    

    
}
