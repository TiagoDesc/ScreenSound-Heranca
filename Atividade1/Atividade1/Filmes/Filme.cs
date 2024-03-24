using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1.Filmes
{
    internal class Filme
    {
        private List <string> Elenco { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int duracao, List<string>? elenco)
        {
            if(elenco == null)
            {
                Elenco = new List<string>();
            }
            else
            {
                Elenco = elenco;
            }

            Titulo = titulo;
            Duracao = duracao;
        }

        public void AdicionarElenco(string ator)
        {
            Elenco.Add(ator);
            Console.WriteLine($"{ator} foi adicionado/a ao elenco!");
        }

        public void ListarElenco()
        {

            if(Elenco.Count == 0)
            {
                Console.WriteLine("O elenco está vazio.");
            }
            else
            {
                Console.WriteLine("Elenco:");
                foreach (var ator in Elenco) {
                    Console.WriteLine(ator);

                }
            }
            
        }
    }
}
