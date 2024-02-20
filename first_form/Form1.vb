Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class WelcomingForm
    Private Sub btnLoadObjectDemo_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim objDemoForm As New ObjectDemonstrations()
        objDemoForm.Show()
    End Sub

    'Exit button click event
    Private Sub btnExit_MouseClick(sender As Object, e As MouseEventArgs)
        Application.Exit()
    End Sub

    'Form click event to maximize and change background color
    Private Sub WelcomingForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form and change background color to RED
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub WelcomingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
