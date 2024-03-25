using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes
{
    internal class Filme
    {
        public List <Artista> Elenco { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int duracao, List<Artista> elenco)
        {
            if(elenco == null)
            {
                Elenco = new List<Artista>();
            }
            else
            {
                Elenco = elenco;
                foreach (var artista in Elenco)
                {
                    artista.AdicionarFilme(this);
                }
            }

            Titulo = titulo;
            Duracao = duracao;
        }

        public void AdicionarElenco(Artista artista)
        {
            Elenco.Add(artista);
            if (!artista.FilmesAtuados.Contains(this))
            {
                artista.AdicionarFilme(this);
            }
            Console.WriteLine($"{artista} adicionado/a ao elenco.");
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
                foreach (var artista in Elenco) {
                    Console.WriteLine(artista.Nome);

                }
            }
            
        }
    }
}
