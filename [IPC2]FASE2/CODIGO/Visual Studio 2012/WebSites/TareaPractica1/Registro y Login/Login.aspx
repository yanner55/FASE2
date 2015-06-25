<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Registro_y_Login_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1 style="margin-left:120px">IDENTIFICARSE</h1>

    <h2>USUARIO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h2>
    <p>&nbsp;</p>
    <h2>CONTRASEÑA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server">
           
        </asp:TextBox>
    </h2>
    <p>&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p style="margin-left: 320px">&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="INICIAR SECION" OnClick="Button1_Click" />
    </p>

</asp:Content>

