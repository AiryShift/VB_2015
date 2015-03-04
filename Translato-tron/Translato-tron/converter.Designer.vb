<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrencyChange))
        Me.vSclCurValue = New System.Windows.Forms.VScrollBar()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gpbTransferFrom = New System.Windows.Forms.GroupBox()
        Me.rdbAUS = New System.Windows.Forms.RadioButton()
        Me.rdbEurope = New System.Windows.Forms.RadioButton()
        Me.rdbUSA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbFlagFrom = New System.Windows.Forms.PictureBox()
        Me.pbFlagTo = New System.Windows.Forms.PictureBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.gpbTransferFrom.SuspendLayout()
        CType(Me.pbFlagFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlagTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vSclCurValue
        '
        Me.vSclCurValue.Location = New System.Drawing.Point(135, 30)
        Me.vSclCurValue.Maximum = 2500
        Me.vSclCurValue.Name = "vSclCurValue"
        Me.vSclCurValue.Size = New System.Drawing.Size(17, 215)
        Me.vSclCurValue.TabIndex = 0
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(155, 137)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 18)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "0.0"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(108, 248)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gpbTransferFrom
        '
        Me.gpbTransferFrom.BackColor = System.Drawing.Color.Transparent
        Me.gpbTransferFrom.Controls.Add(Me.rdbAUS)
        Me.gpbTransferFrom.Controls.Add(Me.rdbEurope)
        Me.gpbTransferFrom.Controls.Add(Me.rdbUSA)
        Me.gpbTransferFrom.ForeColor = System.Drawing.Color.White
        Me.gpbTransferFrom.Location = New System.Drawing.Point(2, 154)
        Me.gpbTransferFrom.Name = "gpbTransferFrom"
        Me.gpbTransferFrom.Size = New System.Drawing.Size(130, 91)
        Me.gpbTransferFrom.TabIndex = 5
        Me.gpbTransferFrom.TabStop = False
        Me.gpbTransferFrom.Text = "Choose a currency:"
        '
        'rdbAUS
        '
        Me.rdbAUS.AutoSize = True
        Me.rdbAUS.ForeColor = System.Drawing.Color.White
        Me.rdbAUS.Location = New System.Drawing.Point(6, 65)
        Me.rdbAUS.Name = "rdbAUS"
        Me.rdbAUS.Size = New System.Drawing.Size(48, 17)
        Me.rdbAUS.TabIndex = 2
        Me.rdbAUS.Text = "AUD"
        Me.rdbAUS.UseVisualStyleBackColor = True
        '
        'rdbEurope
        '
        Me.rdbEurope.AutoSize = True
        Me.rdbEurope.ForeColor = System.Drawing.Color.White
        Me.rdbEurope.Location = New System.Drawing.Point(6, 42)
        Me.rdbEurope.Name = "rdbEurope"
        Me.rdbEurope.Size = New System.Drawing.Size(48, 17)
        Me.rdbEurope.TabIndex = 1
        Me.rdbEurope.Text = "EUR"
        Me.rdbEurope.UseVisualStyleBackColor = True
        '
        'rdbUSA
        '
        Me.rdbUSA.AutoSize = True
        Me.rdbUSA.Checked = True
        Me.rdbUSA.ForeColor = System.Drawing.Color.White
        Me.rdbUSA.Location = New System.Drawing.Point(6, 19)
        Me.rdbUSA.Name = "rdbUSA"
        Me.rdbUSA.Size = New System.Drawing.Size(47, 17)
        Me.rdbUSA.TabIndex = 0
        Me.rdbUSA.TabStop = True
        Me.rdbUSA.Text = "USA"
        Me.rdbUSA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Correct as at 2015-03-02"
        '
        'pbFlagFrom
        '
        Me.pbFlagFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlagFrom.Image = Global.WindowsApplication1.My.Resources.Resources.usa
        Me.pbFlagFrom.Location = New System.Drawing.Point(2, 30)
        Me.pbFlagFrom.Name = "pbFlagFrom"
        Me.pbFlagFrom.Size = New System.Drawing.Size(130, 101)
        Me.pbFlagFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlagFrom.TabIndex = 4
        Me.pbFlagFrom.TabStop = False
        '
        'pbFlagTo
        '
        Me.pbFlagTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlagTo.Location = New System.Drawing.Point(155, 30)
        Me.pbFlagTo.Name = "pbFlagTo"
        Me.pbFlagTo.Size = New System.Drawing.Size(130, 101)
        Me.pbFlagTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlagTo.TabIndex = 1
        Me.pbFlagTo.TabStop = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.White
        Me.lblFrom.Location = New System.Drawing.Point(-1, 137)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(28, 18)
        Me.lblFrom.TabIndex = 7
        Me.lblFrom.Text = "0.0"
        '
        'CurrencyChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 283)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbTransferFrom)
        Me.Controls.Add(Me.pbFlagFrom)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.pbFlagTo)
        Me.Controls.Add(Me.vSclCurValue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CurrencyChange"
        Me.Text = "Currency Converter"
        Me.gpbTransferFrom.ResumeLayout(False)
        Me.gpbTransferFrom.PerformLayout()
        CType(Me.pbFlagFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlagTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vSclCurValue As System.Windows.Forms.VScrollBar
    Friend WithEvents pbFlagTo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pbFlagFrom As System.Windows.Forms.PictureBox
    Friend WithEvents gpbTransferFrom As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAUS As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEurope As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUSA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
End Class
