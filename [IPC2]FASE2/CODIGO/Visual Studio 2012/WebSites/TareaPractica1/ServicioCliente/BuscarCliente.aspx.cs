using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServicioCliente_BuscarCliente : System.Web.UI.Page
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
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        int codigo = ws.getcasilla(TextBox1.Text);
         if(codigo>0){
                Label2.Text = Convert.ToString(codigo); 
         }else{
               Response.Write("<script> window.alert('No se encontro ninguna casilla');</script>");
         }
        



    }
}