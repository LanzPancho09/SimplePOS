<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accountdata
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
        Me.lblPassword = New Guna.UI.WinForms.GunaLabel()
        Me.lblUsername = New Guna.UI.WinForms.GunaLabel()
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.lblaccid = New Guna.UI.WinForms.GunaLabel()
        Me.pnlbtn = New Guna.UI.WinForms.GunaPanel()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnedit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblAccType = New Guna.UI.WinForms.GunaLabel()
        Me.profileimg = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.pnlbtn.SuspendLayout()
        CType(Me.profileimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.IndianRed
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(659, 16)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(130, 15)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "PASSWORD"
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.IndianRed
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(497, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(135, 15)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "USERNAME"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.IndianRed
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(300, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(156, 15)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "NAME"
        '
        'lblaccid
        '
        Me.lblaccid.BackColor = System.Drawing.Color.IndianRed
        Me.lblaccid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblaccid.Location = New System.Drawing.Point(63, 15)
        Me.lblaccid.Name = "lblaccid"
        Me.lblaccid.Size = New System.Drawing.Size(78, 15)
        Me.lblaccid.TabIndex = 5
        Me.lblaccid.Text = "ACCOUNT ID"
        Me.lblaccid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlbtn
        '
        Me.pnlbtn.Controls.Add(Me.btndelete)
        Me.pnlbtn.Location = New System.Drawing.Point(1135, 0)
        Me.pnlbtn.Name = "pnlbtn"
        Me.pnlbtn.Size = New System.Drawing.Size(135, 46)
        Me.pnlbtn.TabIndex = 12
        '
        'btndelete
        '
        Me.btndelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btndelete.Location = New System.Drawing.Point(16, 11)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Radius = 5
        Me.btndelete.Size = New System.Drawing.Size(98, 25)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnedit
        '
        Me.btnedit.Animated = True
        Me.btnedit.AnimationHoverSpeed = 0.07!
        Me.btnedit.AnimationSpeed = 0.03!
        Me.btnedit.BackColor = System.Drawing.Color.Transparent
        Me.btnedit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnedit.BorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedBaseColor = System.Drawing.Color.SeaGreen
        Me.btnedit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedForeColor = System.Drawing.Color.White
        Me.btnedit.CheckedImage = Nothing
        Me.btnedit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnedit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnedit.FocusedColor = System.Drawing.Color.Empty
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Image = Nothing
        Me.btnedit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnedit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(1141, 11)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnedit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnedit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnedit.OnHoverImage = Nothing
        Me.btnedit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.OnPressedColor = System.Drawing.Color.Black
        Me.btnedit.Radius = 5
        Me.btnedit.Size = New System.Drawing.Size(98, 22)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAccType
        '
        Me.lblAccType.BackColor = System.Drawing.Color.IndianRed
        Me.lblAccType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAccType.Location = New System.Drawing.Point(848, 16)
        Me.lblAccType.Name = "lblAccType"
        Me.lblAccType.Size = New System.Drawing.Size(261, 15)
        Me.lblAccType.TabIndex = 14
        Me.lblAccType.Text = "ACCESS TYPE"
        '
        'profileimg
        '
        Me.profileimg.BackColor = System.Drawing.Color.Transparent
        Me.profileimg.BaseColor = System.Drawing.Color.White
        Me.profileimg.Location = New System.Drawing.Point(187, 6)
        Me.profileimg.Name = "profileimg"
        Me.profileimg.Size = New System.Drawing.Size(35, 35)
        Me.profileimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profileimg.TabIndex = 10
        Me.profileimg.TabStop = False
        Me.profileimg.UseTransfarantBackground = False
        '
        'Accountdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAccType)
        Me.Controls.Add(Me.pnlbtn)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.profileimg)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblaccid)
        Me.Name = "Accountdata"
        Me.Size = New System.Drawing.Size(1335, 46)
        Me.pnlbtn.ResumeLayout(False)
        CType(Me.profileimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPassword As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUsername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblaccid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents profileimg As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pnlbtn As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnedit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblAccType As Guna.UI.WinForms.GunaLabel

End Class
