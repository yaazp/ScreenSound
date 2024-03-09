using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Musica
    {
        public Musica(Banda artista, string nome) //construtor para forçar a cada vez que for fazer um new Musica() passar o nome da banda como parâmetro
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        // public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}"; //Lambda


        public void ExibirFicha()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            //Console.WriteLine($"Disponível: {Disponivel}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano ++");
            }

            //Console.WriteLine($"Descrição Resumida: {DescricaoResumida.}");
        }


    }
}
