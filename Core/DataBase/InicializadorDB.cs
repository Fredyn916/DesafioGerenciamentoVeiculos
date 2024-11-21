using Core.DataBase.Scripts;
using Dapper;
using System.Data.SQLite;

namespace Core.DataBase;

public class InicializadorDB
{
    public static object DataBaseScript { get; private set; }

    public static void Inicializar()
    {
        using var connection = new SQLiteConnection("Data Source=GerenciamentoVeiculos.db");

        connection.Execute(DataBaseScripts.CreateTables());

        int categoriaCount = connection.QueryFirst<int>(DataBaseScripts.SelectCountAllCategorias());

        if (categoriaCount == 0)
        {
            connection.Execute(DataBaseScripts.InsertCategorias());
        }
    }
}