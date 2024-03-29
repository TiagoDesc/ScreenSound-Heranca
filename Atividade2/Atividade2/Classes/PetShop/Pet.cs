
namespace Atividade2.Classes.PetShop
{
    internal class Pet
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }

        public Pet(string nome, int idade, string especie)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }

    }
}
