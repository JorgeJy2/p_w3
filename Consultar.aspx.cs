using System;
using System.Collections.Generic;

public partial class consultar : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Telefonia telefonia= new Telefonia();
        List<SmartphoneBean> smartphones = telefonia.obtenerTodo();
      
        int contador = 0;
        foreach (SmartphoneBean smartphone in smartphones)
        {
            tbl_body_table.InnerHtml += "<tr>";
            tbl_body_table.InnerHtml += "<td>"+ smartphone.Modelo+"</td>";
            tbl_body_table.InnerHtml += "<td>" + smartphone.Sistema + "</td>";
            tbl_body_table.InnerHtml += "<td>" + smartphone.Sistema + "</td>";
            tbl_body_table.InnerHtml += "<td>" + smartphone.Liberado + "</td>";
            tbl_body_table.InnerHtml += "<td><a href='Eliminar.aspx?id="+ contador + "'>Eliminar</a></td>";
            tbl_body_table.InnerHtml += "</tr>";
            contador++;
        }
       
    }

   
}
