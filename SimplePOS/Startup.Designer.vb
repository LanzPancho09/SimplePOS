<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.pgbar = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.tmloading = New System.Windows.Forms.Timer(Me.components)
        Me.lblloading = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlactivation = New Guna.UI.WinForms.GunaPanel()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtact5 = New Guna.UI.WinForms.GunaTextBox()
        Me.txtact4 = New Guna.UI.WinForms.GunaTextBox()
        Me.txtact2 = New Guna.UI.WinForms.GunaTextBox()
        Me.txtact3 = New Guna.UI.WinForms.GunaTextBox()
        Me.txtact1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.btnactivate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnbuy = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.pnlactivation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 0
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(131, 57)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(344, 18)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "POINT OF SALE AND INVENTORY SYSTEM 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pgbar
        '
        Me.pgbar.BackColor = System.Drawing.Color.Transparent
        Me.pgbar.BorderColor = System.Drawing.Color.Black
        Me.pgbar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.pgbar.IdleColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbar.Location = New System.Drawing.Point(235, 237)
        Me.pgbar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pgbar.Name = "pgbar"
        Me.pgbar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgbar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgbar.Radius = 1
        Me.pgbar.Size = New System.Drawing.Size(389, 4)
        Me.pgbar.TabIndex = 2
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel2.Location = New System.Drawing.Point(499, 319)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GunaLabel2.Size = New System.Drawing.Size(252, 12)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = ".COPYRIGHTED 2020 VERSION ALL RIGHTS RESERVED"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(4, 6)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(118, 118)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(109, 103)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(525, 130)
        Me.GunaShadowPanel1.TabIndex = 4
        '
        'tmloading
        '
        Me.tmloading.Interval = 20
        '
        'lblloading
        '
        Me.lblloading.AutoSize = True
        Me.lblloading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloading.ForeColor = System.Drawing.Color.White
        Me.lblloading.Location = New System.Drawing.Point(235, 246)
        Me.lblloading.Name = "lblloading"
        Me.lblloading.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblloading.Size = New System.Drawing.Size(54, 13)
        Me.lblloading.TabIndex = 5
        Me.lblloading.Text = "Loading..."
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel3.Location = New System.Drawing.Point(148, 239)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(41, 13)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Ver 1.0"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 2
        Me.GunaElipse2.TargetControl = Me
        '
        'pnlactivation
        '
        Me.pnlactivation.Controls.Add(Me.GunaAdvenceButton2)
        Me.pnlactivation.Controls.Add(Me.txtact5)
        Me.pnlactivation.Controls.Add(Me.txtact4)
        Me.pnlactivation.Controls.Add(Me.txtact2)
        Me.pnlactivation.Controls.Add(Me.txtact3)
        Me.pnlactivation.Controls.Add(Me.txtact1)
        Me.pnlactivation.Controls.Add(Me.GunaLabel5)
        Me.pnlactivation.Controls.Add(Me.btnactivate)
        Me.pnlactivation.Controls.Add(Me.GunaLabel4)
        Me.pnlactivation.Controls.Add(Me.btnbuy)
        Me.pnlactivation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlactivation.Location = New System.Drawing.Point(0, 0)
        Me.pnlactivation.Name = "pnlactivation"
        Me.pnlactivation.Size = New System.Drawing.Size(776, 339)
        Me.pnlactivation.TabIndex = 7
        Me.pnlactivation.Visible = False
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
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(12, 12)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 20
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(45, 42)
        Me.GunaAdvenceButton2.TabIndex = 8
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtact5
        '
        Me.txtact5.BackColor = System.Drawing.Color.Transparent
        Me.txtact5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact5.BorderColor = System.Drawing.Color.Silver
        Me.txtact5.BorderSize = 1
        Me.txtact5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtact5.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtact5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact5.FocusedForeColor = System.Drawing.Color.White
        Me.txtact5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtact5.ForeColor = System.Drawing.Color.White
        Me.txtact5.Location = New System.Drawing.Point(498, 153)
        Me.txtact5.MaxLength = 4
        Me.txtact5.Name = "txtact5"
        Me.txtact5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtact5.Radius = 5
        Me.txtact5.Size = New System.Drawing.Size(81, 30)
        Me.txtact5.TabIndex = 16
        Me.txtact5.Text = "XXXX"
        Me.txtact5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtact4
        '
        Me.txtact4.BackColor = System.Drawing.Color.Transparent
        Me.txtact4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact4.BorderColor = System.Drawing.Color.Silver
        Me.txtact4.BorderSize = 1
        Me.txtact4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtact4.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtact4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact4.FocusedForeColor = System.Drawing.Color.White
        Me.txtact4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtact4.ForeColor = System.Drawing.Color.White
        Me.txtact4.Location = New System.Drawing.Point(411, 153)
        Me.txtact4.MaxLength = 4
        Me.txtact4.Name = "txtact4"
        Me.txtact4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtact4.Radius = 5
        Me.txtact4.Size = New System.Drawing.Size(81, 30)
        Me.txtact4.TabIndex = 15
        Me.txtact4.Text = "XXXX"
        Me.txtact4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtact2
        '
        Me.txtact2.BackColor = System.Drawing.Color.Transparent
        Me.txtact2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact2.BorderColor = System.Drawing.Color.Silver
        Me.txtact2.BorderSize = 1
        Me.txtact2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtact2.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtact2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact2.FocusedForeColor = System.Drawing.Color.White
        Me.txtact2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtact2.ForeColor = System.Drawing.Color.White
        Me.txtact2.Location = New System.Drawing.Point(237, 153)
        Me.txtact2.MaxLength = 4
        Me.txtact2.Name = "txtact2"
        Me.txtact2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtact2.Radius = 5
        Me.txtact2.Size = New System.Drawing.Size(81, 30)
        Me.txtact2.TabIndex = 14
        Me.txtact2.Text = "XXXX"
        Me.txtact2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtact3
        '
        Me.txtact3.BackColor = System.Drawing.Color.Transparent
        Me.txtact3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact3.BorderColor = System.Drawing.Color.Silver
        Me.txtact3.BorderSize = 1
        Me.txtact3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtact3.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtact3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact3.FocusedForeColor = System.Drawing.Color.White
        Me.txtact3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtact3.ForeColor = System.Drawing.Color.White
        Me.txtact3.Location = New System.Drawing.Point(324, 153)
        Me.txtact3.MaxLength = 4
        Me.txtact3.Name = "txtact3"
        Me.txtact3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtact3.Radius = 5
        Me.txtact3.Size = New System.Drawing.Size(81, 30)
        Me.txtact3.TabIndex = 14
        Me.txtact3.Text = "XXXX"
        Me.txtact3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtact1
        '
        Me.txtact1.BackColor = System.Drawing.Color.Transparent
        Me.txtact1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact1.BorderColor = System.Drawing.Color.Silver
        Me.txtact1.BorderSize = 1
        Me.txtact1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtact1.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtact1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtact1.FocusedForeColor = System.Drawing.Color.White
        Me.txtact1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtact1.ForeColor = System.Drawing.Color.White
        Me.txtact1.Location = New System.Drawing.Point(150, 153)
        Me.txtact1.MaxLength = 4
        Me.txtact1.Name = "txtact1"
        Me.txtact1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtact1.Radius = 5
        Me.txtact1.Size = New System.Drawing.Size(81, 30)
        Me.txtact1.TabIndex = 13
        Me.txtact1.Text = "XXXX"
        Me.txtact1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel5.Location = New System.Drawing.Point(626, 269)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(86, 13)
        Me.GunaLabel5.TabIndex = 12
        Me.GunaLabel5.Text = "Dont Have Key?"
        Me.GunaLabel5.Visible = False
        '
        'btnactivate
        '
        Me.btnactivate.Animated = True
        Me.btnactivate.AnimationHoverSpeed = 0.07!
        Me.btnactivate.AnimationSpeed = 0.03!
        Me.btnactivate.BackColor = System.Drawing.Color.Transparent
        Me.btnactivate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnactivate.BorderColor = System.Drawing.Color.Black
        Me.btnactivate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnactivate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnactivate.CheckedForeColor = System.Drawing.Color.White
        Me.btnactivate.CheckedImage = CType(resources.GetObject("btnactivate.CheckedImage"), System.Drawing.Image)
        Me.btnactivate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnactivate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnactivate.FocusedColor = System.Drawing.Color.Empty
        Me.btnactivate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactivate.ForeColor = System.Drawing.Color.White
        Me.btnactivate.Image = CType(resources.GetObject("btnactivate.Image"), System.Drawing.Image)
        Me.btnactivate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnactivate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnactivate.Location = New System.Drawing.Point(277, 193)
        Me.btnactivate.Name = "btnactivate"
        Me.btnactivate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnactivate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnactivate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnactivate.OnHoverImage = Nothing
        Me.btnactivate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnactivate.OnPressedColor = System.Drawing.Color.Black
        Me.btnactivate.Radius = 5
        Me.btnactivate.Size = New System.Drawing.Size(180, 42)
        Me.btnactivate.TabIndex = 11
        Me.btnactivate.Text = "Activate"
        Me.btnactivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(143, 109)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(254, 37)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Enter Activation Key"
        '
        'btnbuy
        '
        Me.btnbuy.Animated = True
        Me.btnbuy.AnimationHoverSpeed = 0.07!
        Me.btnbuy.AnimationSpeed = 0.03!
        Me.btnbuy.BackColor = System.Drawing.Color.Transparent
        Me.btnbuy.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbuy.BorderColor = System.Drawing.Color.Black
        Me.btnbuy.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnbuy.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnbuy.CheckedForeColor = System.Drawing.Color.White
        Me.btnbuy.CheckedImage = CType(resources.GetObject("btnbuy.CheckedImage"), System.Drawing.Image)
        Me.btnbuy.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnbuy.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbuy.FocusedColor = System.Drawing.Color.Empty
        Me.btnbuy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuy.ForeColor = System.Drawing.Color.White
        Me.btnbuy.Image = CType(resources.GetObject("btnbuy.Image"), System.Drawing.Image)
        Me.btnbuy.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbuy.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnbuy.Location = New System.Drawing.Point(584, 285)
        Me.btnbuy.Name = "btnbuy"
        Me.btnbuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbuy.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuy.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuy.OnHoverImage = Nothing
        Me.btnbuy.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnbuy.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuy.Radius = 5
        Me.btnbuy.Size = New System.Drawing.Size(180, 42)
        Me.btnbuy.TabIndex = 5
        Me.btnbuy.Text = "BUY NOW $100"
        Me.btnbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnbuy.Visible = False
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 339)
        Me.Controls.Add(Me.pnlactivation)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.lblloading)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.pgbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.pnlactivation.ResumeLayout(False)
        Me.pnlactivation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pgbar As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents tmloading As System.Windows.Forms.Timer
    Friend WithEvents lblloading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnlactivation As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnbuy As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnactivate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtact1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtact5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtact4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtact2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtact3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
End Class
