<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Libros/MPLibro.master" AutoEventWireup="true" CodeFile="MasPrestados.aspx.cs" Inherits="Libros_MasPrestados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h2>TOP 10 LIBROS PRESTADOS</h2>
    <p style="margin-left: 120px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="cantidad" HeaderText="cantidad" ReadOnly="True" SortExpression="cantidad" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BlibliotecaConnectionString %>" SelectCommand="select Top 10 l.nombre,COUNT(d.cod_libro) as cantidad from Libro l,detalle d 
where l.cod_libro=d.cod_libro  group by l.nombre
order by cantidad desc"></asp:SqlDataSource>
    <br />
</asp:Content>

