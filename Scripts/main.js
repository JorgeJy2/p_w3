function tempData() {
    var templeta = "<tr>";
    templeta += ("<td>" + "JH" + "</td>");
    templeta += ("<td>" + "JH" + "</td>");
    templeta += ("<td>" + "JH" + "</td>");
    templeta += ("<td>" + "JH" + "</td>");
    templeta += "</tr>";
    return templeta;
}


function addRowToTable() {
    console.log("Cargando..");

    var template = tempData();
    for (var i = 0; i < 10; i++) {
        console.log(i);
        $("#tbl_body_table").append(template);
    }
}

addRowToTable();
function addRowDT(data) {
    var table = $("#tbl_mascota").DataTable();
    for (var i = 0; i < data.length; i++) {
        table.fnAddData([
          data.nombre,
            data.tipo,
            data.costo,
            data.asegurado
        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "gestionMascota.aspx/listar",
        data: {},
        contentType: "application/json",
        error: function (xhr, ajaxOptions, thorwsError) {
            console.log(xhr, ajaxOptions, thorwsError);
        },
        success: function (data) {
             console.log(data)
        }
    });
}

console.log("Saludo..");