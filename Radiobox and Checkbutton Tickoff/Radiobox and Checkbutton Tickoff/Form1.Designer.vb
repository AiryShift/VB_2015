<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fonts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fonts))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.rdbFontJoke = New System.Windows.Forms.RadioButton()
        Me.rdbFontComic = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Jokerman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 28)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(260, 24)
        Me.txtInput.TabIndex = 0
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(12, 137)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(51, 17)
        Me.chkBold.TabIndex = 1
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(12, 160)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(48, 17)
        Me.chkItalic.TabIndex = 2
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'rdbFontJoke
        '
        Me.rdbFontJoke.AutoSize = True
        Me.rdbFontJoke.Checked = True
        Me.rdbFontJoke.Font = New System.Drawing.Font("Jokerman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFontJoke.Location = New System.Drawing.Point(99, 136)
        Me.rdbFontJoke.Name = "rdbFontJoke"
        Me.rdbFontJoke.Size = New System.Drawing.Size(81, 21)
        Me.rdbFontJoke.TabIndex = 3
        Me.rdbFontJoke.TabStop = True
        Me.rdbFontJoke.Text = "Jokerman"
        Me.rdbFontJoke.UseVisualStyleBackColor = True
        '
        'rdbFontComic
        '
        Me.rdbFontComic.AutoSize = True
        Me.rdbFontComic.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFontComic.Location = New System.Drawing.Point(99, 159)
        Me.rdbFontComic.Name = "rdbFontComic"
        Me.rdbFontComic.Size = New System.Drawing.Size(84, 19)
        Me.rdbFontComic.TabIndex = 4
        Me.rdbFontComic.Text = "Comic Sans"
        Me.rdbFontComic.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Location = New System.Drawing.Point(12, 9)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(131, 13)
        Me.lblInst.TabIndex = 6
        Me.lblInst.Text = "Enter some text to convert"
        '
        'Fonts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 195)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rdbFontComic)
        Me.Controls.Add(Me.rdbFontJoke)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.txtInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fonts"
        Me.Text = "Font Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents chkBold As System.Windows.Forms.CheckBox
    Friend WithEvents chkItalic As System.Windows.Forms.CheckBox
    Friend WithEvents rdbFontJoke As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFontComic As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInst As System.Windows.Forms.Label

End Class
