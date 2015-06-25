<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Importaciones/MPimportaciones.master" AutoEventWireup="true" CodeFile="ControlEstados.aspx.cs" Inherits="Importaciones_ControlEstados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>CONTROL DE ESTADOS</h1>
    <p>LOTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>ESTADO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>FECHA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>
        SUCURSAL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_sucursal">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [sucursal]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        IMPORTACION
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>

