using System;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Concesionaria concesionaria = new Concesionaria();
       
        var id = Request.QueryString["id"];
        if (id != null)
        {

            AutomovilBean automovil= concesionaria.obtenerIndice(Int32.Parse(id));
            if (automovil != null)
            {
                lbDelete.Text = automovil.ToString();
                if (concesionaria.delete(Int32.Parse(id))) {
                    lbDelete.Text = "Eliminado..";
                    Response.Redirect("consultar.aspx");
                }
                else
                {
                    lbDelete.Text = concesionaria.obtenerIndice(Int32.Parse(id)).ToString();
                }
            }
            else
            {
                lbDelete.Text = "No se encontró la posición :" + id;
            }
        }
        else {
            lbDelete.Text = "No se recibió ningun valor eliminar.";
           }

       
    }
}