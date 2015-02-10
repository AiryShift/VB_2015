<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyExchange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrencyExchange))
        Me.hsbSlider = New System.Windows.Forms.HScrollBar()
        Me.lblAus = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.rdbUSD = New System.Windows.Forms.RadioButton()
        Me.rdbGB = New System.Windows.Forms.RadioButton()
        Me.rdbBitCoin = New System.Windows.Forms.RadioButton()
        Me.rdbDogeCoin = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.plcOther = New System.Windows.Forms.PictureBox()
        Me.plcAus = New System.Windows.Forms.PictureBox()
        Me.lblScrollInst = New System.Windows.Forms.Label()
        Me.lblSwitchInst = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.plcOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plcAus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hsbSlider
        '
        Me.hsbSlider.Location = New System.Drawing.Point(9, 236)
        Me.hsbSlider.Maximum = 10000
        Me.hsbSlider.Name = "hsbSlider"
        Me.hsbSlider.Size = New System.Drawing.Size(656, 17)
        Me.hsbSlider.TabIndex = 0
        '
        'lblAus
        '
        Me.lblAus.AutoSize = True
        Me.lblAus.Location = New System.Drawing.Point(80, 138)
        Me.lblAus.Name = "lblAus"
        Me.lblAus.Size = New System.Drawing.Size(13, 13)
        Me.lblAus.TabIndex = 1
        Me.lblAus.Text = "0"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Blackadder ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(211, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(271, 48)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "Currency Exchange"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(486, 138)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(13, 13)
        Me.lblOther.TabIndex = 5
        Me.lblOther.Text = "0"
        '
        'rdbUSD
        '
        Me.rdbUSD.AutoSize = True
        Me.rdbUSD.Location = New System.Drawing.Point(595, 67)
        Me.rdbUSD.Name = "rdbUSD"
        Me.rdbUSD.Size = New System.Drawing.Size(48, 17)
        Me.rdbUSD.TabIndex = 6
        Me.rdbUSD.TabStop = True
        Me.rdbUSD.Text = "USD"
        Me.rdbUSD.UseVisualStyleBackColor = True
        '
        'rdbGB
        '
        Me.rdbGB.AutoSize = True
        Me.rdbGB.Location = New System.Drawing.Point(595, 90)
        Me.rdbGB.Name = "rdbGB"
        Me.rdbGB.Size = New System.Drawing.Size(47, 17)
        Me.rdbGB.TabIndex = 7
        Me.rdbGB.TabStop = True
        Me.rdbGB.Text = "GBP"
        Me.rdbGB.UseVisualStyleBackColor = True
        '
        'rdbBitCoin
        '
        Me.rdbBitCoin.AutoSize = True
        Me.rdbBitCoin.Location = New System.Drawing.Point(595, 111)
        Me.rdbBitCoin.Name = "rdbBitCoin"
        Me.rdbBitCoin.Size = New System.Drawing.Size(58, 17)
        Me.rdbBitCoin.TabIndex = 8
        Me.rdbBitCoin.TabStop = True
        Me.rdbBitCoin.Text = "BitCoin"
        Me.rdbBitCoin.UseVisualStyleBackColor = True
        '
        'rdbDogeCoin
        '
        Me.rdbDogeCoin.AutoSize = True
        Me.rdbDogeCoin.Location = New System.Drawing.Point(595, 134)
        Me.rdbDogeCoin.Name = "rdbDogeCoin"
        Me.rdbDogeCoin.Size = New System.Drawing.Size(72, 17)
        Me.rdbDogeCoin.TabIndex = 9
        Me.rdbDogeCoin.TabStop = True
        Me.rdbDogeCoin.Text = "DogeCoin"
        Me.rdbDogeCoin.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(277, 67)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(124, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Correct as at 2015-02-10"
        '
        'plcOther
        '
        Me.plcOther.Image = Global.WindowsApplication1.My.Resources.Resources._06_13_2013_us_flag
        Me.plcOther.Location = New System.Drawing.Point(489, 67)
        Me.plcOther.Name = "plcOther"
        Me.plcOther.Size = New System.Drawing.Size(100, 50)
        Me.plcOther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plcOther.TabIndex = 4
        Me.plcOther.TabStop = False
        '
        'plcAus
        '
        Me.plcAus.Image = CType(resources.GetObject("plcAus.Image"), System.Drawing.Image)
        Me.plcAus.Location = New System.Drawing.Point(83, 67)
        Me.plcAus.Name = "plcAus"
        Me.plcAus.Size = New System.Drawing.Size(100, 50)
        Me.plcAus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plcAus.TabIndex = 2
        Me.plcAus.TabStop = False
        '
        'lblScrollInst
        '
        Me.lblScrollInst.AutoSize = True
        Me.lblScrollInst.Location = New System.Drawing.Point(293, 236)
        Me.lblScrollInst.Name = "lblScrollInst"
        Me.lblScrollInst.Size = New System.Drawing.Size(84, 13)
        Me.lblScrollInst.TabIndex = 11
        Me.lblScrollInst.Text = "Scroll to change"
        '
        'lblSwitchInst
        '
        Me.lblSwitchInst.AutoSize = True
        Me.lblSwitchInst.Location = New System.Drawing.Point(579, 32)
        Me.lblSwitchInst.Name = "lblSwitchInst"
        Me.lblSwitchInst.Size = New System.Drawing.Size(86, 13)
        Me.lblSwitchInst.TabIndex = 12
        Me.lblSwitchInst.Text = "Swap currencies"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(0, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CurrencyExchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSwitchInst)
        Me.Controls.Add(Me.lblScrollInst)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.rdbDogeCoin)
        Me.Controls.Add(Me.rdbBitCoin)
        Me.Controls.Add(Me.rdbGB)
        Me.Controls.Add(Me.rdbUSD)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.plcOther)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.plcAus)
        Me.Controls.Add(Me.lblAus)
        Me.Controls.Add(Me.hsbSlider)
        Me.Name = "CurrencyExchange"
        Me.Text = "Currency Exchange"
        CType(Me.plcOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plcAus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hsbSlider As System.Windows.Forms.HScrollBar
    Friend WithEvents lblAus As System.Windows.Forms.Label
    Friend WithEvents plcAus As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents plcOther As System.Windows.Forms.PictureBox
    Friend WithEvents lblOther As System.Windows.Forms.Label
    Friend WithEvents rdbUSD As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGB As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBitCoin As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDogeCoin As System.Windows.Forms.RadioButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblScrollInst As System.Windows.Forms.Label
    Friend WithEvents lblSwitchInst As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
