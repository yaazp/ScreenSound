using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcao("Avaliação de bandas:");
        ExibirBandasCadastradas(bandasRegistradas);
        Console.Write("\nQual banda você deseja avaliar?: ");
        string bandaAvaliada = Console.ReadLine()!;

        if (!string.IsNullOrEmpty(bandaAvaliada))
        {
            if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
            {

                Banda banda = bandasRegistradas[bandaAvaliada];
                Console.Write($"\nQual a nota você quer dar para a banda {bandaAvaliada}?: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!); // aqui não precisei colocar new porque a função é static
                banda.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota.Nota} foi registrada com sucesso para a banda {bandaAvaliada}!");
                Thread.Sleep(2000);
                MenuPrincipal();


            }
            else
            {
                Console.WriteLine($"A banda {bandaAvaliada} não foi encontrada!");
                Console.WriteLine("Digite qualquer tecla para voltar.");
                Console.ReadKey();
                MenuPrincipal();
            }

        }


    }

}
