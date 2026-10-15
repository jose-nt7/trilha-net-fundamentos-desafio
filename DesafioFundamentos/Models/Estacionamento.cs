using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida.");
                return;
            }

            placa = placa.Trim().ToUpperInvariant();

            // Verifica se o veículo já está estacionado
            if (veiculos.Any(x => x.Equals(
                placa,
                StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Esse veículo já está estacionado.");
                return;
            }

            // Adiciona o veículo à lista
            veiculos.Add(placa);

            Console.WriteLine(
                $"Veículo com a placa {placa} adicionado com sucesso."
            );
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida.");
                return;
            }

            placa = placa.Trim();

            // Localiza a placa sem diferenciar maiúsculas e minúsculas
            string? placaEncontrada = veiculos.FirstOrDefault(
                x => x.Equals(
                    placa,
                    StringComparison.OrdinalIgnoreCase)
            );

            if (placaEncontrada == null)
            {
                Console.WriteLine(
                    "Esse veículo não está estacionado aqui."
                );
                return;
            }

            Console.WriteLine(
                "Digite a quantidade de horas que o veículo permaneceu estacionado:"
            );

            // Valida a quantidade de horas informada
            bool conversaoSucesso = int.TryParse(
                Console.ReadLine(),
                out int horas
            );

            if (!conversaoSucesso || horas < 0)
            {
                Console.WriteLine(
                    "Quantidade de horas inválida. Digite um número válido."
                );
                return;
            }

            // Calcula o valor total do estacionamento
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            Console.WriteLine(
                $"\nO valor total a ser pago é: R$ {valorTotal:F2}"
            );

            // Remove o veículo encontrado
            veiculos.Remove(placaEncontrada);

            Console.WriteLine(
                $"Veículo com a placa {placaEncontrada} removido com sucesso."
            );

            // Exibe a lista atualizada
            ListarVeiculos();
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nVeículos estacionados:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
