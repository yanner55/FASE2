<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/ServicioCliente/MPserviciocliente.master" AutoEventWireup="true" CodeFile="ValidarCliente.aspx.cs" Inherits="ServicioCliente_ValidarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" Runat="Server">
    <h1>SOLICITUDES DE CLIENTES</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True" CellPadding="4" DataKeyNames="cod_cliente" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="cod_cliente" HeaderText="cod_cliente" SortExpression="cod_cliente" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="nit" HeaderText="nit" SortExpression="nit" />
            <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario" />
            <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT cod_cliente, nombre, apellido, telefono, direccion, nit, usuario, contraseña FROM cliente WHERE (estado = 0)"></asp:SqlDataSource>

    <br />
    <br />
    CODIGO DEL CLIENTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Autorizar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
&nbsp;&nbsp; 

    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Rechazar" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
     <div id="cabecera" style="margin-left:40px">
        <p>
        SERVICIO AL CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>

