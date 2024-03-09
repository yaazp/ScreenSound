using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => Episodios.Count();
        private List<Episodio> Episodios = new List<Episodio>();

        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodios(Episodio episodio)
        {
            Episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Host: {Host}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine("Lista de episódios: \n");
            foreach (Episodio item in Episodios)
            {
                Console.WriteLine($"Episódio: {item.Ordem}, Título: {item.Titulo}, Resumo: {item.Resumo}");
            };

            Console.WriteLine($"\nTotal de Episodios: {TotalEpisodios}");
        }
    }
}
