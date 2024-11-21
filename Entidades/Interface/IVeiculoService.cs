using Entidades.DTOs;

namespace Entidades.Interface;

public interface IVeiculoService
{
    Task Adicionar(CreateVeiculoDTO veiculo);
    Task<List<Veiculo>> Listar();
    Task<Veiculo> BuscarVeiculoPorId(int id);
    Task Editar(Veiculo veiculo);
    Task Remover(int id);
    Task<string> ExibirDetalhesPorId(int id);
    Task<double> CalcularConsumoPorDistanciaDoVeiculoPeloId(int id, double distancia);
}