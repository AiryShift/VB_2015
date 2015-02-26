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
        Me.pbFrench = New System.Windows.Forms.PictureBox()
        Me.pbAzerbaijan = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMSTitle = New System.Windows.Forms.Label()
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFrench, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAzerbaijan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDenmark
        '
        Me.pbDenmark.Image = Global.WindowsApplication1.My.Resources.Resources.DENMARK
        Me.pbDenmark.Location = New System.Drawing.Point(163, 64)
        Me.pbDenmark.Name = "pbDenmark"
        Me.pbDenmark.Size = New System.Drawing.Size(150, 81)
        Me.pbDenmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDenmark.TabIndex = 0
        Me.pbDenmark.TabStop = False
        '
        'pbFrench
        '
        Me.pbFrench.Image = Global.WindowsApplication1.My.Resources.Resources.french
        Me.pbFrench.Location = New System.Drawing.Point(12, 317)
        Me.pbFrench.Name = "pbFrench"
        Me.pbFrench.Size = New System.Drawing.Size(150, 81)
        Me.pbFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFrench.TabIndex = 1
        Me.pbFrench.TabStop = False
        '
        'pbAzerbaijan
        '
        Me.pbAzerbaijan.Image = Global.WindowsApplication1.My.Resources.Resources.azerbaijan_2
        Me.pbAzerbaijan.Location = New System.Drawing.Point(316, 317)
        Me.pbAzerbaijan.Name = "pbAzerbaijan"
        Me.pbAzerbaijan.Size = New System.Drawing.Size(150, 81)
        Me.pbAzerbaijan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAzerbaijan.TabIndex = 2
        Me.pbAzerbaijan.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(391, 459)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMSTitle
        '
        Me.lblMSTitle.AutoSize = True
        Me.lblMSTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMSTitle.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSTitle.ForeColor = System.Drawing.Color.White
        Me.lblMSTitle.Location = New System.Drawing.Point(155, 9)
        Me.lblMSTitle.Name = "lblMSTitle"
        Me.lblMSTitle.Size = New System.Drawing.Size(176, 43)
        Me.lblMSTitle.TabIndex = 4
        Me.lblMSTitle.Text = "[Title Here]"
        '
        'mainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.triangle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(478, 494)
        Me.Controls.Add(Me.lblMSTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbAzerbaijan)
        Me.Controls.Add(Me.pbFrench)
        Me.Controls.Add(Me.pbDenmark)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainScreen"
        Me.Text = "Translator"
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFrench, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAzerbaijan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDenmark As System.Windows.Forms.PictureBox
    Friend WithEvents pbFrench As System.Windows.Forms.PictureBox
    Friend WithEvents pbAzerbaijan As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMSTitle As System.Windows.Forms.Label

End Class
