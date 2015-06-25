<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Director/MPdirector.master" AutoEventWireup="true" CodeFile="ConsultarEmpleados.aspx.cs" Inherits="Director_ConsultarEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>LISTA DE EMPLEADOS</h1>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_contrato" DataSourceID="SqlDataSource1" EnableModelValidation="True">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="cod_contrato" HeaderText="cod_contrato" InsertVisible="False" ReadOnly="True" SortExpression="cod_contrato" />
        <asp:BoundField DataField="cod_sucursal" HeaderText="cod_sucursal" SortExpression="cod_sucursal" />
        <asp:BoundField DataField="cod_jefe" HeaderText="cod_jefe" SortExpression="cod_jefe" />
        <asp:BoundField DataField="cod_depto" HeaderText="cod_depto" SortExpression="cod_depto" />
        <asp:HyperLinkField DataNavigateUrlFields="cod_empleado" HeaderText="cod_empleado" DataNavigateUrlFormatString="DetalleEmpleado.aspx?cod_empleado={0}" DataTextField="cod_empleado" />
    </Columns>
</asp:GridView>
<p>&nbsp;</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" SelectCommand="SELECT * FROM [contrato] WHERE (([cod_depto] = @cod_depto) AND ([cod_jefe] = @cod_jefe) AND ([cod_sucursal] = @cod_sucursal))" DeleteCommand="DELETE FROM [contrato] WHERE [cod_contrato] = @cod_contrato" InsertCommand="INSERT INTO [contrato] ([cod_sucursal], [cod_empleado], [cod_jefe], [cod_depto]) VALUES (@cod_sucursal, @cod_empleado, @cod_jefe, @cod_depto)" UpdateCommand="UPDATE [contrato] SET [cod_sucursal] = @cod_sucursal, [cod_empleado] = @cod_empleado, [cod_jefe] = @cod_jefe, [cod_depto] = @cod_depto WHERE [cod_contrato] = @cod_contrato">
        <DeleteParameters>
            <asp:Parameter Name="cod_contrato" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_sucursal" Type="Int32" />
            <asp:Parameter Name="cod_empleado" Type="Int32" />
            <asp:Parameter Name="cod_jefe" Type="Int32" />
            <asp:Parameter Name="cod_depto" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:SessionParameter Name="cod_depto" SessionField="depto" Type="Int32" />
            <asp:SessionParameter Name="cod_jefe" SessionField="codigo" Type="Int32" />
            <asp:SessionParameter Name="cod_sucursal" SessionField="sucursal" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_sucursal" Type="Int32" />
            <asp:Parameter Name="cod_empleado" Type="Int32" />
            <asp:Parameter Name="cod_jefe" Type="Int32" />
            <asp:Parameter Name="cod_depto" Type="Int32" />
            <asp:Parameter Name="cod_contrato" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        DIRECTOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

