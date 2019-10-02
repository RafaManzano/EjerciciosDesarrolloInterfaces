<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHolaMundo
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
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.btnSaludar = New System.Windows.Forms.Button()
        Me.lbError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(326, 56)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(379, 56)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 1
        '
        'btnSaludar
        '
        Me.btnSaludar.Location = New System.Drawing.Point(325, 98)
        Me.btnSaludar.Name = "btnSaludar"
        Me.btnSaludar.Size = New System.Drawing.Size(153, 22)
        Me.btnSaludar.TabIndex = 2
        Me.btnSaludar.Text = "Saludar"
        Me.btnSaludar.UseVisualStyleBackColor = True
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.ForeColor = System.Drawing.Color.Red
        Me.lbError.Location = New System.Drawing.Point(497, 58)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(154, 13)
        Me.lbError.TabIndex = 3
        Me.lbError.Text = "Introduce al menos un caracter"
        Me.lbError.Visible = False
        '
        'frmHolaMundo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.btnSaludar)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lbNombre)
        Me.Name = "frmHolaMundo"
        Me.Text = "Formulario Visual Basic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombre As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents btnSaludar As Button
    Friend WithEvents lbError As Label
End Class
