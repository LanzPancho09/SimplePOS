<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updateitem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updateitem))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel43 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel40 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel42 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel41 = New Guna.UI.WinForms.GunaLabel()
        Me.cbcategory = New Guna.UI.WinForms.GunaComboBox()
        Me.txtprodname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtprice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnupdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel39 = New Guna.UI.WinForms.GunaLabel()
        Me.txtitemid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtstock = New Guna.UI.WinForms.GunaLineTextBox()
        Me.pnlshad = New Guna.UI.WinForms.GunaPanel()
        Me.dtpexpr = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.btnexpr = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.btnedID = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaPictureBox0 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox4 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(426, 37)
        Me.GunaPanel1.TabIndex = 0
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
        Me.btnback.Location = New System.Drawing.Point(0, 0)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 5
        Me.btnback.Size = New System.Drawing.Size(38, 37)
        Me.btnback.TabIndex = 23
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel43
        '
        Me.GunaLabel43.AutoSize = True
        Me.GunaLabel43.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel43.Location = New System.Drawing.Point(48, 414)
        Me.GunaLabel43.Name = "GunaLabel43"
        Me.GunaLabel43.Size = New System.Drawing.Size(40, 16)
        Me.GunaLabel43.TabIndex = 16
        Me.GunaLabel43.Text = "Price"
        '
        'GunaLabel40
        '
        Me.GunaLabel40.AutoSize = True
        Me.GunaLabel40.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel40.Location = New System.Drawing.Point(48, 129)
        Me.GunaLabel40.Name = "GunaLabel40"
        Me.GunaLabel40.Size = New System.Drawing.Size(100, 16)
        Me.GunaLabel40.TabIndex = 13
        Me.GunaLabel40.Text = "Product Name"
        '
        'GunaLabel42
        '
        Me.GunaLabel42.AutoSize = True
        Me.GunaLabel42.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel42.Location = New System.Drawing.Point(48, 352)
        Me.GunaLabel42.Name = "GunaLabel42"
        Me.GunaLabel42.Size = New System.Drawing.Size(43, 16)
        Me.GunaLabel42.TabIndex = 15
        Me.GunaLabel42.Text = "Stock"
        '
        'GunaLabel41
        '
        Me.GunaLabel41.AutoSize = True
        Me.GunaLabel41.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel41.Location = New System.Drawing.Point(48, 209)
        Me.GunaLabel41.Name = "GunaLabel41"
        Me.GunaLabel41.Size = New System.Drawing.Size(69, 16)
        Me.GunaLabel41.TabIndex = 14
        Me.GunaLabel41.Text = "Category"
        '
        'cbcategory
        '
        Me.cbcategory.BackColor = System.Drawing.Color.Transparent
        Me.cbcategory.BaseColor = System.Drawing.Color.White
        Me.cbcategory.BorderColor = System.Drawing.Color.Silver
        Me.cbcategory.BorderSize = 1
        Me.cbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.FocusedColor = System.Drawing.Color.Empty
        Me.cbcategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbcategory.ForeColor = System.Drawing.Color.Black
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.Location = New System.Drawing.Point(51, 228)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbcategory.Radius = 10
        Me.cbcategory.Size = New System.Drawing.Size(319, 26)
        Me.cbcategory.TabIndex = 22
        '
        'txtprodname
        '
        Me.txtprodname.Animated = True
        Me.txtprodname.BackColor = System.Drawing.Color.White
        Me.txtprodname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprodname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtprodname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprodname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtprodname.LineSize = 2
        Me.txtprodname.Location = New System.Drawing.Point(51, 148)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprodname.Size = New System.Drawing.Size(319, 30)
        Me.txtprodname.TabIndex = 18
        Me.txtprodname.Text = "Enter Product"
        '
        'txtprice
        '
        Me.txtprice.Animated = True
        Me.txtprice.BackColor = System.Drawing.Color.White
        Me.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtprice.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprice.LineColor = System.Drawing.Color.Gainsboro
        Me.txtprice.LineSize = 2
        Me.txtprice.Location = New System.Drawing.Point(51, 433)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprice.Size = New System.Drawing.Size(319, 30)
        Me.txtprice.TabIndex = 20
        Me.txtprice.Text = "Enter Price"
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnupdate
        '
        Me.btnupdate.Animated = True
        Me.btnupdate.AnimationHoverSpeed = 0.07!
        Me.btnupdate.AnimationSpeed = 0.03!
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnupdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnupdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnupdate.CheckedImage = Nothing
        Me.btnupdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = Nothing
        Me.btnupdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnupdate.Location = New System.Drawing.Point(122, 481)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Radius = 20
        Me.btnupdate.Size = New System.Drawing.Size(180, 42)
        Me.btnupdate.TabIndex = 21
        Me.btnupdate.Text = "Update Item"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel39
        '
        Me.GunaLabel39.AutoSize = True
        Me.GunaLabel39.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel39.Location = New System.Drawing.Point(183, 60)
        Me.GunaLabel39.Name = "GunaLabel39"
        Me.GunaLabel39.Size = New System.Drawing.Size(53, 16)
        Me.GunaLabel39.TabIndex = 12
        Me.GunaLabel39.Text = "Item ID"
        '
        'txtitemid
        '
        Me.txtitemid.Animated = True
        Me.txtitemid.BackColor = System.Drawing.Color.White
        Me.txtitemid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtitemid.Enabled = False
        Me.txtitemid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtitemid.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtitemid.LineColor = System.Drawing.Color.Gainsboro
        Me.txtitemid.LineSize = 2
        Me.txtitemid.Location = New System.Drawing.Point(51, 81)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitemid.Size = New System.Drawing.Size(319, 30)
        Me.txtitemid.TabIndex = 17
        Me.txtitemid.Text = "0"
        Me.txtitemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtstock
        '
        Me.txtstock.Animated = True
        Me.txtstock.BackColor = System.Drawing.Color.White
        Me.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstock.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtstock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtstock.LineColor = System.Drawing.Color.Gainsboro
        Me.txtstock.LineSize = 2
        Me.txtstock.Location = New System.Drawing.Point(51, 371)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstock.Size = New System.Drawing.Size(319, 30)
        Me.txtstock.TabIndex = 19
        Me.txtstock.Text = "Enter Stock"
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlshad
        '
        Me.pnlshad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlshad.Location = New System.Drawing.Point(0, 37)
        Me.pnlshad.Name = "pnlshad"
        Me.pnlshad.Size = New System.Drawing.Size(426, 11)
        Me.pnlshad.TabIndex = 23
        '
        'dtpexpr
        '
        Me.dtpexpr.BaseColor = System.Drawing.Color.White
        Me.dtpexpr.BorderColor = System.Drawing.Color.Silver
        Me.dtpexpr.CustomFormat = Nothing
        Me.dtpexpr.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpexpr.Enabled = False
        Me.dtpexpr.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpexpr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpexpr.ForeColor = System.Drawing.Color.Black
        Me.dtpexpr.Location = New System.Drawing.Point(97, 304)
        Me.dtpexpr.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpexpr.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpexpr.Name = "dtpexpr"
        Me.dtpexpr.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpexpr.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpexpr.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpexpr.OnPressedColor = System.Drawing.Color.Black
        Me.dtpexpr.Size = New System.Drawing.Size(223, 30)
        Me.dtpexpr.TabIndex = 26
        Me.dtpexpr.Text = "Wednesday, April 8, 2020"
        Me.dtpexpr.Value = New Date(2020, 4, 8, 12, 51, 35, 648)
        '
        'btnexpr
        '
        Me.btnexpr.AnimationHoverSpeed = 0.07!
        Me.btnexpr.AnimationSpeed = 0.03!
        Me.btnexpr.BaseColor = System.Drawing.Color.Transparent
        Me.btnexpr.BorderColor = System.Drawing.Color.Black
        Me.btnexpr.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexpr.FocusedColor = System.Drawing.Color.Empty
        Me.btnexpr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnexpr.ForeColor = System.Drawing.Color.White
        Me.btnexpr.Image = CType(resources.GetObject("btnexpr.Image"), System.Drawing.Image)
        Me.btnexpr.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnexpr.Location = New System.Drawing.Point(326, 304)
        Me.btnexpr.Name = "btnexpr"
        Me.btnexpr.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexpr.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexpr.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexpr.OnHoverImage = Nothing
        Me.btnexpr.OnPressedColor = System.Drawing.Color.Black
        Me.btnexpr.Size = New System.Drawing.Size(30, 30)
        Me.btnexpr.TabIndex = 25
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(48, 274)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(153, 16)
        Me.GunaLabel9.TabIndex = 24
        Me.GunaLabel9.Text = "Expiry Date (Optional)"
        '
        'btnedID
        '
        Me.btnedID.AnimationHoverSpeed = 0.07!
        Me.btnedID.AnimationSpeed = 0.03!
        Me.btnedID.BaseColor = System.Drawing.Color.Transparent
        Me.btnedID.BorderColor = System.Drawing.Color.Black
        Me.btnedID.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnedID.FocusedColor = System.Drawing.Color.Empty
        Me.btnedID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnedID.ForeColor = System.Drawing.Color.White
        Me.btnedID.Image = CType(resources.GetObject("btnedID.Image"), System.Drawing.Image)
        Me.btnedID.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnedID.Location = New System.Drawing.Point(376, 81)
        Me.btnedID.Name = "btnedID"
        Me.btnedID.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnedID.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnedID.OnHoverForeColor = System.Drawing.Color.White
        Me.btnedID.OnHoverImage = Nothing
        Me.btnedID.OnPressedColor = System.Drawing.Color.Black
        Me.btnedID.Size = New System.Drawing.Size(30, 30)
        Me.btnedID.TabIndex = 27
        '
        'GunaPictureBox0
        '
        Me.GunaPictureBox0.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox0.Image = CType(resources.GetObject("GunaPictureBox0.Image"), System.Drawing.Image)
        Me.GunaPictureBox0.Location = New System.Drawing.Point(12, 81)
        Me.GunaPictureBox0.Name = "GunaPictureBox0"
        Me.GunaPictureBox0.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox0.TabIndex = 31
        Me.GunaPictureBox0.TabStop = False
        Me.GunaPictureBox0.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(12, 148)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 32
        Me.GunaPictureBox1.TabStop = False
        Me.GunaPictureBox1.Visible = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(12, 228)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 33
        Me.GunaPictureBox2.TabStop = False
        Me.GunaPictureBox2.Visible = False
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = CType(resources.GetObject("GunaPictureBox3.Image"), System.Drawing.Image)
        Me.GunaPictureBox3.Location = New System.Drawing.Point(12, 371)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox3.TabIndex = 34
        Me.GunaPictureBox3.TabStop = False
        Me.GunaPictureBox3.Visible = False
        '
        'GunaPictureBox4
        '
        Me.GunaPictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox4.Image = CType(resources.GetObject("GunaPictureBox4.Image"), System.Drawing.Image)
        Me.GunaPictureBox4.Location = New System.Drawing.Point(12, 433)
        Me.GunaPictureBox4.Name = "GunaPictureBox4"
        Me.GunaPictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox4.TabIndex = 35
        Me.GunaPictureBox4.TabStop = False
        Me.GunaPictureBox4.Visible = False
        '
        'Updateitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 553)
        Me.Controls.Add(Me.GunaPictureBox4)
        Me.Controls.Add(Me.GunaPictureBox3)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPictureBox0)
        Me.Controls.Add(Me.btnedID)
        Me.Controls.Add(Me.dtpexpr)
        Me.Controls.Add(Me.btnexpr)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.pnlshad)
        Me.Controls.Add(Me.GunaLabel43)
        Me.Controls.Add(Me.GunaLabel40)
        Me.Controls.Add(Me.GunaLabel42)
        Me.Controls.Add(Me.GunaLabel41)
        Me.Controls.Add(Me.cbcategory)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GunaLabel39)
        Me.Controls.Add(Me.txtitemid)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Updateitem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updateitem"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel43 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel40 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel42 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel41 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbcategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtprodname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtprice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel39 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtitemid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtstock As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlshad As Guna.UI.WinForms.GunaPanel
    Friend WithEvents dtpexpr As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents btnexpr As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnedID As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaPictureBox4 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox0 As Guna.UI.WinForms.GunaPictureBox
End Class
