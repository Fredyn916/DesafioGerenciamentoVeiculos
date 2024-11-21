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

    public async Task Adicionar(CreateVeiculoDTO createVeiculoDTO)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        AddVeiculoDTO addVeiculoDTO = _Mapper.Map<AddVeiculoDTO>(createVeiculoDTO);

        if (addVeiculoDTO.CapacidaDeCarga == null)
        {
            Carro carro = _Mapper.Map<Carro>(addVeiculoDTO);
            carro.Categoria = 1;
            await connection.InsertAsync<Veiculo>(carro);
        }
        else if (addVeiculoDTO.Tipo == null)
        {
            Caminhao caminhao = _Mapper.Map<Caminhao>(addVeiculoDTO);
            caminhao.Categoria = 2;
            await connection.InsertAsync<Veiculo>(caminhao);
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

    public async Task<string> ExibirDetalhesPorId(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Veiculo veiculo = connection.Get<Veiculo>(id);

        return veiculo.ExibirDetalhes();
    }

    public async Task<double> CalcularConsumoPorDistanciaDoVeiculoPeloId(int id, double distancia)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Veiculo veiculo = connection.Get<Veiculo>(id);

        return veiculo.CalcularConsumo(distancia);
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