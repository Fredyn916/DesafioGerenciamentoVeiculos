namespace Core.DataBase.Scripts;

public static class DataBaseScripts
{
    public static string CreateTables()
    {
        string commandCREATE = @"
                CREATE TABLE IF NOT EXISTS Carros(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Modelo TEXT NOT NULL,
                    Ano INTEGER NOT NULL,
                    CapacidadeDoTanque INTEGER NOT NULL,
                    ConsumoPorKm REAL NOT NULL,
                    Tipo TEXT NOT NULL
                );
                
                CREATE TABLE IF NOT EXISTS Caminhoes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Modelo TEXT NOT NULL,
                    Ano INTEGER NOT NULL,
                    CapacidadeDoTanque INTEGER NOT NULL,
                    ConsumoPorKm REAL NOT NULL,
                    CapacidaDeCarga INTEGER NOT NULL
                );";

        return commandCREATE;
    }
}