<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainScreen))
        Me.pbDenmark = New System.Windows.Forms.PictureBox()
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDenmark
        '
        Me.pbDenmark.Location = New System.Drawing.Point(163, 64)
        Me.pbDenmark.Name = "pbDenmark"
        Me.pbDenmark.Size = New System.Drawing.Size(150, 81)
        Me.pbDenmark.TabIndex = 0
        Me.pbDenmark.TabStop = False
        '
        'mainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.triangle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(478, 494)
        Me.Controls.Add(Me.pbDenmark)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainScreen"
        Me.Text = "Form1"
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbDenmark As System.Windows.Forms.PictureBox

End Class
