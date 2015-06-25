using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Libros_AgregarLibro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.AgregarLibro(Convert.ToInt32(TextBox1.Text),1,1, Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text),TextBox4.Text);

       
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}