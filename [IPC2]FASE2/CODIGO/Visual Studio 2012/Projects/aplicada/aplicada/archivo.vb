Imports System.IO
Imports System.Text.RegularExpressions

Public Class archivo
    Dim fondo As Color = Color.Green
    Public Sub escribir(conte As RichTextBox, buscar As String)

        Try
            Dim control As Integer
            While control < conte.Text.LastIndexOf(buscar)
                conte.Find(buscar, control, conte.TextLength, RichTextBoxFinds.None)
                conte.SelectionBackColor = fondo
                control = conte.Text.IndexOf(buscar, control) + 1

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub expresionregular(conte As RichTextBox, buscar As String)
        Dim patron As String = "(\s)|(\n)"
        Dim contenido() As String = Regex.Split(conte.Text, patron)
        MsgBox(contenido(0) + contenido(1) + contenido(2) + contenido(5))
        Dim inicio As Integer = 0
        'Dim contenido() As String = {
        '"hola",
        '"como",
        '"estas"
        '}

        For Each palabra As String In contenido

            If Regex.IsMatch(palabra, buscar, RegexOptions.IgnoreCase) Then
                conte.Select(INICIO, palabra.Length)
                conte.SelectionBackColor = fondo
            End If
            If palabra.Equals(" ") Then
                INICIO = INICIO
            End If
            inicio = inicio + palabra.Length
        Next


        Try


        Catch ex As Exception

        End Try
    End Sub

End Class
