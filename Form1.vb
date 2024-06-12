Public Class Form1
    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Dim dato1, dato2 As Integer
        dato1 = Txtdato1.Text
        dato2 = Txtdato2.Text
        If dato1 > dato2 Then
            'verdadero
            lblmostrar.Text = "el mayor es: " & dato1
            'falso
        Else lblmostrar.Text = "el mayor es: " & dato2
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblmostrar.Click

    End Sub
End Class
