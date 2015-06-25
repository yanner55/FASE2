<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Administrador/MPadministrador.master" AutoEventWireup="true" CodeFile="CargaMasiva.aspx.cs" Inherits="Director_CargaMasiva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>CARGAR ARCHIVO CSV</h1>
    <p>&nbsp;</p>
    <h2>CARGAR  IMPUESTOS CSV</h2>
    <p>DIRECCION:
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar Archivo" />
    </p>
    <h2>CARGAR EMPLEADO CSV</h2>
    <p>DIRECCION:<asp:FileUpload ID="FileUpload2" runat="server" />
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cargar Archivo" />
    </p>
    <h2>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
         <div id="cabecera" style="margin-left:40px">
        <p>
        DIRECTOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

