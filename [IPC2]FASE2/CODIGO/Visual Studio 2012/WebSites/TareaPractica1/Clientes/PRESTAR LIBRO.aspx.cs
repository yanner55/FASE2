using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes_PRESTAR_LIBRO : System.Web.UI.Page
{
    public int disponible = 100;
    public int prestado = 100;
    public int reservado = 100;
    public int existente = 100;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Verificar Cliente
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        Int64 valor = ws.Verificar(Convert.ToInt32(TextBox2.Text));
        Label1.Text = valor+"";    
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Modificar el limite del cliente y la informacino de prestado del libro
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.ModificarCliente(Convert.ToInt32(TextBox2.Text), Convert.ToInt32(Label1.Text));
        List<Int64> lista = ws.VerificarLibro(Convert.ToInt32(TextBox3.Text));
        ws.ModificarLibro(Convert.ToInt32(TextBox3.Text), Convert.ToInt32(lista[1]), Convert.ToInt32(lista[2]));
        ws.AgregarPedido(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        ws.AgregarDetalle(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox3.Text));
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //Verificar Libro
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        List<Int64> lista = new List<Int64>();
        lista=ws.VerificarLibro(Convert.ToInt32(TextBox3.Text));
        Label2.Text = "existencias: " + Convert.ToString(lista[0]) + " disponibles: " + Convert.ToString(lista[1]) + " prestados  : " + Convert.ToString(lista[2]) + " reservados : " + Convert.ToString(lista[3]);
    }
    protected void Reservar_Click(object sender, EventArgs e)
    {
        //reservar libro
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.ModificarCliente(Convert.ToInt32(TextBox2.Text), Convert.ToInt32(Label1.Text));
        List<Int64> lista = ws.VerificarLibro(Convert.ToInt32(TextBox3.Text));
        ws.ModificarLibroR(Convert.ToInt32(TextBox3.Text), Convert.ToInt32(lista[1]), Convert.ToInt32(lista[3]));
        ws.AgregarPedido(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text));
        ws.AgregarDetalle(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox3.Text));
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //Devolver libro
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        ws.ModificarClienteDevolucion(Convert.ToInt32(TextBox2.Text), Convert.ToInt32(Label1.Text));
        List<Int64> lista = ws.VerificarLibro(Convert.ToInt32(TextBox3.Text));
        ws.ModificarLibroDevolucion(Convert.ToInt32(TextBox3.Text), Convert.ToInt32(lista[1]), Convert.ToInt32(lista[2]));   
        
    }
}