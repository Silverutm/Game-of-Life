<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGameofLife1 = New System.Windows.Forms.Button()
        Me.btnGameofLife2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGameofLife1
        '
        Me.btnGameofLife1.Location = New System.Drawing.Point(96, 75)
        Me.btnGameofLife1.Name = "btnGameofLife1"
        Me.btnGameofLife1.Size = New System.Drawing.Size(98, 23)
        Me.btnGameofLife1.TabIndex = 0
        Me.btnGameofLife1.Text = "GameofLife 1"
        Me.btnGameofLife1.UseVisualStyleBackColor = True
        '
        'btnGameofLife2
        '
        Me.btnGameofLife2.Location = New System.Drawing.Point(96, 121)
        Me.btnGameofLife2.Name = "btnGameofLife2"
        Me.btnGameofLife2.Size = New System.Drawing.Size(98, 23)
        Me.btnGameofLife2.TabIndex = 1
        Me.btnGameofLife2.Text = "GameofLife 2"
        Me.btnGameofLife2.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGameofLife2)
        Me.Controls.Add(Me.btnGameofLife1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGameofLife1 As Button
    Friend WithEvents btnGameofLife2 As Button
End Class
