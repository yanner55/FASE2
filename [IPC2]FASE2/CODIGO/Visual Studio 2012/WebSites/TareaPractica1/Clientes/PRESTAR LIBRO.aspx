<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Clientes/MPCliente.master" AutoEventWireup="true" CodeFile="PRESTAR LIBRO.aspx.cs" Inherits="Clientes_PRESTAR_LIBRO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h2>PRESTAR LIBRO</h2>
    <p>CODIGO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>CARNET&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp; </p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verificar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
    <p>LIBRO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Verificar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Resultado"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Prestar" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Devolver" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Reservar" runat="server" Text="Reservar" OnClick="Reservar_Click" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>

