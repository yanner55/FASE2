using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_Registrar_Miembro : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.AgregarCliente(Convert.ToInt32(TextBox1.Text),TextBox2.Text,TextBox3.Text,TextBox4.Text);
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}