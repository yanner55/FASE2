<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Código que se ejecuta al iniciarse la aplicación

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Código que se ejecuta al cerrarse la aplicación

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Código que se ejecuta cuando se produce un error sin procesar

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Código que se ejecuta al iniciarse una nueva sesión
        Session["codigo"] = "";//para almacenar el codigo del usuario o del empleado
        Session["usuario"] = "";//para el login
        Session["contraseña"] = "";//para el login
        Session["tipo"] = "";//es el tipo de empleado para mostrar la interfaz
        Session["pedido"] = "";//este se va a usar para almacer el codigo del lote mientras se hace un pedido
        Session["sucursal"] = "";//COD_SUCURSAL
        Session["casilla"] = "";//al buscar el codigo del empleado
        Session["depto"] = "";//COD_DEPTO
        
        Session["temporal"] = "";//almacenar casilla
        Session["mostrar"] = "";// almacenar lote
        Session["temporal2"] = "";//almacenar busqueda
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Código que se ejecuta cuando finaliza una sesión. 
        // Nota: el evento Session_End se produce solamente con el modo sessionstate
        // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer
        // o SQLServer, el evento no se produce.

    }
       
</script>
