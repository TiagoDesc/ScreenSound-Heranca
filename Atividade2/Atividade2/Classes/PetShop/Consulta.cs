using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2.Classes.PetShop
{

    //animal
    //donoAnimal
    //Veterianrio
    //dataconsulta
    internal class Consulta
    {

        public Pet Animal { get; set; }
        public Dono DonoAnimal { get; set; }
        public Medico Veterinario {  get; set; }

        public string DataConsulta { get; set; }

        public Consulta(Pet animal, Dono donoAnimal, Medico veterinario, string dataConsulta)
        {
            Animal = animal;
            DonoAnimal = donoAnimal;
            Veterinario = veterinario;
            DataConsulta = dataConsulta;
        }
    }
}
