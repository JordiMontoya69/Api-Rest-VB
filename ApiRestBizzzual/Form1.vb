Imports Newtonsoft.Json

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            Dim api = New DBApi

            Dim headers = New List(Of Parametro)
            Dim parametros = New List(Of Parametro)

            Dim resultado = api.MGet("https://api.nasa.gov/planetary/earth/assets?lon=" + tbLongitud.Text + "&lat=" + tbLatitud.Text + "&date=2018-01-01&&dim=0.10&api_key=hzk4Tt8dm0wsur8fdFFf8W7o8IAfzn6l2KnxTnwy", headers, parametros)

            Dim objeto = JsonConvert.DeserializeObject(Of Imagen)(resultado)
            pbImagen.ImageLocation = objeto.url
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
End Class
