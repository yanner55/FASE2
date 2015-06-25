
Imports System.IO



Public Class MenuPrincipal
    Dim ruta As String
    Dim TipoB As Integer
    Dim rutas As New ProcessStartInfo
    Dim abrir As New Process
    Dim lista As New lista
    Dim listasimbolo As New listatabla
    Dim listaerror As New listaerr
    Dim analisar As New analisislexico
    Dim nombrearchivo As String = ""
    Dim programa As String = ""
    Dim reporte As html = New html()

    
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NegritaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegritaToolStripMenuItem.Click
        Try
            Dim negrita As FontDialog = New FontDialog
            negrita.Font = RichTextBox1.SelectionFont
            If negrita.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionFont = negrita.Font
            End If
        Catch ex As Exception


        End Try
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        RichTextBox1.Clear()
        Dim abrir As New OpenFileDialog
        abrir.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        abrir.Filter = "Java|*.java"
        abrir.Title = "Abir"


        If (abrir.ShowDialog() = DialogResult.OK) Then
            Dim Direccion As String = abrir.FileName
            Me.RichTextBox1.LoadFile(Direccion, RichTextBoxStreamType.PlainText)
        End If
        ruta = abrir.FileName
        Dim nombre As String = abrir.SafeFileName
        Dim aux As String = ""
        Dim ban As Boolean = True
        Dim n As Integer = 0
        Dim car As Char = "."
        While ban
            If nombre(n).Equals(car) Then
                ban = False
            Else
                aux = aux & nombre.Chars(n)
            End If
            n = n + 1
        End While
        nombrearchivo = aux
        RichTextBox1.Text = RichTextBox1.Text + vbLf
        analisar.analisar(RichTextBox1.Text, lista, listasimbolo, listaerror, nombrearchivo)
        MsgBox("La clase se analiso correctamente!!!")
        programa = programa & vbLf & abrir.SafeFileName & vbLf & RichTextBox1.Text
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim guardar As New SaveFileDialog()
        Dim escribir As System.IO.StreamWriter
        guardar.Filter = "JAVA|*.java"
        guardar.CheckPathExists = True
        guardar.Title = "Guardar como"
        guardar.ShowDialog(Me)

        Try
            escribir = System.IO.File.AppendText(guardar.FileName)
            escribir.Write(RichTextBox1.Text)
            escribir.Flush()
            escribir.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        If (My.Computer.FileSystem.FileExists(ruta)) Then
            My.Computer.FileSystem.DeleteFile(ruta)
            Dim escribir As System.IO.StreamWriter
            Try

                escribir = System.IO.File.AppendText(ruta)
                escribir.Write("")
                escribir.Write(RichTextBox1.Text)
                escribir.Flush()
                escribir.Close()
                MsgBox("EL ARCHIVO FUE GUARDADO EXITOSAMENTE!!!   ")
            Catch ex As Exception

            End Try

        Else
            'Dim hubicacion As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\nuevop.java"
            'My.Computer.FileSystem.WriteAllText(hubicacion, RichTextBox1.Text, True)
            'MsgBox("EL ARCHIVO FUE GUARDADO EXITOSAMENTE!!!   " + ruta)
            Dim guardar As New SaveFileDialog()
            Dim escribir As System.IO.StreamWriter
            guardar.Filter = "JAVA|*.java"
            guardar.CheckPathExists = True
            guardar.Title = "Guardar como"
            guardar.ShowDialog(Me)

            Try
                escribir = System.IO.File.AppendText(guardar.FileName)
                escribir.Write(RichTextBox1.Text)
                escribir.Flush()
                escribir.Close()
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        

    End Sub

    Private Sub SubrayarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EdicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdicionToolStripMenuItem.Click

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dato_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        rutas.FileName = "C:\ayuda.pdf"
        Try
            abrir = Process.Start(rutas)
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("By: Yanner Augusto Juarez Catalan      201314688")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'lista.limpiar()
        'listaerror.limpiar()
        'RichTextBox1.Text = programa
        
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        My.Computer.FileSystem.DeleteFile(ruta)
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub AbrirProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirProyectoToolStripMenuItem.Click
        lista.limpiar()
        listaerror.limpiar()
        programa = ""
        MsgBox("LISTO PARA CARGAR PROYECTO")
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        If listaerror.inicio IsNot Nothing Then
            reporte.REPORTEERROR(listaerror)
        Else
            reporte.reportetoken(lista)
        End If
        RichTextBox1.Text = programa
    End Sub
End Class
