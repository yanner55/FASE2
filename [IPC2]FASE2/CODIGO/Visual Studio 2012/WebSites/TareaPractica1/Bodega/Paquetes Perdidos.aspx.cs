using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bodega_Paquetes_Perdidos : System.Web.UI.Page
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
        int lote = 0;
        FileUpload1.SaveAs(MapPath(FileUpload1.FileName));
        String linea = MapPath(FileUpload1.FileName);
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        lote=ws.CompararBodega(linea);
        Session["temporal"] = 0;
        Session["mostrar"] = lote;
        
        
    }
}