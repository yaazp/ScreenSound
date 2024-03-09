using OpenAI_API;
using PrimeiroPrograma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Menus;

internal class MenuRegistrarBanda : Menu
{
   public async override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcao("Registro de Bandas:");
        Console.Write("\nDigite o nome da banda que você deseja cadastrar: ");
        string nomeBanda = Console.ReadLine()!; // exclamação serve para não aceitar valores nulos
        Banda banda = new Banda(nomeBanda);                                      //listaBandas.Add(nomeBanda);
        //Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(nomeBanda, banda);

        var client = new OpenAIAPI("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");  //cria variável que instancia a chave da api

        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 parágrafo. Adote um estilo informal.");      //envia o promp de comando para a api

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult(); //GetAwaiter faz com que espere a resposta
        banda.resumo = resposta;


        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        MenuPrincipal();

    }
}
