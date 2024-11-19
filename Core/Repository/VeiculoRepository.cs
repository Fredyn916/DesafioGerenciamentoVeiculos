using AutoMapper;
using Dapper.Contrib.Extensions;
using Entidades;
using Entidades.DTOs;
using Entidades.Interface;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Core.Repository;

public class VeiculoRepository
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
            await connection.InsertAsync(veiculo);
        }
        else if (veiculo.Tipo == null)
        {
            Caminhao caminhao = _Mapper.Map<Caminhao>(veiculo);
            await connection.InsertAsync(veiculo);
        }
    }

    public async Task<List<Veiculo>> Listar()
    {
        List<Veiculo> veiculos = connection.GetAll<>().ToList();

        return veiculos;
    }

    public ReadFuncionarioDTO BuscarFuncionarioDTOPorId(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Funcionario funcionario = connection.Get<Funcionario>(id);
        ReadFuncionarioDTO funcionarioDTO = new ReadFuncionarioDTO();

        funcionarioDTO.Id = funcionario.Id;
        funcionarioDTO.Nome = funcionario.Nome;
        funcionarioDTO.Idade = funcionario.Idade;
        funcionarioDTO.Peso = funcionario.Peso;
        funcionarioDTO.Salario = funcionario.Salario;
        funcionarioDTO.Cargo = _Repository.BuscarCargoPorId(funcionario.CargoId);

        return funcionarioDTO;
    }

    public Funcionario BuscarFuncionarioPorId(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        return connection.Get<Funcionario>(id);
    }

    public void Editar(Funcionario editFuncionario)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        connection.Update<Funcionario>(editFuncionario);
    }

    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(_ConnectionString);

        Funcionario funcionarioToRemove = BuscarFuncionarioPorId(id);

        connection.Delete<Funcionario>(funcionarioToRemove);
    }
}