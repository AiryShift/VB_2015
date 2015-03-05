<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class country
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(country))
        Me.gpbTranslations = New System.Windows.Forms.GroupBox()
        Me.lblInfo_1 = New System.Windows.Forms.Label()
        Me.lblInfo_2 = New System.Windows.Forms.Label()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.rdb10 = New System.Windows.Forms.RadioButton()
        Me.rdb9 = New System.Windows.Forms.RadioButton()
        Me.rdb8 = New System.Windows.Forms.RadioButton()
        Me.rdb7 = New System.Windows.Forms.RadioButton()
        Me.rdb6 = New System.Windows.Forms.RadioButton()
        Me.rdb5 = New System.Windows.Forms.RadioButton()
        Me.rdb4 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtTranslated = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCountryTo = New System.Windows.Forms.Label()
        Me.chkHide = New System.Windows.Forms.CheckBox()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.gpbTranslations.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbTranslations
        '
        Me.gpbTranslations.BackColor = System.Drawing.Color.Transparent
        Me.gpbTranslations.Controls.Add(Me.lblInfo_1)
        Me.gpbTranslations.Controls.Add(Me.lblInfo_2)
        Me.gpbTranslations.Controls.Add(Me.txt10)
        Me.gpbTranslations.Controls.Add(Me.txt2)
        Me.gpbTranslations.Controls.Add(Me.rdb10)
        Me.gpbTranslations.Controls.Add(Me.rdb9)
        Me.gpbTranslations.Controls.Add(Me.rdb8)
        Me.gpbTranslations.Controls.Add(Me.rdb7)
        Me.gpbTranslations.Controls.Add(Me.rdb6)
        Me.gpbTranslations.Controls.Add(Me.rdb5)
        Me.gpbTranslations.Controls.Add(Me.rdb4)
        Me.gpbTranslations.Controls.Add(Me.rdb3)
        Me.gpbTranslations.Controls.Add(Me.rdb2)
        Me.gpbTranslations.Controls.Add(Me.rdb1)
        Me.gpbTranslations.ForeColor = System.Drawing.Color.White
        Me.gpbTranslations.Location = New System.Drawing.Point(12, 12)
        Me.gpbTranslations.Name = "gpbTranslations"
        Me.gpbTranslations.Size = New System.Drawing.Size(309, 254)
        Me.gpbTranslations.TabIndex = 0
        Me.gpbTranslations.TabStop = False
        Me.gpbTranslations.Text = "Translating from English..."
        '
        'lblInfo_1
        '
        Me.lblInfo_1.AutoSize = True
        Me.lblInfo_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo_1.Location = New System.Drawing.Point(218, 45)
        Me.lblInfo_1.Name = "lblInfo_1"
        Me.lblInfo_1.Size = New System.Drawing.Size(84, 13)
        Me.lblInfo_1.TabIndex = 13
        Me.lblInfo_1.Text = "Enter your name"
        '
        'lblInfo_2
        '
        Me.lblInfo_2.AutoSize = True
        Me.lblInfo_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo_2.Location = New System.Drawing.Point(223, 228)
        Me.lblInfo_2.Name = "lblInfo_2"
        Me.lblInfo_2.Size = New System.Drawing.Size(79, 13)
        Me.lblInfo_2.TabIndex = 12
        Me.lblInfo_2.Text = "Enter a country"
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(82, 223)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(135, 20)
        Me.txt10.TabIndex = 11
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(99, 42)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(103, 20)
        Me.txt2.TabIndex = 10
        '
        'rdb10
        '
        Me.rdb10.AutoSize = True
        Me.rdb10.Location = New System.Drawing.Point(6, 226)
        Me.rdb10.Name = "rdb10"
        Me.rdb10.Size = New System.Drawing.Size(70, 17)
        Me.rdb10.TabIndex = 9
        Me.rdb10.Text = "I'm from..."
        Me.rdb10.UseVisualStyleBackColor = True
        '
        'rdb9
        '
        Me.rdb9.AutoSize = True
        Me.rdb9.Location = New System.Drawing.Point(6, 203)
        Me.rdb9.Name = "rdb9"
        Me.rdb9.Size = New System.Drawing.Size(76, 17)
        Me.rdb9.TabIndex = 8
        Me.rdb9.Text = "Thank you"
        Me.rdb9.UseVisualStyleBackColor = True
        '
        'rdb8
        '
        Me.rdb8.AutoSize = True
        Me.rdb8.Location = New System.Drawing.Point(6, 180)
        Me.rdb8.Name = "rdb8"
        Me.rdb8.Size = New System.Drawing.Size(68, 17)
        Me.rdb8.TabIndex = 7
        Me.rdb8.Text = "Goodbye"
        Me.rdb8.UseVisualStyleBackColor = True
        '
        'rdb7
        '
        Me.rdb7.AutoSize = True
        Me.rdb7.Location = New System.Drawing.Point(6, 157)
        Me.rdb7.Name = "rdb7"
        Me.rdb7.Size = New System.Drawing.Size(49, 17)
        Me.rdb7.TabIndex = 6
        Me.rdb7.Text = "Hello"
        Me.rdb7.UseVisualStyleBackColor = True
        '
        'rdb6
        '
        Me.rdb6.AutoSize = True
        Me.rdb6.Location = New System.Drawing.Point(6, 134)
        Me.rdb6.Name = "rdb6"
        Me.rdb6.Size = New System.Drawing.Size(196, 17)
        Me.rdb6.TabIndex = 5
        Me.rdb6.Text = "Can you show me the nearest toilet?"
        Me.rdb6.UseVisualStyleBackColor = True
        '
        'rdb5
        '
        Me.rdb5.AutoSize = True
        Me.rdb5.Location = New System.Drawing.Point(6, 111)
        Me.rdb5.Name = "rdb5"
        Me.rdb5.Size = New System.Drawing.Size(123, 17)
        Me.rdb5.TabIndex = 4
        Me.rdb5.Text = "Where is the airport?"
        Me.rdb5.UseVisualStyleBackColor = True
        '
        'rdb4
        '
        Me.rdb4.AutoSize = True
        Me.rdb4.Location = New System.Drawing.Point(6, 88)
        Me.rdb4.Name = "rdb4"
        Me.rdb4.Size = New System.Drawing.Size(148, 17)
        Me.rdb4.TabIndex = 3
        Me.rdb4.Text = "Where is the train station?"
        Me.rdb4.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Location = New System.Drawing.Point(6, 65)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(191, 17)
        Me.rdb3.TabIndex = 2
        Me.rdb3.Text = "Where can I find something to eat?"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Location = New System.Drawing.Point(6, 42)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(87, 17)
        Me.rdb2.TabIndex = 1
        Me.rdb2.Text = "My name is..."
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Checked = True
        Me.rdb1.Location = New System.Drawing.Point(6, 19)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(119, 17)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "What is your name?"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(433, 280)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(12, 280)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(309, 23)
        Me.btnConvert.TabIndex = 12
        Me.btnConvert.Text = "Currency Converter"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtTranslated
        '
        Me.txtTranslated.Location = New System.Drawing.Point(327, 192)
        Me.txtTranslated.Multiline = True
        Me.txtTranslated.Name = "txtTranslated"
        Me.txtTranslated.ReadOnly = True
        Me.txtTranslated.Size = New System.Drawing.Size(181, 74)
        Me.txtTranslated.TabIndex = 13
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(323, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(131, 22)
        Me.lblHeader.TabIndex = 14
        Me.lblHeader.Text = "Translating to"
        '
        'lblCountryTo
        '
        Me.lblCountryTo.AutoSize = True
        Me.lblCountryTo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryTo.ForeColor = System.Drawing.Color.White
        Me.lblCountryTo.Location = New System.Drawing.Point(408, 48)
        Me.lblCountryTo.Name = "lblCountryTo"
        Me.lblCountryTo.Size = New System.Drawing.Size(100, 22)
        Me.lblCountryTo.TabIndex = 15
        Me.lblCountryTo.Text = "Loading..."
        Me.lblCountryTo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkHide
        '
        Me.chkHide.AutoSize = True
        Me.chkHide.ForeColor = System.Drawing.Color.White
        Me.chkHide.Location = New System.Drawing.Point(327, 284)
        Me.chkHide.Name = "chkHide"
        Me.chkHide.Size = New System.Drawing.Size(104, 17)
        Me.chkHide.TabIndex = 16
        Me.chkHide.Text = "Hide translations"
        Me.chkHide.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(327, 163)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(181, 23)
        Me.btnRandom.TabIndex = 14
        Me.btnRandom.Text = "Random phrase"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'country
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 315)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.chkHide)
        Me.Controls.Add(Me.lblCountryTo)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.txtTranslated)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gpbTranslations)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "country"
        Me.Text = "Let's translate!"
        Me.gpbTranslations.ResumeLayout(False)
        Me.gpbTranslations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbTranslations As System.Windows.Forms.GroupBox
    Friend WithEvents rdb10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb9 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb8 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb7 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb6 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents txtTranslated As System.Windows.Forms.TextBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblCountryTo As System.Windows.Forms.Label
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents chkHide As System.Windows.Forms.CheckBox
    Friend WithEvents lblInfo_1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo_2 As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button
End Class
