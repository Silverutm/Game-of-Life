<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfGame2
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
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnLimpiarMatriz = New System.Windows.Forms.Button()
        Me.nudVelocidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudLimY = New System.Windows.Forms.NumericUpDown()
        Me.btnDibujaMatriz = New System.Windows.Forms.Button()
        Me.lblIter = New System.Windows.Forms.Label()
        Me.nudLimX = New System.Windows.Forms.NumericUpDown()
        Me.lblCuadrosX = New System.Windows.Forms.Label()
        Me.lblCuadrosY = New System.Windows.Forms.Label()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.nudAncho = New System.Windows.Forms.NumericUpDown()
        Me.tbControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblFbasica = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llblFormasBasicas = New System.Windows.Forms.LinkLabel()
        Me.cbTipoJuego = New System.Windows.Forms.ComboBox()
        Me.cbBorrarPasar = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblTurArch = New System.Windows.Forms.Label()
        Me.lblTurEstado = New System.Windows.Forms.Label()
        Me.nudTurEstado = New System.Windows.Forms.NumericUpDown()
        Me.cbTurDir = New System.Windows.Forms.ComboBox()
        Me.lblTurX = New System.Windows.Forms.Label()
        Me.lblTurY = New System.Windows.Forms.Label()
        Me.nudTurX = New System.Windows.Forms.NumericUpDown()
        Me.nudTurY = New System.Windows.Forms.NumericUpDown()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblIteraciones = New System.Windows.Forms.Label()
        Me.lblIte = New System.Windows.Forms.Label()
        Me.llblTurmitas = New System.Windows.Forms.LinkLabel()
        Me.btnTurDetener = New System.Windows.Forms.Button()
        Me.btnTurComenzar = New System.Windows.Forms.Button()
        Me.cbFondo = New System.Windows.Forms.ComboBox()
        Me.rbNegro = New System.Windows.Forms.RadioButton()
        Me.rbBlanco = New System.Windows.Forms.RadioButton()
        CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLimY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLimX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudTurEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTurX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTurY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(11, 18)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(75, 23)
        Me.btnComenzar.TabIndex = 0
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(11, 61)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 1
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'btnLimpiarMatriz
        '
        Me.btnLimpiarMatriz.Location = New System.Drawing.Point(43, 233)
        Me.btnLimpiarMatriz.Name = "btnLimpiarMatriz"
        Me.btnLimpiarMatriz.Size = New System.Drawing.Size(89, 31)
        Me.btnLimpiarMatriz.TabIndex = 2
        Me.btnLimpiarMatriz.Text = "Limpiar Matriz"
        Me.btnLimpiarMatriz.UseVisualStyleBackColor = True
        '
        'nudVelocidad
        '
        Me.nudVelocidad.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudVelocidad.Location = New System.Drawing.Point(92, 310)
        Me.nudVelocidad.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudVelocidad.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudVelocidad.Name = "nudVelocidad"
        Me.nudVelocidad.Size = New System.Drawing.Size(67, 20)
        Me.nudVelocidad.TabIndex = 3
        Me.nudVelocidad.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Velocidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Iteraciones"
        '
        'nudLimY
        '
        Me.nudLimY.Location = New System.Drawing.Point(277, 305)
        Me.nudLimY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLimY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLimY.Name = "nudLimY"
        Me.nudLimY.Size = New System.Drawing.Size(67, 20)
        Me.nudLimY.TabIndex = 6
        Me.nudLimY.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnDibujaMatriz
        '
        Me.btnDibujaMatriz.Location = New System.Drawing.Point(43, 270)
        Me.btnDibujaMatriz.Name = "btnDibujaMatriz"
        Me.btnDibujaMatriz.Size = New System.Drawing.Size(116, 27)
        Me.btnDibujaMatriz.TabIndex = 7
        Me.btnDibujaMatriz.Text = "Dibujar Matriz"
        Me.btnDibujaMatriz.UseVisualStyleBackColor = True
        '
        'lblIter
        '
        Me.lblIter.AutoSize = True
        Me.lblIter.Location = New System.Drawing.Point(90, 143)
        Me.lblIter.Name = "lblIter"
        Me.lblIter.Size = New System.Drawing.Size(13, 13)
        Me.lblIter.TabIndex = 8
        Me.lblIter.Text = "0"
        '
        'nudLimX
        '
        Me.nudLimX.Location = New System.Drawing.Point(277, 339)
        Me.nudLimX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLimX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLimX.Name = "nudLimX"
        Me.nudLimX.Size = New System.Drawing.Size(67, 20)
        Me.nudLimX.TabIndex = 9
        Me.nudLimX.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblCuadrosX
        '
        Me.lblCuadrosX.AutoSize = True
        Me.lblCuadrosX.Location = New System.Drawing.Point(197, 312)
        Me.lblCuadrosX.Name = "lblCuadrosX"
        Me.lblCuadrosX.Size = New System.Drawing.Size(56, 13)
        Me.lblCuadrosX.TabIndex = 10
        Me.lblCuadrosX.Text = "Cuadros Y"
        '
        'lblCuadrosY
        '
        Me.lblCuadrosY.AutoSize = True
        Me.lblCuadrosY.Location = New System.Drawing.Point(204, 346)
        Me.lblCuadrosY.Name = "lblCuadrosY"
        Me.lblCuadrosY.Size = New System.Drawing.Size(56, 13)
        Me.lblCuadrosY.TabIndex = 11
        Me.lblCuadrosY.Text = "Cuadros X"
        '
        'lblAncho
        '
        Me.lblAncho.AutoSize = True
        Me.lblAncho.Location = New System.Drawing.Point(29, 351)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(38, 13)
        Me.lblAncho.TabIndex = 13
        Me.lblAncho.Text = "Ancho"
        '
        'nudAncho
        '
        Me.nudAncho.Location = New System.Drawing.Point(92, 344)
        Me.nudAncho.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAncho.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAncho.Name = "nudAncho"
        Me.nudAncho.Size = New System.Drawing.Size(67, 20)
        Me.nudAncho.TabIndex = 12
        Me.nudAncho.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.TabPage1)
        Me.tbControl.Controls.Add(Me.TabPage2)
        Me.tbControl.Location = New System.Drawing.Point(28, 12)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(306, 215)
        Me.tbControl.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblFbasica)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.llblFormasBasicas)
        Me.TabPage1.Controls.Add(Me.cbTipoJuego)
        Me.TabPage1.Controls.Add(Me.cbBorrarPasar)
        Me.TabPage1.Controls.Add(Me.btnComenzar)
        Me.TabPage1.Controls.Add(Me.lblIter)
        Me.TabPage1.Controls.Add(Me.btnDetener)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(298, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Game of Life"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblFbasica
        '
        Me.lblFbasica.AutoSize = True
        Me.lblFbasica.Location = New System.Drawing.Point(191, 78)
        Me.lblFbasica.Name = "lblFbasica"
        Me.lblFbasica.Size = New System.Drawing.Size(0, 13)
        Me.lblFbasica.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Da doble clic en el lugar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "donde quieras colocar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la forma basica"
        '
        'llblFormasBasicas
        '
        Me.llblFormasBasicas.AutoSize = True
        Me.llblFormasBasicas.Location = New System.Drawing.Point(188, 61)
        Me.llblFormasBasicas.Name = "llblFormasBasicas"
        Me.llblFormasBasicas.Size = New System.Drawing.Size(81, 13)
        Me.llblFormasBasicas.TabIndex = 4
        Me.llblFormasBasicas.TabStop = True
        Me.llblFormasBasicas.Text = "Formas Basicas"
        '
        'cbTipoJuego
        '
        Me.cbTipoJuego.FormattingEnabled = True
        Me.cbTipoJuego.Items.AddRange(New Object() {"Conway", "Day and Night", "Life without Dead", "Seeds", "Hight Life", "Triangle", "Otro2"})
        Me.cbTipoJuego.Location = New System.Drawing.Point(107, 21)
        Me.cbTipoJuego.Name = "cbTipoJuego"
        Me.cbTipoJuego.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoJuego.TabIndex = 3
        Me.cbTipoJuego.Text = "Tipo Juego"
        '
        'cbBorrarPasar
        '
        Me.cbBorrarPasar.AutoSize = True
        Me.cbBorrarPasar.Checked = True
        Me.cbBorrarPasar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBorrarPasar.Location = New System.Drawing.Point(19, 109)
        Me.cbBorrarPasar.Name = "cbBorrarPasar"
        Me.cbBorrarPasar.Size = New System.Drawing.Size(98, 17)
        Me.cbBorrarPasar.TabIndex = 2
        Me.cbBorrarPasar.Text = "Borrar  al Pasar"
        Me.cbBorrarPasar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblTurArch)
        Me.TabPage2.Controls.Add(Me.lblTurEstado)
        Me.TabPage2.Controls.Add(Me.nudTurEstado)
        Me.TabPage2.Controls.Add(Me.cbTurDir)
        Me.TabPage2.Controls.Add(Me.lblTurX)
        Me.TabPage2.Controls.Add(Me.lblTurY)
        Me.TabPage2.Controls.Add(Me.nudTurX)
        Me.TabPage2.Controls.Add(Me.nudTurY)
        Me.TabPage2.Controls.Add(Me.lblInt)
        Me.TabPage2.Controls.Add(Me.lblIteraciones)
        Me.TabPage2.Controls.Add(Me.lblIte)
        Me.TabPage2.Controls.Add(Me.llblTurmitas)
        Me.TabPage2.Controls.Add(Me.btnTurDetener)
        Me.TabPage2.Controls.Add(Me.btnTurComenzar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(298, 189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Turmites"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblTurArch
        '
        Me.lblTurArch.AutoSize = True
        Me.lblTurArch.Location = New System.Drawing.Point(150, 36)
        Me.lblTurArch.Name = "lblTurArch"
        Me.lblTurArch.Size = New System.Drawing.Size(0, 13)
        Me.lblTurArch.TabIndex = 17
        '
        'lblTurEstado
        '
        Me.lblTurEstado.AutoSize = True
        Me.lblTurEstado.Location = New System.Drawing.Point(11, 133)
        Me.lblTurEstado.Name = "lblTurEstado"
        Me.lblTurEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblTurEstado.TabIndex = 16
        Me.lblTurEstado.Text = "Estado"
        '
        'nudTurEstado
        '
        Me.nudTurEstado.Location = New System.Drawing.Point(66, 127)
        Me.nudTurEstado.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTurEstado.Name = "nudTurEstado"
        Me.nudTurEstado.Size = New System.Drawing.Size(34, 20)
        Me.nudTurEstado.TabIndex = 15
        '
        'cbTurDir
        '
        Me.cbTurDir.FormattingEnabled = True
        Me.cbTurDir.Items.AddRange(New Object() {"Norte", "Este", "Sur", "Oeste"})
        Me.cbTurDir.Location = New System.Drawing.Point(28, 155)
        Me.cbTurDir.Name = "cbTurDir"
        Me.cbTurDir.Size = New System.Drawing.Size(99, 21)
        Me.cbTurDir.TabIndex = 14
        Me.cbTurDir.Text = "Dirección"
        '
        'lblTurX
        '
        Me.lblTurX.AutoSize = True
        Me.lblTurX.Location = New System.Drawing.Point(158, 157)
        Me.lblTurX.Name = "lblTurX"
        Me.lblTurX.Size = New System.Drawing.Size(14, 13)
        Me.lblTurX.TabIndex = 13
        Me.lblTurX.Text = "X"
        '
        'lblTurY
        '
        Me.lblTurY.AutoSize = True
        Me.lblTurY.Location = New System.Drawing.Point(158, 121)
        Me.lblTurY.Name = "lblTurY"
        Me.lblTurY.Size = New System.Drawing.Size(14, 13)
        Me.lblTurY.TabIndex = 12
        Me.lblTurY.Text = "Y"
        '
        'nudTurX
        '
        Me.nudTurX.Location = New System.Drawing.Point(191, 155)
        Me.nudTurX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudTurX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTurX.Name = "nudTurX"
        Me.nudTurX.Size = New System.Drawing.Size(57, 20)
        Me.nudTurX.TabIndex = 11
        Me.nudTurX.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'nudTurY
        '
        Me.nudTurY.Location = New System.Drawing.Point(191, 119)
        Me.nudTurY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudTurY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTurY.Name = "nudTurY"
        Me.nudTurY.Size = New System.Drawing.Size(57, 20)
        Me.nudTurY.TabIndex = 10
        Me.nudTurY.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Location = New System.Drawing.Point(150, 52)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(102, 39)
        Me.lblInt.TabIndex = 5
        Me.lblInt.Text = "Selecciona la tumite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " y da clic donde la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quieres poner"
        '
        'lblIteraciones
        '
        Me.lblIteraciones.AutoSize = True
        Me.lblIteraciones.Location = New System.Drawing.Point(90, 110)
        Me.lblIteraciones.Name = "lblIteraciones"
        Me.lblIteraciones.Size = New System.Drawing.Size(13, 13)
        Me.lblIteraciones.TabIndex = 4
        Me.lblIteraciones.Text = "0"
        '
        'lblIte
        '
        Me.lblIte.AutoSize = True
        Me.lblIte.Location = New System.Drawing.Point(25, 110)
        Me.lblIte.Name = "lblIte"
        Me.lblIte.Size = New System.Drawing.Size(59, 13)
        Me.lblIte.TabIndex = 3
        Me.lblIte.Text = "Iteraciones"
        '
        'llblTurmitas
        '
        Me.llblTurmitas.AutoSize = True
        Me.llblTurmitas.Location = New System.Drawing.Point(147, 17)
        Me.llblTurmitas.Name = "llblTurmitas"
        Me.llblTurmitas.Size = New System.Drawing.Size(47, 13)
        Me.llblTurmitas.TabIndex = 2
        Me.llblTurmitas.TabStop = True
        Me.llblTurmitas.Text = "Turmites"
        '
        'btnTurDetener
        '
        Me.btnTurDetener.Location = New System.Drawing.Point(25, 64)
        Me.btnTurDetener.Name = "btnTurDetener"
        Me.btnTurDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnTurDetener.TabIndex = 1
        Me.btnTurDetener.Text = "Detener"
        Me.btnTurDetener.UseVisualStyleBackColor = True
        '
        'btnTurComenzar
        '
        Me.btnTurComenzar.Location = New System.Drawing.Point(25, 19)
        Me.btnTurComenzar.Name = "btnTurComenzar"
        Me.btnTurComenzar.Size = New System.Drawing.Size(75, 23)
        Me.btnTurComenzar.TabIndex = 0
        Me.btnTurComenzar.Text = "Comenzar"
        Me.btnTurComenzar.UseVisualStyleBackColor = True
        '
        'cbFondo
        '
        Me.cbFondo.FormattingEnabled = True
        Me.cbFondo.Items.AddRange(New Object() {"Negro", "Blanco", "Azure", "Beige", "Azul", "Verde", "Rosa"})
        Me.cbFondo.Location = New System.Drawing.Point(223, 270)
        Me.cbFondo.Name = "cbFondo"
        Me.cbFondo.Size = New System.Drawing.Size(121, 21)
        Me.cbFondo.TabIndex = 15
        Me.cbFondo.Text = "Color"
        '
        'rbNegro
        '
        Me.rbNegro.AutoSize = True
        Me.rbNegro.Location = New System.Drawing.Point(226, 246)
        Me.rbNegro.Name = "rbNegro"
        Me.rbNegro.Size = New System.Drawing.Size(54, 17)
        Me.rbNegro.TabIndex = 16
        Me.rbNegro.TabStop = True
        Me.rbNegro.Text = "Negro"
        Me.rbNegro.UseVisualStyleBackColor = True
        '
        'rbBlanco
        '
        Me.rbBlanco.AutoSize = True
        Me.rbBlanco.Checked = True
        Me.rbBlanco.Location = New System.Drawing.Point(290, 247)
        Me.rbBlanco.Name = "rbBlanco"
        Me.rbBlanco.Size = New System.Drawing.Size(58, 17)
        Me.rbBlanco.TabIndex = 17
        Me.rbBlanco.TabStop = True
        Me.rbBlanco.Text = "Blanco"
        Me.rbBlanco.UseVisualStyleBackColor = True
        '
        'ConfGame2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 454)
        Me.Controls.Add(Me.rbBlanco)
        Me.Controls.Add(Me.rbNegro)
        Me.Controls.Add(Me.cbFondo)
        Me.Controls.Add(Me.tbControl)
        Me.Controls.Add(Me.lblAncho)
        Me.Controls.Add(Me.nudAncho)
        Me.Controls.Add(Me.lblCuadrosY)
        Me.Controls.Add(Me.lblCuadrosX)
        Me.Controls.Add(Me.nudLimX)
        Me.Controls.Add(Me.btnDibujaMatriz)
        Me.Controls.Add(Me.nudLimY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudVelocidad)
        Me.Controls.Add(Me.btnLimpiarMatriz)
        Me.Name = "ConfGame2"
        Me.Text = "ConfGame2"
        CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLimY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLimX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAncho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudTurEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTurX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTurY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComenzar As Button
    Friend WithEvents btnDetener As Button
    Friend WithEvents btnLimpiarMatriz As Button
    Friend WithEvents nudVelocidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudLimY As NumericUpDown
    Friend WithEvents btnDibujaMatriz As Button
    Friend WithEvents lblIter As Label
    Friend WithEvents nudLimX As NumericUpDown
    Friend WithEvents lblCuadrosX As Label
    Friend WithEvents lblCuadrosY As Label
    Friend WithEvents lblAncho As Label
    Friend WithEvents nudAncho As NumericUpDown
    Friend WithEvents tbControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cbBorrarPasar As CheckBox
    Friend WithEvents cbTipoJuego As ComboBox
    Friend WithEvents llblFormasBasicas As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFbasica As Label
    Friend WithEvents lblTurEstado As Label
    Friend WithEvents nudTurEstado As NumericUpDown
    Friend WithEvents cbTurDir As ComboBox
    Friend WithEvents lblTurX As Label
    Friend WithEvents lblTurY As Label
    Friend WithEvents nudTurX As NumericUpDown
    Friend WithEvents nudTurY As NumericUpDown
    Friend WithEvents lblInt As Label
    Friend WithEvents lblIteraciones As Label
    Friend WithEvents lblIte As Label
    Friend WithEvents llblTurmitas As LinkLabel
    Friend WithEvents btnTurDetener As Button
    Friend WithEvents btnTurComenzar As Button
    Friend WithEvents lblTurArch As Label
    Friend WithEvents cbFondo As ComboBox
    Friend WithEvents rbNegro As RadioButton
    Friend WithEvents rbBlanco As RadioButton
End Class
