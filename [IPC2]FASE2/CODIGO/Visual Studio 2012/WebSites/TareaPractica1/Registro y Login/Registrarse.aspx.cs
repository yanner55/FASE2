using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Libros_Registrarse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.registrar(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox6.Text), TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox8.Text);
    }
}