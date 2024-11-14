using Entidades.Interface;

namespace Entidades;

public class Veiculo : IVeiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int CapacidadeDoTanque { get; set; }
    public double ConsumoPorKm { get; set; }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine("--- DETALHES ---");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Capacidade do Tanque: {CapacidadeDoTanque}L");
        Console.WriteLine($"Consumo por Km: {ConsumoPorKm}L/Km");
    }

    public virtual double CalcularConsumo(double distancia)
    {
        return ConsumoPorKm / distancia;
    }
}