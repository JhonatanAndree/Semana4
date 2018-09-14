Public Class Form1
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtn1.Clear()
        txtn2.Clear()
        txtnumeromayor.Clear()
    End Sub

    Private Sub btnreportar_Click(sender As Object, e As EventArgs) Handles btnreportar.Click

        Dim numero1 As Integer
        Dim numero2 As Integer

        numero1 = Val(txtn1.Text) And numero1 <= 5
        numero2 = Val(txtn2.Text) And numero2 <= 5

        If numero1 > numero2 Then
            txtnumeromayor.Text = numero1
        Else
            txtnumeromayor.Text = numero2
        End If


    End Sub
End Class
