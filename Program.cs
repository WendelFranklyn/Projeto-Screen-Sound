string mensagem = "Boas vindas ao Screen Sound";

void ExibirMensagem()
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
            Console.WriteLine("Você escolheu a opção " + opcaoNumerica);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoNumerica);
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
ExibirMensagem();
ExibirMenu();
Console.ReadLine();