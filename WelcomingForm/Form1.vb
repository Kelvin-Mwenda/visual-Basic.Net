Public Class WelcomingForm
    Private Sub WelcomingFormClick(sender As Object, e As EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub LoadObjectButtonClick(sender As Object, e As EventArgs) Handles LoadObjectDemoButton.Click
        Me.Hide()

        Dim frmObjectDemo As New ObjectDemonstrationsForm

        frmObjectDemo.Show()
        frmObjectDemo.Focus()
    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
