﻿using Entidades.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades;

[Table("Veiculos")]
public class Veiculo : IVeiculo
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int CapacidadeDoTanque { get; set; }
    public double ConsumoPorKm { get; set; }
    public int Categoria { get; set; }

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