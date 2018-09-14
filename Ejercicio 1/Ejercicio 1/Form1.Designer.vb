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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.txtn3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.txtsituacionfinal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examen 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Examen 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Examen 3"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(127, 25)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(129, 20)
        Me.txtn1.TabIndex = 0
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(127, 56)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(129, 20)
        Me.txtn2.TabIndex = 1
        '
        'txtn3
        '
        Me.txtn3.Location = New System.Drawing.Point(126, 91)
        Me.txtn3.Name = "txtn3"
        Me.txtn3.Size = New System.Drawing.Size(129, 20)
        Me.txtn3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Promedio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Situación Final"
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcular.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.ForeColor = System.Drawing.Color.White
        Me.btncalcular.Location = New System.Drawing.Point(292, 48)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(96, 26)
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
        Me.btnlimpiar.Location = New System.Drawing.Point(292, 96)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(96, 26)
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
        Me.btnsalir.Location = New System.Drawing.Point(292, 143)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(96, 26)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'txtpromedio
        '
        Me.txtpromedio.Location = New System.Drawing.Point(127, 129)
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(129, 20)
        Me.txtpromedio.TabIndex = 6
        '
        'txtsituacionfinal
        '
        Me.txtsituacionfinal.Location = New System.Drawing.Point(126, 170)
        Me.txtsituacionfinal.Name = "txtsituacionfinal"
        Me.txtsituacionfinal.Size = New System.Drawing.Size(129, 20)
        Me.txtsituacionfinal.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(419, 223)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtsituacionfinal)
        Me.Controls.Add(Me.txtpromedio)
        Me.Controls.Add(Me.txtn3)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promedios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents txtn3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtpromedio As TextBox
    Friend WithEvents txtsituacionfinal As TextBox
End Class
