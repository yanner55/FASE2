
Imports System.IO



Public Class MenuPrincipal
    Dim ruta As String
    Dim TipoB As Integer
    Dim ayuda As archivo = New archivo
    Dim rutas As New ProcessStartInfo
    Dim abrir As New Process
    
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
        abrir.Filter = "Text Files|*.txt"
        abrir.Title = "Abir"


        If (abrir.ShowDialog() = DialogResult.OK) Then
            Dim Direccion As String = abrir.FileName
            Me.RichTextBox1.LoadFile(Direccion, RichTextBoxStreamType.PlainText)
        End If
        ruta = abrir.FileName


    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim guardar As New SaveFileDialog()
        Dim escribir As System.IO.StreamWriter
        guardar.Filter = "TEXT FILE|*.txt"
        guardar.CheckPathExists = True
        guardar.Title = "Guardar como"
        guardar.ShowDialog(Me)

        Try
            escribir = System.IO.File.AppendText(guardar.FileName)
            escribir.Write(RichTextBox1.Text)
            escribir.Flush()

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
                MsgBox("EL ARCHIVO FUE GUARDADO EXITOSAMENTE!!!   ")
            Catch ex As Exception

            End Try

        Else
            Dim hubicacion As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\nuevop.txt"
            My.Computer.FileSystem.WriteAllText(hubicacion, RichTextBox1.Text, True)
            MsgBox("EL ARCHIVO FUE GUARDADO EXITOSAMENTE!!!   " + ruta)


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

    Private Sub dato_TextChanged(sender As Object, e As EventArgs) Handles dato.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TipoB = 1


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TipoB = 2


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TipoB = 1 Then
            ayuda.escribir(RichTextBox1, dato.Text)

        Else
            ayuda.expresionregular(RichTextBox1, dato.Text)
        End If

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
End Class
