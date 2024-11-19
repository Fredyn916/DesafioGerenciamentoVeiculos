namespace Entidades.DTOs;

public class CreateVeiculoDTO : Veiculo
{
    public int? CapacidaDeCarga { get; set; }
    public string? Tipo { get; set; }
}
