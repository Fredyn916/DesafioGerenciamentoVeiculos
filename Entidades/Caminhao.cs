namespace Entidades;

public class Caminhao : Veiculo
{
    public int CapacidaDeCarga { get; set; }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($"Capacidade de Carga: {CapacidaDeCarga}T");
    }

    public override double CalcularConsumo(double distancia)
    {
        double consumoBase = base.CalcularConsumo(distancia); // Consumo sem contar com a carga

        double fatorDeIncrementoDeConsumo = 0.1 * CapacidaDeCarga; // Em Tonelada

        return consumoBase + (fatorDeIncrementoDeConsumo);
    }
}