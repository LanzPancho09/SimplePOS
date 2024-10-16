<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accountlog
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblLogId = New Guna.UI.WinForms.GunaLabel()
        Me.lblUsername = New Guna.UI.WinForms.GunaLabel()
        Me.lblHistory = New Guna.UI.WinForms.GunaLabel()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblDate = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblLogId
        '
        Me.lblLogId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLogId.Location = New System.Drawing.Point(28, 10)
        Me.lblLogId.Name = "lblLogId"
        Me.lblLogId.Size = New System.Drawing.Size(50, 15)
        Me.lblLogId.TabIndex = 2
        Me.lblLogId.Text = "LOG ID"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsername.Location = New System.Drawing.Point(302, 10)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(105, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "USERNAME"
        '
        'lblHistory
        '
        Me.lblHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHistory.Location = New System.Drawing.Point(652, 10)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(68, 15)
        Me.lblHistory.TabIndex = 5
        Me.lblHistory.Text = "HISTORY"
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.AnimationHoverSpeed = 0.07!
        Me.btndelete.AnimationSpeed = 0.03!
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BaseColor = System.Drawing.Color.Transparent
        Me.btndelete.BorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedBaseColor = System.Drawing.Color.SeaGreen
        Me.btndelete.CheckedBorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedForeColor = System.Drawing.Color.White
        Me.btndelete.CheckedImage = Nothing
        Me.btndelete.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btndelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndelete.FocusedColor = System.Drawing.Color.Empty
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Silver
        Me.btndelete.Image = Nothing
        Me.btndelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(1128, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Radius = 5
        Me.btndelete.Size = New System.Drawing.Size(98, 22)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(918, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 15)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "DATE"
        '
        'Accountlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblLogId)
        Me.Name = "Accountlog"
        Me.Size = New System.Drawing.Size(1358, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogId As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUsername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHistory As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblDate As Guna.UI.WinForms.GunaLabel
End Class
