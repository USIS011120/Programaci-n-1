Public Class Form1
    Dim objEstadistica As New estadistica
    Private Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        lblRespuestaMedia.Text = objEstadistica.calcularMedia(txtSerie.Text.Split(","))
        lblRespuestaVarianza.Text = objEstadistica.calcularVarianza(txtSerie.Text.Split(","))
        lblRespuestaDesvTipica.Text = objEstadistica.calcularDesvTipica(txtSerie.Text.Split(","))
    End Sub
End Class
