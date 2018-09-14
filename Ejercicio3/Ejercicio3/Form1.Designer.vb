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
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.btnreportar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtnumeromayor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número 2"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(128, 37)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(100, 20)
        Me.txtn1.TabIndex = 0
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(128, 68)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(100, 20)
        Me.txtn2.TabIndex = 1
        '
        'btnreportar
        '
        Me.btnreportar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnreportar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnreportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportar.ForeColor = System.Drawing.Color.White
        Me.btnreportar.Location = New System.Drawing.Point(52, 116)
        Me.btnreportar.Name = "btnreportar"
        Me.btnreportar.Size = New System.Drawing.Size(88, 23)
        Me.btnreportar.TabIndex = 2
        Me.btnreportar.Text = "REPORTAR"
        Me.btnreportar.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(203, 116)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(88, 23)
        Me.btnlimpiar.TabIndex = 3
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(356, 116)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'txtnumeromayor
        '
        Me.txtnumeromayor.Location = New System.Drawing.Point(344, 51)
        Me.txtnumeromayor.Name = "txtnumeromayor"
        Me.txtnumeromayor.Size = New System.Drawing.Size(100, 20)
        Me.txtnumeromayor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "El mayor es"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(492, 173)
        Me.Controls.Add(Me.txtnumeromayor)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnreportar)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¿Cuál es el mayor?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents btnreportar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtnumeromayor As TextBox
    Friend WithEvents Label3 As Label
End Class
