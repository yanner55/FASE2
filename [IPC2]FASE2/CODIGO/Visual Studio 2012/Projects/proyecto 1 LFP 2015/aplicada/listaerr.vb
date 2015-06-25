Public Class listaerr
    Public inicio As nodoerr
    Public Sub add(ByVal no As Integer, ByVal token As String, ByVal lexema As String, ByVal descripcion As String, ByVal reservada As String, ByVal hubicacion As String, ByVal archivo As String)

        If inicio IsNot Nothing Then
            Dim temp As nodoerr = inicio
            While (temp.siguiente IsNot Nothing)
                temp = temp.siguiente
            End While
            temp.siguiente = New nodoerr(no, token, lexema, descripcion, reservada, hubicacion, archivo)
        Else
            inicio = New nodoerr(no, token, lexema, descripcion, reservada, hubicacion, archivo)
        End If

    End Sub
    Public Sub imprimir()
        Dim texto As String
        Dim temp As nodoerr = inicio
        texto = String.Empty
        While temp IsNot Nothing
            texto = texto + " " + temp.tokenesperado
            texto = texto + " " + temp.lexema
            texto = texto + " " + temp.descripcion
            texto = texto + " " + temp.reservada
            temp = temp.siguiente
        End While
        MsgBox(texto)
    End Sub
    Public Sub limpiar()
        inicio = Nothing
    End Sub
End Class
