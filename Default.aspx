<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Telefonía</h1>
        <p class="lead">Página para control de smartphones</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Información</h2>
            <p>
                Práctica W3 – DB Web
            </p>
            <p>
                Persistencía en BD postgresql usando ASP.NET
            </p>
        </div>
        <div class="col-md-4">
            <h2>Agregar smartphones</h2>
            <p>
                Página para agregar smartphones al sistema.
            <p>
                <a class="btn btn-default" href="Agregar.aspx">Agregar smartphones</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Consultar smartphones</h2>
            <p>
               Página para consultar los smartphones al sitema.
            </p>
            <p>
                <a class="btn btn-default" href="Consultar.aspx">Consultar smartphones</a>
            </p>
        </div>
    </div>
</asp:Content>
