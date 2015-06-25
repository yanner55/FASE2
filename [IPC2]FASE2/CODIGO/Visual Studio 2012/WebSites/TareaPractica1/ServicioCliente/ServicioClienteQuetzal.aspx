<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="ServicioClienteQuetzal.aspx.cs" Inherits="ServicioCliente_ServicioClienteQuetzal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>BIENVENIDO SERVICIO AL CLIENTE</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
            SERVICIO AL CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

