<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Director/MPdirector.master" AutoEventWireup="true" CodeFile="DetalleEmpleado.aspx.cs" Inherits="Director_DetalleEmpleadot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>INFORAMCION DEL EMPLEADO</h1>
    <p>&nbsp;</p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="cod_empleado" DataSourceID="SqlDataSource1" EnableModelValidation="True" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="cod_empleado" HeaderText="cod_empleado" InsertVisible="False" ReadOnly="True" SortExpression="cod_empleado" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
            <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario" />
            <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
            <asp:BoundField DataField="puesto" HeaderText="puesto" SortExpression="puesto" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
    </asp:DetailsView>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" DeleteCommand="DELETE FROM [empleado] WHERE [cod_empleado] = @cod_empleado" InsertCommand="INSERT INTO [empleado] ([nombre], [apellido], [telefono], [direccion], [sueldo], [usuario], [contraseña], [puesto]) VALUES (@nombre, @apellido, @telefono, @direccion, @sueldo, @usuario, @contraseña, @puesto)" SelectCommand="SELECT * FROM [empleado] WHERE ([cod_empleado] = @cod_empleado)" UpdateCommand="UPDATE [empleado] SET [nombre] = @nombre, [apellido] = @apellido, [telefono] = @telefono, [direccion] = @direccion, [sueldo] = @sueldo, [usuario] = @usuario, [contraseña] = @contraseña, [puesto] = @puesto WHERE [cod_empleado] = @cod_empleado">
            <DeleteParameters>
                <asp:Parameter Name="cod_empleado" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellido" Type="String" />
                <asp:Parameter Name="telefono" Type="String" />
                <asp:Parameter Name="direccion" Type="String" />
                <asp:Parameter Name="sueldo" Type="Decimal" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="contraseña" Type="String" />
                <asp:Parameter Name="puesto" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="cod_empleado" QueryStringField="cod_empleado" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellido" Type="String" />
                <asp:Parameter Name="telefono" Type="String" />
                <asp:Parameter Name="direccion" Type="String" />
                <asp:Parameter Name="sueldo" Type="Decimal" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="contraseña" Type="String" />
                <asp:Parameter Name="puesto" Type="String" />
                <asp:Parameter Name="cod_empleado" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        DIRECTOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

