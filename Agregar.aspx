<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Agregar.aspx.cs" Inherits="AgregarMascota" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">


    <div class="container">
        <h1>Agregar Smartphones</h1>

        <asp:Label ID="lbName" runat="server" Text="Modelo"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_modelo" runat="server"></asp:TextBox>

        <asp:Label ID="lbTipo" runat="server" Text="Sistema"></asp:Label>
        <asp:DropDownList class="form-control" ID="ddl_sistema" runat="server">
            <asp:ListItem>Android</asp:ListItem>
            <asp:ListItem>iOS</asp:ListItem>
            <asp:ListItem>Windows phone:(</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="Label1" runat="server" Text="Tamanio"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_tamanio" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Liberado"></asp:Label>
        <asp:CheckBox ID="cbx_liberad" runat="server" Text=" " />
        <br />
        <asp:Button ID="btnAgregar" type="button" class="btn btn-success" runat="server" OnClick="btnAgregaClick" Text="Agregar" />
        <asp:Button ID="btn_cancelar" class="btn btn-dark" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />

    </div>
    <div class="alert alert-primary" id="divAlert" runat="server" role="alert">
    </div>


</asp:Content>

