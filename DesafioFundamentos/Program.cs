
using System;
using System.Text;
using DesafioFundamentos.Models;

// Configura a codificação UTF-8
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("====================================");
Console.WriteLine("   SISTEMA DE ESTACIONAMENTO - DIO");
Console.WriteLine("====================================");

// Solicita e valida o preço inicial
decimal precoInicial;

while (true)
{
    Console.Write("Digite o preço inicial: R$ ");

    if (decimal.TryParse(Console.ReadLine(), out precoInicial)
        && precoInicial >= 0)
    {
        break;
    }

    Console.WriteLine("Valor inválido. Tente novamente.");
}

// Solicita e valida o preço por hora
decimal precoPorHora;

while (true)
{
    Console.Write("Digite o preço por hora: R$ ");

    if (decimal.TryParse(Console.ReadLine(), out precoPorHora)
        && precoPorHora >= 0)
    {
        break;
    }

    Console.WriteLine("Valor inválido. Tente novamente.");
}

// Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Mantém o menu ativo até o usuário escolher sair
while (exibirMenu)
{
    Console.Clear();

    Console.WriteLine("====================================");
    Console.WriteLine("       MENU DO ESTACIONAMENTO");
    Console.WriteLine("====================================");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("====================================");
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    Console.WriteLine();

    switch (opcao)
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
            Console.WriteLine("Encerrando o sistema...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    // Aguarda o usuário antes de limpar a tela
    if (exibirMenu)
    {
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou.");

