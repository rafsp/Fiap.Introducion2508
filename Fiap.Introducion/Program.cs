// See https://aka.ms/new-console-template for more information
using Fiap.Introducion;
Util util = new Util();
Console.WriteLine("╔════════════════════════════════════╗");
Console.WriteLine("║         FIAP - WELCOME!            ║");
Console.WriteLine("║    Primeira Aplicação C# 2025      ");
Console.WriteLine("╚════════════════════════════════════╝");

Console.WriteLine("\nOlá, Mundo FIAP!");
Console.WriteLine("Bem-vindo ao universo .NET!\n");

// Solicita o nome do usuário
Console.Write("Digite seu usuário: ");
string nome = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

if (nome == "admin" & senha == "123456")
{
    Console.WriteLine($"\nParabéns, {nome}!");
    Console.WriteLine($"Seu usuário e senha são válidos");

    Console.WriteLine("Digite um número (1,2 ou 3) para opções abaixo:");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Extrato");
    Console.WriteLine("3 - Investimentos");

    int opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você selecionou saque");
            Console.Write("Digite o valor que deseja sacar?");
            float vlSaque = float.Parse(Console.ReadLine());
            break;

        case 2:
            Console.WriteLine("Você selecionou extrato");
            Console.Write("Você não possui nada em conta");
            break;

        case 3:
            Console.WriteLine("Você selecionou investimentos");
            Console.Write("Digite o valor que deseja investir?");
            float vlInvestido = float.Parse(Console.ReadLine());
            break;

        default:
            Console.WriteLine("Opção inválida. Escolha apenas 1,2 ou 3");
            break;
    }
    //Console.Write("Digite o valor que deseja investir?");
    //float vlInvestido = float.Parse(Console.ReadLine());

}
else
{
    Console.WriteLine("Usuário ou senha inválidos");


    util.Log(Util.TiposErro.ErroLogin);
   

}

    //Console.WriteLine($"\nParabéns, {nome}!");
    //Console.WriteLine($"Você acabou de criar seu primeiro programa C# na FIAP!");

    // Aguarda tecla para não fechar
    Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();

