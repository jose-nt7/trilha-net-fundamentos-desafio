
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
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    
                    int horas;
                    bool conversaoSucesso = int.TryParse(Console.ReadLine(), out horas);

                    
                    if (conversaoSucesso && horas >= 0)
                    {
                        
                        decimal valorTotal = precoInicial + (precoPorHora * horas);
                        Console.WriteLine($"\nO valor total a ser pago é: R$ {valorTotal:F2}");

                        // Remove o veículo
                        veiculos.Remove(placa);
                        Console.WriteLine($"O veículo com a placa {placa} foi removido.");
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                }
            }
            else
            {
                Console.WriteLine("Placa inválida.");
            }

            ListarVeiculos(); 
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
