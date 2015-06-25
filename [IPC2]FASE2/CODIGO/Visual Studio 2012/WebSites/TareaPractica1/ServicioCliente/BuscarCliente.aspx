<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="BuscarCliente.aspx.cs" Inherits="ServicioCliente_BuscarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" Runat="Server">
    <h1>BUSCAR CLIENTE</h1>
<p>NOMBRE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar Casilla" />
</p>
<p>CODIGO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server"></asp:Label>
</p>
<p>&nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
            SERVICIO AL CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

