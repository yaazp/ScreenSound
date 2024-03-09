using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Album: IAvaliavel
    {

        public Album(string nome)
        {
            Nome = nome;
            ContadorAlbuns++;
        }

        public  string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        private List<Avaliacao> Notas = new();

        public double Media
        {
            get
            {
                if (Notas.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Notas.Average(a => a.Nota);
                }
            }
        }

        private List<Musica> musicas = new List<Musica>();

        public static int ContadorAlbuns = 0;


        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicas()
        {
            Console.WriteLine($"Lista de músicas do álbum: {Nome}");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Duração total do álbum: {DuracaoTotal}");
        }

        public void AdicionarNota(Avaliacao nota)
        {
            Notas.Add(nota);
        }
    }
}
