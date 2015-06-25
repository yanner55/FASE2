<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Bodega/MPbodega.master" AutoEventWireup="true" CodeFile="Paquetes Perdidos.aspx.cs" Inherits="Bodega_Paquetes_Perdidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>BIENVENIDO</h1>
    <p>PAQUETES PERDIDOS</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Comparar" />
    </p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_pedido" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="cod_pedido" HeaderText="cod_pedido" InsertVisible="False" ReadOnly="True" SortExpression="cod_pedido" />
            <asp:BoundField DataField="cod_casilla" HeaderText="cod_casilla" SortExpression="cod_casilla" />
            <asp:BoundField DataField="cod_lote" HeaderText="cod_lote" SortExpression="cod_lote" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
            <asp:BoundField DataField="cod_sucursal" HeaderText="cod_sucursal" SortExpression="cod_sucursal" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
            <asp:BoundField DataField="busqueda" HeaderText="busqueda" SortExpression="busqueda" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [pedido] WHERE (([cod_lote] = @cod_lote) AND ([busqueda] = @busqueda))">
        <SelectParameters>
            <asp:SessionParameter Name="cod_lote" SessionField="mostrar" Type="Int32" />
            <asp:SessionParameter Name="busqueda" SessionField="temporal" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <p>&nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        BODEGA
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

