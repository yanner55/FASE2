Public Class analisislexico
    


    Public Sub analisar(texto As String, lista As lista, listasimbolos As listatabla, listaerror As listaerr, nombrearchivo As String)

        Dim estado As Integer = 0
        Dim contador As Integer = 0
        Dim lexema As String = ""
        Dim caracter As Char = ""
        Dim parentesisa As Char = "("
        Dim parentesisc As Char = ")"
        Dim coma As Char = ","
        Dim llavea As Char = "{"
        Dim llavec As Char = "}"
        Dim puntocoma As Char = ";"
        Dim igual As Char = "="
        Dim guion As Char = "_"
        Dim espacio As Char = " "
        Dim salto As Char = vbLf
        Dim tabular As Char = vbTab
        Dim comillas As Char = """"
        Dim apostro As Char = "'"
        Dim comentario As Char = "/"
        Dim asterisco As Char = "*"
        Dim fila As Integer = 0
        Dim col As Integer = 0
        listasimbolos.add(1, "id", "class", "reservada", "si")
        listasimbolos.add(2, "id", "private", "", "si")
        listasimbolos.add(2, "id", "public", "visibilidad", "si")
        listasimbolos.add(2, "id", "protected", "visibilidad", "si")
        listasimbolos.add(3, "id", "int", "tipo dato", "si")
        listasimbolos.add(3, "id", "String", "tipo dato", "si")
        listasimbolos.add(3, "id", "boolean", "tipo dato", "si")
        listasimbolos.add(3, "id", "char", "tipo dato", "si")
        listasimbolos.add(3, "id", "double", "tipo dato", "si")
        listasimbolos.add(7, "id", "extends", "reservada", "si")
        listasimbolos.add(19, "id", "true", "valor boolean", "si")
        listasimbolos.add(20, "id", "false", "valor boolean", "si")
        While contador < texto.Length
            caracter = texto.Chars(contador)


            Select Case estado
                Case 0
                    If caracter.Equals(parentesisa) Then
                        estado = 1


                    ElseIf caracter.Equals(parentesisc) Then
                        estado = 2


                    ElseIf caracter.Equals(coma) Then
                        estado = 3

                    ElseIf caracter.Equals(llavea) Then
                        estado = 4

                    ElseIf caracter.Equals(llavec) Then
                        estado = 5

                    ElseIf caracter.Equals(puntocoma) Then
                        estado = 6

                    ElseIf caracter.Equals(igual) Then
                        estado = 7

                    ElseIf Char.IsLetter(caracter) Then
                        estado = 8

                        lexema = ""

                    ElseIf Char.IsNumber(caracter) Then
                        estado = 9
                        lexema = ""
                    ElseIf caracter.Equals(comillas) Then

                        estado = 12
                        lexema = ""
                        lexema = lexema & caracter
                        contador = contador + 1
                    ElseIf caracter.Equals(apostro) Then
                        estado = 14
                        lexema = ""
                        lexema = lexema & caracter
                        contador = contador + 1
                    ElseIf caracter.Equals(comentario) Then
                        estado = 16
                        lexema = ""
                        lexema = lexema & caracter
                        contador = contador + 1
                    ElseIf caracter.Equals(espacio) Then

                        contador = contador + 1
                    ElseIf caracter.Equals(tabular) Then

                        contador = contador + 1
                    ElseIf caracter.Equals(salto) Then

                        contador = contador + 1
                        fila = fila + 1
                        col = 0
                    Else

                        listaerror.add(21, "caracter", caracter, "invalido", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        contador = contador + 1
                        col = col + 1
                    End If


                Case 1
                    lista.add(11, "parentesis", caracter, "abierto", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    contador = contador + 1
                    col = col + 1
                    estado = 0

                Case 2
                    lista.add(12, "parentesis", caracter, "cerrado", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    contador = contador + 1
                    col = col + 1
                    estado = 0


                Case 3
                    lista.add(13, "coma", caracter, "separador", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    caracter = ""
                    contador = contador + 1
                    col = col + 1
                    estado = 0
                Case 4
                    lista.add(8, "llave", caracter, "abierta", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    caracter = ""
                    estado = 0
                    contador = contador + 1
                    col = col + 1
                Case 5
                    lista.add(9, "llave", caracter, "cerrada", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    caracter = ""
                    estado = 0
                    contador = contador + 1
                    col = col + 1
                Case 6
                    lista.add(10, "puntocoma", caracter, "fin comando", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    caracter = ""
                    estado = 0
                    contador = contador + 1
                    col = col + 1
                Case 7
                    lista.add(14, "igual", caracter, "asignacion", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    caracter = ""
                    estado = 0
                    contador = contador + 1
                    col = col + 1
                Case 8

                    If Char.IsLetter(caracter) Or Char.IsNumber(caracter) Or caracter.Equals(guion) Then

                        contador = contador + 1
                        lexema = lexema & caracter
                        col = col + 1
                    Else

                        listasimbolos.comparar(lexema)

                        If listasimbolos.lexema.Equals(String.Empty) Then
                            lista.add(4, "id", lexema, "variable", "no", "fila: " & fila & "col: " & col, nombrearchivo)

                            lexema = ""
                        Else
                            lista.add(listasimbolos.no, listasimbolos.token, lexema, listasimbolos.descripcion, listasimbolos.reservada, "fila: " & fila & "col: " & col, nombrearchivo)

                            lexema = ""
                        End If
                        estado = 0

                    End If
                Case 9
                    If Char.IsNumber(caracter) Then
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    ElseIf caracter = "." Then

                        estado = 10
                        contador = contador + 1
                        col = col + 1
                        lexema = lexema & caracter
                    Else
                        lista.add(5, "numero", lexema, "entero", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case 10
                    If Char.IsNumber(caracter) Then
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                        estado = 11
                    Else
                        listaerror.add(6, "numero", lexema, "decimal", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case 11
                    If Char.IsNumber(caracter) Then
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    Else
                        estado = 0
                        lista.add(6, "numero", lexema, "decimal", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        lexema = ""
                    End If
                Case 12

                    If caracter.Equals(comillas) Then
                        estado = 13
                        lexema = lexema & caracter
                    ElseIf caracter.Equals(salto) Then
                        listaerror.add(15, "cadena", lexema, "string", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        fila = fila + 1
                        col = 0
                        estado = 0
                    Else
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    End If

                Case 13

                    lista.add(15, "cadena", lexema, "string", "no", "fila: " & fila & "col: " & col, nombrearchivo)

                    estado = 0
                    lexema = ""
                    contador = contador + 1
                Case 14
                    If caracter.Equals(apostro) Then
                        estado = 15
                        lexema = lexema & caracter
                    ElseIf caracter.Equals(salto) Then
                        listaerror.add(15, "cadena", lexema, "string", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        fila = fila + 1
                        col = 0
                        estado = 0
                    Else
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    End If

                Case 15
                    lista.add(16, "cadena", lexema, "char", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                    estado = 0
                    lexema = ""
                    contador = contador + 1
                Case 16

                    If caracter.Equals(asterisco) Then
                        estado = 17
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    ElseIf caracter.Equals(comentario) Then
                        estado = 18
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    Else
                        listaerror.add(17, "comentario", lexema, "linea,multilinea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case 17
                    If caracter.Equals(asterisco) Then
                        estado = 19
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    Else
                        listaerror.add(18, "comentario", lexema, "multilinea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case 18
                    If caracter.Equals(salto) Then
                        lista.add(17, "comentario", lexema, "linea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        contador = contador + 1
                        col = col + 1
                        lexema = ""
                    Else
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    End If
                Case 19
                    lexema = lexema & caracter
                    contador = contador + 1
                    col = col + 1
                    If caracter.Equals(asterisco) Then
                        estado = 21
                    ElseIf caracter.Equals(salto) Then
                        fila = fila + 1
                        col = 0
                    End If

                Case 20

                Case 21
                    If caracter.Equals(asterisco) Then
                        estado = 22
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                    Else
                        listaerror.add(18, "comentario", lexema, "multilinea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case 22
                    If caracter.Equals(comentario) Then
                        lexema = lexema & caracter
                        contador = contador + 1
                        col = col + 1
                        lista.add(18, "comentario", lexema, "multilinea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    Else
                        listaerror.add(18, "comentario", lexema, "multilinea", "no", "fila: " & fila & "col: " & col, nombrearchivo)
                        estado = 0
                        lexema = ""
                    End If
                Case Else

            End Select


        End While

    End Sub

End Class
