Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim num1, num2, respuesta As Double
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        If optSuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

    End Sub
End Class

