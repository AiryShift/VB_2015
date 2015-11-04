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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.lblRedLaps = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblYellowLaps = New System.Windows.Forms.Label()
        Me.picRedCar = New System.Windows.Forms.PictureBox()
        Me.picYellowCar = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.tmrRace = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellowCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRedLaps
        '
        Me.lblRedLaps.AutoSize = True
        Me.lblRedLaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRedLaps.Location = New System.Drawing.Point(216, 84)
        Me.lblRedLaps.Name = "lblRedLaps"
        Me.lblRedLaps.Size = New System.Drawing.Size(15, 15)
        Me.lblRedLaps.TabIndex = 0
        Me.lblRedLaps.Text = "0"
        Me.lblRedLaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lap Count"
        '
        'lblYellowLaps
        '
        Me.lblYellowLaps.AutoSize = True
        Me.lblYellowLaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYellowLaps.Location = New System.Drawing.Point(253, 84)
        Me.lblYellowLaps.Name = "lblYellowLaps"
        Me.lblYellowLaps.Size = New System.Drawing.Size(15, 15)
        Me.lblYellowLaps.TabIndex = 2
        Me.lblYellowLaps.Text = "0"
        Me.lblYellowLaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picRedCar
        '
        Me.picRedCar.Image = CType(resources.GetObject("picRedCar.Image"), System.Drawing.Image)
        Me.picRedCar.Location = New System.Drawing.Point(310, 16)
        Me.picRedCar.Name = "picRedCar"
        Me.picRedCar.Size = New System.Drawing.Size(100, 50)
        Me.picRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedCar.TabIndex = 3
        Me.picRedCar.TabStop = False
        '
        'picYellowCar
        '
        Me.picYellowCar.Image = CType(resources.GetObject("picYellowCar.Image"), System.Drawing.Image)
        Me.picYellowCar.Location = New System.Drawing.Point(310, 105)
        Me.picYellowCar.Name = "picYellowCar"
        Me.picYellowCar.Size = New System.Drawing.Size(100, 50)
        Me.picYellowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYellowCar.TabIndex = 4
        Me.picYellowCar.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(310, 76)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'tmrRace
        '
        Me.tmrRace.Interval = 1
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 167)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picYellowCar)
        Me.Controls.Add(Me.picRedCar)
        Me.Controls.Add(Me.lblYellowLaps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRedLaps)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grand Prix"
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellowCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRedLaps As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblYellowLaps As System.Windows.Forms.Label
    Friend WithEvents picRedCar As System.Windows.Forms.PictureBox
    Friend WithEvents picYellowCar As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents tmrRace As System.Windows.Forms.Timer

End Class
