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
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum.Location = New System.Drawing.Point(12, 74)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(60, 20)
        Me.lblnum.TabIndex = 0
        Me.lblnum.Text = "Número:"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(78, 74)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(134, 20)
        Me.txtnum.TabIndex = 1
        '
        'btnParImpar
        '
        Me.btnParImpar.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParImpar.Location = New System.Drawing.Point(12, 132)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(102, 56)
        Me.btnParImpar.TabIndex = 2
        Me.btnParImpar.Text = "Par o Impar?"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(120, 132)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(92, 56)
        Me.btnPrimo.TabIndex = 3
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(218, 133)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(106, 56)
        Me.btnCajero.TabIndex = 4
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(333, 243)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(196, 34)
        Me.btnProcesar.TabIndex = 5
        Me.btnProcesar.Text = "Mostrar pares e impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(333, 12)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(196, 225)
        Me.lstEjercicios.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 392)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblnum)
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnParImpar As Button
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstEjercicios As ListBox
End Class
