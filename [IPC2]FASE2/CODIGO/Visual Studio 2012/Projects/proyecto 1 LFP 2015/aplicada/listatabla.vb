Public Class listatabla
    Dim inicio As nodotabla
    Public no As Integer
    Public token As String
    Public lexema As String
    Public descripcion As String
    Public reservada As String

    Public Sub add(ByVal no As Integer, ByVal token As String, ByVal lexema As String, ByVal descripcion As String, ByVal reservada As String)

        If inicio IsNot Nothing Then
            Dim temp As nodotabla = inicio
            While (temp.siguiente IsNot Nothing)
                temp = temp.siguiente
            End While
            temp.siguiente = New nodotabla(no, token, lexema, descripcion, reservada)
        Else
            inicio = New nodotabla(no, token, lexema, descripcion, reservada)
        End If

    End Sub
    Public Sub imprimir()
        Dim texto As String
        Dim temp As nodotabla = inicio
        texto = String.Empty
        While temp IsNot Nothing
            texto = texto + " " + temp.no
            texto = texto + " " + temp.token
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
    Public Function comparar(texto As String) As Boolean
        no = 0
        token = String.Empty
        lexema = String.Empty
        descripcion = String.Empty
        reservada = String.Empty
        Dim temp As nodotabla
        temp = inicio
        While temp IsNot Nothing
            If temp.lexema = texto Then
                no = temp.no
                token = temp.token
                lexema = temp.lexema
                descripcion = temp.descripcion
                reservada = temp.reservada
                Return True

            End If
            temp = temp.siguiente
        End While
        Return False


    End Function
End Class
