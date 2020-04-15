using Npgsql;
using System;
using System.Collections.Generic;

public class BDAutomovil
{
    private Persistencia connection;

    private static BDAutomovil instancia;

    private BDAutomovil()
    {
        connection = Persistencia.getInstancia();
    }

    public static BDAutomovil getInstancia()
    {
        if (instancia == null)
            instancia = new BDAutomovil();
        return instancia;
    }


    public List<AutomovilBean> load()
    {
        List<AutomovilBean> automoviles = new List<AutomovilBean>();

        Persistencia connection = Persistencia.getInstancia();
        NpgsqlDataReader dr = connection.getSqlCommand("SELECT id,nombre,marca,precio,asegurado from automovil").ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", dr[0], dr[1], dr[2], dr[3], dr[4]);
            double precioD = (Double)dr[3];
            float precio = (float)precioD;
            AutomovilBean smartphone = new AutomovilBean(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), precio, (bool)dr[4]);
            automoviles.Add(smartphone);
        }
        dr.Close();
        return automoviles;
    }

    public bool delete(int id) {
        try
        {
            NpgsqlCommand comAdd = connection.getSqlCommand("DELETE FROM automovil WHERE id = @id");
            comAdd.Parameters.AddWithValue("id", id);
            int columnasAfectadas = comAdd.ExecuteNonQuery();
            return (columnasAfectadas > 0);
        }
        catch (System.InvalidOperationException w)
        {
            Console.WriteLine(w.GetBaseException());
            return false;
        }
    }

    public bool add(AutomovilBean smartphone)
    {
        try
        {
            NpgsqlCommand comAdd = connection.getSqlCommand("INSERT INTO automovil (nombre,marca,precio,asegurado) VALUES (@nombre, @marca, @precio, @asegurado);");

            comAdd.Parameters.AddWithValue("nombre", smartphone.Nombre);
            comAdd.Parameters.AddWithValue("marca", smartphone.Marca);
            comAdd.Parameters.AddWithValue("precio", smartphone.Precio);
            comAdd.Parameters.AddWithValue("asegurado", smartphone.Asegurado);
            int columnasAfectadas = comAdd.ExecuteNonQuery();
            return (columnasAfectadas > 0);
        }
        catch (System.InvalidOperationException w) {
            Console.WriteLine(w.GetBaseException());
            return false;
        }
    }

    public bool save(List<AutomovilBean> list)
    {
        try
        {
            foreach (AutomovilBean smartphone in list)
            {
                if (smartphone.Id == -1)
                {
                    if (add(smartphone))
                        Console.WriteLine("Guardó sin problemas");
                    else
                        Console.WriteLine("No guardo.");
                }
            }
        }
        catch
        {
            Console.WriteLine("Error");
            return false;
        }
        return true;
    }
}