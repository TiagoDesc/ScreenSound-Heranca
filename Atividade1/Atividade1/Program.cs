// See https://aka.ms/new-console-template for more information
using Alura.Filmes;

Filme filme1 = new Filme("Creed - Nascido pra Lutar", 133, new List<Artista>());
Filme filme2 = new Filme("Creed 2", 130, new List<Artista>());
Filme filme3 = new Filme("Creed 3", 116, new List<Artista>());
Filme filme4 = new Filme("Homem-Aranha: Sem Volta para Casa", 148, new List<Artista>());
Filme filme5 = new Filme("À Procura da Felicidade", 157, new List<Artista>());

List<Filme> filmesFavoritos = new List<Filme>();
filmesFavoritos.Add(filme1);
filmesFavoritos.Add(filme2);
filmesFavoritos.Add(filme3);
filmesFavoritos.Add(filme4);
filmesFavoritos.Add(filme5);

foreach (var filme in filmesFavoritos)
{
    Console.WriteLine($"Titulo: {filme.Titulo}");
    Console.WriteLine($"Duração: {filme.Duracao}");
    filme.ListarElenco();
    Console.WriteLine();
}