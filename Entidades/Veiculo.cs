using Entidades.Interface;

namespace Entidades;

public class Veiculo : IVeiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int CapacidadeDoTanque { get; set; }
    public double ConsumoPorKm { get; set; }

    public virtual string ExibirDetalhes()
    {
        string mensagem =
            $"--- DETALHES ---" +
            $"\nModelo: {Modelo}" +
            $"\nAno: {Ano}" +
            $"\nCapacidade do Tanque: {CapacidadeDoTanque}L" +
            $"\nConsumo por Km: {ConsumoPorKm}L/Km";

        return mensagem;
    }

    public virtual double CalcularConsumo(double distancia)
    {
        return ConsumoPorKm / distancia;
    }
}