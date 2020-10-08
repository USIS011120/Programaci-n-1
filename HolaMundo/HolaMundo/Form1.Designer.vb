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
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.lblde = New System.Windows.Forms.Label()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(183, 47)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 0
        Me.lbltipo.Text = "Tipo"
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Monedas", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cbotipo.Location = New System.Drawing.Point(227, 44)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo.TabIndex = 1
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(117, 161)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(181, 62)
        Me.btnConvertir.TabIndex = 2
        Me.btnConvertir.Text = "Convertir "
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(70, 111)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(121, 21)
        Me.cbode.TabIndex = 4
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(39, 114)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(25, 13)
        Me.lblde.TabIndex = 3
        Me.lblde.Text = "DE:"
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(217, 111)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(121, 21)
        Me.cboa.TabIndex = 6
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(197, 114)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(14, 13)
        Me.lbla.TabIndex = 5
        Me.lbla.Text = "A"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(399, 111)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 7
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(344, 114)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblcantidad.TabIndex = 8
        Me.lblcantidad.Text = "Cantidad"
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuesta.Location = New System.Drawing.Point(343, 184)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(107, 19)
        Me.lblrespuesta.TabIndex = 9
        Me.lblrespuesta.Text = "Respuesta:?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 282)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.lblde)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lbltipo)
        Me.Name = "Form1"
        Me.Text = "Comobos dinamicos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltipo As Label
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents cbode As ComboBox
    Friend WithEvents lblde As Label
    Friend WithEvents cboa As ComboBox
    Friend WithEvents lbla As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lblrespuesta As Label
End Class
