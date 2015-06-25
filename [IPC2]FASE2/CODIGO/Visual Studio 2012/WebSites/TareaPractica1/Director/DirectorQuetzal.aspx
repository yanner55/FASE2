<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Director/MPdirector.master" AutoEventWireup="true" CodeFile="DirectorQuetzal.aspx.cs" Inherits="Director_DirectorQuetzalaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
     <h1>BIENVENIDO DIRECTOR</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        DIRECTOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

