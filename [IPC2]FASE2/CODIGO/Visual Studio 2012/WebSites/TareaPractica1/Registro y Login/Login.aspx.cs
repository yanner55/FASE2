using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registro_y_Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["usuario"] = TextBox1.Text;
        Session["contraseña"] = TextBox2.Text;
        int tipo = 0;
        int codigo = 0;
        int cod_sucursal = 0;

        ServiceReference1.ServiceSoapClient ws=new ServiceReference1.ServiceSoapClient();
        if (ws.login(TextBox1.Text, TextBox2.Text)){

            tipo = ws.getcodigo(TextBox1.Text, TextBox2.Text);
            Session["codigo"] = tipo;
            Response.Redirect("/Clientes/ClienteQuetzal.aspx");
            
        }else if(ws.loginempleado(TextBox1.Text,TextBox2.Text)){
            
            
            
            tipo=ws.gettipo(TextBox1.Text,TextBox2.Text);
            Session["tipo"] = tipo;
            codigo = ws.getcodigoempleado(TextBox1.Text, TextBox2.Text);
            Session["codigo"] = codigo;
            cod_sucursal = ws.getsucursal(Convert.ToInt32(Session["codigo"]));
            Session["sucursal"] = cod_sucursal;
            Session["depto"] = ws.getdepartamentocodigo(codigo);
            if(tipo==2){
                Response.Redirect("/Director/DirectorQuetzal.aspx");
            }
            else if (tipo == 3) {
                Response.Redirect("/ServicioCliente/ServicioClienteQuetzal.aspx");
            } else if (tipo == 4)
            {
                Response.Redirect("/Administrador/AdministradorQuetzal.aspx");
            } else if (tipo == 5)
            {
                Response.Redirect("/Bodega/BodegaQuetzal.aspx");
            }else if (tipo == 6)
            {
                Response.Redirect("/Importaciones/ImportacionQuetzal.aspx");
            }


        }else{
               Response.Write("<script> window.alert('datos invalidos');</script>");
       }


    }
}