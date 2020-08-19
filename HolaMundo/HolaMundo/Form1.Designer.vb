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
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(56, 12)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(178, 20)
        Me.txtSerie.TabIndex = 0
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(16, 15)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 1
        Me.lblserie.Text = "Serie:"
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(19, 132)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(198, 37)
        Me.btnMediaAritmetica.TabIndex = 2
        Me.btnMediaAritmetica.Text = "Calculos Estadisticos "
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(96, 50)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 3
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(16, 50)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(39, 13)
        Me.lblmedia.TabIndex = 4
        Me.lblmedia.Text = "Media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(16, 75)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 5
        Me.lblVarianza.Text = "Varianza:"
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(16, 103)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(67, 13)
        Me.lblDesvTipica.TabIndex = 6
        Me.lblDesvTipica.Text = "Desv.Tipica:"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(96, 75)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaVarianza.TabIndex = 7
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(96, 103)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 8
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtSerie)
        Me.Name = "Form1"
        Me.Text = "Matrices y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSerie As TextBox
    Friend WithEvents lblserie As Label
    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblDesvTipica As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
End Class
