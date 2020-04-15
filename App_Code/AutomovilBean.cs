using System;
/// <summary>
/// Descripción breve de MascotaBean
/// </summary>
[Serializable]
public class AutomovilBean
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public float Precio { get; set; }
    public bool Asegurado { get; set; }

    public AutomovilBean()
    {
        Id =  -1;
        Nombre = "Samsung";
        Marca = "Android";
        Precio = 9.5F;
        Asegurado = true;
    }

    public AutomovilBean(string nombre, string marca, float precio, bool asegurado)
    {
        Id = -1;
        Nombre = nombre;
        Marca = marca;
        Precio = precio;
        Asegurado = asegurado;
    }
    public AutomovilBean(int id, string nombre, string marca, float precio, bool asegurado)
    {
        Id = id;
        Nombre = nombre;
        Marca = marca;
        Precio = precio;
        Asegurado = asegurado;
    }

    public override string ToString()
    {
        return $"Automovil = [ Nombre = {Nombre}, Marca= {Marca} , Precio= {Precio}, Asegurado= {Asegurado} ]";
    }

}