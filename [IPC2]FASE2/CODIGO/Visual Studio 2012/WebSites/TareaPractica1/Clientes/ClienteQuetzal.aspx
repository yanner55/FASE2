<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Clientes/QuetzalCliente.master" AutoEventWireup="true" CodeFile="ClienteQuetzal.aspx.cs" Inherits="Clientes_ClienteQuetzal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>BIENVENIDO CLIENTE</h1>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    
    <div id="cabecera" style="margin-left:40px">
        <p>
        CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
    
</asp:Content>
