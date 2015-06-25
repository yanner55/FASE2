using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Importaciones_ListaPedido : System.Web.UI.Page
{
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
}