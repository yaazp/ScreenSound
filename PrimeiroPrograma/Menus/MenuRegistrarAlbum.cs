using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloOpcao("Registrar Álbuns: ");
            ExibirBandasCadastradas(bandasRegistradas);

            Console.Write("\nDigite o nome da banda cujo álbum deseja regitrar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.Write("\nAgora digite o nome do álbum: ");
                string nomeAlbum = Console.ReadLine()!;
                bandasRegistradas[nomeBanda].AdicionarAlbum(new Album(nomeAlbum));
                Console.WriteLine($"O álbum {nomeAlbum} de {nomeBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                MenuPrincipal();
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não está registrada!\nTente novamente!");
                Thread.Sleep(4000);
                MenuPrincipal();
            }


        }

    }
}
