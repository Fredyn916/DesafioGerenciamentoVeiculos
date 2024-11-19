using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades;

[Table("Carros")]
public class Carro : Veiculo
{
    public string Tipo { get; set; }

    public override string ExibirDetalhes()
    {
        string mensagem = base.ExibirDetalhes();
        mensagem += $"\nTipo: {Tipo}";

        return mensagem;
    }

    public override double CalcularConsumo(double distancia)
    {
        switch (Tipo) {
            case "Sedan":
                base.ConsumoPorKm = 0.081;
                break;
            case "SUV Compacto":
                base.ConsumoPorKm = 0.091;
                break;
            case "SUV Médio":
                base.ConsumoPorKm = 0.112;
                break;
            case "Hatch Compacto":
                base.ConsumoPorKm = 0.077;
                break;
            case "Picape Média":
                base.ConsumoPorKm = 0.1243;
                break;
            case "Picape Compacta":
                base.ConsumoPorKm = 0.083;
                break;
            case "Esportivo":
                base.ConsumoPorKm = 0.143;
                break;
            case "Crossover":
                base.ConsumoPorKm = 0.088;
                break;
            case "Minivan":
                base.ConsumoPorKm = 0.117;
                break;
            case "Sedan Grande":
                base.ConsumoPorKm = 0.1;
                break;
            case "VAN": 
                base.ConsumoPorKm = 0.13; 
                break;
            case "Elétrico": 
                base.ConsumoPorKm = 0.0;
                break;
            case "Híbrido":
                base.ConsumoPorKm = 0.045; 
                break;
            case "Conversível": 
                base.ConsumoPorKm = 0.105; 
                break;
            case "Wagon": 
                base.ConsumoPorKm = 0.095; 
                break;
            case "Coupé": 
                base.ConsumoPorKm = 0.102; 
                break;
        }

        return base.CalcularConsumo(distancia);
    }
}