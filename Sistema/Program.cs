using Entidades;
using Entidades.Interface;

List<IVeiculo> _Veiculos = new List<IVeiculo>();

Carro c1 = new Carro
{
    Modelo = "Toyota Corolla",
    Ano = 2021,
    CapacidadeDoTanque = 50,
    ConsumoPorKm = 0.081,
    Tipo = "Sedan"
};
Carro c2 = new Carro
{
    Modelo = "Ford EcoSport",
    Ano = 2019,
    CapacidadeDoTanque = 52,
    ConsumoPorKm = 0.091,
    Tipo = "SUV Compacto"
};
Carro c3 = new Carro
{
    Modelo = "Chevrolet S10",
    Ano = 2022,
    CapacidadeDoTanque = 76,
    ConsumoPorKm = 0.1243,
    Tipo = "Picape Média"
};
Caminhao C1 = new Caminhao
{
    Modelo = "Volvo FH16",
    Ano = 2021,
    CapacidadeDoTanque = 600,
    ConsumoPorKm = 0.24,
    CapacidaDeCarga = 25
};
Caminhao C2 = new Caminhao
{
    Modelo = "Scania R450",
    Ano = 2020,
    CapacidadeDoTanque = 500,
    ConsumoPorKm = 0.22,
    CapacidaDeCarga = 20
};
Caminhao C3 = new Caminhao
{
    Modelo = "Mercedes-Benz Actros",
    Ano = 2019,
    CapacidadeDoTanque = 550,
    ConsumoPorKm = 0.23,
    CapacidaDeCarga = 22
};

_Veiculos.Add(c1);
_Veiculos.Add(c2);
_Veiculos.Add(c3);
_Veiculos.Add(C1);
_Veiculos.Add(C2);
_Veiculos.Add(C3);

double consumo;

foreach (Veiculo v in _Veiculos)
{
    switch (v)
    {
        case Carro:
            Console.WriteLine("----------------");
            Console.WriteLine("");
            v.ExibirDetalhes();
            consumo = v.CalcularConsumo(5);
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine($"Em 5 Km o carro consumirá {consumo}L/Km");
            consumo = v.CalcularConsumo(10);
            Console.WriteLine("----------------");
            Console.WriteLine($"Em 10 Km o carro consumirá {consumo}L/Km");
            consumo = v.CalcularConsumo(20);
            Console.WriteLine("----------------");
            Console.WriteLine($"Em 20 Km o carro consumirá {consumo}L/Km");
            Console.WriteLine("");
            Console.WriteLine("----------------");
            break;
        case Caminhao:
            Console.WriteLine("----------------");
            Console.WriteLine("");
            v.ExibirDetalhes();
            consumo = v.CalcularConsumo(5);
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine($"Em 5 Km o caminhão consumirá {consumo}L/Km");
            consumo = v.CalcularConsumo(10);
            Console.WriteLine("----------------");
            Console.WriteLine($"Em 10 Km o caminhão consumirá {consumo}L/Km");
            consumo = v.CalcularConsumo(20);
            Console.WriteLine("----------------");
            Console.WriteLine($"Em 20 Km o caminhão consumirá {consumo}L/Km");
            Console.WriteLine("");
            Console.WriteLine("----------------");
            break;
    }
}