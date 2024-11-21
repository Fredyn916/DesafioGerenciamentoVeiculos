using AutoMapper;
using Dapper.Contrib.Extensions;
using Entidades;
using Entidades.DTOs;
using Entidades.Interface;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Core.Repository;

public class VeiculoRepository : IVeiculoRepository
{
    private readonly string _ConnectionString;
    private readonly IMapper _Mapper;

    public VeiculoRepository(IConfiguration connection, IMapper mapper) // Bloco de código responsável por preencher a connectionString
    {
        _ConnectionString = connection.GetConnectionString("DefaultConnection");
        _Mapper = mapper;
    }

    public async Task Adicionar(CreateVeiculoDTO veiculo)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        if(veiculo.CapacidaDeCarga == null)
        {
            Carro carro = _Mapper.Map<Carro>(veiculo);
            veiculo.Categoria = 1;
            await connection.InsertAsync<Veiculo>(veiculo);
        }
        else if (veiculo.Tipo == null)
        {
            Caminhao caminhao = _Mapper.Map<Caminhao>(veiculo);
            veiculo.Categoria = 2;
            await connection.InsertAsync<Veiculo>(veiculo);
        }
    }

    public async Task<List<Veiculo>> Listar()
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        List<Veiculo> veiculos = connection.GetAll<Veiculo>().ToList();

        return veiculos;
    }

    public async Task<Veiculo> BuscarVeiculoPorId(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Veiculo veiculo = connection.Get<Veiculo>(id);

        return veiculo;
    }

    public async Task Editar(Veiculo veiculo)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        connection.Update<Veiculo>(veiculo);
    }

    public async Task Remover(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Veiculo veiculoToRemove = BuscarVeiculoPorIdPrivate(id);

        connection.Delete<Veiculo>(veiculoToRemove);
    }

    private Veiculo BuscarVeiculoPorIdPrivate(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Veiculo veiculo = connection.Get<Veiculo>(id);

        return veiculo;
    }
}