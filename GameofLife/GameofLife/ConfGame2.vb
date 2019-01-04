Imports System.ComponentModel
Imports System.IO

Public Class ConfGame2
    Dim calculationText As String
    Dim cvivo As Boolean
    Private Sub nudVelocidad_ValueChanged(sender As Object, e As EventArgs) Handles nudVelocidad.ValueChanged
        G2.tiTiempo.Interval = nudVelocidad.Value
        G2.tiTurmite.Interval = nudVelocidad.Value
    End Sub

    Private Sub nudAncho_ValueChanged(sender As Object, e As EventArgs) Handles nudAncho.ValueChanged
        ancho = nudAncho.Value
    End Sub

    Private Sub nudLimY_ValueChanged(sender As Object, e As EventArgs) Handles nudLimY.ValueChanged
        Limy = nudLimY.Value
    End Sub

    Private Sub nudLimX_ValueChanged(sender As Object, e As EventArgs) Handles nudLimX.ValueChanged
        Limx = nudLimX.Value
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        'For i = 1 To Limy
        'For j = 1 To Limx
        'bmatrizsig(i, j) = bmatriz(i, j)
        'Next
        'Next

        activo = True
        G2.tiTiempo.Enabled = True
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        activo = False
    End Sub

    Private Sub btnLimpiarMatriz_Click(sender As Object, e As EventArgs) Handles btnLimpiarMatriz.Click
        For i = 1 To Limy
            For j = 1 To Limx
                bmatriz(i, j) = False
            Next
        Next
    End Sub

    Private Sub btnDibujaMatriz_Click(sender As Object, e As EventArgs) Handles btnDibujaMatriz.Click
        For i = 1 To Limy
            'pintalinea(i, 1, i, Limx)
            For j = 1 To Limx
                pintacuadro(i, j, bmatriz(i, j))
            Next
        Next

        For i = 1 To Limy
            pintalinea(i, 1, i, Limx)
        Next
        For j = 1 To Limx
            pintalinea(1, j, Limy, j)
        Next
    End Sub

    Private Sub ConfGame2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablero = Graphics.FromHwnd(G2.Handle)
    End Sub

    Private Sub ConfGame2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'G2.Close()
    End Sub

    Private Sub cbBorrarPasar_CheckedChanged(sender As Object, e As EventArgs) Handles cbBorrarPasar.CheckedChanged
        borraralpasar = cbBorrarPasar.Checked
    End Sub

    Private Sub cbTipoJuego_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoJuego.SelectedIndexChanged
        tipodeJuego = cbTipoJuego.SelectedIndex
    End Sub

    Private Sub llblFormasBasicas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblFormasBasicas.LinkClicked
        Dim fileName As String
        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog() '// make a new dialog'
        If openDlg.ShowDialog() = DialogResult.OK Then
            '// the user clicked OK'
            fileName = openDlg.FileName
            calculationText = File.ReadAllText(fileName)
            Dim numeros() As String
            numeros = calculationText.Split(" ")

            Limybas = CInt(numeros(0))
            Limxbas = CInt(numeros(1))
            xbas = 1
            ybas = 1
            For i = 2 To numeros.Length - 1
                formasbasicas(ybas, xbas) = CBool(numeros(i))
                xbas += 1
                If xbas = Limxbas + 1 Then
                    xbas = 1
                    ybas += 1
                End If
            Next
            Dim ulti() As String
            ulti = fileName.Split("\")
            lblFbasica.Text = ulti(ulti.Length - 1)
        End If

    End Sub

    Private Sub cbTurDir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTurDir.SelectedIndexChanged
        turDir = cbTurDir.SelectedIndex * 2
    End Sub

    Private Sub nudTurEstado_ValueChanged(sender As Object, e As EventArgs) Handles nudTurEstado.ValueChanged
        turEstado = nudTurEstado.Value
    End Sub

    Private Sub nudTurY_ValueChanged(sender As Object, e As EventArgs) Handles nudTurY.ValueChanged
        TurY = nudTurY.Value
    End Sub

    Private Sub nudTurX_ValueChanged(sender As Object, e As EventArgs) Handles nudTurX.ValueChanged
        TurX = nudTurX.Value
    End Sub

    Private Sub btnTurComenzar_Click(sender As Object, e As EventArgs) Handles btnTurComenzar.Click
        turActiva = True
        G2.tiTurmite.Enabled = True
    End Sub

    Private Sub btnTurDetener_Click(sender As Object, e As EventArgs) Handles btnTurDetener.Click
        turActiva = False
    End Sub

    Private Sub llblTurmitas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblTurmitas.LinkClicked
        Dim fileName As String
        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog() '// make a new dialog'
        If openDlg.ShowDialog() = DialogResult.OK Then
            '// the user clicked OK'
            fileName = openDlg.FileName
            calculationText = File.ReadAllText(fileName)
            Dim numeros() As String
            numeros = calculationText.Split(" ")

            turSigcolor(0, 0) = CBool(numeros(0))
            turSiggiro(0, 0) = CInt(numeros(1))
            turSigestado(0, 0) = CBool(numeros(2))

            turSigcolor(1, 0) = CBool(numeros(6))
            turSiggiro(1, 0) = CInt(numeros(7))
            turSigestado(1, 0) = CBool(numeros(8))

            turSigcolor(0, 1) = CBool(numeros(3))
            turSiggiro(0, 1) = CInt(numeros(4))
            turSigestado(0, 1) = CBool(numeros(5))

            turSigcolor(1, 1) = CBool(numeros(9))
            turSiggiro(1, 1) = CInt(numeros(10))
            turSigestado(1, 1) = CBool(numeros(11))


            'turSigestado(0, 0) = 0
            'turSigestado(0, 1) = 1

            'turSigestado(1, 0) = 1
            'turSigestado(1, 1) = 1
            'Limybas = CInt(numeros(0))
            'Limxbas = CInt(numeros(1))
            'xbas = 1
            'ybas = 1
            'For i = 2 To numeros.Length - 1
            'formasbasicas(ybas, xbas) = CBool(numeros(i))
            'xbas += 1
            'If xbas = Limxbas + 1 Then
            'xbas = 1
            'ybas += 1
            'End If
            '   Next
            Dim ulti() As String
            ulti = fileName.Split("\")
            lblTurArch.Text = ulti(ulti.Length - 1)
        End If
    End Sub

    Private Sub rbNegro_CheckedChanged(sender As Object, e As EventArgs) Handles rbNegro.CheckedChanged
        If rbNegro.Checked = True Then
            cvivo = True
        End If
    End Sub

    Private Sub rbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlanco.CheckedChanged
        If rbBlanco.Checked = True Then
            cvivo = False
        End If
    End Sub

    Private Sub cbFondo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFondo.SelectedIndexChanged
        If cvivo = True Then
            cambiacfondo(negro, cbFondo.SelectedIndex)
        Else
            cambiacfondo(blanco, cbFondo.SelectedIndex)
        End If
    End Sub

    Private Sub cambiacfondo(ByRef c As Brush, ByVal n As Integer)
        Select Case n
            Case 0
                c = Brushes.Black
            Case 1
                c = Brushes.White
            Case 2
                c = Brushes.Azure
            Case 3
                c = Brushes.Beige
            Case 4
                c = Brushes.Blue
            Case 5
                c = Brushes.Green
            Case 6
                c = Brushes.Pink
        End Select
    End Sub
End Class