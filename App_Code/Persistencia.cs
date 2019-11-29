using Npgsql;
using System;

/// <summary>
/// Descripción breve de Persistencia
/// </summary>
public class Persistencia
{

    private static Persistencia instancia;

    private static string connString = "Host=127.0.0.1;User ID=postgres;Password=123456789;Database=telefonia;";

    private static NpgsqlConnection connection;

    private Persistencia() { }

    public static Persistencia getInstancia()
    {
        if (instancia == null)
            instancia = new Persistencia();
        try
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(connString);
                connection.Open();
                Console.WriteLine("Good connection");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocuriio un error en la connection");
            Console.WriteLine(e.GetBaseException());
            Console.WriteLine(e.GetType());
            Console.WriteLine(e);
        }


        return instancia;
    }

    public NpgsqlCommand getSqlCommand(string sql)
    {
        return new NpgsqlCommand(sql, connection);
    }

    public void closeConnection()
    {
        Console.WriteLine("Cerrando conexión.");
        connection.Close();
    }

    public NpgsqlDataAdapter getDataAdapter(string sql)
    {
        return new NpgsqlDataAdapter(sql, connection);
    }
}