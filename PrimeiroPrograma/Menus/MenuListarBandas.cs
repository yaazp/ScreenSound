using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus
{
    internal class MenuListarBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas); //aqui indico que vai executar o que está no pai (menu) e depois o que está no filho
            ExibirTituloOpcao("Bandas Registradas:");
            int i = 1;
            foreach (var item in bandasRegistradas)
            {

                Console.WriteLine($"{i}: {item.Key} - Total de albuns: {item.Value.ExibirTotalAlbuns()}");
                i += 1;
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar");
            Console.ReadKey();
            MenuPrincipal();
        }
    }
}
