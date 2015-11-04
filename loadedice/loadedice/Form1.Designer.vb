<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dice1 = New System.Windows.Forms.Label()
        Me.dice2 = New System.Windows.Forms.Label()
        Me.results = New System.Windows.Forms.TextBox()
        Me.press = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'dice1
        '
        Me.dice1.AutoSize = True
        Me.dice1.Location = New System.Drawing.Point(12, 67)
        Me.dice1.Name = "dice1"
        Me.dice1.Size = New System.Drawing.Size(39, 13)
        Me.dice1.TabIndex = 0
        Me.dice1.Text = "Label1"
        '
        'dice2
        '
        Me.dice2.AutoSize = True
        Me.dice2.Location = New System.Drawing.Point(12, 162)
        Me.dice2.Name = "dice2"
        Me.dice2.Size = New System.Drawing.Size(39, 13)
        Me.dice2.TabIndex = 1
        Me.dice2.Text = "Label2"
        '
        'results
        '
        Me.results.Location = New System.Drawing.Point(387, 67)
        Me.results.Multiline = True
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(100, 248)
        Me.results.TabIndex = 2
        '
        'press
        '
        Me.press.Location = New System.Drawing.Point(0, 0)
        Me.press.Name = "press"
        Me.press.Size = New System.Drawing.Size(75, 23)
        Me.press.TabIndex = 3
        Me.press.Text = "Roll"
        Me.press.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 372)
        Me.Controls.Add(Me.press)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.dice2)
        Me.Controls.Add(Me.dice1)
        Me.Name = "main"
        Me.Text = "Rolling Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dice1 As System.Windows.Forms.Label
    Friend WithEvents dice2 As System.Windows.Forms.Label
    Friend WithEvents results As System.Windows.Forms.TextBox
    Friend WithEvents press As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
