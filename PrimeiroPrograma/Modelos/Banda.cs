using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Banda : IAvaliavel //banda implementa a interface IAvaliavel
    {

        public Banda(string nome) //construtor
        {
            Nome = nome;
        }
        public string? resumo { get; set; }
        public string Nome { get; } //quando deixo a propriedade apenas como leitura, é preciso inicializar o valor no construtor ou já fornecer nesta linha

        public List<Album> Albuns = new List<Album>();
        private List<Avaliacao> Notas = new List<Avaliacao>();
        public static int TotalAlbuns = 0;
        public double Media
        {
            get
            {
                if (Notas.Count == 0 )
                {
                    return 0;
                }
                else
                {
                    return Notas.Average(a => a.Nota);
                }
            }
        }

        public void AdicionarAlbum(Album album)
        {
            Albuns.Add(album);
        }

        public void Exibirdiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}: ");
            foreach (Album album in Albuns)
            {
                Console.WriteLine($"Álbum: {album.Nome} --> Duração Total: {album.DuracaoTotal}");
                Console.WriteLine();
            }
        }

        public void AdicionarNota(Avaliacao nota)
        {
            Notas.Add(nota);
        }

        public int ExibirTotalAlbuns()
        {
            if (Albuns.Count == 0)
            {
                return 0;
            }
            else
            {
                TotalAlbuns = Album.ContadorAlbuns;
                return TotalAlbuns;
            }
            
        }

        public List<Album> RetornaAlbuns()
        {
            return Albuns;
        }
    }
}
