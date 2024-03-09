using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus;

internal class Menu
{
    string nomeSistema = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
    string mensagemBoasVindas = "Bem vindo ao Screen Sound";

    public void ExibirTituloOpcao(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
    }

    public void ExibirBandasCadastradas(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nBandas Registradas:");
        int i = 1;
        foreach (var item in bandasRegistradas)
        {
            Console.WriteLine($"{i}: {item.Key}");
            i += 1;
        }

        Thread.Sleep(1000);
    }

    public void ExibirAlbunsCadastrados_Banda( Banda bandasAvaliada)
    {
        Console.WriteLine($"\nAlbuns registrados para a banda {bandasAvaliada.Nome}:");
        int i = 1;
        List<Album> albuns = bandasAvaliada.Albuns;
        foreach (var item in albuns)
        {
            Console.WriteLine($"{i}: {item.Nome}");
            i += 1;
        }

        Thread.Sleep(1000);
    }

    public void MenuPrincipal()
    {

        Console.Clear();
        ExibirMensagemBoasVindas();
       // ExibirOpcoesMenu();
    }

    void ExibirMensagemBoasVindas()
    {
        Console.WriteLine(nomeSistema);
        Console.WriteLine(mensagemBoasVindas);
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }


}
