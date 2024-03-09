using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcao("Avaliar de album:");
        ExibirBandasCadastradas(bandasRegistradas);
        Console.Write("\nQual banda você deseja avaliar?: ");
        string bandaAvaliada = Console.ReadLine()!;

        if (!string.IsNullOrEmpty(bandaAvaliada))
        {
            if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
            {
                Banda banda = bandasRegistradas[bandaAvaliada];
                ExibirAlbunsCadastrados_Banda(banda);
                Console.Write($"\nQual album da banda {bandaAvaliada} você deseja avaliar?: ");
                string albumAvaliado = Console.ReadLine()!;

                if (!string.IsNullOrEmpty(albumAvaliado))
                {

                    
                    List<Album> albunsBanda = banda.Albuns;
                    
                    if (banda.Albuns.Any(a => a.Nome.Equals(albumAvaliado)))
                    {
                        Album album = banda.Albuns.First(a => a.Nome.Equals(albumAvaliado)); //aqui eu capturo o album avaliado de fato

                        Console.Write($"\nQual a nota você quer dar para o album {albumAvaliado} da banda {bandaAvaliada}?: ");
                        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!); // aqui não precisei colocar new porque a função é static
                        album.AdicionarNota(nota);
                        Console.WriteLine($"A nota {nota.Nota} foi registrada com sucesso para o album {albumAvaliado} da banda {bandaAvaliada}!");
                        Thread.Sleep(2000);
                        MenuPrincipal();
                    }
                    else
                    {
                        Console.WriteLine($"O album {albumAvaliado} não foi localizado!");
                        Console.WriteLine("Digite qualquer tecla para voltar.");
                        Console.ReadKey();
                        MenuPrincipal();
                    }
                }


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
