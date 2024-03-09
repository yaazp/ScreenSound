using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus
{
    internal class MenuExibirMedia : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloOpcao("Média de bandas:");
            ExibirBandasCadastradas(bandasRegistradas);
            Console.Write("\nQual banda você deseja saber a média?: ");
            string bandaAvaliada = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(bandaAvaliada))
            {
                if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
                {
                    Banda banda = bandasRegistradas[bandaAvaliada];
                    Console.WriteLine(banda.resumo);
                    Console.Write($"\nA média da banda {bandaAvaliada} é: {banda.Media}");
                    Console.WriteLine("\nDiscografia: ");
                    foreach (Album album in banda.Albuns)
                    {
                        Console.WriteLine($"{album.Nome}  -> {album.Media}");
                    }
                    //COMPLETAR AQUI PARA APARECER A MÉDIA DOS ALBUNS TAMBÉM
                    Console.WriteLine();
                    Thread.Sleep(4000);
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
}
