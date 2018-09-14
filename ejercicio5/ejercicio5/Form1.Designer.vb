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
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.btnreportar = New System.Windows.Forms.Button()
        Me.txtreporte = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Edad"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(124, 42)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(124, 79)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 20)
        Me.txtedad.TabIndex = 1
        '
        'btnreportar
        '
        Me.btnreportar.Location = New System.Drawing.Point(36, 128)
        Me.btnreportar.Name = "btnreportar"
        Me.btnreportar.Size = New System.Drawing.Size(75, 23)
        Me.btnreportar.TabIndex = 2
        Me.btnreportar.Text = "REPORTAR"
        Me.btnreportar.UseVisualStyleBackColor = True
        '
        'txtreporte
        '
        Me.txtreporte.Location = New System.Drawing.Point(124, 183)
        Me.txtreporte.Name = "txtreporte"
        Me.txtreporte.Size = New System.Drawing.Size(203, 20)
        Me.txtreporte.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(346, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 262)
        Me.Controls.Add(Me.txtreporte)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnreportar)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents btnreportar As Button
    Friend WithEvents txtreporte As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
