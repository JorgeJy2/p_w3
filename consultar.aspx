<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Consultar.aspx.cs" Inherits="consultar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Consulta de Smartphones.</h2>
    
    <div class ="row">
        <div id="data_load"></div>
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Smartphones registrados</h3>
                </div>
                <div class="box-body table-responsive">
                    <table id="tbl_mascota" class="table table-bordered">
                        <thead >
                            <tr>
                                <th>Modelo</th>
                                <th>Sistema</th>
                                <th>Tamaño</th>
                                <th>Liberado</th>
                                <th>Acción</th>
                            </tr>
                        </thead>
                        
                        <tbody id="tbl_body_table" runat="server">

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

