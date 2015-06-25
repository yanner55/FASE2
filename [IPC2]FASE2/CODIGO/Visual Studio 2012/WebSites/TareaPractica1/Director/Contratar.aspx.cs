using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Director_Contratar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = (string)Session["usuario"];
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

        string puesto = "";
        
        ws.contratar(TextBox6.Text,TextBox7.Text,Convert.ToDecimal(TextBox4.Text),TextBox8.Text,TextBox5.Text,puesto,TextBox3.Text,TextBox2.Text,Convert.ToInt32(Session["sucursal"]),Convert.ToInt32(Session["codigo"]));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(MapPath(FileUpload1.FileName));
        String linea = MapPath(FileUpload1.FileName);

        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.ContratarArchivoEmpleado(linea, Convert.ToInt32(Session["sucursal"]), Convert.ToInt32(Session["codigo"]));
    }
}