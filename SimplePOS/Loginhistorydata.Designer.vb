<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginhistorydata
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
        Me.lblusername = New Guna.UI.WinForms.GunaLabel()
        Me.lblaccesstype = New Guna.UI.WinForms.GunaLabel()
        Me.lbllogin = New Guna.UI.WinForms.GunaLabel()
        Me.lbllogout = New Guna.UI.WinForms.GunaLabel()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblusername.Location = New System.Drawing.Point(105, 10)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(68, 15)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "USERNAME"
        '
        'lblaccesstype
        '
        Me.lblaccesstype.AutoSize = True
        Me.lblaccesstype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblaccesstype.Location = New System.Drawing.Point(348, 11)
        Me.lblaccesstype.Name = "lblaccesstype"
        Me.lblaccesstype.Size = New System.Drawing.Size(78, 15)
        Me.lblaccesstype.TabIndex = 1
        Me.lblaccesstype.Text = "ACCESS TYPE"
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbllogin.Location = New System.Drawing.Point(606, 10)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(45, 15)
        Me.lbllogin.TabIndex = 2
        Me.lbllogin.Text = "LOG IN"
        '
        'lbllogout
        '
        Me.lbllogout.AutoSize = True
        Me.lbllogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbllogout.Location = New System.Drawing.Point(883, 10)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(56, 15)
        Me.lbllogout.TabIndex = 3
        Me.lbllogout.Text = "LOG OUT"
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
        Me.btndelete.Location = New System.Drawing.Point(1128, 7)
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
        'Loginhistorydata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lbllogout)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.lblaccesstype)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "Loginhistorydata"
        Me.Size = New System.Drawing.Size(1347, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblaccesstype As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbllogin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbllogout As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton

End Class
