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
        btnLoadObjectDemo = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnLoadObjectDemo
        ' 
        btnLoadObjectDemo.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoadObjectDemo.Location = New Point(133, 288)
        btnLoadObjectDemo.Margin = New Padding(4, 3, 4, 3)
        btnLoadObjectDemo.Name = "btnLoadObjectDemo"
        btnLoadObjectDemo.Size = New Size(370, 58)
        btnLoadObjectDemo.TabIndex = 0
        btnLoadObjectDemo.Text = "&Loading Object Demo"
        btnLoadObjectDemo.TextAlign = ContentAlignment.MiddleLeft
        btnLoadObjectDemo.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(537, 288)
        btnExit.Margin = New Padding(4, 3, 4, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(370, 58)
        btnExit.TabIndex = 1
        btnExit.Text = "E&XIT"
        btnExit.TextAlign = ContentAlignment.MiddleLeft
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' WelcomingForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 486)
        Controls.Add(btnExit)
        Controls.Add(btnLoadObjectDemo)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "WelcomingForm"
        Tag = "btnExit"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLoadObjectDemo As Button
    Friend WithEvents btnExit As Button

End Class
