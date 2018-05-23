Module ConvertNumberLetter
    Public Function ConvertirNumeroLetros(ByVal Valor As Decimal)
        Dim numero(9), fraccion(2), entero, casillas, i, j As Integer
        Dim CienMillo, deci, decim, Millo, centanamil, Unidec, unidecmil, centena As String
        Dim completo As Double
        Dim ResultadoCambio As String

        entero = Int(Valor)
        completo = CDbl(Valor)
        deci = Format((completo - entero), "#.00")

        'El limite fue rebalsado solo se permiten valores menores a 999,999,999

        casillas = CStr(entero).Length
        j = 0
        For i = casillas - 1 To 0 Step -1
            j = j + 1
            numero(j) = CInt(CStr(entero).Substring(i, 1))
        Next i
        For i = (casillas + 1) To 9
            numero(i) = 0
        Next i
        For i = 1 To 2
            fraccion(i) = CInt(CStr(deci).Substring(i, 1))
        Next i
        Unidec = Conver((numero(1)), (numero(2)))
        centena = ConvCent((numero(3)))
        If centena = "Ciento " And Unidec = "" Then
            centena = "Cien "
        End If
        unidecmil = Conver((numero(4)), (numero(5)))
        If unidecmil <> "" Then
            If unidecmil = "Uno" Then
                unidecmil = "Un mil "
            Else
                If numero(4) = 1 Then

                    unidecmil = unidecmil.Substring(0, unidecmil.Length - 1) & " mil "
                Else
                    unidecmil = unidecmil & " mil "
                End If

            End If
        End If
        centanamil = ConvCent((numero(6)))
        If centanamil = "Ciento " And unidecmil = "" Then
            centanamil = "Cien mil "
        Else
            If centanamil <> "" And unidecmil = "" Then
                centanamil = centanamil & " mil "
            End If
        End If
        Millo = Conver((numero(7)), (numero(8)))
        If Millo <> "" Then
            If Millo = "Uno" Then
                Millo = "Un Millon "
            Else
                If numero(7) = 1 Then
                    Millo = Millo.Substring(0, Millo.Length - 1) & " Milloes "
                Else
                    Millo = Millo & " Millones "
                End If

            End If

        End If
        CienMillo = ConvCent((numero(9)))
        If CienMillo = "Ciento " And Millo = "" Then
            CienMillo = "Cien Millones "
        End If
        If deci <> "0" Then
            decim = Conver((fraccion(2)), (fraccion(1)))
            If decim <> "" Then
                decim = " Con " & decim
            Else
                decim = " Netos"
            End If
        Else
            decim = ""
        End If
        'Diseñado por Victor Hugo Cardenas
        ResultadoCambio = CienMillo & Millo & centanamil & unidecmil & centena & Unidec & decim
        If ResultadoCambio = "" Then
            ResultadoCambio = "Cero"
        End If


        Return ResultadoCambio
    End Function

    Private Function Conver(ByVal ValorUno As Integer, ByVal ValorDos As Integer) As String
        Dim unidad, decena As String
        Dim grupo1 As Integer
        Dim ResConver As String
        grupo1 = CInt(ValorDos & ValorUno)

        Select Case grupo1
            Case 11
                ResConver = "Once"
            Case 12
                ResConver = "Doce"
            Case 13
                ResConver = "Trece"
            Case 14
                ResConver = "Catorce"
            Case 15
                ResConver = "Quince"
            Case Else
                Select Case ValorUno
                    Case 0
                        unidad = ""
                    Case 1
                        unidad = "Uno"
                    Case 2
                        unidad = "Dos"
                    Case 3
                        unidad = "Tres"
                    Case 4
                        unidad = "Cuatro"
                    Case 5
                        unidad = "Cinco"
                    Case 6
                        unidad = "Seis"
                    Case 7
                        unidad = "Siete"
                    Case 8
                        unidad = "Ocho"
                    Case 9
                        unidad = "Nueve"
                    Case Else
                        unidad = ""
                End Select
                Select Case ValorDos
                    Case 0
                        decena = ""
                    Case 1
                        decena = "Diez"
                    Case 2
                        If ValorUno <> 0 Then
                            decena = "Veinti"
                        Else
                            decena = "Veinte "
                        End If
                    Case 3
                        decena = "Treinta"
                    Case 4
                        decena = "Cuarenta"
                    Case 5
                        decena = "Cincuenta"
                    Case 6
                        decena = "Sesenta"
                    Case 7
                        decena = "Setenta"
                    Case 8
                        decena = "Ochenta"
                    Case 9
                        decena = "Noventa"
                    Case Else
                        decena = ""
                End Select
                If ValorUno = 0 Then
                    ResConver = decena & unidad
                Else
                    If ValorDos = 0 Then
                        ResConver = unidad
                    Else
                        If ValorDos = 2 Then
                            ResConver = decena & unidad
                        Else
                            ResConver = decena & " y " & unidad
                        End If
                    End If
                End If

        End Select
        Return ResConver
    End Function
    Private Function ConvCent(ByVal Valor As Integer) As String
        'Diseñado por Victor Hugo Cardenas
        Dim ResConvCent As String
        Select Case Valor
            Case 0
                ResConvCent = ""
            Case 1
                ResConvCent = "Ciento "
            Case 2
                ResConvCent = "Docientos "
            Case 3
                ResConvCent = "Trecientos "
            Case 4
                ResConvCent = "Cuatrocientos "
            Case 5
                ResConvCent = "Quinientos "
            Case 6
                ResConvCent = "Seis cientos "
            Case 7
                ResConvCent = "Setecientos "
            Case 8
                ResConvCent = "Ochocientos "
            Case 9
                ResConvCent = "Novecientos "
            Case Else
                ResConvCent = ""
        End Select
        Return ResConvCent
    End Function
End Module
