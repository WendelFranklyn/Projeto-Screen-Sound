string mensagem = "Boas vindas ao Screen Sound";
List<string> listaBandas = new List<string>();

void ExibirLogo()
{
    //O @ no C# antes da string, é para chamar a string de uma maneira como você gostaria de ver, vulgo exemplo
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagem);
}
void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // O "!" no final da linha do código, serve para não trabalhar com uma variavel de valor nulo
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarRegistroBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoNumerica);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoNumerica);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("********************\n");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirMenu();
}

void MostrarRegistroBandas()
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("*************************************\n");
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaBandas[i]}");
    //}
    foreach (string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine(\n"Digite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirLogo();
ExibirMenu();
Console.ReadLine();