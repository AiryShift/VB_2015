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
        Me.pbBosnia = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMSTitle = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.pcbWorldMap = New System.Windows.Forms.PictureBox()
        Me.lblName_1 = New System.Windows.Forms.Label()
        Me.lblName_2 = New System.Windows.Forms.Label()
        Me.lblName_3 = New System.Windows.Forms.Label()
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFrench, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBosnia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbWorldMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDenmark
        '
        Me.pbDenmark.Image = Global.WindowsApplication1.My.Resources.Resources.DENMARK
        Me.pbDenmark.Location = New System.Drawing.Point(12, 55)
        Me.pbDenmark.Name = "pbDenmark"
        Me.pbDenmark.Size = New System.Drawing.Size(150, 81)
        Me.pbDenmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDenmark.TabIndex = 0
        Me.pbDenmark.TabStop = False
        '
        'pbFrench
        '
        Me.pbFrench.Image = Global.WindowsApplication1.My.Resources.Resources.french
        Me.pbFrench.Location = New System.Drawing.Point(12, 177)
        Me.pbFrench.Name = "pbFrench"
        Me.pbFrench.Size = New System.Drawing.Size(150, 81)
        Me.pbFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFrench.TabIndex = 1
        Me.pbFrench.TabStop = False
        '
        'pbBosnia
        '
        Me.pbBosnia.Image = CType(resources.GetObject("pbBosnia.Image"), System.Drawing.Image)
        Me.pbBosnia.Location = New System.Drawing.Point(12, 293)
        Me.pbBosnia.Name = "pbBosnia"
        Me.pbBosnia.Size = New System.Drawing.Size(150, 81)
        Me.pbBosnia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBosnia.TabIndex = 2
        Me.pbBosnia.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(470, 380)
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
        Me.lblMSTitle.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSTitle.ForeColor = System.Drawing.Color.White
        Me.lblMSTitle.Location = New System.Drawing.Point(113, 9)
        Me.lblMSTitle.Name = "lblMSTitle"
        Me.lblMSTitle.Size = New System.Drawing.Size(346, 43)
        Me.lblMSTitle.TabIndex = 4
        Me.lblMSTitle.Text = "Handy Tourist's Guide"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(12, 380)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Credits"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'pcbWorldMap
        '
        Me.pcbWorldMap.Image = Global.WindowsApplication1.My.Resources.Resources.blank_europe_map
        Me.pcbWorldMap.Location = New System.Drawing.Point(168, 55)
        Me.pcbWorldMap.Name = "pcbWorldMap"
        Me.pcbWorldMap.Size = New System.Drawing.Size(377, 319)
        Me.pcbWorldMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbWorldMap.TabIndex = 6
        Me.pcbWorldMap.TabStop = False
        '
        'lblName_1
        '
        Me.lblName_1.AutoSize = True
        Me.lblName_1.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName_1.ForeColor = System.Drawing.Color.White
        Me.lblName_1.Location = New System.Drawing.Point(12, 33)
        Me.lblName_1.Name = "lblName_1"
        Me.lblName_1.Size = New System.Drawing.Size(65, 19)
        Me.lblName_1.TabIndex = 7
        Me.lblName_1.Text = "Denmark"
        Me.lblName_1.Visible = False
        '
        'lblName_2
        '
        Me.lblName_2.AutoSize = True
        Me.lblName_2.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName_2.ForeColor = System.Drawing.Color.White
        Me.lblName_2.Location = New System.Drawing.Point(12, 155)
        Me.lblName_2.Name = "lblName_2"
        Me.lblName_2.Size = New System.Drawing.Size(51, 19)
        Me.lblName_2.TabIndex = 8
        Me.lblName_2.Text = "France"
        Me.lblName_2.Visible = False
        '
        'lblName_3
        '
        Me.lblName_3.AutoSize = True
        Me.lblName_3.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName_3.ForeColor = System.Drawing.Color.White
        Me.lblName_3.Location = New System.Drawing.Point(12, 271)
        Me.lblName_3.Name = "lblName_3"
        Me.lblName_3.Size = New System.Drawing.Size(52, 19)
        Me.lblName_3.TabIndex = 9
        Me.lblName_3.Text = "Bosnia"
        Me.lblName_3.Visible = False
        '
        'mainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(557, 411)
        Me.Controls.Add(Me.lblName_3)
        Me.Controls.Add(Me.lblName_2)
        Me.Controls.Add(Me.lblName_1)
        Me.Controls.Add(Me.pcbWorldMap)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblMSTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbBosnia)
        Me.Controls.Add(Me.pbFrench)
        Me.Controls.Add(Me.pbDenmark)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainScreen"
        Me.Text = "Translator"
        CType(Me.pbDenmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFrench, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBosnia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbWorldMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDenmark As System.Windows.Forms.PictureBox
    Friend WithEvents pbFrench As System.Windows.Forms.PictureBox
    Friend WithEvents pbBosnia As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMSTitle As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents pcbWorldMap As System.Windows.Forms.PictureBox
    Friend WithEvents lblName_1 As System.Windows.Forms.Label
    Friend WithEvents lblName_2 As System.Windows.Forms.Label
    Friend WithEvents lblName_3 As System.Windows.Forms.Label

End Class
