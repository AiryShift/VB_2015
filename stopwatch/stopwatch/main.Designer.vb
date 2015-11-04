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
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblLittleSeconds = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmr
        '
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(42, 52)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(39, 13)
        Me.lblMinutes.TabIndex = 0
        Me.lblMinutes.Text = "Label1"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(87, 52)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(39, 13)
        Me.lblSeconds.TabIndex = 1
        Me.lblSeconds.Text = "Label2"
        '
        'lblLittleSeconds
        '
        Me.lblLittleSeconds.AutoSize = True
        Me.lblLittleSeconds.Location = New System.Drawing.Point(132, 52)
        Me.lblLittleSeconds.Name = "lblLittleSeconds"
        Me.lblLittleSeconds.Size = New System.Drawing.Size(39, 13)
        Me.lblLittleSeconds.TabIndex = 2
        Me.lblLittleSeconds.Text = "Label3"
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(6, 122)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 3
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(96, 122)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(186, 122)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.lblLittleSeconds)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents lblLittleSeconds As System.Windows.Forms.Label
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button

End Class
