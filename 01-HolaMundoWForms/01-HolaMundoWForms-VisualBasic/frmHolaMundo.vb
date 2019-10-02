Imports Classes

Public Class frmHolaMundo
    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'Dim nombre As String'
        Dim objPersona As New clsPersona

        objPersona.Nombre = tbNombre.Text

        If String.IsNullOrWhiteSpace(objPersona.Nombre) Then
            lbError.Visible = True
        Else
            MessageBox.Show("Hola " + objPersona.Nombre)
        End If



    End Sub
End Class