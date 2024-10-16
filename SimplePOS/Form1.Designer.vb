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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtuser = New Guna.UI.WinForms.GunaTextBox()
        Me.txtpass = New Guna.UI.WinForms.GunaTextBox()
        Me.Btnlogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblnc = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.userprofile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Transparent
        Me.txtuser.BaseColor = System.Drawing.Color.White
        Me.txtuser.BorderColor = System.Drawing.Color.Silver
        Me.txtuser.BorderSize = 0
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtuser.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtuser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.DarkGray
        Me.txtuser.Location = New System.Drawing.Point(35, 5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.Radius = 15
        Me.txtuser.Size = New System.Drawing.Size(207, 30)
        Me.txtuser.TabIndex = 1
        Me.txtuser.Text = "Username"
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.BaseColor = System.Drawing.Color.White
        Me.txtpass.BorderColor = System.Drawing.Color.Silver
        Me.txtpass.BorderSize = 0
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpass.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtpass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.DarkGray
        Me.txtpass.Location = New System.Drawing.Point(35, 5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpass.Radius = 15
        Me.txtpass.Size = New System.Drawing.Size(207, 30)
        Me.txtpass.TabIndex = 2
        Me.txtpass.Text = "Password"
        '
        'Btnlogin
        '
        Me.Btnlogin.Animated = True
        Me.Btnlogin.AnimationHoverSpeed = 0.07!
        Me.Btnlogin.AnimationSpeed = 0.03!
        Me.Btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Btnlogin.BorderColor = System.Drawing.Color.Black
        Me.Btnlogin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btnlogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btnlogin.CheckedForeColor = System.Drawing.Color.White
        Me.Btnlogin.CheckedImage = Nothing
        Me.Btnlogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnlogin.FocusedColor = System.Drawing.Color.Empty
        Me.Btnlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.ForeColor = System.Drawing.Color.White
        Me.Btnlogin.Image = Nothing
        Me.Btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnlogin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btnlogin.Location = New System.Drawing.Point(66, 392)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.Btnlogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnlogin.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnlogin.OnHoverImage = Nothing
        Me.Btnlogin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btnlogin.OnPressedColor = System.Drawing.Color.Black
        Me.Btnlogin.Radius = 20
        Me.Btnlogin.Size = New System.Drawing.Size(167, 42)
        Me.Btnlogin.TabIndex = 3
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(195, 19)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(81, 28)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Log in"
        '
        'lblnc
        '
        Me.lblnc.AutoSize = True
        Me.lblnc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblnc.Location = New System.Drawing.Point(87, 362)
        Me.lblnc.Name = "lblnc"
        Me.lblnc.Size = New System.Drawing.Size(124, 17)
        Me.lblnc.TabIndex = 6
        Me.lblnc.Text = "Incorrect Password"
        Me.lblnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblnc.Visible = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.txtuser)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(31, 248)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 15
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(245, 41)
        Me.GunaElipsePanel1.TabIndex = 9
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 7
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.GunaElipsePanel2.Controls.Add(Me.txtpass)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(31, 295)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 15
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(245, 41)
        Me.GunaElipsePanel2.TabIndex = 10
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 8
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaCheckBox1.Location = New System.Drawing.Point(36, 339)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox1.TabIndex = 13
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.Animated = True
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(9, 9)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 20
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(45, 42)
        Me.GunaAdvenceButton2.TabIndex = 4
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userprofile
        '
        Me.userprofile.BaseColor = System.Drawing.Color.White
        Me.userprofile.Image = CType(resources.GetObject("userprofile.Image"), System.Drawing.Image)
        Me.userprofile.Location = New System.Drawing.Point(77, 67)
        Me.userprofile.Name = "userprofile"
        Me.userprofile.Size = New System.Drawing.Size(150, 150)
        Me.userprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userprofile.TabIndex = 14
        Me.userprofile.TabStop = False
        Me.userprofile.UseTransfarantBackground = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(299, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.userprofile)
        Me.Controls.Add(Me.GunaCheckBox1)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.lblnc)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.Btnlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaElipsePanel1.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtpass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Btnlogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblnc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents userprofile As Guna.UI.WinForms.GunaCirclePictureBox
End Class
