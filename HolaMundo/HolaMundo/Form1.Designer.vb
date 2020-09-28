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
        Me.lbldepto = New System.Windows.Forms.Label()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.lblmun = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldepto
        '
        Me.lbldepto.AutoSize = True
        Me.lbldepto.Location = New System.Drawing.Point(77, 47)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(39, 13)
        Me.lbldepto.TabIndex = 0
        Me.lbldepto.Text = "Deoto:"
        '
        'cboDepto
        '
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(122, 44)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(121, 21)
        Me.cboDepto.TabIndex = 1
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(305, 44)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(121, 21)
        Me.cboMun.TabIndex = 3
        '
        'lblmun
        '
        Me.lblmun.AutoSize = True
        Me.lblmun.Location = New System.Drawing.Point(268, 47)
        Me.lblmun.Name = "lblmun"
        Me.lblmun.Size = New System.Drawing.Size(31, 13)
        Me.lblmun.TabIndex = 2
        Me.lblmun.Text = "Mun:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 234)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.lblmun)
        Me.Controls.Add(Me.cboDepto)
        Me.Controls.Add(Me.lbldepto)
        Me.Name = "Form1"
        Me.Text = "Combo dinamicos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldepto As Label
    Friend WithEvents cboDepto As ComboBox
    Friend WithEvents cboMun As ComboBox
    Friend WithEvents lblmun As Label
End Class
