<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Clientes/QuetzalCliente.master" AutoEventWireup="true" CodeFile="DetalleDelPedido.aspx.cs" Inherits="Clientes_DetalleDelPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>DETALLES DEL PEDIDO</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_paquete" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="cod_paquete" HeaderText="cod_paquete" InsertVisible="False" ReadOnly="True" SortExpression="cod_paquete" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="cod_categoria" HeaderText="cod_categoria" SortExpression="cod_categoria" />
            <asp:BoundField DataField="cod_pedido" HeaderText="cod_pedido" SortExpression="cod_pedido" />
            <asp:BoundField DataField="envio" HeaderText="envio" SortExpression="envio" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:GridView ID="GridView3" runat="server">
    </asp:GridView>
    <br />
    <br />
    HISTORIAL DEL PEDIDO<br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" EnableModelValidation="True" DataKeyNames="llave">
        <Columns>
            <asp:BoundField DataField="llave" HeaderText="llave" SortExpression="llave" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="cod_lote" HeaderText="cod_lote" SortExpression="cod_lote" />
            <asp:BoundField DataField="cod_sucursal" HeaderText="cod_sucursal" SortExpression="cod_sucursal" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [lote] WHERE ([cod_lote] = @cod_lote)">
        <SelectParameters>
            <asp:QueryStringParameter Name="cod_lote" QueryStringField="cod_lote" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [paquete] WHERE ([cod_pedido] = @cod_pedido)">
        <SelectParameters>
            <asp:QueryStringParameter Name="cod_pedido" QueryStringField="cod_pedido" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT [estado] FROM [pedido] WHERE ([cod_pedido] = @cod_pedido2)">
        <SelectParameters>
            <asp:QueryStringParameter Name="cod_pedido2" QueryStringField="cod_pedido" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>

