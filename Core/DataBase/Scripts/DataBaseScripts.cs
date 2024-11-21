namespace Core.DataBase.Scripts;

public static class DataBaseScripts
{
    public static string CreateTables()
    {
        string commandCREATE = @"
                CREATE TABLE IF NOT EXISTS Veiculos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Modelo TEXT NOT NULL,
                    Ano INTEGER NOT NULL,
                    CapacidadeDoTanque INTEGER NOT NULL,
                    ConsumoPorKm REAL NOT NULL,
                    Tipo TEXT,
                    CapacidaDeCarga INTEGER,
                    Categoria INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Categorias(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Categoria TEXT NOT NULL
                );";

        return commandCREATE;
    }

    public static string InsertCategorias()
    {
        string commandINSERT = @"
                INSERT INTO Categorias (Categoria)
                VALUES ('Carro'),
                       ('Caminhão')
                ";

        return commandINSERT;
    }

    public static string SelectCountAllCategorias()
    {
        string commandSELECTCOUNTCategorias = "SELECT COUNT(*) FROM Categorias;"; // Comando para contar quantos itens existem na tabela {Cargos}

        return commandSELECTCOUNTCategorias;
    }
}