using System;
using System.Text.RegularExpressions;

public partial class Agregar : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnAgregaClick(object sender, EventArgs e)
    {
        Concesionaria concesionaria = new Concesionaria();
        string marca = ddl_marca.SelectedItem.Text;
        string nombre = txb_nombre.Text;
  
        if (marca.Length > 0)
        {
            Regex exp = new Regex("^[a-zA-Z0-9 ]*$");
            if (exp.IsMatch(nombre) && nombre.Length >= 2)
            {
                string precio = txb_precio.Text.Trim();
                if (precio.Length > 0)
                {
                    try
                    {
                        float preciofloat = float.Parse(precio);
                        bool asegurado = cbx_asegurado.Checked;
                        AutomovilBean automovil = new AutomovilBean();
                        automovil.Nombre = txb_nombre.Text;
                        automovil.Marca = ddl_marca.SelectedItem.Text;
                        automovil.Precio = preciofloat;
                        automovil.Asegurado = cbx_asegurado.Checked;

                        concesionaria.add(automovil);

                        clearData();
                        showMessage("Automóvil agregado.");
                    }
                    catch { showMessage("Datos incorrectos para precio."); }
                }
                else showMessage("Ingresa datos para precio.");
            }
            else showMessage("Datos incorrectos para nombre.");
        }
        else showMessage("Seleccione un modelo.");
    }

    private void showMessage(string message)
    {
        divAlert.InnerHtml = message;
    }

    private void clearData()
    {
        ddl_marca.SelectedIndex = 0;
        txb_nombre.Text = "";
        txb_precio.Text = "";
        cbx_asegurado.Checked = false;
    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        clearData();
    }
}