<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Importaciones/MPimportaciones.master" AutoEventWireup="true" CodeFile="RegistrarPedido.aspx.cs" Inherits="Importaciones_RegistrarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
       <h1>COTIZAR PRECIO</h1>
<p>CASILLA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCURSAL:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombre" DataValueField="cod_sucursal">
    </asp:DropDownList>
       </p>
<p>NOMBRE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [sucursal] WHERE ([cod_sede] = @cod_sede)">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="cod_sede" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>PRECIO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>&nbsp;</p>
<p>PESO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>FECHA:</p>
<p>CATEGORIA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_categoria">
    </asp:DropDownList>
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [categoria]"></asp:SqlDataSource>
</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Costo De Envio" />
<p>COSTO ES DE:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar a Pedido" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ver Lista Del Pedido" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Nuevo Pedido" />
    </p>
    <p>&nbsp;</p>
    <p>Cargar Paquete Por CSV</p>
       <p style="margin-left: 40px">
           <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar Paquetes" />
       </p>
    <p>&nbsp;</p>
 


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">

    <div id="cabecera" style="margin-left:40px">
        <p>
        CLIENTE
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

