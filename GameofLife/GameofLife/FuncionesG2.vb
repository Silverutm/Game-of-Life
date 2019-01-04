Module FuncionesG2
    Public tablero As Graphics
    'Public myRectangle As Rectangle
    'Public myPen As New Pen(Color.Blue)
    Public G2 As New Game2
    Public CG2 As New ConfGame2
    Public rayar As Boolean
    Public borraralpasar As Boolean
    Public tipodeJuego As Integer

    Public ancho As Integer = 20
    Public Limx As Integer = 100
    Public Limy As Integer = 100
    Public iteraciones As Integer = 0

    Public posx, posy, posanx, posany As Integer
    Public bmatriz(1002, 1002), bmatrizsig(1002, 1002) As Boolean

    Public negro As Brush = Brushes.Black
    Public blanco As Brush = Brushes.White

    Public activo As Boolean = False

    Public formasbasicas(100, 100) As Boolean
    Public Limxbas, Limybas, xbas, ybas As Integer


    Public Function convertir(ByVal a As Integer) As Integer
        Return CInt(a / ancho + 0.5)
    End Function

    Public Function apixel(ByVal x As Integer) As Integer
        Return (x - 1) * ancho + 20
    End Function

    Public Sub pintacuadro(ByVal y As Integer, ByVal x As Integer, ByVal col As Boolean)
        'tablero = Graphics.FromHwnd(G2.Handle)
        Dim pintura As Brush
        If col = True Then
            pintura = negro
        Else
            pintura = blanco
        End If
        tablero.FillRectangle(pintura, apixel(x), apixel(y), ancho, ancho)
    End Sub

    Public Function cuentavecinos(ByVal y As Integer, ByVal x As Integer) As Integer
        Dim i, cont As Integer
        For i = 0 To 7
            If bmatriz(y + vecinosy(i), x + vecinosx(i)) = True Then
                cont += 1
            End If
        Next
        Return cont
    End Function

    Public Sub pintalinea(ByVal y1 As Integer, ByVal x1 As Integer, ByVal y2 As Integer, ByVal x2 As Integer)
        'tablero = Graphics.FromHwnd(G2.Handle)
        Dim p1, p2 As Point
        p1.X = x1
        p1.Y = y1
        p2.X = x2
        p2.Y = y2
        tablero.DrawLine(Pens.Blue, apixel(x1), apixel(y1), apixel(x2), apixel(y2))
    End Sub

    Public Function regla(ByVal estado As Boolean, ByVal veci As Integer) As Integer
        If tipodeJuego = 0 Then
            If estado = True Then
                If veci >= 2 And veci <= 3 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If veci = 3 Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf tipodeJuego = 1
            If estado = False Then
                If veci = 3 Or veci = 6 Or veci = 7 Or veci = 8 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If veci = 3 Or veci = 4 Or veci = 6 Or veci = 7 Or veci = 8 Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf tipodeJuego = 2
            If estado = True Then
                Return True
            Else
                If veci = 3 Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf tipodeJuego = 4
            If estado = True Then
                If veci >= 2 And veci <= 3 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If veci = 3 Or veci = 6 Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf tipodeJuego = 5
            If estado = True Then
                If veci >= 1 And veci <= 2 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If veci = 1 Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf tipodeJuego = 6
            If estado = True Then
                If veci = 6 Or veci = 1 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If veci = 6 Then
                    Return True
                Else
                    Return False
                End If
            End If






        End If
        Return True
    End Function
End Module
