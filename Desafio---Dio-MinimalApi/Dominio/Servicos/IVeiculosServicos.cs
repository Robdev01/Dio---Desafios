using Minimalapi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace Minimalapi.Dominio.Interfaces;

public interface IVeiculosServico
{
    List<Veiculo> Todos(int pagina = 1, string? nome=null, string? marca = null);
    Veiculo BuscaPorId(int Id);
    Veiculo Incluir(Veiculo veiculo);
    Veiculo Atualizar(Veiculo veiculo);
    Veiculo Apagar(Veiculo veiculo);

}