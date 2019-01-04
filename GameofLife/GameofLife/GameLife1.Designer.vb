<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameLife1
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvGame = New System.Windows.Forms.DataGridView()
        Me.nudX = New System.Windows.Forms.NumericUpDown()
        Me.nudY = New System.Windows.Forms.NumericUpDown()
        Me.cbModo = New System.Windows.Forms.ComboBox()
        Me.btnComienza = New System.Windows.Forms.Button()
        Me.tiJuego = New System.Windows.Forms.Timer(Me.components)
        Me.nudVelocidad = New System.Windows.Forms.NumericUpDown()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.lblVel = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblIte = New System.Windows.Forms.Label()
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGame
        '
        Me.dgvGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGame.Location = New System.Drawing.Point(55, 25)
        Me.dgvGame.Name = "dgvGame"
        Me.dgvGame.Size = New System.Drawing.Size(709, 702)
        Me.dgvGame.TabIndex = 0
        '
        'nudX
        '
        Me.nudX.Location = New System.Drawing.Point(820, 652)
        Me.nudX.Name = "nudX"
        Me.nudX.Size = New System.Drawing.Size(47, 20)
        Me.nudX.TabIndex = 1
        '
        'nudY
        '
        Me.nudY.Location = New System.Drawing.Point(820, 617)
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(47, 20)
        Me.nudY.TabIndex = 2
        '
        'cbModo
        '
        Me.cbModo.FormattingEnabled = True
        Me.cbModo.Items.AddRange(New Object() {"*", "Negro"})
        Me.cbModo.Location = New System.Drawing.Point(789, 312)
        Me.cbModo.Name = "cbModo"
        Me.cbModo.Size = New System.Drawing.Size(78, 21)
        Me.cbModo.TabIndex = 3
        Me.cbModo.Text = "Modo"
        '
        'btnComienza
        '
        Me.btnComienza.Location = New System.Drawing.Point(789, 196)
        Me.btnComienza.Name = "btnComienza"
        Me.btnComienza.Size = New System.Drawing.Size(75, 23)
        Me.btnComienza.TabIndex = 4
        Me.btnComienza.Text = "Comenzar"
        Me.btnComienza.UseVisualStyleBackColor = True
        '
        'tiJuego
        '
        '
        'nudVelocidad
        '
        Me.nudVelocidad.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudVelocidad.Location = New System.Drawing.Point(820, 377)
        Me.nudVelocidad.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudVelocidad.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudVelocidad.Name = "nudVelocidad"
        Me.nudVelocidad.Size = New System.Drawing.Size(47, 20)
        Me.nudVelocidad.TabIndex = 5
        Me.nudVelocidad.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(789, 226)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 6
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        Me.btnDetener.Visible = False
        '
        'lblVel
        '
        Me.lblVel.AutoSize = True
        Me.lblVel.Location = New System.Drawing.Point(789, 353)
        Me.lblVel.Name = "lblVel"
        Me.lblVel.Size = New System.Drawing.Size(54, 13)
        Me.lblVel.TabIndex = 7
        Me.lblVel.Text = "Velocidad"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(792, 267)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(792, 434)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(13, 13)
        Me.lblContador.TabIndex = 9
        Me.lblContador.Text = "0"
        '
        'lblIte
        '
        Me.lblIte.AutoSize = True
        Me.lblIte.Location = New System.Drawing.Point(771, 404)
        Me.lblIte.Name = "lblIte"
        Me.lblIte.Size = New System.Drawing.Size(59, 13)
        Me.lblIte.TabIndex = 10
        Me.lblIte.Text = "Iteraciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 739)
        Me.Controls.Add(Me.lblIte)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblVel)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.nudVelocidad)
        Me.Controls.Add(Me.btnComienza)
        Me.Controls.Add(Me.cbModo)
        Me.Controls.Add(Me.nudY)
        Me.Controls.Add(Me.nudX)
        Me.Controls.Add(Me.dgvGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGame As DataGridView
    Friend WithEvents nudX As NumericUpDown
    Friend WithEvents nudY As NumericUpDown
    Friend WithEvents cbModo As ComboBox
    Friend WithEvents btnComienza As Button
    Friend WithEvents tiJuego As Timer
    Friend WithEvents nudVelocidad As NumericUpDown
    Friend WithEvents btnDetener As Button
    Friend WithEvents lblVel As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblContador As Label
    Friend WithEvents lblIte As Label
End Class
