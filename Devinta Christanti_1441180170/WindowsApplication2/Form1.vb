Public Class Form1

    Private Sub Ubah_Click(sender As Object, e As EventArgs) Handles Ubah.Click
        If Me.BackColor = Color.LightCoral Then
            Me.BackColor = Color.CornflowerBlue
        ElseIf Me.BackColor = Color.CornflowerBlue Then
            Me.BackColor = Color.LightCoral
        End If
    End Sub

End Class
