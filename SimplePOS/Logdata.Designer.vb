<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logdata
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
        Me.lblProdName = New Guna.UI.WinForms.GunaLabel()
        Me.lblHistory = New Guna.UI.WinForms.GunaLabel()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblDate = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblLogId
        '
        Me.lblLogId.BackColor = System.Drawing.Color.IndianRed
        Me.lblLogId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLogId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLogId.Location = New System.Drawing.Point(19, 9)
        Me.lblLogId.Name = "lblLogId"
        Me.lblLogId.Size = New System.Drawing.Size(221, 15)
        Me.lblLogId.TabIndex = 1
        Me.lblLogId.Text = "LOG ID"
        '
        'lblProdName
        '
        Me.lblProdName.BackColor = System.Drawing.Color.IndianRed
        Me.lblProdName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProdName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProdName.Location = New System.Drawing.Point(345, 9)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(105, 15)
        Me.lblProdName.TabIndex = 2
        Me.lblProdName.Text = "PRODUCT NAME"
        '
        'lblHistory
        '
        Me.lblHistory.BackColor = System.Drawing.Color.IndianRed
        Me.lblHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHistory.Location = New System.Drawing.Point(575, 9)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(165, 15)
        Me.lblHistory.TabIndex = 3
        Me.lblHistory.Text = "ACTION/STOCK IN"
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
        Me.btndelete.Location = New System.Drawing.Point(1232, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Radius = 5
        Me.btndelete.Size = New System.Drawing.Size(98, 22)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.IndianRed
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(843, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(313, 15)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "DATE"
        '
        'Logdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblProdName)
        Me.Controls.Add(Me.lblLogId)
        Me.Name = "Logdata"
        Me.Size = New System.Drawing.Size(1347, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogId As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHistory As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblDate As Guna.UI.WinForms.GunaLabel
End Class
