<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Venta de autos</h1>
        <p class="lead">Página para venta de autos</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Información</h2>
            <p>
                Práctica W3 – DB Web
            </p>
        </div>
        <div class="col-md-4">
            <h2>Agregar automoviles</h2>
            <p>
                Página para agregar automoviles al sistema.
            <p>
                <a class="btn btn-default" href="Agregar.aspx">Agregar automoviles</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Consultar automoviles</h2>
            <p>
               Página para consultar los automoviles al sitema.
            </p>
            <p>
                <a class="btn btn-default" href="Consultar.aspx">Consultar automoviles</a>
            </p>
        </div>
    </div>
</asp:Content>
