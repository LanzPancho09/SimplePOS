<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Createaccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Createaccount))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlshad = New Guna.UI.WinForms.GunaPanel()
        Me.lblcreate = New Guna.UI.WinForms.GunaLabel()
        Me.txtaccid = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.lblconfirmp = New Guna.UI.WinForms.GunaLabel()
        Me.txtconfirmp = New Guna.UI.WinForms.GunaTextBox()
        Me.lblaccesstype = New Guna.UI.WinForms.GunaLabel()
        Me.cbaccesstype = New Guna.UI.WinForms.GunaComboBox()
        Me.cbcheck = New Guna.UI.WinForms.GunaCheckBox()
        Me.pnledit = New Guna.UI.WinForms.GunaPanel()
        Me.btnedit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.btncreateacc = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btneditprofile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pbprofile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.cbpassc = New Guna.UI.WinForms.GunaCheckBox()
        Me.cbind = New Guna.UI.WinForms.GunaCheckBox()
        Me.pnledit.SuspendLayout()
        CType(Me.pbprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'pnlshad
        '
        Me.pnlshad.Location = New System.Drawing.Point(2, 52)
        Me.pnlshad.Name = "pnlshad"
        Me.pnlshad.Size = New System.Drawing.Size(334, 10)
        Me.pnlshad.TabIndex = 1
        '
        'lblcreate
        '
        Me.lblcreate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreate.Location = New System.Drawing.Point(96, 16)
        Me.lblcreate.Name = "lblcreate"
        Me.lblcreate.Size = New System.Drawing.Size(139, 19)
        Me.lblcreate.TabIndex = 6
        Me.lblcreate.Text = "Create Account"
        Me.lblcreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtaccid
        '
        Me.txtaccid.BackColor = System.Drawing.Color.Transparent
        Me.txtaccid.BaseColor = System.Drawing.Color.White
        Me.txtaccid.BorderColor = System.Drawing.Color.Silver
        Me.txtaccid.BorderSize = 1
        Me.txtaccid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaccid.Enabled = False
        Me.txtaccid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtaccid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaccid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtaccid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtaccid.ForeColor = System.Drawing.Color.Silver
        Me.txtaccid.Location = New System.Drawing.Point(21, 257)
        Me.txtaccid.MaxLength = 10
        Me.txtaccid.Name = "txtaccid"
        Me.txtaccid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaccid.Radius = 15
        Me.txtaccid.Size = New System.Drawing.Size(283, 30)
        Me.txtaccid.TabIndex = 7
        Me.txtaccid.Text = "0"
        Me.txtaccid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(127, 237)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(79, 16)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Account ID"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(18, 352)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(72, 16)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BaseColor = System.Drawing.Color.White
        Me.txtusername.BorderColor = System.Drawing.Color.Silver
        Me.txtusername.BorderSize = 1
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtusername.ForeColor = System.Drawing.Color.Silver
        Me.txtusername.Location = New System.Drawing.Point(21, 371)
        Me.txtusername.MaxLength = 50
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Radius = 15
        Me.txtusername.Size = New System.Drawing.Size(283, 30)
        Me.txtusername.TabIndex = 10
        Me.txtusername.Text = "Enter Username..."
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(18, 413)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(68, 16)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BaseColor = System.Drawing.Color.White
        Me.txtpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtpassword.BorderSize = 1
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Silver
        Me.txtpassword.Location = New System.Drawing.Point(21, 432)
        Me.txtpassword.MaxLength = 50
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.Radius = 15
        Me.txtpassword.Size = New System.Drawing.Size(283, 30)
        Me.txtpassword.TabIndex = 12
        Me.txtpassword.Text = "Enter Password..."
        '
        'lblconfirmp
        '
        Me.lblconfirmp.AutoSize = True
        Me.lblconfirmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmp.Location = New System.Drawing.Point(18, 495)
        Me.lblconfirmp.Name = "lblconfirmp"
        Me.lblconfirmp.Size = New System.Drawing.Size(123, 16)
        Me.lblconfirmp.TabIndex = 15
        Me.lblconfirmp.Text = "Confirm Password"
        '
        'txtconfirmp
        '
        Me.txtconfirmp.BackColor = System.Drawing.Color.Transparent
        Me.txtconfirmp.BaseColor = System.Drawing.Color.White
        Me.txtconfirmp.BorderColor = System.Drawing.Color.Silver
        Me.txtconfirmp.BorderSize = 1
        Me.txtconfirmp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmp.FocusedBaseColor = System.Drawing.Color.White
        Me.txtconfirmp.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtconfirmp.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtconfirmp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtconfirmp.ForeColor = System.Drawing.Color.Silver
        Me.txtconfirmp.Location = New System.Drawing.Point(21, 514)
        Me.txtconfirmp.MaxLength = 50
        Me.txtconfirmp.Name = "txtconfirmp"
        Me.txtconfirmp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtconfirmp.Radius = 15
        Me.txtconfirmp.Size = New System.Drawing.Size(283, 30)
        Me.txtconfirmp.TabIndex = 14
        Me.txtconfirmp.Text = "Confirm Password..."
        '
        'lblaccesstype
        '
        Me.lblaccesstype.AutoSize = True
        Me.lblaccesstype.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccesstype.Location = New System.Drawing.Point(113, 571)
        Me.lblaccesstype.Name = "lblaccesstype"
        Me.lblaccesstype.Size = New System.Drawing.Size(89, 16)
        Me.lblaccesstype.TabIndex = 17
        Me.lblaccesstype.Text = "Access Type"
        '
        'cbaccesstype
        '
        Me.cbaccesstype.BackColor = System.Drawing.Color.Transparent
        Me.cbaccesstype.BaseColor = System.Drawing.Color.White
        Me.cbaccesstype.BorderColor = System.Drawing.Color.Silver
        Me.cbaccesstype.BorderSize = 1
        Me.cbaccesstype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbaccesstype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbaccesstype.FocusedColor = System.Drawing.Color.Empty
        Me.cbaccesstype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbaccesstype.ForeColor = System.Drawing.Color.Black
        Me.cbaccesstype.FormattingEnabled = True
        Me.cbaccesstype.Items.AddRange(New Object() {"Administrator", "Employee", "Tester", "Cashier"})
        Me.cbaccesstype.Location = New System.Drawing.Point(21, 591)
        Me.cbaccesstype.Name = "cbaccesstype"
        Me.cbaccesstype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbaccesstype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbaccesstype.Radius = 10
        Me.cbaccesstype.Size = New System.Drawing.Size(283, 26)
        Me.cbaccesstype.TabIndex = 18
        '
        'cbcheck
        '
        Me.cbcheck.BaseColor = System.Drawing.Color.White
        Me.cbcheck.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbcheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcheck.FillColor = System.Drawing.Color.White
        Me.cbcheck.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbcheck.Location = New System.Drawing.Point(21, 468)
        Me.cbcheck.Name = "cbcheck"
        Me.cbcheck.Size = New System.Drawing.Size(115, 20)
        Me.cbcheck.TabIndex = 20
        Me.cbcheck.Text = "Show Password"
        '
        'pnledit
        '
        Me.pnledit.Controls.Add(Me.btnedit)
        Me.pnledit.Location = New System.Drawing.Point(69, 627)
        Me.pnledit.Name = "pnledit"
        Me.pnledit.Size = New System.Drawing.Size(200, 48)
        Me.pnledit.TabIndex = 21
        '
        'btnedit
        '
        Me.btnedit.AnimationHoverSpeed = 0.07!
        Me.btnedit.AnimationSpeed = 0.03!
        Me.btnedit.BackColor = System.Drawing.Color.Transparent
        Me.btnedit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnedit.BorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnedit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedForeColor = System.Drawing.Color.White
        Me.btnedit.CheckedImage = CType(resources.GetObject("btnedit.CheckedImage"), System.Drawing.Image)
        Me.btnedit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnedit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnedit.FocusedColor = System.Drawing.Color.Empty
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Image = Nothing
        Me.btnedit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnedit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(10, 3)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnedit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnedit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnedit.OnHoverImage = Nothing
        Me.btnedit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.OnPressedColor = System.Drawing.Color.Black
        Me.btnedit.Radius = 15
        Me.btnedit.Size = New System.Drawing.Size(180, 42)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(18, 295)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(47, 16)
        Me.GunaLabel5.TabIndex = 23
        Me.GunaLabel5.Text = "Name"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.BaseColor = System.Drawing.Color.White
        Me.txtname.BorderColor = System.Drawing.Color.Silver
        Me.txtname.BorderSize = 1
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtname.ForeColor = System.Drawing.Color.Silver
        Me.txtname.Location = New System.Drawing.Point(21, 314)
        Me.txtname.MaxLength = 50
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Radius = 15
        Me.txtname.Size = New System.Drawing.Size(283, 30)
        Me.txtname.TabIndex = 22
        Me.txtname.Text = "Enter Name..."
        '
        'btncreateacc
        '
        Me.btncreateacc.AnimationHoverSpeed = 0.07!
        Me.btncreateacc.AnimationSpeed = 0.03!
        Me.btncreateacc.BackColor = System.Drawing.Color.Transparent
        Me.btncreateacc.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncreateacc.BorderColor = System.Drawing.Color.Black
        Me.btncreateacc.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncreateacc.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncreateacc.CheckedForeColor = System.Drawing.Color.White
        Me.btncreateacc.CheckedImage = CType(resources.GetObject("btncreateacc.CheckedImage"), System.Drawing.Image)
        Me.btncreateacc.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncreateacc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncreateacc.FocusedColor = System.Drawing.Color.Empty
        Me.btncreateacc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreateacc.ForeColor = System.Drawing.Color.White
        Me.btncreateacc.Image = Nothing
        Me.btncreateacc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncreateacc.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncreateacc.Location = New System.Drawing.Point(75, 627)
        Me.btncreateacc.Name = "btncreateacc"
        Me.btncreateacc.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncreateacc.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncreateacc.OnHoverForeColor = System.Drawing.Color.White
        Me.btncreateacc.OnHoverImage = Nothing
        Me.btncreateacc.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncreateacc.OnPressedColor = System.Drawing.Color.Black
        Me.btncreateacc.Radius = 15
        Me.btncreateacc.Size = New System.Drawing.Size(180, 42)
        Me.btncreateacc.TabIndex = 19
        Me.btncreateacc.Text = "Create Account"
        Me.btncreateacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btneditprofile
        '
        Me.btneditprofile.Animated = True
        Me.btneditprofile.AnimationHoverSpeed = 0.07!
        Me.btneditprofile.AnimationSpeed = 0.03!
        Me.btneditprofile.BackColor = System.Drawing.Color.Transparent
        Me.btneditprofile.BaseColor = System.Drawing.Color.Transparent
        Me.btneditprofile.BorderColor = System.Drawing.Color.Black
        Me.btneditprofile.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btneditprofile.CheckedBorderColor = System.Drawing.Color.Black
        Me.btneditprofile.CheckedForeColor = System.Drawing.Color.White
        Me.btneditprofile.CheckedImage = Nothing
        Me.btneditprofile.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btneditprofile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btneditprofile.FocusedColor = System.Drawing.Color.Empty
        Me.btneditprofile.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditprofile.ForeColor = System.Drawing.Color.Silver
        Me.btneditprofile.Image = CType(resources.GetObject("btneditprofile.Image"), System.Drawing.Image)
        Me.btneditprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btneditprofile.ImageSize = New System.Drawing.Size(20, 20)
        Me.btneditprofile.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btneditprofile.Location = New System.Drawing.Point(104, 193)
        Me.btneditprofile.Name = "btneditprofile"
        Me.btneditprofile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btneditprofile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btneditprofile.OnHoverForeColor = System.Drawing.Color.White
        Me.btneditprofile.OnHoverImage = CType(resources.GetObject("btneditprofile.OnHoverImage"), System.Drawing.Image)
        Me.btneditprofile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btneditprofile.OnPressedColor = System.Drawing.Color.Black
        Me.btneditprofile.Radius = 15
        Me.btneditprofile.Size = New System.Drawing.Size(120, 30)
        Me.btneditprofile.TabIndex = 8
        Me.btneditprofile.Text = "Edit Profile"
        Me.btneditprofile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnback
        '
        Me.btnback.Animated = True
        Me.btnback.AnimationHoverSpeed = 0.07!
        Me.btnback.AnimationSpeed = 0.03!
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BaseColor = System.Drawing.Color.Transparent
        Me.btnback.BorderColor = System.Drawing.Color.Black
        Me.btnback.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnback.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnback.CheckedForeColor = System.Drawing.Color.White
        Me.btnback.CheckedImage = Nothing
        Me.btnback.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnback.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnback.FocusedColor = System.Drawing.Color.Empty
        Me.btnback.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnback.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnback.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.Location = New System.Drawing.Point(8, 4)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = CType(resources.GetObject("btnback.OnHoverImage"), System.Drawing.Image)
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 20
        Me.btnback.Size = New System.Drawing.Size(43, 39)
        Me.btnback.TabIndex = 5
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbprofile
        '
        Me.pbprofile.BaseColor = System.Drawing.Color.White
        Me.pbprofile.Image = Global.SimplePOS.My.Resources.Resources.male96
        Me.pbprofile.Location = New System.Drawing.Point(104, 68)
        Me.pbprofile.Name = "pbprofile"
        Me.pbprofile.Size = New System.Drawing.Size(120, 120)
        Me.pbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbprofile.TabIndex = 0
        Me.pbprofile.TabStop = False
        Me.pbprofile.UseTransfarantBackground = False
        '
        'cbpassc
        '
        Me.cbpassc.BaseColor = System.Drawing.Color.White
        Me.cbpassc.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbpassc.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbpassc.FillColor = System.Drawing.Color.White
        Me.cbpassc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbpassc.Location = New System.Drawing.Point(21, 550)
        Me.cbpassc.Name = "cbpassc"
        Me.cbpassc.Size = New System.Drawing.Size(115, 20)
        Me.cbpassc.TabIndex = 24
        Me.cbpassc.Text = "Show Password"
        '
        'cbind
        '
        Me.cbind.BaseColor = System.Drawing.Color.White
        Me.cbind.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbind.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbind.FillColor = System.Drawing.Color.White
        Me.cbind.Location = New System.Drawing.Point(31, 649)
        Me.cbind.Name = "cbind"
        Me.cbind.Size = New System.Drawing.Size(20, 20)
        Me.cbind.TabIndex = 25
        Me.cbind.Visible = False
        '
        'Createaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(331, 685)
        Me.Controls.Add(Me.cbind)
        Me.Controls.Add(Me.cbpassc)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.pnledit)
        Me.Controls.Add(Me.cbcheck)
        Me.Controls.Add(Me.btncreateacc)
        Me.Controls.Add(Me.cbaccesstype)
        Me.Controls.Add(Me.lblaccesstype)
        Me.Controls.Add(Me.lblconfirmp)
        Me.Controls.Add(Me.txtconfirmp)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.btneditprofile)
        Me.Controls.Add(Me.txtaccid)
        Me.Controls.Add(Me.lblcreate)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pnlshad)
        Me.Controls.Add(Me.pbprofile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Createaccount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Createaccount"
        Me.pnledit.ResumeLayout(False)
        CType(Me.pbprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pbprofile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pnlshad As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblcreate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btneditprofile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtaccid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblconfirmp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtconfirmp As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cbcheck As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btncreateacc As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cbaccesstype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblaccesstype As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnledit As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnedit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cbpassc As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents cbind As Guna.UI.WinForms.GunaCheckBox
End Class
