Public Class nodoerr

    Public siguiente As nodoerr
    Public no As Integer
    Public tokenesperado As String
    Public lexema As String
    Public descripcion As String
    Public reservada As String
    Public hubicacion As String
    Public archivo As String


    Public Sub New(ByVal no1 As Integer, ByVal token1 As String, ByVal lexema1 As String, ByVal descripcion1 As String, ByVal reserva1 As String, ByVal hubicacion1 As String, ByVal archivo1 As String)

        no = no1
        tokenesperado = token1
        lexema = lexema1
        descripcion = descripcion1
        reservada = reserva1
        hubicacion = hubicacion1
        archivo = archivo1
        siguiente = Nothing
    End Sub




End Class
