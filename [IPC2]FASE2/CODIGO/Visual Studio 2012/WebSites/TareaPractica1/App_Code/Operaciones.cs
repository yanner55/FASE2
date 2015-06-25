using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;

/// <summary>
/// Descripción breve de Class1
/// </summary>
public class Operaciones
{
    /// <summary>
    /// tipo donde 
    /// 1 es cliente
    /// 2 es director 
    /// 3 es servicio
    /// 4 administrador
    /// 5 bodega
    /// 6 importaciones
    /// </summary>
    /// estados 
    /// 1 USA
    /// 2 AVION
    /// 3 BODEGA
    /// 4 ENTREGADO
    /// 5 DEVUELTO
    private int codigos = 0;
    
    public void agregarLibro(int codigolibro,int codigoautor,int codigotema,int existencias,int paginas,string nombre) {
        string insert = "insert into Libro values(" + codigolibro + "," + codigoautor + "," + codigotema + "," + existencias + "," + existencias + "," + 0 + "," + 0 + ","+paginas+",'" + nombre + "')";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
    
    }
    public void agregarCliente(int carnet,string nombre,string direccion , string telefono)
    {
        string insert="insert into cliente values("+carnet+",'"+nombre+"','"+direccion+"','"+telefono+"',"+0+")";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar=new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd=new SqlCommand(insert,conectar);
        try{
            cmd.ExecuteNonQuery();
        }catch(Exception e){
            throw new Exception("Error al insertar registro",e);
        }
        conectar.Close();

    }
    public void agregarPedido(int cod_prestamo,int carnet)
    {
        string insert = "insert into prestamo values(" + cod_prestamo + "," + carnet + ")";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();

    }
    public void agregarDetalle(int cod_detalle,int cod_prestamo, int cod_libro)
    {
        string insert = "insert into detalle values(" + cod_detalle + "," + cod_prestamo + "," + cod_libro + ")";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();

    }
    public void ModificarCliente(int carnet,int limite)
    {
        limite = limite + 1;
        string update = "update cliente set limite="+limite+" where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(update, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }


    }
    public void ModificarClienteDevolucion(int carnet, int limite)
    {
        limite = limite -1;
        string update = "update cliente set limite=" + limite + " where carnet=" + carnet + "";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(update, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }


    }
    public void ModificarLibro(int codigolibro,int disponible,int prestado)
    {
        Int64 disponible1 = disponible-1;
        Int64 prestado1 = prestado+ 1;
        string update = "update Libro set disponible=" +disponible1+",prestado="+prestado1+" where cod_libro=" +codigolibro+ "";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(update, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }


    }
    public void ModificarLibroR(int codigolibro, int disponible, int reservado)
    {
        Int64 disponible1 = disponible;
        Int64 reservado1 = reservado + 1;
        string update = "update Libro set disponible=" + disponible1 + ",reservado=" + reservado1 + " where cod_libro=" + codigolibro + "";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(update, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }


    }
    public void ModificarLibroDevolver(int codigolibro, int disponible, int prestado)
    {
        Int64 disponible1 = disponible + 1;
        Int64 prestado1 = prestado - 1;
        string update = "update Libro set disponible=" + disponible1 + ",prestado=" + prestado1 + " where cod_libro=" + codigolibro + "";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(update, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }


    }
    public void Prestar()
    {


    }
    public Int64 Verificar(int carnet)
    {
        Int64 limite=100;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select limite from cliente where carnet like '%{0}%'",carnet), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            limite = Convert.ToInt64(reader["limite"]);
        }
        conectar.Close();
        return limite;
        
    }

    public List<Int64> VerificarLibro(int codigolibro)
    {
        int ban = 0;
        List<Int64> lista=new List<Int64>();   
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=Bliblioteca;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select existencia,disponible,prestado,reservado from Libro where cod_libro like '%{0}%'", codigolibro), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ban = 1;
            lista.Add(Convert.ToInt64(reader["existencia"]));
            lista.Add(Convert.ToInt64(reader["disponible"]));
            lista.Add(Convert.ToInt64(reader["prestado"]));
            lista.Add(Convert.ToInt64(reader["reservado"]));
             
        }
        if (ban == 0) {
            lista.Add(Convert.ToInt64(100));
            lista.Add(Convert.ToInt64(100));
            lista.Add(Convert.ToInt64(100));
            lista.Add(Convert.ToInt64(100));
        
        
        }
        conectar.Close();
        return lista;

    }
    public void MasPrestados()
    {


    }
    
    
    public Operaciones()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    //Esta seccion es para las consultas para la fase 2 lo de arriba son los metodos de la practica
    
    
    public Boolean login(string usuario,string contraseña) {
        int codigo = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from cliente where usuario ='"+usuario+"' and contraseña='"+contraseña+"' and estado=1"), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
           codigo = Convert.ToInt32(reader["cod_cliente"]);
        }
        codigos = codigo;
        conectar.Close();
        if (codigo != 0)
        {
            return true;
        }
        else {
            return false;
        }
    }
    public Boolean loginempleado(string usuario, string contraseña)
    {
        int codigo = 0;
        string tipo="";
        
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from empleado where usuario='"+usuario+"' and contraseña='"+contraseña+"'"), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            codigo = Convert.ToInt32(reader["cod_empleado"]);
            tipo = Convert.ToString(reader["puesto"]);
        }
        codigos = codigo;
        conectar.Close();
        if (codigo != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int gettipo(string usuario, string contraseña)
    {
        int codigo = 0;
        string tipo = "";
        int tipo1 = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from empleado where usuario like '%{0}%' and contraseña like '%{1}%'", usuario, contraseña), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            codigo = Convert.ToInt32(reader["cod_empleado"]);
            tipo = Convert.ToString(reader["puesto"]);
        }
        codigos = codigo;

        if (tipo.Equals("director"))
        {
            tipo1 = 2;
        }
        else if(tipo.Equals("bodega"))
        {
            tipo1 = 5;
        }
        else if (tipo.Equals("servicio"))
        {
            tipo1 = 3;
        }
        else if (tipo.Equals("administrador"))
        {
            tipo1 = 4;
        }
        else if (tipo.Equals("importaciones"))
        {
            tipo1 = 6;
        }
        conectar.Close();
        return tipo1;
    }
    
    public int getcodigo(string usuario,string contraseña) {
        int codigo = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from cliente where usuario like '%{0}%' and contraseña like '%{1}%'", usuario, contraseña), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            codigo = Convert.ToInt32(reader["cod_cliente"]);
        }
        conectar.Close();
        return codigo;
    }
    public int getcodigoempleado(string usuario, string contraseña)
    {
        int codigo = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from empleado where usuario like '%{0}%' and contraseña like '%{1}%'", usuario, contraseña), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            codigo = Convert.ToInt32(reader["cod_empleado"]);
        }
        conectar.Close();
        return codigo;
    }
    public int getsucursal(int cod_empleado) {
        int sucursal = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from contrato where cod_empleado="+cod_empleado+""), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            sucursal = Convert.ToInt32(reader["cod_sucursal"]);
        }
        conectar.Close();
        return sucursal;
    }
    public void Registrar(string nombre,string apellido,int nit,string telefono, string direccion, string tarjeta,string usuario,string contraseña)
    {
        string insert = "insert into cliente (nombre,apellido,telefono,direccion,tarjeta,estado,usuario,contraseña,nit)values('" + nombre + "','" + apellido + "','" + telefono + "','" + direccion + "','" + tarjeta + "'," + 0 + ",'" + usuario + "','" + contraseña + "',"+nit+")";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();

    }
    public int getdepartamentoCodigo(int cod_empleado)
    {
        int puest = 0;
        
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd3 = new SqlCommand(String.Format("Select * from contrato where cod_empleado="+cod_empleado+""), conectar);

        SqlDataReader reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            puest = Convert.ToInt32(reader["cod_depto"]);

        }
        conectar.Close();
        return puest;
    }
   
    public string getdepartamento(int cod_empleado) {
        int puest = 0;
        string puestoz = "";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd3 = new SqlCommand(String.Format("Select * from contrato where cod_empleado like '%{0}%'",cod_empleado), conectar);

        SqlDataReader reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            puest = Convert.ToInt32(reader["cod_depto"]);

        }
        reader.Close();
        SqlCommand cmd33 = new SqlCommand(String.Format("Select * from depto  where cod_depto like '%{0}%'", puest), conectar);
        reader = cmd33.ExecuteReader();
        while (reader.Read())
        {
            puestoz = Convert.ToString(reader["nombre"]);

        }
        reader.Close();
        conectar.Close();
        return puestoz;
    }
    public string Contratar(string nombre, string apellido, decimal sueldo, string telefono, string direccion, string puesto, string usuario, string contraseña,int sucursal,int jefe)
    {
        Operaciones accion=new Operaciones();
        int puest = 0;
        string puestoz = accion.getdepartamento(jefe);
        int empleado = 0;        
        string insert = "insert into empleado (nombre,apellido,sueldo,telefono,direccion,puesto,usuario,contraseña)values('" + nombre + "','" + apellido + "',"+sueldo+",'" + telefono + "','" + direccion + "','" + puestoz + "','" + usuario + "','" + contraseña + "')";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd3 = new SqlCommand(String.Format("Select * from contrato where cod_empleado like '%{0}%'", jefe), conectar);
        
        SqlDataReader reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            puest = Convert.ToInt32(reader["cod_depto"]);
            
        }
        reader.Close();
                
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        SqlCommand cmd2 = new SqlCommand(String.Format("Select top 1 * from empleado order by cod_empleado desc"), conectar);
        reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
            empleado = Convert.ToInt32(reader["cod_empleado"]);
        }
        reader.Close();
        SqlCommand cmd5 = new SqlCommand(String.Format("insert into contrato(cod_sucursal,cod_empleado,cod_jefe,cod_depto)values("+sucursal+","+empleado+","+jefe+","+puest+")"), conectar);
        try
        {
            cmd5.ExecuteNonQuery();
        }
        catch (Exception e) {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();
        return puestoz;
    }

    public void contratarDirector(string nombre, string apellido, decimal sueldo, string telefono, string direccion, string puesto, string usuario, string contraseña,string  sucursal) {
        Operaciones accion = new Operaciones();
        int puest = 0;
        int sucursall = 0;
        //string puestoz = accion.getdepartamento(jefe);
        int empleado = 0;
        string insert = "insert into empleado (nombre,apellido,sueldo,telefono,direccion,puesto,usuario,contraseña)values('" + nombre + "','" + apellido + "'," + sueldo + ",'" + telefono + "','" + direccion + "','director','" + usuario + "','" + contraseña + "')";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd3 = new SqlCommand(String.Format("Select * from depto where nombre like '%{0}%'", puesto), conectar);

        SqlDataReader reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            puest = Convert.ToInt32(reader["cod_depto"]);

        }
        reader.Close();
        SqlCommand cmd33 = new SqlCommand(String.Format("Select * from sucursal where nombre like '%{0}%'",sucursal), conectar);
        reader = cmd33.ExecuteReader();
        while (reader.Read())
        {
            sucursall = Convert.ToInt32(reader["cod_sucursal"]);

        }
        reader.Close();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        SqlCommand cmd2 = new SqlCommand(String.Format("Select top 1 * from empleado order by cod_empleado desc"), conectar);
        reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
            empleado = Convert.ToInt32(reader["cod_empleado"]);
        }
        reader.Close();
        SqlCommand cmd5 = new SqlCommand(String.Format("insert into contrato(cod_sucursal,cod_empleado,cod_jefe,cod_depto)values(" + sucursall + "," + empleado + "," +empleado+ "," + puest + ")"), conectar);
        try
        {
            cmd5.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();
        
    }
    
    public void cambiardatoscliente(int codigo,string nombre, string apellido, string telefono, string direccion, string tarjeta, string usuario, string contraseña) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(string.Format("update cliente set nombre='" + nombre + "',apellido='" + apellido + "',telefono='" + telefono + "',direccion='" + direccion+ "',tarjeta='" + tarjeta + "',usuario='" + usuario + "',contraseña='" + contraseña + "' where cod_cliente like '%{0}%'",codigo), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();
    
    
    }
    public void aceptarcliente(int codigo) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("update cliente set estado=1 where cod_cliente like '%{0}%'",codigo), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al modificar cliente", e);
        }
    }
    public void rechazarCliente(int codigo) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("update cliente set estado=2 where cod_cliente like '%{0}%'", codigo), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al modificar cliente", e);
        }
    }
    public List<string> modificarperfil(int codigo){
       
        //string select = "select limite from cliente where carnet="+carnet+"";
        List<string> lista=new List<string>();
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from cliente where cod_cliente like '%{0}%'",codigo), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
              lista.Add((string)reader["nombre"]);
              lista.Add((string)reader["apellido"]);
              lista.Add((string)reader["telefono"]);
              lista.Add((string)reader["direccion"]);
              lista.Add((string)reader["tarjeta"]);
              lista.Add((string)reader["usuario"]);
              lista.Add((string)reader["contraseña"]);

        }
       
        conectar.Close();
        return lista;
    }
    public decimal cotizar(decimal precio,int peso, int categoria) {
        decimal costo = 0m;
        decimal costof=0m;
        int ganancia = 0;
        int categorias = 0;
        int aduana = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select top 1 * from ganancia order by cod_ganancia desc"), conectar);
        SqlCommand cmd2 = new SqlCommand(String.Format("Select top 1 * from aduana order by cod_aduana desc"), conectar);
        SqlCommand cmd3 = new SqlCommand(String.Format("Select porcentaje from categoria where cod_categoria like '%{0}%'",categoria), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ganancia = Convert.ToInt32(reader["porcentaje"]);
        }
        reader.Close();
        reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
            if (Convert.ToInt32(reader["estado"]) == 0)
            {
                aduana = Convert.ToInt32(reader["porcentaje"]);
            }
        }
        reader.Close();
        reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            categorias = Convert.ToInt32(reader["porcentaje"]);
        }
        conectar.Close();
        costo = peso * aduana + (categorias* precio)/100;
        costof=costo*ganancia/100+costo;
        return costof;
    }
    
    public int  crearpedido(int cod_cliente,int sucursal,string fecha) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        int pedido=0;
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("insert into pedido (cod_casilla,cod_lote,cod_sucursal,fecha,estado,busqueda) values ("+cod_cliente+",1,"+sucursal+",'"+fecha+"','pendiente',0)"), conectar);
        SqlCommand cmd2 = new SqlCommand(String.Format("Select top 1 * from pedido order by cod_pedido desc"), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e) {
            throw new Exception("Error al insertar pedido", e);
        }
        SqlDataReader reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
             pedido= Convert.ToInt32(reader["cod_pedido"]);
        }
        conectar.Close();
        return pedido;
    }
    public void agregarLote(int lote,int sucursal,string fecha,string estado ) {
        string insert = "insert into  lote (cod_lote,cod_sucursal,fecha,estado)values(" + lote + "," + sucursal + ",'" + fecha + "','" + estado + "')";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();
    
    
    }
    public void AgregarAlPedido(string nombre,int peso,decimal precio,int categoria,int pedido,decimal envio) {
        string insert = "insert into  paquete (nombre,peso,precio,cod_categoria,cod_pedido,envio)values('" + nombre + "'," + peso + "," + precio + "," + categoria + "," + pedido + ","+envio+")";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar registro", e);
        }
        conectar.Close();
    
    
    }
    public decimal facturar(int pedido,int empleado) {
        int ganancia = 0;
        int aduana = 0;
        decimal total = 0m;
        int codganancia = 0;
        int codaduana = 0;
        
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        
        SqlCommand cmd2 = new SqlCommand(String.Format("Select top 1 * from ganancia order by cod_ganancia desc"), conectar);
        SqlCommand cmd3 = new SqlCommand(String.Format("Select top 1 * from aduana order by cod_aduana desc"), conectar);
        SqlCommand cmd4 = new SqlCommand(String.Format("Select * from paquete where cod_pedido like '%{0}%'",pedido), conectar);
        
        conectar.Open();
        SqlDataReader reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
            if (Convert.ToInt32(reader["estado"]) == 0)
            {
                ganancia = Convert.ToInt32(reader["porcentaje"]);
                codganancia = Convert.ToInt32(reader["cod_ganancia"]);
            }
        }
        reader.Close();
        reader = cmd3.ExecuteReader();
        while (reader.Read())
        {
            if (Convert.ToInt32(reader["estado"]) == 0)
            {
                aduana = Convert.ToInt32(reader["porcentaje"]);
                codaduana = Convert.ToInt32(reader["cod_aduana"]);
            }
        }
        reader.Close();
        reader = cmd4.ExecuteReader();
        while (reader.Read())
        {
            //if (Convert.ToInt32(reader["estado"]) == 0)
            //{
            total = total + Convert.ToDecimal(reader["envio"]);
            //}
        }
        total = total * ganancia / 100 + total;
        reader.Close();
        string insert = "insert into factura(cod_pedido,cod_empleado,cod_ganancia,cod_aduana,total) values(" + pedido + "," + empleado + "," + codganancia + "," + codaduana + "," + total + " )";
        SqlCommand cmd = new SqlCommand(insert, conectar);
        try { 
            cmd.ExecuteNonQuery();
            //cmd5.ExecuteNonQuery();
        }catch(Exception e){
            throw new Exception("Error al insertar registro", e);
        }
        SqlCommand cmd5 = new SqlCommand(String.Format("update pedido set estado='entregado' where cod_pedido like '%{0}%'", pedido), conectar);
        try
        {
            cmd5.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al modificar estado", e);
        }
        conectar.Close();
        return total;
    
    }
    public Boolean TienenFactura(int pedido) {
        int codigo = 0;
        //string select = "select limite from cliente where carnet="+carnet+"";
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("Select * from factura where cod_pedido like '%{0}%'",pedido), conectar);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            codigo = Convert.ToInt32(reader["cod_factura"]);
        }
        conectar.Close();
        if (codigo != 0)
        {
            return true;
        }
        else {
            return false;
        }
        
    }
    public void devolver(int pedido) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd5 = new SqlCommand(String.Format("update pedido set estado='devuelto' where cod_pedido like '%{0}%'",pedido), conectar);
        try
        {
            cmd5.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al modificar estado", e);
        }
        conectar.Close();
            
    
    }
    public int getcasilla(string nombre) {
        int codigo = 0;
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd5 = new SqlCommand(String.Format("select * from cliente where nombre like '%{0}%'",nombre), conectar);
        SqlDataReader reader=cmd5.ExecuteReader();
        while(reader.Read()){
            codigo = Convert.ToInt32(reader["cod_cliente"]);
        }
        return codigo;
    }

    public void CargarArchivo(string direccion) {
        Boolean ban = true;
        string linea = "";
        char[] delimitadores = {','};
        string[] registro;
        string[] columna;
        StreamReader leer=new StreamReader(direccion);
        List<string> lista = new List<string>();
        while(!leer.EndOfStream){
            linea = leer.ReadLine();
            if (ban)
            {
                columna = linea.Split(delimitadores);
                ban=false;
            }
            else {
                registro = linea.Split(delimitadores);
                string porcentaje=registro[1];
                int porcentajes=Convert.ToInt32(porcentaje);
                string insert = "insert into categoria (nombre,porcentaje)values('"+registro[0]+"',"+porcentajes+")";
                string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
                SqlConnection conectar = new SqlConnection(enlace);
                conectar.Open();
                SqlCommand cmd = new SqlCommand(insert, conectar);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar registro", e);
                }
                conectar.Close();
            }


        }
    
    }
    
    public void CargarArchivoDirector(string direccion)
    {
        Operaciones accion = new Operaciones();
        Boolean ban=true;
        string linea = "";
        char[] delimitadores = { ',' };
        string[] registro;
        string[] columna;
        StreamReader leer = new StreamReader(direccion);
        List<string> lista = new List<string>();
        while (!leer.EndOfStream)
        {
            linea = leer.ReadLine();
            if (ban)
            {
                columna = linea.Split(delimitadores);
                ban = false;
            }
            else
            {
                registro = linea.Split(delimitadores);
                decimal sueldo=Convert.ToInt32(registro[2]);
                if (registro[4].Equals("Servicio al cliente")) {
                    registro[4] = "servicio";
                }else if (registro[4].Equals("Registro"))
                {
                    registro[4] = "importaciones";
                }
                accion.contratarDirector(registro[1],registro[0],sueldo,"000","000",registro[4],registro[1],registro[0],registro[3]);
            }


        }
    }
    public void CargarArchivoPaquetes(string direccion,int sucursal) {
        Operaciones accion = new Operaciones();
        Boolean ban = true;
        string linea = "";
        char[] delimitadores = { ',' };
        string[] registro;
        string[] columna;
        StreamReader leer = new StreamReader(direccion);
        List<string> lista = new List<string>();
        while (!leer.EndOfStream)
        {
            linea = leer.ReadLine();
            if (ban)
            {
                columna = linea.Split(delimitadores);
                ban = false;
            }
            else
            {
                registro = linea.Split(delimitadores);
                //esto es para obtener el codigo de la sucursal
                int codigo = 0;
                int codigo2 = 0;
                decimal peso = Math.Ceiling(Convert.ToDecimal(registro[2]));
                decimal precio = Convert.ToDecimal(registro[3]);
                int cliente = Convert.ToInt32(registro[1]);
                decimal costo = accion.cotizar(precio, Convert.ToInt32(peso), codigo);
                string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
                SqlConnection conectar = new SqlConnection(enlace);
                conectar.Open();
                SqlCommand cmd5 = new SqlCommand(String.Format("select * from categoria where nombre like '%{0}%'",registro[0]), conectar);
                SqlDataReader reader = cmd5.ExecuteReader();
                while (reader.Read())
                {
                    codigo = Convert.ToInt32(reader["cod_categoria"]);
                }
                reader.Close();
                
                //fin de la busqueda del codigo de la sucursal
                accion.crearpedido(cliente, sucursal, "2015/06/10");
                //esto es para obtener el codigo del pedido
                SqlCommand cmd55 = new SqlCommand(String.Format("Select top 1 * from pedido order by cod_pedido desc"), conectar);
                reader = cmd55.ExecuteReader();
                while (reader.Read())
                {
                    codigo2 = Convert.ToInt32(reader["cod_pedido"]);
                }
                //fin de la busqueda del codigo del pedido
                accion.AgregarAlPedido("paquete",Convert.ToInt32(peso),precio,codigo,codigo2,costo);
            }


        }
    }

    public void CargarArchivoEmpleado(string direccion,int sucursal,int jefe) {
        Operaciones accion = new Operaciones();
        Boolean ban = true;
        string linea = "";
        char[] delimitadores = { ',' };
        string[] registro;
        string[] columna;
        StreamReader leer = new StreamReader(direccion);
        List<string> lista = new List<string>();
        while (!leer.EndOfStream)
        {
            linea = leer.ReadLine();
            if (ban)
            {
                columna = linea.Split(delimitadores);
                ban = false;
            }
            else
            {
                registro = linea.Split(delimitadores);
                decimal sueldo = Convert.ToInt32(registro[2]);
                accion.Contratar(registro[1], registro[0], sueldo, "000", "000", registro[4], registro[1], registro[0],sucursal ,jefe);
            }


        }
    }
    public void InicarBusquedaEnBodega() {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        
        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("update pedido set busqueda=0 "), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar pedido", e);
        }
        
        conectar.Close();
    
    }
    public void ModificarBusquedaEnBodega(int pedido) {
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";

        SqlConnection conectar = new SqlConnection(enlace);
        conectar.Open();
        SqlCommand cmd = new SqlCommand(String.Format("update pedido set busqueda=1 where cod_pedido like '%{0}%'",pedido), conectar);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception("Error al insertar pedido", e);
        }

        conectar.Close();
    }
    public int CompararBodega(string direccion) {
        Operaciones accion = new Operaciones();
        Boolean ban = true;        
        int codpedido = 0;
        string linea = "";
        char[] delimitadores = { ',' };
        string[] registro;
        string[] columna;
        int cod_pedido = 0;
        accion.InicarBusquedaEnBodega();
        StreamReader leer = new StreamReader(direccion);
        
        List<string> lista = new List<string>();
        while (!leer.EndOfStream)
        {
            linea = leer.ReadLine();
            if (ban)
            {
                columna = linea.Split(delimitadores);
                ban = false;
             
            }
            else
            {
                
                registro = linea.Split(delimitadores);
                cod_pedido = Convert.ToInt32(registro[0]);
                string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
                SqlConnection conectar = new SqlConnection(enlace);
                SqlCommand cmd2 = new SqlCommand(String.Format("Select * from pedido where cod_lote like '%{0}%' and cod_casilla like '%{1}%' and cod_pedido like '%{2}%'",registro[0],registro[2],registro[5]), conectar);
                conectar.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    codpedido = Convert.ToInt32(reader["cod_pedido"]);
                    accion.ModificarBusquedaEnBodega(codpedido);

                }
                reader.Close();
                conectar.Close();
                
            }

            
        }
        return cod_pedido ;
    
    
    }

    public int CompararBodegaxx(int lote,int casilla) {
        int codpedido=0;
        string enlace = @"Data source=YANNER-PC\SQLEXPRESS;Initial catalog=QUETZAL;Trusted_Connection=Yes;";
        SqlConnection conectar = new SqlConnection(enlace);
        SqlCommand cmd2 = new SqlCommand(String.Format("Select * from pedido where cod_lote like '%{0}%' and cod_casilla like '%{1}%'", lote, casilla), conectar);
        conectar.Open();
        SqlDataReader reader = cmd2.ExecuteReader();
        while (reader.Read())
        {
            codpedido = Convert.ToInt32(reader["cod_pedido"]);
            //accion.ModificarBusquedaEnBodega(codpedido);

        }
        reader.Close();
        conectar.Close();
        return codpedido;

    }
}