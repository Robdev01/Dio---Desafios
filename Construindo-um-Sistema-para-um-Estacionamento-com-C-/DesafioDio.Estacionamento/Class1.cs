using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio.Estacionamento
{
    internal class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoPorHora { get; set; }
        private List<string> Veiculos { get; set; } // Alterado para uma lista de placas de veículos

        public Estacionamento()
        {
            Veiculos = new List<string>(); // Inicializa a lista no construtor
        }
        public void AdicionarVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Verifica se a placa já existe na lista
            if (Veiculos.Contains(placa))
            {
                Console.WriteLine($"A placa {placa} já está estacionada. Por favor, insira uma placa diferente.");
            }
            else
            {
                Veiculos.Add(placa); // Adiciona a placa à lista de veículos
                Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
            }
        }


        public void RemoverVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("Por favor, digite um número válido de horas.");
                }

                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa digitada da lista de veículos
                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in Veiculos)
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
