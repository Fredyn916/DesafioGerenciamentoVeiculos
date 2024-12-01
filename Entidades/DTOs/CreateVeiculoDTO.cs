﻿namespace Entidades.DTOs;

public class CreateVeiculoDTO
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int CapacidadeDoTanque { get; set; }
    public double ConsumoPorKm { get; set; }
    public int? CapacidaDeCarga { get; set; }
    public string? Tipo { get; set; }
}