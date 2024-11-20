using Entidades;
using Entidades.DTOs;
using Entidades.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private readonly IVeiculoService _Service;

    public VeiculoController(IVeiculoService veiculoService)
    {
        _Service = veiculoService;
    }

    [HttpPost("AdicionarVeiculo")]
    public async Task Adicionar(CreateVeiculoDTO veiculo)
    {
        try
        {
            _Service.Adicionar(veiculo);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("VisualizarVeiculos")]
    public async Task<List<Veiculo>> Listar()
    {
        try
        {
            return await _Service.Listar();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("BuscarVeiculoPorId")]
    public async Task<Veiculo> BuscarVeiculoPorId(int id)
    {
        try
        {
            return await _Service.BuscarVeiculoPorId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("EditarVeiculo")]
    public async Task Editar(Veiculo veiculo)
    {
        try
        {
            _Service.Editar(veiculo);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpDelete("RemoverVeiculo")]
    public async Task Remover(int id)
    {
        try
        {
            _Service.Remover(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}