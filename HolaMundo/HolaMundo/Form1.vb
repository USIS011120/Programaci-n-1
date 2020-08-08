Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim num1, num2, respuesta As Double
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        If optsuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If
        If optresta.Checked Then
            lblrespuesta.Text = num1 - num2
        End If
        If optmultiplicacion.Checked Then
            lblrespuesta.Text = num1 * num2
        End If
        If optdivicion.Checked Then
            lblrespuesta.Text = num1 / num2
        End If
        If optporcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If
        If optesponente.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If
        If optmodulo.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If

        Select Case cboOperaciones.SelectedIndex
            Case 1
                lblrespuesta.Text = num1 + num2
            Case 2
                lblrespuesta.Text = num1 - num2
            Case 3
                lblrespuesta.Text = num1 * num2
            Case 4
                lblrespuesta.Text = num1 / num2
            Case 5
                lblrespuesta.Text = num1 * num2 / 100
            Case 6
                lblrespuesta.Text = num1 ^ num2
            Case 7
                lblrespuesta.Text = num1 Mod num2
        End Select

    End Sub
End Class
