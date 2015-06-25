<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/Administrador/MPadministrador.master" AutoEventWireup="true" CodeFile="Gestionar Costos.aspx.cs" Inherits="Administrador_Gestionar_Costos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <h1>GESTION DE COSTOS</h1>
    <p>GANANCIA DE QUETZAL EXPRESS:</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_ganancia" DataSourceID="SqlDataSource1" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="cod_ganancia" HeaderText="cod_ganancia" InsertVisible="False" ReadOnly="True" SortExpression="cod_ganancia" />
                <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
                <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" DeleteCommand="DELETE FROM [ganancia] WHERE [cod_ganancia] = @cod_ganancia" InsertCommand="INSERT INTO [ganancia] ([porcentaje], [estado]) VALUES (@porcentaje, @estado)" SelectCommand="SELECT * FROM [ganancia]" UpdateCommand="UPDATE [ganancia] SET [porcentaje] = @porcentaje, [estado] = @estado WHERE [cod_ganancia] = @cod_ganancia">
            <DeleteParameters>
                <asp:Parameter Name="cod_ganancia" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="porcentaje" Type="Int32" />
                <asp:Parameter Name="estado" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="porcentaje" Type="Int32" />
                <asp:Parameter Name="estado" Type="Int32" />
                <asp:Parameter Name="cod_ganancia" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_aduana" DataSourceID="SqlDataSource2" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="cod_aduana" HeaderText="cod_aduana" InsertVisible="False" ReadOnly="True" SortExpression="cod_aduana" />
                <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
                <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" DeleteCommand="DELETE FROM [aduana] WHERE [cod_aduana] = @cod_aduana" InsertCommand="INSERT INTO [aduana] ([porcentaje], [estado]) VALUES (@porcentaje, @estado)" SelectCommand="SELECT * FROM [aduana]" UpdateCommand="UPDATE [aduana] SET [porcentaje] = @porcentaje, [estado] = @estado WHERE [cod_aduana] = @cod_aduana">
            <DeleteParameters>
                <asp:Parameter Name="cod_aduana" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="porcentaje" Type="Int32" />
                <asp:Parameter Name="estado" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="porcentaje" Type="Int32" />
                <asp:Parameter Name="estado" Type="Int32" />
                <asp:Parameter Name="cod_aduana" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="cod_categoria" DataSourceID="SqlDataSource3" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="cod_categoria" HeaderText="cod_categoria" InsertVisible="False" ReadOnly="True" SortExpression="cod_categoria" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QUETZALConnectionString %>" DeleteCommand="DELETE FROM [categoria] WHERE [cod_categoria] = @cod_categoria" InsertCommand="INSERT INTO [categoria] ([nombre], [porcentaje]) VALUES (@nombre, @porcentaje)" SelectCommand="SELECT * FROM [categoria]" UpdateCommand="UPDATE [categoria] SET [nombre] = @nombre, [porcentaje] = @porcentaje WHERE [cod_categoria] = @cod_categoria">
            <DeleteParameters>
                <asp:Parameter Name="cod_categoria" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="porcentaje" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="porcentaje" Type="Int32" />
                <asp:Parameter Name="cod_categoria" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMenuInformacion" Runat="Server">
    <div id="cabecera" style="margin-left:40px">
        <p>
        ADMINISTRADOR
        </p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

