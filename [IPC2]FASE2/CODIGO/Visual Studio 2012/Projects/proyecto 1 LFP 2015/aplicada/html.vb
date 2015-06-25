Public Class html

    Dim parte1 As String = "<html>" + vbLf + "<head>" + vbLf + "<tilte>REPORTE DE TOKEN</tilte>" + vbLf + "</head>" + vbLf + "<body>" + vbLf + "<table border=1 width=100% bgcolor=blue>" + vbLf +
    "<tr bgcolor=white><td>Numero</td><td>Token</td><td>Lexema</td><td>Descripcion</td><td>Reservada</td><td>Hubicacion</td><td>Archivo</td></tr>"
    Dim parte2 As String = "</table>" + vbLf + "</body>" + vbLf + "</html>"
    Dim parte4 As String = "</table>" + vbLf + "</body>" + vbLf + "</html>"
    Dim parte3 As String = "<html>\n" + "<head>\n" + "<tilte>REPORTE DE ERRORES</tilte>\n" + "</head>\n" + "<body>\n" + "<table border=1 width=100% bgcolor=blue>\n" +
    "<tr bgcolor=white><td>Numero</td><td>Token esperado</td><td>Lexema</td><td>Descripcion</td><td>Reservada</td><td>Ubicacion</td></tr>"

    Public Sub reportetoken(lista As lista)
        Dim rutas As New ProcessStartInfo
        Dim abrir As New Process
        Dim texto As String
        Dim temp As nodo = lista.inicio
        texto = String.Empty
        Dim hubicacion As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\201314688_tok.html"
        If (My.Computer.FileSystem.FileExists(hubicacion)) Then
            My.Computer.FileSystem.DeleteFile(hubicacion)
        End If

        While temp IsNot Nothing
            texto = texto + "<tr bgcolor=blue><td>" & temp.no & "</td><td>" + temp.token & "</td><td>" + temp.lexema & "</td><td>" +
                temp.descripcion & "</td><td>" + temp.reservada & "</td><td>" + temp.hubicacion & "</td><td>" + temp.archivo & "</td><td>" + vbLf

            temp = temp.siguiente
        End While

        Dim textos As String = parte1 & texto & parte2
        My.Computer.FileSystem.WriteAllText(hubicacion, textos, True)



        rutas.FileName = hubicacion
        Try
            abrir = Process.Start(rutas)
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Public Sub REPORTEERROR(lista As listaerr)
        Dim rutas As New ProcessStartInfo
        Dim abrir As New Process
        Dim texto As String
        Dim temp As nodoerr = lista.inicio
        texto = String.Empty
        Dim hubicacion As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\201314688_err.html"
        If (My.Computer.FileSystem.FileExists(hubicacion)) Then
            My.Computer.FileSystem.DeleteFile(hubicacion)
        End If

        While temp IsNot Nothing
            texto = texto + "<tr bgcolor=blue><td>" & temp.no & "</td><td>" + temp.tokenesperado & "</td><td>" + temp.lexema & "</td><td>" +
                temp.descripcion & "</td><td>" + temp.reservada & "</td><td>" + temp.hubicacion & "</td><td>" + temp.archivo & "</td><td>" + vbLf

            temp = temp.siguiente
        End While

        Dim textos As String = parte3 & texto & parte4
        My.Computer.FileSystem.WriteAllText(hubicacion, textos, True)



        rutas.FileName = hubicacion
        Try
            abrir = Process.Start(rutas)
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
