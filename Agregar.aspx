<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Agregar.aspx.cs" Inherits="Agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">


    <div class="container" style="width:100%" >
        <h1>Agregar automóvil</h1>

        <asp:Label ID="lbName" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_nombre" runat="server" style="width: 100%"></asp:TextBox>

        <asp:Label ID="lbMarca" runat="server" Text="Marca"></asp:Label>
        <asp:DropDownList class="form-control" ID="ddl_marca" runat="server">
            <asp:ListItem>Audi</asp:ListItem>
            <asp:ListItem>Porsche</asp:ListItem>
            <asp:ListItem>Honda</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_precio" runat="server" style="width: 100%"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Asegurado"></asp:Label>
        <asp:CheckBox ID="cbx_asegurado" runat="server" Text=" " />
        <br />
        <asp:Button ID="btnAgregar" type="button" class="btn btn-success" runat="server" OnClick="btnAgregaClick" Text="Agregar" />
        <asp:Button ID="btn_cancelar" class="btn btn-dark" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />

    </div>
    <div class="alert alert-primary" id="divAlert" runat="server" role="alert">
    </div>


</asp:Content>

