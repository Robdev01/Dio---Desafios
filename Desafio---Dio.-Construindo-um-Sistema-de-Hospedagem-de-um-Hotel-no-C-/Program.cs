using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desadio.Dio___Hotelaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria alguns hóspedes
            Pessoa pessoa1 = new Pessoa("Carlos", 30);
            Pessoa pessoa2 = new Pessoa("Maria", 25);
            Pessoa pessoa3 = new Pessoa("Robson", 17);

            // Cria uma suíte
            Suite suite = new Suite("Luxo", 3, 100m);

            // Define a data de entrada
            DateTime dataEntrada = new DateTime(2024, 8, 25);

            // Cria uma reserva
            Reserva reserva = new Reserva(12, dataEntrada); // 12 dias reservados
            reserva.CadastrarSuite(suite);

            // Adiciona os hóspedes à reserva
            reserva.CadastrarHospedes(new List<Pessoa> { pessoa1, pessoa2, pessoa3 });

            // Calcula o valor total da reserva
            decimal valorTotal = reserva.CalcularValorDiaria();

            // Exibe informações
            Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor total da reserva: {valorTotal:C}");
            Console.WriteLine($"Data de entrada: {reserva.DataEntrada:dd/MM/yyyy}");
            Console.WriteLine($"Data de saída: {reserva.DataSaida:dd/MM/yyyy}");
            Console.ReadKey();
        }
    }
 
}
