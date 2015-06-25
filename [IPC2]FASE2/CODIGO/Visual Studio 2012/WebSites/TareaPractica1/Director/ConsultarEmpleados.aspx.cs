using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Director_ConsultarEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = Convert.ToString(Session["codigo"])+Convert.ToString(Session["sucursal"])+Convert.ToString(Session["depto"]);
        Label1.Text = userid;
        if (!IsPostBack)
        {
            if (userid == "")
            {
                Response.Redirect("/PaginaPrincipal.aspx");
            }

        }
        
    }
}