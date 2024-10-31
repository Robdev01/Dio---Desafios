using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio.Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();
            // Solicita ao usuário os valores de preço
            Console.WriteLine("Digite o preço inicial do estacionamento:");
            decimal precoInicialTemp;
            while (!decimal.TryParse(Console.ReadLine(), out precoInicialTemp) || precoInicialTemp < 0)
            {
                Console.WriteLine("Por favor, digite um valor válido para o preço inicial.");
            }
            estacionamento.precoInicial = precoInicialTemp;

            Console.WriteLine("Digite o preço por hora do estacionamento:");
            decimal precoPorHoraTemp;
            while (!decimal.TryParse(Console.ReadLine(), out precoPorHoraTemp) || precoPorHoraTemp < 0)
            {
                Console.WriteLine("Por favor, digite um valor válido para o preço por hora.");
            }
            estacionamento.precoPorHora = precoPorHoraTemp;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar veículo");
                Console.WriteLine("2. Remover veículo");
                Console.WriteLine("3. Listar veículos");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        estacionamento.AdicionarVeiculos();
                        break;
                    case "2":
                        estacionamento.RemoverVeiculos();
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa.");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    }
            } } }
}

