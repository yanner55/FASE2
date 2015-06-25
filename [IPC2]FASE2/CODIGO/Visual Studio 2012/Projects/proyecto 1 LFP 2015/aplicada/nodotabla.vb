Public Class nodotabla
    Public siguiente As nodotabla
    Public no As Integer
    Public token As String
    Public lexema As String
    Public descripcion As String
    Public reservada As String


    Public Sub New(ByVal no1 As Integer, ByVal token1 As String, ByVal lexema1 As String, ByVal descripcion1 As String, ByVal reserva1 As String)

        no = no1
        token = token1
        lexema = lexema1
        descripcion = descripcion1
        reservada = reserva1
        siguiente = Nothing
    End Sub

End Class
