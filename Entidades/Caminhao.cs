using Dapper.Contrib.Extensions;

namespace Entidades;

[Table("Veiculos")]
public class Caminhao : Veiculo
{
    public int CapacidaDeCarga { get; set; }

    public override string ExibirDetalhes()
    {
        string mensagem = base.ExibirDetalhes();
        mensagem += $"\nCapacidade de Carga: {CapacidaDeCarga}T";

        return mensagem;
    }

    public override double CalcularConsumo(double distancia)
    {
        double consumoBase = base.CalcularConsumo(distancia); // Consumo sem contar com a carga

        double fatorDeIncrementoDeConsumo = 0.1 * CapacidaDeCarga; // Em Tonelada

        return consumoBase + (fatorDeIncrementoDeConsumo);
    }
}