using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    Operaciones accion = new Operaciones();
    public Service () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloYanner() {
        return "Hola a todos";
    }
    [WebMethod]
    public void AgregarCliente(int carnet,string nombre,string direccion, string telefono){
        accion.agregarCliente(carnet, nombre, direccion, telefono);
    }
    [WebMethod]
    public void AgregarPedido(int cod_pedido,int carnet)
    {
        accion.agregarPedido(cod_pedido,carnet);
    }
    [WebMethod]
    public void AgregarDetalle(int cod_detalle,int cod_pedido,int cod_libro)
    {
        accion.agregarDetalle(cod_detalle,cod_pedido,cod_libro);
    }
    [WebMethod]
    public void ModificarCliente(int carnet,int limite)
    {
        accion.ModificarCliente(carnet, limite);
    }
    [WebMethod]
    public void ModificarClienteDevolucion(int carnet, int limite)
    {
        accion.ModificarClienteDevolucion(carnet, limite);
    }
    [WebMethod]
    public void ModificarLibro(int codigolibro,int disponible,int prestado)
    {
        accion.ModificarLibro(codigolibro,disponible,prestado);
    }

    [WebMethod]
    public void ModificarLibroDevolucion(int codigolibro, int disponible, int prestado)
    {
        accion.ModificarLibroDevolver(codigolibro, disponible, prestado);
    }
    [WebMethod]
    public void ModificarLibroR(int codigolibro, int disponible, int reservado)
    {
        accion.ModificarLibroR(codigolibro, disponible, reservado);
    }

    [WebMethod]
    public void AgregarLibro(int codigolibro,int codigotema,int codigoautor,int existencias,int paginas,string nombre)
    {
        accion.agregarLibro(codigolibro,codigotema,codigoautor,existencias,paginas,nombre);
    }
    [WebMethod]
    public Int64 Verificar(int carnet) {
        return accion.Verificar(carnet);
    }
    [WebMethod]
    public List<Int64> VerificarLibro(int codigolibro) {
        return accion.VerificarLibro(codigolibro);
    }

    //ESTOS METODOS SON DE LA FASE 2  DEL PROYECTO DE IPC
    [WebMethod]
    public Boolean login(string usuario, string contraseña) {
        return accion.login(usuario,contraseña);
    
    }
    [WebMethod]
    public void registrar(string nombre, string apellido, int nit, string telefono, string direccion, string tarjeta, string usuario, string contraseña) {
        accion.Registrar(nombre,apellido,nit,telefono,direccion,tarjeta,usuario,contraseña);
    }
    [WebMethod]
    public Boolean loginempleado(string usuario,string contraseña) {
        return accion.loginempleado(usuario, contraseña);
    }
    [WebMethod]
    public int gettipo(string usuario, string contraseña)
    {
        return accion.gettipo(usuario,contraseña);
    }
    [WebMethod]
    public int getcodigo(string usuario,string contraseña)
    {
        return accion.getcodigo(usuario,contraseña);
    }
    [WebMethod]
    public int getcodigoempleado(string usuario, string contraseña)
    {
        return accion.getcodigoempleado(usuario, contraseña);
    }
    [WebMethod]
    public void activarcliente(int codigo)
    {
        accion.aceptarcliente(codigo);
    }
    [WebMethod]
    public void rechazarcliente(int codigo)
    {
        accion.rechazarCliente(codigo);
    }
    [WebMethod]
    public List<string> modificarperfil(int codigo) {
        return accion.modificarperfil(codigo);
    }
    [WebMethod]
    public void guardarcambiosenperfil(int codigo, string nombre, string apellido, string telefono, string direccion, string tarjeta, string usuario, string contraseña) {
        accion.cambiardatoscliente(codigo, nombre, apellido, telefono, direccion,tarjeta, usuario, contraseña);
    }
    [WebMethod]
    public decimal cotizar(decimal precio,int peso, int categoria) {
        return accion.cotizar(precio, peso, categoria);
    }
    [WebMethod]
    public int crearpedido(int cod_cliente,int sucursal,string fecha) {
        return accion.crearpedido(cod_cliente,sucursal,fecha);
    }
    [WebMethod]
    public void AgregarAlPedido(string nombre, int peso, decimal precio, int categoria, int pedido,decimal envio) {
        accion.AgregarAlPedido(nombre, peso, precio, categoria, pedido,envio);
    }
    [WebMethod]
    public void AgregarLote(int lote,int sucursal,string fecha,string estado ){
        accion.agregarLote(lote, sucursal, fecha, estado);
    }
    [WebMethod]
    public int getsucursal(int cod_empleado) {
        return accion.getsucursal(cod_empleado);
    }
    [WebMethod]
    public decimal facturar(int pedido, int empleado) {
        return accion.facturar(pedido, empleado);
    }
    [WebMethod]
    public Boolean tienefactura(int pedido) {
        return accion.TienenFactura(pedido);
    }
    [WebMethod]
    public void devolver(int pedido){
        accion.devolver(pedido);
    }
    [WebMethod]
    public int getcasilla(string nombre) {
        return accion.getcasilla(nombre);
    }
    [WebMethod]
    public string getdepartamento(int cod_empleado) {
        return accion.getdepartamento(cod_empleado);
    }
    [WebMethod]
    public int getdepartamentocodigo(int cod_empleado)
    {
        return accion.getdepartamentoCodigo(cod_empleado);
    }
    [WebMethod]
    public string contratar(string nombre, string apellido, decimal sueldo, string telefono, string direccion, string puesto, string usuario, string contraseña,int sucursal,int jefe)
    {
        return accion.Contratar(nombre,apellido,sueldo,telefono,direccion,puesto,usuario,contraseña,sucursal,jefe);
    }
    [WebMethod]
    public void cargarmasiva(string direccion) {
        accion.CargarArchivo(direccion);
    }
    [WebMethod]
    public int CompararBodega(string direccion) {
        
        return accion.CompararBodega(direccion);
    }
    [WebMethod]
    public void ContratarArchivoDirector(string direccion)
    {
        accion.CargarArchivoDirector(direccion);
    }
    [WebMethod]
    public void ContratarArchivoEmpleado(string direccion,int sucursal,int jefe) {
        accion.CargarArchivoEmpleado(direccion,sucursal,jefe);
    }
    [WebMethod]
    public void RegistrarArchivoPaquete(string direccion, int sucursal)
    {
        accion.CargarArchivoPaquetes(direccion, sucursal);
    }
}