using Core.DataBase.Scripts;
using Dapper;
using System.Data.SQLite;

namespace Core.DataBase;

public class InicializadorDB
{
    public static object DataBaseScript { get; private set; }

    public static void Inicializar()
    {
        using var connection = new SQLiteConnection("Data Source=GerenciamentoVeiculos.db"); // Criando a conexão

        connection.Execute(DataBaseScripts.CreateTables());
    }
}