using PrimeiroPrograma.Menus;
using PrimeiroPrograma.Modelos;
using OpenAI_API;


#region Variáveis

string nomeSistema = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
string mensagemBoasVindas = "Bem vindo ao Screen Sound";

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(5));

Banda gal = new Banda("Gal Costa");
gal.AdicionarNota(new Avaliacao(10));
gal.AdicionarNota(new Avaliacao(9));
gal.AdicionarNota(new Avaliacao(8));

Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();// Dictionary<string, Banda>();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(gal.Nome, gal);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuListarBandas());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuExibirMedia());
opcoes.Add(5, new MenuRegistrarAlbum());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(-1, new MenuSair());

Album album = new Album("Casos de amor");
ira.AdicionarAlbum(new Album("Casos de amor"));
gal.AdicionarAlbum(new Album("Casos de amor 2"));
beatles.AdicionarAlbum(new Album("Casos de amor 3"));

#endregion



ExibirMensagemBoasVindas();
ExibirOpcoesMenu();

#region Funções
void ExibirMensagemBoasVindas()
{
    Console.WriteLine(nomeSistema);
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 6 para avaliar o álbum de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção:");

    string opcaoEscolhida = Console.ReadLine()!;
    if (!string.IsNullOrEmpty(opcaoEscolhida))
    {
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menu menuexibido = opcoes[opcaoEscolhidaNumerica];
            menuexibido.Executar(bandasRegistradas);
            if (opcaoEscolhidaNumerica > 0)
            {
                ExibirOpcoesMenu();
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }

    }
    else
    {
        Console.WriteLine("Você precisa digitar algo!\nVamos tentar novamente!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
        //MenuPrincipal();
    }
}

#endregion

#region Old
void Old_3()
{
    #region Funções
    void ExibirMensagemBoasVindas()
    {
        Console.WriteLine(nomeSistema);
        Console.WriteLine(mensagemBoasVindas);
    }

    void ExibirOpcoesMenu()
    {
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite 5 para registrar o álbum de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção:");

        string opcaoEscolhida = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(opcaoEscolhida))
        {
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
          


            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    MenuRegistrarBanda menu1 = new MenuRegistrarBanda();
                    menu1.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    //RegistrarBanda();
                    break;
                case 2:
                    MenuListarBandas menu2 = new MenuListarBandas();
                    menu2.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    //ListarBandasCadastradas();
                    break;
                case 3:
                    MenuAvaliarBanda menu3 = new MenuAvaliarBanda();
                    menu3.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    // AvaliarBanda();
                    break;
                case 4:
                    MenuExibirMedia menu4 = new();
                    menu4.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    //ExibirMediaBanda();
                    break;
                case 5:
                    MenuRegistrarAlbum menu5 = new MenuRegistrarAlbum();
                    menu5.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    //RegistrarAlbum();
                    break;
                case -1:
                    MenuSair menu6 = new MenuSair();
                    menu6.Executar(bandasRegistradas);
  
                    //Console.WriteLine("Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }
        else
        {
            Console.WriteLine("Você precisa digitar algo!\nVamos tentar novamente!");
            Thread.Sleep(2000);
            MenuPrincipal();
        }
    }

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Registro de Bandas:");
        Console.Write("\nDigite o nome da banda que você deseja cadastrar: ");
        string nomeBanda = Console.ReadLine()!; // exclamação serve para não aceitar valores nulos
        Banda banda = new Banda(nomeBanda);                                       //listaBandas.Add(nomeBanda);
        bandasRegistradas.Add(nomeBanda, banda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        MenuPrincipal();

    }

    void RegistrarAlbum()
    {
        Console.Clear();
        ExibirTituloOpcao("Registrar Álbuns: ");
        ExibirBandasCadastradas();

        Console.Write("\nDigite o nome da banda cujo álbum deseja regitrar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("\nAgora digite o nome do álbum: ");
            string nomeAlbum = Console.ReadLine()!;
            bandasRegistradas[nomeBanda].AdicionarAlbum(new Album(nomeAlbum));
            Console.WriteLine($"O álbum {nomeAlbum} de {nomeBanda} foi registrado com sucesso!");
            Console.WriteLine($"O álbum {bandasRegistradas[nomeBanda].ExibirTotalAlbuns()} de {nomeBanda} foi registrado com sucesso!");
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

    void ListarBandasCadastradas()
    {
        Console.Clear();
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

    void ExibirTituloOpcao(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
    }

    void AvaliarBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Avaliação de bandas:");
        ExibirBandasCadastradas();
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

    void ExibirMediaBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Média de bandas:");
        ExibirBandasCadastradas();
        Console.Write("\nQual banda você deseja saber a média?: ");
        string bandaAvaliada = Console.ReadLine()!;

        if (!string.IsNullOrEmpty(bandaAvaliada))
        {
            if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
            {
                Banda banda = bandasRegistradas[bandaAvaliada];
                Console.Write($"\nA média da banda {bandaAvaliada} é: {banda.Media}");

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

    void MenuPrincipal()
    {
        Console.Clear();
        ExibirMensagemBoasVindas();
        ExibirOpcoesMenu();
    }

    void ExibirBandasCadastradas()
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
    #endregion
}

void Old_2()
{

    Banda Queen = new Banda("Queen");
    //Queen.Nome = "Queen";

    Album albumQueen = new Album("A night at the opera");
    //albumQueen.Nome = "A night at the opera";

    Musica musica = new Musica(Queen, "Love of my life")
    {
        Duracao = 213,
        Disponivel = false
    };
    //musica.Nome = "Love of my life";
    //musica.Duracao = 213;
    //musica.Disponivel = true;
    musica.ExibirFicha();
    Console.WriteLine();

    albumQueen.AdicionarMusica(musica);

    musica = new Musica(Queen, "Bohemian Rhapsody")
    {
        Duracao = 254,
        Disponivel = true
    };
    //musica.Nome = "Bohemian Rhapsody";
    //musica.Duracao = 254;
    //musica.Disponivel = true;

    albumQueen.AdicionarMusica(musica);

    Queen.AdicionarAlbum(albumQueen);

    musica.ExibirFicha();
    Console.WriteLine();
    albumQueen.ExibirMusicas();
    Console.WriteLine();
    Queen.Exibirdiscografia();


    Episodio episodio = new Episodio("Episódio gênesis", 1, 50);

    episodio.AdicionarConvidado("Yasmin");
    episodio.AdicionarConvidado("Maria");
    episodio.AdicionarConvidado("Pedro");

    Podcast pod = new Podcast("PodCast da Yaz", "10.225.226");
    pod.AdicionarEpisodios(episodio);

    pod.ExibirDetalhes();

}

void Old()
{
    //Definindo Variáveis
    //string curso = "Programação C# orientada a objetos";


    string nomeSistema = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
    string mensagemBoasVindas = "Bem vindo ao Screen Sound";

    string nome = "Yasmin";
    string sobrenome = "Pesquero";

    //List<String> listaBandas = new List<string> { "U2", "New Order", "The Beatles"};
    Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
    bandasRegistradas.Add("Calypso", new List<int>() { 8, 7, 5, 5 });
    bandasRegistradas.Add("U2", new List<int>() { 10, 7, 5, 9 });
    bandasRegistradas.Add("Pink Floyd", new List<int>() { 8, 9, 9, 10 });

    //Programa principal
    ExibirMensagemBoasVindas();
    Console.WriteLine();
    Console.WriteLine(nome + " " + sobrenome);
    ExibirOpcoesMenu();


    #region Funções
    void ExibirMensagemBoasVindas()
    {
        Console.WriteLine(nomeSistema);
        Console.WriteLine(mensagemBoasVindas);
    }

    void ExibirOpcoesMenu()
    {
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção:");

        string opcaoEscolhida = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(opcaoEscolhida))
        {
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    ListarBandasCadastradas();
                    break;
                case 3:
                    AvaliarBanda();
                    break;
                case 4:
                    ExibirMediaBanda();
                    break;
                case -1:
                    Console.WriteLine("Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Você precisa digitar algo!\nVamos tentar novamente!");
            Thread.Sleep(2000);
            MenuPrincipal();
        }
    }

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Registro de Bandas:");
        Console.Write("\nDigite o nome da banda que você deseja cadastrar: ");
        string nomeBanda = Console.ReadLine()!; // exclamação serve para não aceitar valores nulos
                                                //listaBandas.Add(nomeBanda);
        bandasRegistradas.Add(nomeBanda, new List<int>());
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        MenuPrincipal();

    }

    void ListarBandasCadastradas()
    {
        Console.Clear();
        ExibirTituloOpcao("Bandas Registradas:");
        int i = 1;
        foreach (var item in bandasRegistradas)
        {
            Console.WriteLine($"{i}: {item.Key}");
            i += 1;
        }
        Console.WriteLine("\nDigite qualquer tecla para voltar");
        Console.ReadKey();
        MenuPrincipal();
    }

    void ExibirTituloOpcao(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
    }

    void AvaliarBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Avaliação de bandas:");
        Console.WriteLine("\nBandas Registradas:");
        int i = 1;
        foreach (var item in bandasRegistradas)
        {
            Console.WriteLine($"{i}: {item.Key}");
            i += 1;
        }

        Thread.Sleep(1000);
        Console.Write("\nQual banda você deseja avaliar?: ");
        string bandaAvaliada = Console.ReadLine()!;

        if (!string.IsNullOrEmpty(bandaAvaliada))
        {
            if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
            {
                Console.Write($"\nQual a nota você quer dar para a banda {bandaAvaliada}?: ");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[bandaAvaliada].Add(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {bandaAvaliada}!");
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

    void ExibirMediaBanda()
    {
        Console.Clear();
        ExibirTituloOpcao("Média de bandas:");
        Console.WriteLine("\nBandas Registradas:");
        int i = 1;
        foreach (var item in bandasRegistradas)
        {
            Console.WriteLine($"{i}: {item.Key}");
            i += 1;
        }

        Thread.Sleep(1000);
        Console.Write("\nQual banda você deseja saber a média?: ");
        string bandaAvaliada = Console.ReadLine()!;

        if (!string.IsNullOrEmpty(bandaAvaliada))
        {
            if (bandasRegistradas.ContainsKey(bandaAvaliada.Trim()))
            {
                List<int> notasBanda = bandasRegistradas[bandaAvaliada];
                var media = notasBanda.Average();
                Console.Write($"\nA média da banda {bandaAvaliada} é: {media}");

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

    void MenuPrincipal()
    {
        Console.Clear();
        ExibirMensagemBoasVindas();
        ExibirOpcoesMenu();
    }

    #endregion

}
#endregion



