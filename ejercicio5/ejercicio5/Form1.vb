Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub btnreportar_Click(sender As Object, e As EventArgs) Handles btnreportar.Click

        Dim nombre As String
        Dim edad As Integer

        'INGRESO DE DATOS
        nombre = txtnombre.Text
        edad = Val(txtedad.Text)

        'REPORTAR
        If (edad > 18) Then
            txtreporte.Text = "MAYOR DE EDAD"
        Else
            txtreporte.Text = "MENOR DE EDAD"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtedad.Clear()
        txtnombre.Clear()
        txtreporte.Clear()
    End Sub
End Class
