<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.checkdescuento = New System.Windows.Forms.CheckBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecioparcial = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtpreciototal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(123, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad"
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.Location = New System.Drawing.Point(211, 21)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciounitario.TabIndex = 0
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(211, 63)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 1
        '
        'checkdescuento
        '
        Me.checkdescuento.AutoSize = True
        Me.checkdescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkdescuento.ForeColor = System.Drawing.Color.White
        Me.checkdescuento.Location = New System.Drawing.Point(211, 106)
        Me.checkdescuento.Name = "checkdescuento"
        Me.checkdescuento.Size = New System.Drawing.Size(117, 17)
        Me.checkdescuento.TabIndex = 2
        Me.checkdescuento.Text = "Aplicar Descuento"
        Me.checkdescuento.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcular.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.ForeColor = System.Drawing.Color.White
        Me.btncalcular.Location = New System.Drawing.Point(69, 144)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(96, 27)
        Me.btncalcular.TabIndex = 3
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(196, 144)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(96, 27)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(315, 144)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(96, 27)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpreciototal)
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Controls.Add(Me.txtprecioparcial)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas Totales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(74, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Precio Parcial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(73, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Precio Total"
        '
        'txtprecioparcial
        '
        Me.txtprecioparcial.Location = New System.Drawing.Point(219, 28)
        Me.txtprecioparcial.Name = "txtprecioparcial"
        Me.txtprecioparcial.Size = New System.Drawing.Size(155, 22)
        Me.txtprecioparcial.TabIndex = 0
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(219, 60)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(155, 22)
        Me.txtdescuento.TabIndex = 1
        '
        'txtpreciototal
        '
        Me.txtpreciototal.Location = New System.Drawing.Point(219, 94)
        Me.txtpreciototal.Name = "txtpreciototal"
        Me.txtpreciototal.Size = New System.Drawing.Size(155, 22)
        Me.txtpreciototal.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(474, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.checkdescuento)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtpreciounitario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sentencia IF 01"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpreciounitario As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents checkdescuento As CheckBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpreciototal As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtprecioparcial As TextBox
End Class
