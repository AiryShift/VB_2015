<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class converter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(converter))
        Me.vSclCurValue = New System.Windows.Forms.VScrollBar()
        Me.pbFlagTo = New System.Windows.Forms.PictureBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pbFlagFrom = New System.Windows.Forms.PictureBox()
        Me.gpbTransferFrom = New System.Windows.Forms.GroupBox()
        Me.rdbUSA = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        CType(Me.pbFlagTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlagFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbTransferFrom.SuspendLayout()
        Me.SuspendLayout()
        '
        'vSclCurValue
        '
        Me.vSclCurValue.Location = New System.Drawing.Point(135, 9)
        Me.vSclCurValue.Maximum = 10000
        Me.vSclCurValue.Name = "vSclCurValue"
        Me.vSclCurValue.Size = New System.Drawing.Size(17, 215)
        Me.vSclCurValue.TabIndex = 0
        '
        'pbFlagTo
        '
        Me.pbFlagTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlagTo.Location = New System.Drawing.Point(155, 9)
        Me.pbFlagTo.Name = "pbFlagTo"
        Me.pbFlagTo.Size = New System.Drawing.Size(130, 101)
        Me.pbFlagTo.TabIndex = 1
        Me.pbFlagTo.TabStop = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(155, 113)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 18)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "0.0"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(107, 227)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pbFlagFrom
        '
        Me.pbFlagFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlagFrom.Image = Global.WindowsApplication1.My.Resources.Resources.australia
        Me.pbFlagFrom.Location = New System.Drawing.Point(2, 9)
        Me.pbFlagFrom.Name = "pbFlagFrom"
        Me.pbFlagFrom.Size = New System.Drawing.Size(130, 101)
        Me.pbFlagFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlagFrom.TabIndex = 4
        Me.pbFlagFrom.TabStop = False
        '
        'gpbTransferFrom
        '
        Me.gpbTransferFrom.BackColor = System.Drawing.Color.Transparent
        Me.gpbTransferFrom.Controls.Add(Me.RadioButton3)
        Me.gpbTransferFrom.Controls.Add(Me.RadioButton2)
        Me.gpbTransferFrom.Controls.Add(Me.rdbUSA)
        Me.gpbTransferFrom.ForeColor = System.Drawing.Color.Crimson
        Me.gpbTransferFrom.Location = New System.Drawing.Point(2, 116)
        Me.gpbTransferFrom.Name = "gpbTransferFrom"
        Me.gpbTransferFrom.Size = New System.Drawing.Size(130, 92)
        Me.gpbTransferFrom.TabIndex = 5
        Me.gpbTransferFrom.TabStop = False
        Me.gpbTransferFrom.Text = "Choose a currency:"
        '
        'rdbUSA
        '
        Me.rdbUSA.AutoSize = True
        Me.rdbUSA.Checked = True
        Me.rdbUSA.ForeColor = System.Drawing.Color.Crimson
        Me.rdbUSA.Location = New System.Drawing.Point(6, 19)
        Me.rdbUSA.Name = "rdbUSA"
        Me.rdbUSA.Size = New System.Drawing.Size(47, 17)
        Me.rdbUSA.TabIndex = 0
        Me.rdbUSA.TabStop = True
        Me.rdbUSA.Text = "USA"
        Me.rdbUSA.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.triangle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.gpbTransferFrom)
        Me.Controls.Add(Me.pbFlagFrom)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.pbFlagTo)
        Me.Controls.Add(Me.vSclCurValue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "converter"
        Me.Text = "converter"
        CType(Me.pbFlagTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlagFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbTransferFrom.ResumeLayout(False)
        Me.gpbTransferFrom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vSclCurValue As System.Windows.Forms.VScrollBar
    Friend WithEvents pbFlagTo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pbFlagFrom As System.Windows.Forms.PictureBox
    Friend WithEvents gpbTransferFrom As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUSA As System.Windows.Forms.RadioButton
End Class
