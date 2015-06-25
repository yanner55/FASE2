<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Libros/MPLibro.master" AutoEventWireup="true" CodeFile="Consultar.aspx.cs" Inherits="Libros_Consultar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h2>CONSULTAR LIBRO</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="cod_libro" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="cod_libro" HeaderText="cod_libro" ReadOnly="True" SortExpression="cod_libro" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="existencia" HeaderText="existencia" SortExpression="existencia" />
                <asp:BoundField DataField="disponible" HeaderText="disponible" SortExpression="disponible" />
                <asp:BoundField DataField="prestado" HeaderText="prestado" SortExpression="prestado" />
                <asp:BoundField DataField="reservado" HeaderText="reservado" SortExpression="reservado" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BlibliotecaConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [Libro]"></asp:SqlDataSource>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>

