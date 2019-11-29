using System;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Telefonia telefonia = new Telefonia();
       
        var id = Request.QueryString["id"];
        if (id != null)
        {

            SmartphoneBean smartphone= telefonia.obtenerIndice(Int32.Parse(id));
            if (smartphone != null)
            {
                lbDelete.Text = smartphone.ToString();
                if (telefonia.delete(Int32.Parse(id))) {
                    lbDelete.Text = "Eliminado..";
                    Response.Redirect("consultar.aspx");
                }
                else
                {
                    lbDelete.Text = telefonia.obtenerIndice(Int32.Parse(id)).ToString();
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