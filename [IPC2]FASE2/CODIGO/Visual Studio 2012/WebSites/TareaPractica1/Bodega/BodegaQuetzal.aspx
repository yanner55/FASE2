<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Bodega/MPbodega.master" AutoEventWireup="true" CodeFile="BodegaQuetzal.aspx.cs" Inherits="Bodega_BodegaQuetzal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>BIENVENIDO BODEGERO</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        BODEGA
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

