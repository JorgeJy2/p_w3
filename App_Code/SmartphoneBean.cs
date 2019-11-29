using System;
/// <summary>
/// Descripción breve de MascotaBean
/// </summary>
[Serializable]
public class SmartphoneBean
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public string Sistema { get; set; }
    public float Tamanio { get; set; }
    public bool Liberado { get; set; }

    public SmartphoneBean()
    {
        Id =  -1;
        Modelo = "Samsung";
        Sistema = "Android";
        Tamanio = 9.5F;
        Liberado = true;
    }

    public SmartphoneBean(string modelo, string sistema, float tamanio, bool liberado)
    {
        Id = -1;
        Modelo = modelo;
        Sistema = sistema;
        Tamanio = tamanio;
        Liberado = liberado;
    }
    public SmartphoneBean(int id, string modelo, string sistema, float tamanio, bool liberado)
    {
        Id = id;
        Modelo = modelo;
        Sistema = sistema;
        Tamanio = tamanio;
        Liberado = liberado;
    }

    public override string ToString()
    {
        return $"Smartphone = [ Modelo = {Modelo}, Sistema= {Sistema} , Tamanio= {Tamanio}, Liberado= {Liberado} ]";
    }

}