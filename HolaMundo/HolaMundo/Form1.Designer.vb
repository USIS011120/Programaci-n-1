<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.optmodulo = New System.Windows.Forms.RadioButton()
        Me.optesponente = New System.Windows.Forms.RadioButton()
        Me.optporcentaje = New System.Windows.Forms.RadioButton()
        Me.optdivicion = New System.Windows.Forms.RadioButton()
        Me.optmultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Seleccione una opción", "Suma ", "Resta", "Multiplicación ", "Divición ", "Porcentaje", "Exponenciación ", "Modulo "})
        Me.cboOperaciones.Location = New System.Drawing.Point(369, 101)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cboOperaciones.TabIndex = 27
        '
        'optmodulo
        '
        Me.optmodulo.AutoSize = True
        Me.optmodulo.Location = New System.Drawing.Point(212, 177)
        Me.optmodulo.Name = "optmodulo"
        Me.optmodulo.Size = New System.Drawing.Size(33, 17)
        Me.optmodulo.TabIndex = 26
        Me.optmodulo.TabStop = True
        Me.optmodulo.Text = "%"
        Me.optmodulo.UseVisualStyleBackColor = True
        '
        'optesponente
        '
        Me.optesponente.AutoSize = True
        Me.optesponente.Location = New System.Drawing.Point(212, 154)
        Me.optesponente.Name = "optesponente"
        Me.optesponente.Size = New System.Drawing.Size(31, 17)
        Me.optesponente.TabIndex = 25
        Me.optesponente.TabStop = True
        Me.optesponente.Text = "^"
        Me.optesponente.UseVisualStyleBackColor = True
        '
        'optporcentaje
        '
        Me.optporcentaje.AutoSize = True
        Me.optporcentaje.Location = New System.Drawing.Point(212, 128)
        Me.optporcentaje.Name = "optporcentaje"
        Me.optporcentaje.Size = New System.Drawing.Size(79, 17)
        Me.optporcentaje.TabIndex = 24
        Me.optporcentaje.TabStop = True
        Me.optporcentaje.Text = "Porcentaje "
        Me.optporcentaje.UseVisualStyleBackColor = True
        '
        'optdivicion
        '
        Me.optdivicion.AutoSize = True
        Me.optdivicion.Location = New System.Drawing.Point(212, 105)
        Me.optdivicion.Name = "optdivicion"
        Me.optdivicion.Size = New System.Drawing.Size(30, 17)
        Me.optdivicion.TabIndex = 23
        Me.optdivicion.TabStop = True
        Me.optdivicion.Text = "/"
        Me.optdivicion.UseVisualStyleBackColor = True
        '
        'optmultiplicacion
        '
        Me.optmultiplicacion.AutoSize = True
        Me.optmultiplicacion.Location = New System.Drawing.Point(212, 82)
        Me.optmultiplicacion.Name = "optmultiplicacion"
        Me.optmultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optmultiplicacion.TabIndex = 22
        Me.optmultiplicacion.TabStop = True
        Me.optmultiplicacion.Text = "*"
        Me.optmultiplicacion.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.Location = New System.Drawing.Point(212, 59)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(28, 17)
        Me.optresta.TabIndex = 21
        Me.optresta.TabStop = True
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Location = New System.Drawing.Point(212, 36)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(31, 17)
        Me.optsuma.TabIndex = 20
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(301, 37)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 19
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(407, 40)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 18
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(260, 40)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(44, 13)
        Me.lblnum2.TabIndex = 17
        Me.lblnum2.Text = "Num 2 :"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(60, 118)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(128, 37)
        Me.btncalcular.TabIndex = 16
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(88, 30)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 15
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(43, 33)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 14
        Me.lblnum1.Text = "Num 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 299)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.optmodulo)
        Me.Controls.Add(Me.optesponente)
        Me.Controls.Add(Me.optporcentaje)
        Me.Controls.Add(Me.optdivicion)
        Me.Controls.Add(Me.optmultiplicacion)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Calculadora  Basica "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOperaciones As ComboBox
    Friend WithEvents optmodulo As RadioButton
    Friend WithEvents optesponente As RadioButton
    Friend WithEvents optporcentaje As RadioButton
    Friend WithEvents optdivicion As RadioButton
    Friend WithEvents optmultiplicacion As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum1 As Label
End Class
