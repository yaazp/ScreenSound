using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Episodio
    {
        public Episodio(string titulo, int ordem, int duracao)
        {
            Titulo = titulo;
            Ordem = ordem;
            Duracao = duracao;
        }

        public int Duracao { get; }
        public int Ordem { get; }
        public string Resumo => $"Episódio: {Ordem} - {Titulo}. Duração: {Duracao}, Convidados: {string.Join(",", Convidados)}";
        public string Titulo { get; }

        private List<string> Convidados = new List<string>();

        public void AdicionarConvidado(string convidado)
        {
            Convidados.Add(convidado);

        }
    }
}
