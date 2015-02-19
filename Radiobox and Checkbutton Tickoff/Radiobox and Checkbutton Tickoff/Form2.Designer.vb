<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formExit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitTrue = New System.Windows.Forms.Button()
        Me.btnExitFalse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure that you want to exit?"
        '
        'btnExitTrue
        '
        Me.btnExitTrue.Location = New System.Drawing.Point(39, 127)
        Me.btnExitTrue.Name = "btnExitTrue"
        Me.btnExitTrue.Size = New System.Drawing.Size(75, 23)
        Me.btnExitTrue.TabIndex = 1
        Me.btnExitTrue.Text = "Yes"
        Me.btnExitTrue.UseVisualStyleBackColor = True
        '
        'btnExitFalse
        '
        Me.btnExitFalse.Location = New System.Drawing.Point(164, 127)
        Me.btnExitFalse.Name = "btnExitFalse"
        Me.btnExitFalse.Size = New System.Drawing.Size(75, 23)
        Me.btnExitFalse.TabIndex = 2
        Me.btnExitFalse.Text = "No"
        Me.btnExitFalse.UseVisualStyleBackColor = True
        '
        'formExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExitFalse)
        Me.Controls.Add(Me.btnExitTrue)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formExit"
        Me.Text = "Are you sure?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExitTrue As System.Windows.Forms.Button
    Friend WithEvents btnExitFalse As System.Windows.Forms.Button
End Class
