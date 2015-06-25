using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_ModificarPedido : System.Web.UI.Page
{
    List<string> lista = new List<string>();
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
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.guardarcambiosenperfil((int)Session["codigo"],TextBox1.Text, TextBox2.Text, TextBox3.Text,TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox8.Text);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        lista = ws.modificarperfil((int)Session["codigo"]);
        TextBox1.Text = lista[0];
        TextBox2.Text = lista[1];
        TextBox3.Text = lista[2];
        TextBox4.Text = lista[3];
        TextBox5.Text = lista[4];
        TextBox7.Text = lista[5];
        TextBox8.Text = lista[6];
    }
}