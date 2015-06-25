using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServicioCliente_Devolucion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = (string)Session["usuario"];
        string sucursal = Convert.ToString(Session["sucursal"]);
        Label1.Text = sucursal + " el codigo es: " + Convert.ToString(Session["codigo"]);
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
        Boolean ban = false;
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ban = ws.tienefactura(Convert.ToInt32(TextBox1.Text));
        if(ban){
            ws.devolver(Convert.ToInt32(TextBox1.Text));
            Response.Write("<script> window.Information('Paquete en Devolucion');</script>");
        }else{
               Response.Write("<script> window.alert('Paquete no Facturado');</script>");
        }
        
        
    }
}