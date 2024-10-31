using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desadio.Dio___Hotelaria
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite SuiteReservada { get; set; }
        public int DiasReservados { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida
        {
            get
            {
                return DataEntrada.AddDays(DiasReservados);
            }
        }

        public Reserva(int diasReservados, DateTime dataEntrada)
        {
            DiasReservados = diasReservados;
            DataEntrada = dataEntrada;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > SuiteReservada.Capacidade)
            {
                throw new Exception("Capacidade da suíte excedida.");
            }
            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * SuiteReservada.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9m; // Aplica um desconto de 10%
            }

            return valorTotal;
        }
    }
}
