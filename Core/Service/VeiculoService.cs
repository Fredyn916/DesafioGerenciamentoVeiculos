using Entidades;
using Entidades.DTOs;
using Entidades.Interface;

namespace Core.Service;

public class VeiculoService : IVeiculoService
{
    private readonly IVeiculoRepository _Repository;

    public VeiculoService(IVeiculoRepository veiculoRepository)
    {
        _Repository = veiculoRepository;
    }

    public async Task Adicionar(CreateVeiculoDTO veiculo)
    {
        _Repository.Adicionar(veiculo);
    }

    public async Task<List<Veiculo>> Listar()
    {
        return await _Repository.Listar();
    }

    public async Task<Veiculo> BuscarVeiculoPorId(int id)
    {
        return await _Repository.BuscarVeiculoPorId(id);
    }

    public async Task Editar(Veiculo veiculo)
    {
        _Repository.Editar(veiculo);
    }

    public async Task Remover(int id)
    {
        _Repository.Remover(id);
    }
}