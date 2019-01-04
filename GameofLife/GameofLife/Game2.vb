Imports System.ComponentModel

Public Class Game2
    Dim TurConta As Integer
    Private Sub obtenercoordenadas()
        Dim x, y As Integer
        x = MousePosition.X - Me.Location.X - 30
        y = MousePosition.Y - Me.Location.Y - 45
        posx = convertir(x)
        posy = convertir(y)
        If posx <= 0 Then posx = 1
        If posy <= 0 Then posy = 1
    End Sub

    Private Sub Game2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Label1.Text = (-Me.Location.X + MousePosition.X) & "  " & (-Me.Location.Y + MousePosition.Y) & " " & esta
        'Label1.Text = CInt(x / 20 + 0.5) & " " & x
        If rayar = True Then
            obtenercoordenadas()
            If posx <> posanx Or posy <> posany Then
                If borraralpasar = True Then
                    pintacuadro(posy, posx, Not bmatriz(posy, posx))
                    bmatriz(posy, posx) = Not bmatriz(posy, posx)
                Else
                    pintacuadro(posy, posx, True)
                    bmatriz(posy, posx) = True
                End If

                posanx = posx
                posany = posy
            End If
        End If
    End Sub

    Private Sub Game2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        rayar = True
    End Sub

    Private Sub Game2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        rayar = False
    End Sub

    Private Sub tiTiempo_Tick(sender As Object, e As EventArgs) Handles tiTiempo.Tick
        If activo = False Then tiTiempo.Enabled = False
        Dim contador As Integer
        For i = 1 To Limy
            For j = 1 To Limx
                contador = cuentavecinos(i, j)
                If bmatriz(i, j) = True Then
                    If regla(True, contador) = False Then
                        bmatrizsig(i, j) = False
                        pintacuadro(i, j, False)
                    Else
                        bmatrizsig(i, j) = True
                    End If
                Else
                    If regla(False, contador) = True Then
                        bmatrizsig(i, j) = True
                        pintacuadro(i, j, True)
                    Else
                        bmatrizsig(i, j) = False
                    End If
                End If
            Next
        Next

        For i = 1 To Limy
            For j = 1 To Limx
                bmatriz(i, j) = bmatrizsig(i, j)
            Next
        Next
        iteraciones += 1
        CG2.lblIter.Text = iteraciones
    End Sub

    Private Sub Game2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CG2.Close()
    End Sub

    Private Sub Game2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        'MsgBox("hola")
        obtenercoordenadas()
        xbas = posx
        ybas = posy
        For i = 1 To Limybas
            For j = 1 To Limxbas
                pintacuadro(i + ybas - 1, j + xbas - 1, formasbasicas(i, j))
                bmatriz(i + ybas - 1, j + xbas - 1) = formasbasicas(i, j)
            Next
        Next
    End Sub

    Private Sub Game2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        obtenercoordenadas()
        CG2.nudTurY.Value = posy
        CG2.nudTurX.Value = posx
        'TurX = posx
        'TurY = posy
    End Sub

    Private Function CE(ByVal b As Boolean) As Integer
        If b = True Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub tiTurmite_Tick(sender As Object, e As EventArgs) Handles tiTurmite.Tick
        If turActiva = False Then tiTurmite.Enabled = False
        'turEstado = turSigestado(turEstado, turColor)
        Select Case turSiggiro(CE(turEstado), CE(bmatriz(TurY, TurX)))
            Case 8
                turDir = (turDir + 6) Mod 8
            Case 2
                turDir = (turDir + 2) Mod 8
            Case 4
                turDir = (turDir + 4) Mod 8
            Case 1

        End Select
        turColor = turSigcolor(CE(turEstado), CE(bmatriz(TurY, TurX)))
        pintacuadro(TurY, TurX, turColor)
        turEstado = turSigestado(CE(turEstado), CE(bmatriz(TurY, TurX)))
        bmatriz(TurY, TurX) = turColor
        Select Case turDir
            Case 0
                TurY -= 1
            Case 2
                TurX += 1
            Case 4
                TurY += 1
            Case 6
                TurX -= 1
        End Select



        If TurX < 1 Or TurX > Limx Or TurY < 1 Or TurY > Limy Then
            'MsgBox("Se murio")
            turActiva = False
        End If
        'If turSiggiro(turEstado, turColor) = 8 Then

        'End If
        TurConta += 1
        CG2.lblIteraciones.Text = TurConta
    End Sub
End Class