<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="Devolucion.aspx.cs" Inherits="ServicioCliente_Devolucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" Runat="Server">
    <h1>DEVOLUCION DE PAQUETES</h1>
    <p>PAQUETE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Devolver Paquete" />
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
            SERVICIO AL CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

