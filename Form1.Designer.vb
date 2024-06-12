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
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Txtdato1 = New System.Windows.Forms.TextBox()
        Me.Txtdato2 = New System.Windows.Forms.TextBox()
        Me.lblmostrar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Boton1
        '
        Me.Boton1.Location = New System.Drawing.Point(12, 13)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(75, 23)
        Me.Boton1.TabIndex = 0
        Me.Boton1.Text = "Button1"
        Me.Boton1.UseVisualStyleBackColor = True
        '
        'Txtdato1
        '
        Me.Txtdato1.Location = New System.Drawing.Point(104, 13)
        Me.Txtdato1.Name = "Txtdato1"
        Me.Txtdato1.Size = New System.Drawing.Size(100, 22)
        Me.Txtdato1.TabIndex = 3
        '
        'Txtdato2
        '
        Me.Txtdato2.Location = New System.Drawing.Point(210, 15)
        Me.Txtdato2.Name = "Txtdato2"
        Me.Txtdato2.Size = New System.Drawing.Size(100, 22)
        Me.Txtdato2.TabIndex = 4
        '
        'lblmostrar
        '
        Me.lblmostrar.AutoSize = True
        Me.lblmostrar.Location = New System.Drawing.Point(330, 21)
        Me.lblmostrar.Name = "lblmostrar"
        Me.lblmostrar.Size = New System.Drawing.Size(37, 16)
        Me.lblmostrar.TabIndex = 5
        Me.lblmostrar.Text = "label"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblmostrar)
        Me.Controls.Add(Me.Txtdato2)
        Me.Controls.Add(Me.Txtdato1)
        Me.Controls.Add(Me.Boton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton1 As Button
    Friend WithEvents Txtdato1 As TextBox
    Friend WithEvents Txtdato2 As TextBox
    Friend WithEvents lblmostrar As Label
End Class
