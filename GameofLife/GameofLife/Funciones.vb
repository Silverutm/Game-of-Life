Module Funciones
    Public bModo As Boolean         '0 *    1 Negro
    Public bEstActual(105, 105) As Boolean
    Public bEstSiguiente(105, 105) As Boolean
    Public vecinosx() As Integer = {-1, 0, 1, 1, 1, 0, -1, -1}
    Public vecinosy() As Integer = {-1, -1, -1, 0, 1, 1, 1, 0}

    Public Sub cambiavalue(ByRef v As String)
        If v = "" Then
            v = "*"
        Else
            v = ""
        End If
    End Sub

    Public Sub cambiacolor(ByRef c As Color)
        If c = Color.Black Then
            c = Color.White
        Else
            c = Color.Black
        End If
    End Sub

    Public Sub cambiacell(ByRef micell As DataGridViewCell, ByVal y As Integer, ByVal x As Integer)
        bEstActual(y, x) = Not bEstActual(y, x)
        If bModo = False Then
            cambiavalue(micell.Value)
        Else
            cambiacolor(micell.Style.BackColor)
        End If
    End Sub

    Public Function cuentaamigos(ByVal y As Integer, ByVal x As Integer) As Integer
        Dim i, cont As Integer
        For i = 0 To 7
            If bEstActual(y + vecinosy(i), x + vecinosx(i)) = True Then
                cont += 1
            End If
        Next
        Return cont
    End Function

    Public Sub pinta(ByRef dgv As DataGridView, ByVal Ly As Integer, ByVal Lx As Integer)





        For y = 1 To Ly
            For x = 1 To Lx
                bEstActual(y, x) = bEstSiguiente(y, x)
                If bEstActual(y, x) = True Then
                    If bModo = False Then
                        If dgv.Rows(y - 1).Cells(x - 1).Value = "" Then dgv.Rows(y - 1).Cells(x - 1).Value = "*"
                    Else
                        If Not dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black Then
                            dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black
                        End If
                    End If
                Else
                    If bModo = False Then
                        If dgv.Rows(y - 1).Cells(x - 1).Value = "*" Then dgv.Rows(y - 1).Cells(x - 1).Value = ""
                    Else
                        If dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black Then
                            dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.White
                        End If
                    End If
                End If
                'pinta(dgvGame.Rows(i - 1).Cells(j - 1), i, j)
            Next
        Next
    End Sub

    Public Sub redibuja(ByRef dgv As DataGridView, ByVal Ly As Integer, ByVal Lx As Integer)
        If bModo = False Then
            For y = 1 To Ly
                For x = 1 To Lx
                    If dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black Then
                        dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.White
                        dgv.Rows(y - 1).Cells(x - 1).Value = "*"
                    End If
                Next
            Next
        Else
            For y = 1 To Ly
                For x = 1 To Lx
                    If dgv.Rows(y - 1).Cells(x - 1).Value = "*" Then
                        dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black
                        dgv.Rows(y - 1).Cells(x - 1).Value = ""
                    End If
                Next
            Next
        End If
    End Sub

    Public Sub borra(ByRef dgv As DataGridView, ByVal Ly As Integer, ByVal Lx As Integer)
        For y = 1 To Ly
            For x = 1 To Lx
                If dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.Black Then
                    dgv.Rows(y - 1).Cells(x - 1).Style.BackColor = Color.White
                End If
                dgv.Rows(y - 1).Cells(x - 1).Value = ""
            Next
        Next
    End Sub
End Module
