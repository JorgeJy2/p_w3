using System;
using System.Text.RegularExpressions;

public partial class AgregarMascota : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnAgregaClick(object sender, EventArgs e)
    {
        Telefonia telefonia = new Telefonia();
        string sistema = ddl_sistema.SelectedItem.Text;
        string modelo = txb_modelo.Text;

        if (modelo.Length > 0)
        {
            Regex exp = new Regex("^[a-zA-Z ]*$");
            if (exp.IsMatch(modelo))
            {

                string tamanio = txb_tamanio.Text.Trim();
                if (tamanio.Length > 0)
                {
                    try
                    {
                        float tamaniofloat = float.Parse(tamanio);
                        bool liberado = cbx_liberad.Checked;
                        SmartphoneBean smartphone = new SmartphoneBean();

                        smartphone.Modelo = txb_modelo.Text;
                        smartphone.Sistema = ddl_sistema.SelectedItem.Text;
                        smartphone.Tamanio = tamaniofloat;
                        smartphone.Liberado = cbx_liberad.Checked;

                        telefonia.add(smartphone);

                        clearData();
                        showMessage("Smartphone agregado.");
                    }
                    catch { showMessage("Datos incorrectos para tamaño."); }
                }
                else showMessage("Ingresa datos para tamaño.");
            }
            else showMessage("Solo en el modelo");
        }
        else showMessage("Ingresa datos el nombre del modelo");
    }

    private void showMessage(string message)
    {
        divAlert.InnerHtml = message;
    }

    private void clearData()
    {
        ddl_sistema.SelectedIndex = 0;
        txb_modelo.Text = "";
        txb_tamanio.Text = "";
        cbx_liberad.Checked = false;
    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        clearData();
    }
}