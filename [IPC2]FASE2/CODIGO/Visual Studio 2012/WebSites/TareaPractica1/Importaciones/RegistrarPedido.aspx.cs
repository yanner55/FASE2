using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Importaciones_RegistrarPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = Convert.ToString(Session["codigo"]);
        Label1.Text = userid;
        if (!IsPostBack)
        {
            if (userid == "")
            {
                Response.Redirect("/PaginaPrincipal.aspx");
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int categoria = 0;
        decimal costo = 0m;
        decimal prueba = 0;
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        categoria = Convert.ToInt32(DropDownList1.SelectedValue);

        ///LO DE MATH.CEILING ES UNA FUNCION PARA APROXIMAR UN DECIMAL AL ENTERO QUE SIGE EJEMPLO 4.3->5 MEDIA
        ///VEZ TENGA PUNTO DECIMAL LO APROXIMA AL ENTERO SIGUIENTE
        ///
        prueba = Math.Ceiling(Convert.ToDecimal(TextBox3.Text));
        costo = ws.cotizar(Convert.ToDecimal(TextBox2.Text), Convert.ToInt32(prueba), categoria);
        Label2.Text = costo + "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int categoria = 0;
        decimal prueba = 0;
        categoria = Convert.ToInt32(DropDownList1.SelectedValue);

        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        prueba = Math.Ceiling(Convert.ToDecimal(TextBox3.Text));
        ws.AgregarAlPedido(TextBox1.Text, Convert.ToInt32(prueba), Convert.ToDecimal(TextBox2.Text), categoria, Convert.ToInt32(Session["pedido"]),Convert.ToDecimal(Label2.Text));
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Server.Transfer("ListaPedido.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int sucursal = 0;
        sucursal = Convert.ToInt32(DropDownList2.SelectedValue);
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        Session["pedido"] = ws.crearpedido(Convert.ToInt32(TextBox4.Text),sucursal,"2015/06/10");


    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        FileUpload1.SaveAs(MapPath(FileUpload1.FileName));
        String linea = MapPath(FileUpload1.FileName);
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.RegistrarArchivoPaquete(linea,Convert.ToInt32(Session["sucursal"]));

    }
}