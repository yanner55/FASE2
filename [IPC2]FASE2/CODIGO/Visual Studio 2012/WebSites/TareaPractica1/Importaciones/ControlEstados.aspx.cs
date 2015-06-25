using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Importaciones_ControlEstados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        TextBox3.Text ="2015-"+ Convert.ToString(System.DateTime.Today.Month) +"-"+ Convert.ToString(System.DateTime.Today.Day);
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
        int sucursal = Convert.ToInt32(DropDownList1.SelectedValue);
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.AgregarLote(Convert.ToInt32(TextBox1.Text),sucursal,TextBox3.Text,TextBox2.Text);
    }
}