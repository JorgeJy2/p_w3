<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Consultar.aspx.cs" Inherits="consultar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Consulta de automoviles.</h2>
    
    <div class ="row">
        <div id="data_load"></div>
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Automoviles registrados</h3>
                </div>
                <div class="box-body table-responsive table-striped">
                    <table id="tbl_mascota" class="table table-bordered table-hover">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col">Nombre</th>
                                <th scope="col">Modelo</th>
                                <th scope="col">Precio</th>
                                <th scope="col">Asegurado</th>
                                <th scope="col">Acción</th>
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

