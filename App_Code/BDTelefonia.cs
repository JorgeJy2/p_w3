using Npgsql;
using System;
using System.Collections.Generic;

public class BDTelefonia
{
    private Persistencia connection;

    private static BDTelefonia instancia;

    private BDTelefonia()
    {
        connection = Persistencia.getInstancia();
    }

    public static BDTelefonia getInstancia()
    {
        if (instancia == null)
            instancia = new BDTelefonia();
        return instancia;
    }


    public List<SmartphoneBean> load()
    {
        List<SmartphoneBean> smartphones = new List<SmartphoneBean>();

        Persistencia connection = Persistencia.getInstancia();
        NpgsqlDataReader dr = connection.getSqlCommand("SELECT id,marca,sistema,tamanio,liberado from smartphone").ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", dr[0], dr[1], dr[2], dr[3], dr[4]);
            double tamanioD = (Double)dr[3];
            float tamanio = (float)tamanioD;

            SmartphoneBean smartphone = new SmartphoneBean(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), tamanio, (bool)dr[4]);
            smartphones.Add(smartphone);
        }
        dr.Close();
        return smartphones;
    }

    public bool delete(int id) {
        try
        {
            NpgsqlCommand comAdd = connection.getSqlCommand("DELETE FROM smartphone WHERE id = @id");
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

    public bool add(SmartphoneBean smartphone)
    {
        try
        {
            NpgsqlCommand comAdd = connection.getSqlCommand("INSERT INTO smartphone (marca,sistema,tamanio,liberado) VALUES (@marca, @sistema, @tamanio, @liberado);");

            comAdd.Parameters.AddWithValue("marca", smartphone.Modelo);
            comAdd.Parameters.AddWithValue("sistema", smartphone.Sistema);
            comAdd.Parameters.AddWithValue("tamanio", smartphone.Tamanio);
            comAdd.Parameters.AddWithValue("liberado", smartphone.Liberado);
            int columnasAfectadas = comAdd.ExecuteNonQuery();
            return (columnasAfectadas > 0);
        }
        catch (System.InvalidOperationException w) {
            Console.WriteLine(w.GetBaseException());
            return false;
        }
    }

    public bool save(List<SmartphoneBean> list)
    {
        try
        {
            foreach (SmartphoneBean smartphone in list)
            {
                if (smartphone.Id == -1)
                {
                    if (add(smartphone))
                        Console.WriteLine("Guardó sin problemas");
                    else
                        Console.WriteLine("No guardo corre. jaja");
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