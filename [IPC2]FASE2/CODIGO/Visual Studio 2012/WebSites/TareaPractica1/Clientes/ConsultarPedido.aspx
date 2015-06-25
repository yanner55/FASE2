<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Clientes/QuetzalCliente.master" AutoEventWireup="true" CodeFile="ConsultarPedido.aspx.cs" Inherits="Clientes_ConsultarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>PEDIDOS EN TRANSITO</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="cod_pedido" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="cod_casilla" HeaderText="cod_casilla" SortExpression="cod_casilla" />
            <asp:BoundField DataField="cod_lote" HeaderText="cod_lote" SortExpression="cod_lote" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
            <asp:BoundField DataField="cod_sucursal" HeaderText="cod_sucursal" SortExpression="cod_sucursal" />
            <asp:HyperLinkField DataNavigateUrlFields="cod_pedido" DataNavigateUrlFormatString="DetalleDelPedido.aspx?cod_pedido={0}" DataTextField="cod_pedido" HeaderText="cod_pedido" />
            <asp:HyperLinkField DataNavigateUrlFields="cod_lote" DataNavigateUrlFormatString="DetalleDelPedido.aspx?cod_lote={0}" DataTextField="cod_lote" HeaderText="historial" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
    <p>&nbsp;</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [pedido] WHERE ([cod_casilla] = @cod_casilla)">
            <SelectParameters>
                <asp:SessionParameter Name="cod_casilla" SessionField="codigo" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>

