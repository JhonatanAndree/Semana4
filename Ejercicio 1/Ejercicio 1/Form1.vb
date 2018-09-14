Public Class Form1
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtn1.Clear()
        txtn2.Clear()
        txtn3.Clear()
        txtpromedio.Clear()
        txtsituacionfinal.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'DECLARACION DE VARIABLES
        Dim examen1, examen2, examen3 As Integer
        Dim promedio As Single

        'INGRESO DE DATOS
        examen1 = Val(txtn1.Text)
        examen2 = Val(txtn2.Text)
        examen3 = Val(txtn3.Text)

        'PROCESO
        promedio = (examen1 + examen2 + examen3) / 3

        'EVALUACION
        If (promedio > 13) Then
            txtsituacionfinal.Text = "APROBADO"
        Else
            txtsituacionfinal.Text = "DESAPROBADO"
        End If
        txtpromedio.Text = promedio

    End Sub

    Private Sub txtn1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Ingrese solo números")
            sender.focus()
            sender.selectall()
        End If
    End Sub
End Class
