namespace Entidades.Interface;

public interface IVeiculo
{
    string ExibirDetalhes();
    double CalcularConsumo(double distancia);
}