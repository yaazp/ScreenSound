using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos; // se coloco o ponto e vírgula não precisa de chave no ínicio e fim

public class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota < 0) Nota = 0;
        if (nota > 10) Nota = 10;
        Nota = nota;
    }

    public int Nota { get;}

    public static Avaliacao Parse(string texto) //sendo static --> significa que não usa nenhuma informação da instância dessa classe
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

}
