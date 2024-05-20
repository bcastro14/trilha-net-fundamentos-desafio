using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

//precoInicial = Convert.ToDecimal(Console.ReadLine());
//precoPorHora = Convert.ToDecimal(Console.ReadLine());
//Adicionando o tratamento de exceções pra garantir que um input inválido não irá interromper a execução do programa.

while (true)
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
    try { precoInicial = Convert.ToDecimal(Console.ReadLine().Replace(".",",")); } // Input de 2.5 vira 25, usando Replace pra corrigir.
    catch { Console.WriteLine("Input inválido, deve ser um número decimal. Tente novamente.\n"); continue; }
    
    Console.WriteLine("Agora digite o preço por hora:");
    try { precoPorHora = Convert.ToDecimal(Console.ReadLine().Replace(".",",")); }
    catch { Console.WriteLine("Input inválido, deve ser um número decimal. Tente novamente.\n"); continue; }
    
    break;
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

//Mostrando os valores dos Preços inseridos:
// Console.Clear();
// Console.WriteLine($"O Preço inicial é R${precoInicial}. O Preço por hora é R${precoPorHora}.\n");
// Console.WriteLine("Pressione Enter para continuar");
// Console.ReadLine();

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
