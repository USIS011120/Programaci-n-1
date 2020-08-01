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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.lblresta = New System.Windows.Forms.Label()
        Me.lblmult = New System.Windows.Forms.Label()
        Me.lbldivicion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(59, 32)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num 1:"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(104, 29)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 1
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(72, 147)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(284, 36)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(44, 13)
        Me.lblnum2.TabIndex = 3
        Me.lblnum2.Text = "Num 2 :"
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(457, 36)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 4
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(351, 33)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 5
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Location = New System.Drawing.Point(239, 36)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(13, 13)
        Me.lblsuma.TabIndex = 6
        Me.lblsuma.Text = "+"
        '
        'lblresta
        '
        Me.lblresta.AutoSize = True
        Me.lblresta.Location = New System.Drawing.Point(239, 69)
        Me.lblresta.Name = "lblresta"
        Me.lblresta.Size = New System.Drawing.Size(10, 13)
        Me.lblresta.TabIndex = 7
        Me.lblresta.Text = "-"
        '
        'lblmult
        '
        Me.lblmult.AutoSize = True
        Me.lblmult.Location = New System.Drawing.Point(239, 99)
        Me.lblmult.Name = "lblmult"
        Me.lblmult.Size = New System.Drawing.Size(11, 13)
        Me.lblmult.TabIndex = 8
        Me.lblmult.Text = "*"
        '
        'lbldivicion
        '
        Me.lbldivicion.AutoSize = True
        Me.lbldivicion.Location = New System.Drawing.Point(239, 131)
        Me.lbldivicion.Name = "lbldivicion"
        Me.lbldivicion.Size = New System.Drawing.Size(12, 13)
        Me.lbldivicion.TabIndex = 9
        Me.lbldivicion.Text = "/"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Label10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbldivicion)
        Me.Controls.Add(Me.lblmult)
        Me.Controls.Add(Me.lblresta)
        Me.Controls.Add(Me.lblsuma)
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

    Friend WithEvents lblnum1 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents lblnum2 As Label
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblsuma As Label
    Friend WithEvents lblresta As Label
    Friend WithEvents lblmult As Label
    Friend WithEvents lbldivicion As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
