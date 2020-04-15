using System;
using System.Collections.Generic;

public partial class consultar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Concesionaria concesionaria= new Concesionaria();
        List<AutomovilBean> automoviles = concesionaria.obtenerTodo();
      
        int contador = 0;
        foreach (AutomovilBean automovil in automoviles)
        {
            tbl_body_table.InnerHtml += "<tr>";
            tbl_body_table.InnerHtml += "<td>"+ automovil.Nombre+"</td>";
            tbl_body_table.InnerHtml += "<td>" + automovil.Marca+ "</td>";
            tbl_body_table.InnerHtml += "<td>" + automovil.Precio + "</td>";
            tbl_body_table.InnerHtml += "<td>" + automovil.Asegurado + "</td>";
            tbl_body_table.InnerHtml += "<td><a href='Eliminar.aspx?id="+ contador + "'>Eliminar</a></td>";
            tbl_body_table.InnerHtml += "</tr>";
            contador++;
        }
       
    }

   
}
