<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="Paquetes.aspx.cs" Inherits="ServicioCliente_Paquetesaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" Runat="Server">
    <h1>PAQUETES LISTOS PARA ENTREGAR</h1>
<p>&nbsp;</p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_pedido" DataSourceID="SqlDataSource1" EnableModelValidation="True">
    <Columns>
        <asp:BoundField DataField="cod_pedido" HeaderText="cod_pedido" InsertVisible="False" ReadOnly="True" SortExpression="cod_pedido" />
        <asp:BoundField DataField="cod_casilla" HeaderText="cod_casilla" SortExpression="cod_casilla" />
        <asp:BoundField DataField="cod_lote" HeaderText="cod_lote" SortExpression="cod_lote" />
        <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
        <asp:BoundField DataField="cod_sucursal" HeaderText="cod_sucursal" SortExpression="cod_sucursal" />
    </Columns>
</asp:GridView>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT DISTINCT p.cod_pedido, p.cod_casilla, p.cod_lote, p.fecha, p.cod_sucursal FROM pedido AS p INNER JOIN lote AS l ON p.cod_lote = l.cod_lote WHERE (p.cod_casilla = @cod_casilla) AND (l.estado = 'bodega') AND(p.cod_sucursal = @cod_sucursal) AND (p.estado &lt;&gt; 'entregado') AND (p.estado &lt;&gt; 'devuelto')">
        <SelectParameters>
            <asp:SessionParameter Name="cod_casilla" SessionField="casilla" />
            <asp:SessionParameter DefaultValue="" Name="cod_sucursal" SessionField="sucursal" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
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

