﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formExit))
        Me.btnExitTrue = New System.Windows.Forms.Button()
        Me.btnExitFalse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExitTrue
        '
        Me.btnExitTrue.Location = New System.Drawing.Point(12, 293)
        Me.btnExitTrue.Name = "btnExitTrue"
        Me.btnExitTrue.Size = New System.Drawing.Size(75, 23)
        Me.btnExitTrue.TabIndex = 0
        Me.btnExitTrue.Text = "Yes"
        Me.btnExitTrue.UseVisualStyleBackColor = True
        '
        'btnExitFalse
        '
        Me.btnExitFalse.Location = New System.Drawing.Point(197, 293)
        Me.btnExitFalse.Name = "btnExitFalse"
        Me.btnExitFalse.Size = New System.Drawing.Size(75, 23)
        Me.btnExitFalse.TabIndex = 1
        Me.btnExitFalse.Text = "No"
        Me.btnExitFalse.UseVisualStyleBackColor = True
        '
        'formExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.triangle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 370)
        Me.Controls.Add(Me.btnExitFalse)
        Me.Controls.Add(Me.btnExitTrue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formExit"
        Me.Text = "Are you sure?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExitTrue As System.Windows.Forms.Button
    Friend WithEvents btnExitFalse As System.Windows.Forms.Button
End Class
