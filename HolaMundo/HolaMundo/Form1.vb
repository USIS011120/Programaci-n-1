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

    End Sub
End Class

