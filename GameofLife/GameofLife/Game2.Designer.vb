<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tiTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.tiTurmite = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tiTiempo
        '
        '
        'tiTurmite
        '
        Me.tiTurmite.Interval = 900
        '
        'Game2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 486)
        Me.Name = "Game2"
        Me.Text = "Game2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tiTiempo As Timer
    Friend WithEvents tiTurmite As Timer
End Class
