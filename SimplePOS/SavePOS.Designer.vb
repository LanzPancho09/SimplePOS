<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavePOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SavePOS))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txtpayment = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbltotal = New Guna.UI.WinForms.GunaLabel()
        Me.lblchange = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnpay = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlshad = New Guna.UI.WinForms.GunaPanel()
        Me.lbldiscount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btndiscount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlpay = New Guna.UI.WinForms.GunaPanel()
        Me.btnclose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnundo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlpay.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'txtpayment
        '
        Me.txtpayment.BackColor = System.Drawing.Color.Transparent
        Me.txtpayment.BaseColor = System.Drawing.Color.White
        Me.txtpayment.BorderColor = System.Drawing.Color.DimGray
        Me.txtpayment.BorderSize = 1
        Me.txtpayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayment.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpayment.FocusedBorderColor = System.Drawing.Color.DimGray
        Me.txtpayment.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpayment.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpayment.Location = New System.Drawing.Point(76, 113)
        Me.txtpayment.MaxLength = 10
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpayment.Radius = 15
        Me.txtpayment.Size = New System.Drawing.Size(437, 53)
        Me.txtpayment.TabIndex = 0
        Me.txtpayment.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(72, 276)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(99, 20)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Amount Due"
        '
        'lbltotal
        '
        Me.lbltotal.AutoEllipsis = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbltotal.Location = New System.Drawing.Point(76, 304)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(437, 46)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblchange
        '
        Me.lblchange.AutoEllipsis = True
        Me.lblchange.BackColor = System.Drawing.Color.Transparent
        Me.lblchange.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblchange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblchange.Location = New System.Drawing.Point(76, 384)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(437, 46)
        Me.lblchange.TabIndex = 4
        Me.lblchange.Text = "0.00"
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(72, 355)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(61, 20)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Change"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(79, 80)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(133, 20)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Payment Amount"
        '
        'btnpay
        '
        Me.btnpay.Animated = True
        Me.btnpay.AnimationHoverSpeed = 0.07!
        Me.btnpay.AnimationSpeed = 0.03!
        Me.btnpay.BackColor = System.Drawing.Color.Transparent
        Me.btnpay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnpay.BorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnpay.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedForeColor = System.Drawing.Color.White
        Me.btnpay.CheckedImage = Nothing
        Me.btnpay.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnpay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpay.FocusedColor = System.Drawing.Color.Empty
        Me.btnpay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.White
        Me.btnpay.Image = CType(resources.GetObject("btnpay.Image"), System.Drawing.Image)
        Me.btnpay.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnpay.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnpay.Location = New System.Drawing.Point(126, 11)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.btnpay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnpay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpay.OnHoverImage = Nothing
        Me.btnpay.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnpay.OnPressedColor = System.Drawing.Color.Black
        Me.btnpay.Radius = 15
        Me.btnpay.Size = New System.Drawing.Size(167, 42)
        Me.btnpay.TabIndex = 7
        Me.btnpay.Text = "Pay"
        Me.btnpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(583, 48)
        Me.GunaPanel1.TabIndex = 8
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(215, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 5
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(262, 14)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(78, 19)
        Me.GunaLabel5.TabIndex = 4
        Me.GunaLabel5.Text = "Payment"
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
        Me.btnback.Location = New System.Drawing.Point(12, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 20
        Me.btnback.Size = New System.Drawing.Size(45, 42)
        Me.btnback.TabIndex = 3
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlshad
        '
        Me.pnlshad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlshad.Location = New System.Drawing.Point(0, 48)
        Me.pnlshad.Name = "pnlshad"
        Me.pnlshad.Size = New System.Drawing.Size(583, 10)
        Me.pnlshad.TabIndex = 9
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoEllipsis = True
        Me.lbldiscount.BackColor = System.Drawing.Color.Transparent
        Me.lbldiscount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbldiscount.Location = New System.Drawing.Point(76, 221)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(437, 46)
        Me.lbldiscount.TabIndex = 11
        Me.lbldiscount.Text = "0.00"
        Me.lbldiscount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(72, 195)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(71, 20)
        Me.GunaLabel7.TabIndex = 10
        Me.GunaLabel7.Text = "Discount"
        '
        'btndiscount
        '
        Me.btndiscount.Animated = True
        Me.btndiscount.AnimationHoverSpeed = 0.07!
        Me.btndiscount.AnimationSpeed = 0.03!
        Me.btndiscount.BackColor = System.Drawing.Color.Transparent
        Me.btndiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btndiscount.BorderColor = System.Drawing.Color.Black
        Me.btndiscount.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btndiscount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btndiscount.CheckedForeColor = System.Drawing.Color.White
        Me.btndiscount.CheckedImage = Nothing
        Me.btndiscount.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btndiscount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndiscount.FocusedColor = System.Drawing.Color.Empty
        Me.btndiscount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiscount.ForeColor = System.Drawing.Color.White
        Me.btndiscount.Image = CType(resources.GetObject("btndiscount.Image"), System.Drawing.Image)
        Me.btndiscount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndiscount.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndiscount.Location = New System.Drawing.Point(299, 11)
        Me.btndiscount.Name = "btndiscount"
        Me.btndiscount.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.btndiscount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndiscount.OnHoverForeColor = System.Drawing.Color.White
        Me.btndiscount.OnHoverImage = Nothing
        Me.btndiscount.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndiscount.OnPressedColor = System.Drawing.Color.Black
        Me.btndiscount.Radius = 15
        Me.btndiscount.Size = New System.Drawing.Size(167, 42)
        Me.btndiscount.TabIndex = 12
        Me.btndiscount.Text = "Discount"
        Me.btndiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlpay
        '
        Me.pnlpay.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlpay.Controls.Add(Me.btnpay)
        Me.pnlpay.Controls.Add(Me.btndiscount)
        Me.pnlpay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlpay.Location = New System.Drawing.Point(0, 472)
        Me.pnlpay.Name = "pnlpay"
        Me.pnlpay.Size = New System.Drawing.Size(583, 63)
        Me.pnlpay.TabIndex = 13
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.AnimationHoverSpeed = 0.07!
        Me.btnclose.AnimationSpeed = 0.03!
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnclose.BorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnclose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedForeColor = System.Drawing.Color.White
        Me.btnclose.CheckedImage = Nothing
        Me.btnclose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclose.FocusedColor = System.Drawing.Color.Empty
        Me.btnclose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = Nothing
        Me.btnclose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnclose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(215, 472)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.btnclose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnclose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnclose.OnHoverImage = Nothing
        Me.btnclose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.OnPressedColor = System.Drawing.Color.Black
        Me.btnclose.Radius = 15
        Me.btnclose.Size = New System.Drawing.Size(167, 42)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "Ok"
        Me.btnclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnundo
        '
        Me.btnundo.Animated = True
        Me.btnundo.AnimationHoverSpeed = 0.07!
        Me.btnundo.AnimationSpeed = 0.03!
        Me.btnundo.BackColor = System.Drawing.Color.Transparent
        Me.btnundo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnundo.BorderColor = System.Drawing.Color.Black
        Me.btnundo.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnundo.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnundo.CheckedForeColor = System.Drawing.Color.White
        Me.btnundo.CheckedImage = Nothing
        Me.btnundo.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnundo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnundo.FocusedColor = System.Drawing.Color.Empty
        Me.btnundo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnundo.ForeColor = System.Drawing.Color.White
        Me.btnundo.Image = CType(resources.GetObject("btnundo.Image"), System.Drawing.Image)
        Me.btnundo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnundo.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnundo.Location = New System.Drawing.Point(367, 189)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.btnundo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnundo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnundo.OnHoverImage = Nothing
        Me.btnundo.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnundo.OnPressedColor = System.Drawing.Color.Black
        Me.btnundo.Radius = 10
        Me.btnundo.Size = New System.Drawing.Size(148, 30)
        Me.btnundo.TabIndex = 13
        Me.btnundo.Text = "Undo"
        Me.btnundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnundo.Visible = False
        '
        'SavePOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 535)
        Me.Controls.Add(Me.btnundo)
        Me.Controls.Add(Me.pnlpay)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.pnlshad)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.btnclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SavePOS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SavePOS"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlpay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtpayment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblchange As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbltotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnpay As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlshad As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btndiscount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lbldiscount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlpay As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnundo As Guna.UI.WinForms.GunaAdvenceButton
End Class
