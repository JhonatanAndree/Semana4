Public Class Form1
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcantidad.Clear()
        txtdescuento.Clear()
        txtprecioparcial.Clear()
        txtpreciototal.Clear()
        txtpreciounitario.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub checkdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles checkdescuento.CheckedChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        Dim cantidad As Integer
        Dim punitario, descuento, pparcial, ptotal As Single
        Dim marcadescuento As Boolean

        cantidad = Val(txtcantidad.Text)
        punitario = Val(txtpreciounitario.Text)
        marcadescuento = checkdescuento.Checked

        descuento = 0

        pparcial = cantidad * punitario

        If (marcadescuento = True) Then
            descuento = pparcial * 7/100
        End If
        ptotal = pparcial - descuento

        txtprecioparcial.Text = pparcial
        txtdescuento.Text = descuento
        txtpreciototal.Text = ptotal
    End Sub
End Class
