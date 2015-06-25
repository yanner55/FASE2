using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServicioCliente_EntregayFacturacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = (string)Session["usuario"];
        string sucursal = Convert.ToString(Session["sucursal"]);
        Label1.Text = sucursal+" el codigo es: "+Convert.ToString(Session["codigo"]);
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
        Session["casilla"] = TextBox1.Text; 
        Server.Transfer("Paquetes.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient ws =new ServiceReference1.ServiceSoapClient();

        decimal total= ws.facturar(Convert.ToInt32(TextBox2.Text),Convert.ToInt32(Session["codigo"]));
        Label2.Text = Convert.ToString(total);
    }
}