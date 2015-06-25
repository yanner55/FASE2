<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Administrador/MPadministrador.master" AutoEventWireup="true" CodeFile="AdministradorQuetzal.aspx.cs" Inherits="Administrador_AdministradorQuetzal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>BIENVENIDO ADMINISTRADOR</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        ADMINISTRADOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

