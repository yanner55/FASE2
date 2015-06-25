<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Importaciones/MPimportaciones.master" AutoEventWireup="true" CodeFile="ListaPedido.aspx.cs" Inherits="Importaciones_ListaPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
     <h1>LISTA DE PAQUETES AGREGADOS</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="cod_pedido" HeaderText="cod_pedido" SortExpression="cod_pedido" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT [nombre], [peso], [precio], [cod_pedido] FROM [paquete] WHERE ([cod_pedido] = @cod_pedido)">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="1" Name="cod_pedido" SessionField="pedido" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        IMPORTACION
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

