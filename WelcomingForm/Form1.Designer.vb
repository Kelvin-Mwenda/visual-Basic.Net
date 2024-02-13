<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoadObjectDemoButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadObjectDemoButton
        ' 
        LoadObjectDemoButton.AccessibleRole = AccessibleRole.None
        LoadObjectDemoButton.Location = New Point(152, 183)
        LoadObjectDemoButton.Name = "LoadObjectDemoButton"
        LoadObjectDemoButton.Size = New Size(217, 75)
        LoadObjectDemoButton.TabIndex = 0
        LoadObjectDemoButton.Text = "&Load Object Demo"
        LoadObjectDemoButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(396, 183)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(214, 75)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&XIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadObjectDemoButton)
        Name = "WelcomingForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadObjectDemoButton As Button
    Friend WithEvents ExitButton As Button

End Class
