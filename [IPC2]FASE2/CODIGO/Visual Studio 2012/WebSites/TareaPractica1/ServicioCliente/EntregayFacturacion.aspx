<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="EntregayFacturacion.aspx.cs" Inherits="ServicioCliente_EntregayFacturacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" Runat="Server">
     <h1>ENTREGA Y FACTURACION</h1>
     <p>CASILLA:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     </p>
     <p>
         <asp:Button ID="Button1" runat="server" Text="Ver Paquete" OnClick="Button1_Click" />
     </p>
     <p>PAQUETE<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
     </p>
     <p>
         <asp:Button ID="Button2" runat="server" Text="Facturar" OnClick="Button2_Click" />
     </p>
     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
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

