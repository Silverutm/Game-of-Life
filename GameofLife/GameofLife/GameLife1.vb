Public Class GameLife1
    Dim contador As Integer

    Private Sub GameLife1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nudX.Value = dgvGame.ColumnCount
        'nudY.Value = dgvGame.RowCount

        nudX.Value = 31
        nudY.Value = 31
    End Sub

    Private Sub nudY_ValueChanged(sender As Object, e As EventArgs) Handles nudY.ValueChanged
        dgvGame.RowCount = nudY.Value
    End Sub

    Private Sub nudX_ValueChanged(sender As Object, e As EventArgs) Handles nudX.ValueChanged
        dgvGame.ColumnCount = nudX.Value
    End Sub

    Private Sub dgvGame_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGame.CellContentClick

    End Sub

    Private Sub dgvGame_MouseHover(sender As Object, e As EventArgs) Handles dgvGame.MouseHover
        'MsgBox("mouse hover")
    End Sub

    Private Sub dgvGame_Leave(sender As Object, e As EventArgs) Handles dgvGame.Leave
        'MsgBox("leave")
    End Sub

    Private Sub dgvGame_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGame.CellLeave
        'dgvGame.CurrentCell.Value = "*"
        'dgvGame.CurrentCell.Style.BackColor = Color.Black
        Dim x, y As Integer
        x = dgvGame.CurrentCell.ColumnIndex
        y = dgvGame.CurrentCell.RowIndex
        'MsgBox("x " & x & Chr(13) + Chr(10) & "y " & y)
        cambiacell(dgvGame.CurrentCell, y + 1, x + 1)
    End Sub

    Private Sub cbModo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModo.SelectedIndexChanged
        bModo = cbModo.SelectedIndex
        redibuja(dgvGame, nudY.Value, nudX.Value)
    End Sub

    Private Sub btnComienza_Click(sender As Object, e As EventArgs) Handles btnComienza.Click
        'Dim x As Integer = 1
        'MsgBox(2 <= x And x <= 4)
        'Exit Sub


        'copia()
        'MsgBox(bEstActual(4, 5))
        tiJuego.Enabled = True
        btnDetener.Visible = True
        cbModo.Enabled = False
        btnComienza.Visible = False
    End Sub

    Private Sub nudVelocidad_ValueChanged(sender As Object, e As EventArgs) Handles nudVelocidad.ValueChanged
        tiJuego.Interval = nudVelocidad.Value
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        tiJuego.Enabled = False
        btnComienza.Visible = True
        cbModo.Enabled = True
        btnDetener.Visible = False
    End Sub

    Private Sub tiJuego_Tick(sender As Object, e As EventArgs) Handles tiJuego.Tick
        Dim i, j, c As Integer
        For i = 1 To nudY.Value
            For j = 1 To nudX.Value
                c = cuentaamigos(i, j)

                If bEstActual(i, j) = True Then
                    If 2 <= c And c <= 3 Then
                        bEstSiguiente(i, j) = bEstActual(i, j)
                    Else
                        bEstSiguiente(i, j) = Not bEstActual(i, j)
                    End If
                Else
                    If c = 3 Then
                        bEstSiguiente(i, j) = True
                    Else
                        bEstSiguiente(i, j) = False
                    End If
                End If
            Next
        Next

        pinta(dgvGame, nudY.Value, nudX.Value)
        contador += 1
        lblContador.Text = contador
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        borra(dgvGame, nudY.Value, nudX.Value)
        For i = 1 To nudY.Value
            For j = 1 To nudX.Value
                bEstActual(i, j) = False
            Next
        Next
        contador = 0
        lblContador.Text = contador
    End Sub
End Class
