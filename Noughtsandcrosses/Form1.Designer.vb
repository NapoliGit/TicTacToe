<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TL = New System.Windows.Forms.Button()
        Me.TM = New System.Windows.Forms.Button()
        Me.TR = New System.Windows.Forms.Button()
        Me.ML = New System.Windows.Forms.Button()
        Me.MM = New System.Windows.Forms.Button()
        Me.MR = New System.Windows.Forms.Button()
        Me.BL = New System.Windows.Forms.Button()
        Me.BM = New System.Windows.Forms.Button()
        Me.BR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TL
        '
        Me.TL.Location = New System.Drawing.Point(279, 76)
        Me.TL.Name = "TL"
        Me.TL.Size = New System.Drawing.Size(70, 66)
        Me.TL.TabIndex = 0
        Me.TL.UseVisualStyleBackColor = True
        '
        'TM
        '
        Me.TM.Location = New System.Drawing.Point(355, 76)
        Me.TM.Name = "TM"
        Me.TM.Size = New System.Drawing.Size(70, 66)
        Me.TM.TabIndex = 1
        Me.TM.UseVisualStyleBackColor = True
        '
        'TR
        '
        Me.TR.Location = New System.Drawing.Point(431, 76)
        Me.TR.Name = "TR"
        Me.TR.Size = New System.Drawing.Size(70, 66)
        Me.TR.TabIndex = 2
        Me.TR.UseVisualStyleBackColor = True
        '
        'ML
        '
        Me.ML.Location = New System.Drawing.Point(279, 148)
        Me.ML.Name = "ML"
        Me.ML.Size = New System.Drawing.Size(70, 66)
        Me.ML.TabIndex = 5
        Me.ML.UseVisualStyleBackColor = True
        '
        'MM
        '
        Me.MM.Location = New System.Drawing.Point(355, 148)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(70, 66)
        Me.MM.TabIndex = 4
        Me.MM.UseVisualStyleBackColor = True
        '
        'MR
        '
        Me.MR.Location = New System.Drawing.Point(431, 148)
        Me.MR.Name = "MR"
        Me.MR.Size = New System.Drawing.Size(70, 66)
        Me.MR.TabIndex = 3
        Me.MR.UseVisualStyleBackColor = True
        '
        'BL
        '
        Me.BL.Location = New System.Drawing.Point(279, 220)
        Me.BL.Name = "BL"
        Me.BL.Size = New System.Drawing.Size(70, 66)
        Me.BL.TabIndex = 8
        Me.BL.UseVisualStyleBackColor = True
        '
        'BM
        '
        Me.BM.Location = New System.Drawing.Point(355, 220)
        Me.BM.Name = "BM"
        Me.BM.Size = New System.Drawing.Size(70, 66)
        Me.BM.TabIndex = 7
        Me.BM.UseVisualStyleBackColor = True
        '
        'BR
        '
        Me.BR.Location = New System.Drawing.Point(431, 220)
        Me.BR.Name = "BR"
        Me.BR.Size = New System.Drawing.Size(70, 66)
        Me.BR.TabIndex = 6
        Me.BR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(231, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "WINNER : To be decided"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(134, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 39)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tic Tac Toe / Noughts and Crosses"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(610, 191)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "RESTART"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BL)
        Me.Controls.Add(Me.BM)
        Me.Controls.Add(Me.BR)
        Me.Controls.Add(Me.ML)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.MR)
        Me.Controls.Add(Me.TR)
        Me.Controls.Add(Me.TM)
        Me.Controls.Add(Me.TL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TL As Button
    Friend WithEvents TM As Button
    Friend WithEvents TR As Button
    Friend WithEvents ML As Button
    Friend WithEvents MM As Button
    Friend WithEvents MR As Button
    Friend WithEvents BL As Button
    Friend WithEvents BM As Button
    Friend WithEvents BR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button10 As Button
End Class
