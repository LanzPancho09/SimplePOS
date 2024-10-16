<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManager))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblTitle = New Guna.UI.WinForms.GunaLabel()
        Me.pnlSeperator = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaCircleButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabItems = New System.Windows.Forms.TabPage()
        Me.pnlItemFooter = New Guna.UI.WinForms.GunaPanel()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.chkbExpire = New Guna.UI.WinForms.GunaCheckBox()
        Me.txtPrice = New Guna.UI.WinForms.GunaTextBox()
        Me.txtStock = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.dtpExpire = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.cbCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtProductName = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtItemid = New Guna.UI.WinForms.GunaTextBox()
        Me.tabCategory = New System.Windows.Forms.TabPage()
        Me.pnlMcategoryFooter = New Guna.UI.WinForms.GunaPanel()
        Me.btnAddCategory = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.pnlCategoryHeader = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.flpCategory = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabCatItems = New System.Windows.Forms.TabPage()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.btnCategorySave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCategoryCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtCategory = New Guna.UI.WinForms.GunaTextBox()
        Me.tabItemStock = New System.Windows.Forms.TabPage()
        Me.GunaPanel6 = New Guna.UI.WinForms.GunaPanel()
        Me.btnStockSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnStockCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel7 = New Guna.UI.WinForms.GunaPanel()
        Me.txtSAddStock = New Guna.UI.WinForms.GunaTextBox()
        Me.txtSCurrentStock = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.txtSProdName = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txtSItemID = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlShadow = New Guna.UI.WinForms.GunaPanel()
        Me.pnlSeperator.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabItems.SuspendLayout()
        Me.pnlItemFooter.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.tabCategory.SuspendLayout()
        Me.pnlMcategoryFooter.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.pnlCategoryHeader.SuspendLayout()
        Me.tabCatItems.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.tabItemStock.SuspendLayout()
        Me.GunaPanel6.SuspendLayout()
        Me.GunaPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(31, 32)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 79)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add Item"
        '
        'pnlSeperator
        '
        Me.pnlSeperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.pnlSeperator.Controls.Add(Me.lblTitle)
        Me.pnlSeperator.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSeperator.Location = New System.Drawing.Point(0, 0)
        Me.pnlSeperator.Name = "pnlSeperator"
        Me.pnlSeperator.Size = New System.Drawing.Size(347, 585)
        Me.pnlSeperator.TabIndex = 2
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(347, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(600, 58)
        Me.GunaPanel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.SimplePOS.My.Resources.Resources.close_96px
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(553, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Global.SimplePOS.My.Resources.Resources.close_96px_w
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabItems)
        Me.TabControl1.Controls.Add(Me.tabCategory)
        Me.TabControl1.Controls.Add(Me.tabCatItems)
        Me.TabControl1.Controls.Add(Me.tabItemStock)
        Me.TabControl1.Location = New System.Drawing.Point(338, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(616, 560)
        Me.TabControl1.TabIndex = 6
        '
        'tabItems
        '
        Me.tabItems.Controls.Add(Me.pnlItemFooter)
        Me.tabItems.Controls.Add(Me.GunaPanel2)
        Me.tabItems.Location = New System.Drawing.Point(4, 22)
        Me.tabItems.Name = "tabItems"
        Me.tabItems.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItems.Size = New System.Drawing.Size(608, 534)
        Me.tabItems.TabIndex = 0
        Me.tabItems.Text = "TabPage1"
        Me.tabItems.UseVisualStyleBackColor = True
        '
        'pnlItemFooter
        '
        Me.pnlItemFooter.Controls.Add(Me.btnSave)
        Me.pnlItemFooter.Controls.Add(Me.btnCancel)
        Me.pnlItemFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItemFooter.Location = New System.Drawing.Point(3, 472)
        Me.pnlItemFooter.Name = "pnlItemFooter"
        Me.pnlItemFooter.Size = New System.Drawing.Size(602, 59)
        Me.pnlItemFooter.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Animated = True
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.Silver
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = CType(resources.GetObject("btnSave.CheckedImage"), System.Drawing.Image)
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Nothing
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(440, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Radius = 5
        Me.btnSave.Size = New System.Drawing.Size(72, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.BorderSize = 1
        Me.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancel.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancel.CheckedImage = CType(resources.GetObject("btnCancel.CheckedImage"), System.Drawing.Image)
        Me.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(518, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(72, 35)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel2
        '
        Me.GunaPanel2.AutoScroll = True
        Me.GunaPanel2.Controls.Add(Me.chkbExpire)
        Me.GunaPanel2.Controls.Add(Me.txtPrice)
        Me.GunaPanel2.Controls.Add(Me.txtStock)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel2.Controls.Add(Me.dtpExpire)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel2.Controls.Add(Me.cbCategory)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel2.Controls.Add(Me.txtProductName)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel2.Controls.Add(Me.txtItemid)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(602, 528)
        Me.GunaPanel2.TabIndex = 0
        '
        'chkbExpire
        '
        Me.chkbExpire.BaseColor = System.Drawing.Color.White
        Me.chkbExpire.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkbExpire.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkbExpire.FillColor = System.Drawing.Color.White
        Me.chkbExpire.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbExpire.Location = New System.Drawing.Point(25, 280)
        Me.chkbExpire.Name = "chkbExpire"
        Me.chkbExpire.Size = New System.Drawing.Size(115, 20)
        Me.chkbExpire.TabIndex = 14
        Me.chkbExpire.Text = "Ignore Expiration"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BaseColor = System.Drawing.Color.White
        Me.txtPrice.BorderColor = System.Drawing.Color.Silver
        Me.txtPrice.BorderSize = 1
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrice.Location = New System.Drawing.Point(25, 410)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.Radius = 3
        Me.txtPrice.Size = New System.Drawing.Size(223, 30)
        Me.txtPrice.TabIndex = 13
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.Transparent
        Me.txtStock.BaseColor = System.Drawing.Color.White
        Me.txtStock.BorderColor = System.Drawing.Color.Silver
        Me.txtStock.BorderSize = 1
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStock.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStock.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStock.Location = New System.Drawing.Point(25, 341)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.Radius = 3
        Me.txtStock.Size = New System.Drawing.Size(223, 30)
        Me.txtStock.TabIndex = 12
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(22, 389)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(38, 17)
        Me.GunaLabel6.TabIndex = 11
        Me.GunaLabel6.Text = "Price"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(22, 320)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(41, 17)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "Stock"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(22, 223)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(104, 17)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Expiration Date"
        '
        'dtpExpire
        '
        Me.dtpExpire.BackColor = System.Drawing.Color.Transparent
        Me.dtpExpire.BaseColor = System.Drawing.Color.White
        Me.dtpExpire.BorderColor = System.Drawing.Color.Silver
        Me.dtpExpire.BorderSize = 1
        Me.dtpExpire.CustomFormat = Nothing
        Me.dtpExpire.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpExpire.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpExpire.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpExpire.ForeColor = System.Drawing.Color.Black
        Me.dtpExpire.Location = New System.Drawing.Point(25, 244)
        Me.dtpExpire.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpExpire.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpExpire.Name = "dtpExpire"
        Me.dtpExpire.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpExpire.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpExpire.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpExpire.OnPressedColor = System.Drawing.Color.Black
        Me.dtpExpire.Radius = 3
        Me.dtpExpire.Size = New System.Drawing.Size(223, 30)
        Me.dtpExpire.TabIndex = 6
        Me.dtpExpire.Text = "Sunday, November 27, 2022"
        Me.dtpExpire.Value = New Date(2022, 11, 27, 16, 43, 21, 586)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(22, 158)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 17)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Category"
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cbCategory.BaseColor = System.Drawing.Color.White
        Me.cbCategory.BorderColor = System.Drawing.Color.Silver
        Me.cbCategory.BorderSize = 1
        Me.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCategory.ForeColor = System.Drawing.Color.Black
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Goods"})
        Me.cbCategory.Location = New System.Drawing.Point(25, 179)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbCategory.Radius = 3
        Me.cbCategory.Size = New System.Drawing.Size(223, 26)
        Me.cbCategory.TabIndex = 4
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(22, 87)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(96, 17)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.Transparent
        Me.txtProductName.BaseColor = System.Drawing.Color.White
        Me.txtProductName.BorderColor = System.Drawing.Color.Silver
        Me.txtProductName.BorderSize = 1
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtProductName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProductName.Location = New System.Drawing.Point(25, 108)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.Radius = 3
        Me.txtProductName.Size = New System.Drawing.Size(223, 30)
        Me.txtProductName.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(22, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(54, 17)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Item ID"
        '
        'txtItemid
        '
        Me.txtItemid.BackColor = System.Drawing.Color.Transparent
        Me.txtItemid.BaseColor = System.Drawing.Color.White
        Me.txtItemid.BorderColor = System.Drawing.Color.Silver
        Me.txtItemid.BorderSize = 1
        Me.txtItemid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtItemid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemid.Location = New System.Drawing.Point(25, 39)
        Me.txtItemid.Name = "txtItemid"
        Me.txtItemid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemid.Radius = 3
        Me.txtItemid.Size = New System.Drawing.Size(223, 30)
        Me.txtItemid.TabIndex = 0
        '
        'tabCategory
        '
        Me.tabCategory.Controls.Add(Me.pnlMcategoryFooter)
        Me.tabCategory.Controls.Add(Me.GunaPanel5)
        Me.tabCategory.Location = New System.Drawing.Point(4, 22)
        Me.tabCategory.Name = "tabCategory"
        Me.tabCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCategory.Size = New System.Drawing.Size(608, 534)
        Me.tabCategory.TabIndex = 1
        Me.tabCategory.Text = "TabPage2"
        Me.tabCategory.UseVisualStyleBackColor = True
        '
        'pnlMcategoryFooter
        '
        Me.pnlMcategoryFooter.Controls.Add(Me.btnAddCategory)
        Me.pnlMcategoryFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMcategoryFooter.Location = New System.Drawing.Point(3, 472)
        Me.pnlMcategoryFooter.Name = "pnlMcategoryFooter"
        Me.pnlMcategoryFooter.Size = New System.Drawing.Size(602, 59)
        Me.pnlMcategoryFooter.TabIndex = 3
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCategory.Animated = True
        Me.btnAddCategory.AnimationHoverSpeed = 0.07!
        Me.btnAddCategory.AnimationSpeed = 0.03!
        Me.btnAddCategory.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCategory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAddCategory.BorderColor = System.Drawing.Color.Silver
        Me.btnAddCategory.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddCategory.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddCategory.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddCategory.CheckedImage = CType(resources.GetObject("btnAddCategory.CheckedImage"), System.Drawing.Image)
        Me.btnAddCategory.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddCategory.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddCategory.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddCategory.Image = Nothing
        Me.btnAddCategory.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddCategory.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAddCategory.Location = New System.Drawing.Point(440, 12)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddCategory.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddCategory.OnHoverImage = Nothing
        Me.btnAddCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAddCategory.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddCategory.Radius = 5
        Me.btnAddCategory.Size = New System.Drawing.Size(150, 35)
        Me.btnAddCategory.TabIndex = 29
        Me.btnAddCategory.Text = "Add Category"
        Me.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GunaPanel5.Controls.Add(Me.pnlCategoryHeader)
        Me.GunaPanel5.Controls.Add(Me.flpCategory)
        Me.GunaPanel5.Controls.Add(Me.pnlShadow)
        Me.GunaPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel5.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(602, 528)
        Me.GunaPanel5.TabIndex = 2
        '
        'pnlCategoryHeader
        '
        Me.pnlCategoryHeader.BackColor = System.Drawing.Color.White
        Me.pnlCategoryHeader.Controls.Add(Me.GunaLabel9)
        Me.pnlCategoryHeader.Controls.Add(Me.GunaLabel8)
        Me.pnlCategoryHeader.Controls.Add(Me.GunaLabel7)
        Me.pnlCategoryHeader.Location = New System.Drawing.Point(2, 2)
        Me.pnlCategoryHeader.Name = "pnlCategoryHeader"
        Me.pnlCategoryHeader.Size = New System.Drawing.Size(600, 36)
        Me.pnlCategoryHeader.TabIndex = 0
        '
        'GunaLabel9
        '
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(468, 11)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel9.TabIndex = 2
        Me.GunaLabel9.Text = "ACTION"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(188, 11)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(127, 15)
        Me.GunaLabel8.TabIndex = 1
        Me.GunaLabel8.Text = "CATEGORY NAME"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(45, 11)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(100, 15)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "ID"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpCategory
        '
        Me.flpCategory.AutoScroll = True
        Me.flpCategory.BackColor = System.Drawing.Color.White
        Me.flpCategory.Location = New System.Drawing.Point(1, 39)
        Me.flpCategory.Name = "flpCategory"
        Me.flpCategory.Size = New System.Drawing.Size(601, 411)
        Me.flpCategory.TabIndex = 1
        '
        'tabCatItems
        '
        Me.tabCatItems.Controls.Add(Me.GunaPanel3)
        Me.tabCatItems.Controls.Add(Me.GunaPanel4)
        Me.tabCatItems.Location = New System.Drawing.Point(4, 22)
        Me.tabCatItems.Name = "tabCatItems"
        Me.tabCatItems.Size = New System.Drawing.Size(608, 534)
        Me.tabCatItems.TabIndex = 2
        Me.tabCatItems.Text = "TabPage3"
        Me.tabCatItems.UseVisualStyleBackColor = True
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.btnCategorySave)
        Me.GunaPanel3.Controls.Add(Me.btnCategoryCancel)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 475)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(608, 59)
        Me.GunaPanel3.TabIndex = 5
        '
        'btnCategorySave
        '
        Me.btnCategorySave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCategorySave.Animated = True
        Me.btnCategorySave.AnimationHoverSpeed = 0.07!
        Me.btnCategorySave.AnimationSpeed = 0.03!
        Me.btnCategorySave.BackColor = System.Drawing.Color.Transparent
        Me.btnCategorySave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCategorySave.BorderColor = System.Drawing.Color.Silver
        Me.btnCategorySave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCategorySave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCategorySave.CheckedForeColor = System.Drawing.Color.White
        Me.btnCategorySave.CheckedImage = CType(resources.GetObject("btnCategorySave.CheckedImage"), System.Drawing.Image)
        Me.btnCategorySave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCategorySave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategorySave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCategorySave.FocusedColor = System.Drawing.Color.Empty
        Me.btnCategorySave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorySave.ForeColor = System.Drawing.Color.White
        Me.btnCategorySave.Image = Nothing
        Me.btnCategorySave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCategorySave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCategorySave.Location = New System.Drawing.Point(443, 9)
        Me.btnCategorySave.Name = "btnCategorySave"
        Me.btnCategorySave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCategorySave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCategorySave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCategorySave.OnHoverImage = Nothing
        Me.btnCategorySave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCategorySave.OnPressedColor = System.Drawing.Color.Black
        Me.btnCategorySave.Radius = 5
        Me.btnCategorySave.Size = New System.Drawing.Size(72, 35)
        Me.btnCategorySave.TabIndex = 10
        Me.btnCategorySave.Text = "Save"
        Me.btnCategorySave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCategoryCancel
        '
        Me.btnCategoryCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCategoryCancel.Animated = True
        Me.btnCategoryCancel.AnimationHoverSpeed = 0.07!
        Me.btnCategoryCancel.AnimationSpeed = 0.03!
        Me.btnCategoryCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoryCancel.BaseColor = System.Drawing.Color.Transparent
        Me.btnCategoryCancel.BorderColor = System.Drawing.Color.Silver
        Me.btnCategoryCancel.BorderSize = 1
        Me.btnCategoryCancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCategoryCancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCategoryCancel.CheckedForeColor = System.Drawing.Color.White
        Me.btnCategoryCancel.CheckedImage = CType(resources.GetObject("btnCategoryCancel.CheckedImage"), System.Drawing.Image)
        Me.btnCategoryCancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCategoryCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategoryCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCategoryCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCategoryCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCategoryCancel.Image = Nothing
        Me.btnCategoryCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCategoryCancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCategoryCancel.Location = New System.Drawing.Point(521, 9)
        Me.btnCategoryCancel.Name = "btnCategoryCancel"
        Me.btnCategoryCancel.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCategoryCancel.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btnCategoryCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCategoryCancel.OnHoverImage = Nothing
        Me.btnCategoryCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCategoryCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCategoryCancel.Radius = 5
        Me.btnCategoryCancel.Size = New System.Drawing.Size(72, 35)
        Me.btnCategoryCancel.TabIndex = 9
        Me.btnCategoryCancel.Text = "Cancel"
        Me.btnCategoryCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.GunaLabel10)
        Me.GunaPanel4.Controls.Add(Me.txtCategory)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(608, 534)
        Me.GunaPanel4.TabIndex = 4
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(34, 29)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(104, 17)
        Me.GunaLabel10.TabIndex = 3
        Me.GunaLabel10.Text = "Category Name"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.Transparent
        Me.txtCategory.BaseColor = System.Drawing.Color.White
        Me.txtCategory.BorderColor = System.Drawing.Color.Silver
        Me.txtCategory.BorderSize = 1
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategory.Location = New System.Drawing.Point(37, 50)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.Radius = 3
        Me.txtCategory.Size = New System.Drawing.Size(223, 30)
        Me.txtCategory.TabIndex = 2
        Me.txtCategory.Text = "GunaTextBox1"
        '
        'tabItemStock
        '
        Me.tabItemStock.Controls.Add(Me.GunaPanel6)
        Me.tabItemStock.Controls.Add(Me.GunaPanel7)
        Me.tabItemStock.Location = New System.Drawing.Point(4, 22)
        Me.tabItemStock.Name = "tabItemStock"
        Me.tabItemStock.Size = New System.Drawing.Size(608, 534)
        Me.tabItemStock.TabIndex = 3
        Me.tabItemStock.Text = "TabPage1"
        Me.tabItemStock.UseVisualStyleBackColor = True
        '
        'GunaPanel6
        '
        Me.GunaPanel6.Controls.Add(Me.btnStockSave)
        Me.GunaPanel6.Controls.Add(Me.btnStockCancel)
        Me.GunaPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel6.Location = New System.Drawing.Point(0, 475)
        Me.GunaPanel6.Name = "GunaPanel6"
        Me.GunaPanel6.Size = New System.Drawing.Size(608, 59)
        Me.GunaPanel6.TabIndex = 3
        '
        'btnStockSave
        '
        Me.btnStockSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockSave.Animated = True
        Me.btnStockSave.AnimationHoverSpeed = 0.07!
        Me.btnStockSave.AnimationSpeed = 0.03!
        Me.btnStockSave.BackColor = System.Drawing.Color.Transparent
        Me.btnStockSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnStockSave.BorderColor = System.Drawing.Color.Silver
        Me.btnStockSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnStockSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStockSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnStockSave.CheckedImage = CType(resources.GetObject("btnStockSave.CheckedImage"), System.Drawing.Image)
        Me.btnStockSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStockSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStockSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnStockSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockSave.ForeColor = System.Drawing.Color.White
        Me.btnStockSave.Image = Nothing
        Me.btnStockSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStockSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStockSave.Location = New System.Drawing.Point(446, 12)
        Me.btnStockSave.Name = "btnStockSave"
        Me.btnStockSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnStockSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStockSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStockSave.OnHoverImage = Nothing
        Me.btnStockSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStockSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnStockSave.Radius = 5
        Me.btnStockSave.Size = New System.Drawing.Size(72, 35)
        Me.btnStockSave.TabIndex = 8
        Me.btnStockSave.Text = "Save"
        Me.btnStockSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStockCancel
        '
        Me.btnStockCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockCancel.Animated = True
        Me.btnStockCancel.AnimationHoverSpeed = 0.07!
        Me.btnStockCancel.AnimationSpeed = 0.03!
        Me.btnStockCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnStockCancel.BaseColor = System.Drawing.Color.Transparent
        Me.btnStockCancel.BorderColor = System.Drawing.Color.Silver
        Me.btnStockCancel.BorderSize = 1
        Me.btnStockCancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnStockCancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStockCancel.CheckedForeColor = System.Drawing.Color.White
        Me.btnStockCancel.CheckedImage = CType(resources.GetObject("btnStockCancel.CheckedImage"), System.Drawing.Image)
        Me.btnStockCancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStockCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStockCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnStockCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnStockCancel.Image = Nothing
        Me.btnStockCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStockCancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStockCancel.Location = New System.Drawing.Point(524, 12)
        Me.btnStockCancel.Name = "btnStockCancel"
        Me.btnStockCancel.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnStockCancel.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btnStockCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnStockCancel.OnHoverImage = Nothing
        Me.btnStockCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStockCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnStockCancel.Radius = 5
        Me.btnStockCancel.Size = New System.Drawing.Size(72, 35)
        Me.btnStockCancel.TabIndex = 7
        Me.btnStockCancel.Text = "Cancel"
        Me.btnStockCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel7
        '
        Me.GunaPanel7.AutoScroll = True
        Me.GunaPanel7.Controls.Add(Me.txtSAddStock)
        Me.GunaPanel7.Controls.Add(Me.txtSCurrentStock)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel11)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel12)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel15)
        Me.GunaPanel7.Controls.Add(Me.txtSProdName)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel16)
        Me.GunaPanel7.Controls.Add(Me.txtSItemID)
        Me.GunaPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel7.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel7.Name = "GunaPanel7"
        Me.GunaPanel7.Size = New System.Drawing.Size(608, 534)
        Me.GunaPanel7.TabIndex = 2
        '
        'txtSAddStock
        '
        Me.txtSAddStock.BackColor = System.Drawing.Color.Transparent
        Me.txtSAddStock.BaseColor = System.Drawing.Color.White
        Me.txtSAddStock.BorderColor = System.Drawing.Color.Silver
        Me.txtSAddStock.BorderSize = 1
        Me.txtSAddStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSAddStock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSAddStock.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSAddStock.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSAddStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSAddStock.Location = New System.Drawing.Point(25, 254)
        Me.txtSAddStock.Name = "txtSAddStock"
        Me.txtSAddStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSAddStock.Radius = 3
        Me.txtSAddStock.Size = New System.Drawing.Size(223, 30)
        Me.txtSAddStock.TabIndex = 13
        '
        'txtSCurrentStock
        '
        Me.txtSCurrentStock.BackColor = System.Drawing.Color.Transparent
        Me.txtSCurrentStock.BaseColor = System.Drawing.Color.White
        Me.txtSCurrentStock.BorderColor = System.Drawing.Color.Silver
        Me.txtSCurrentStock.BorderSize = 1
        Me.txtSCurrentStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSCurrentStock.Enabled = False
        Me.txtSCurrentStock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSCurrentStock.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSCurrentStock.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSCurrentStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSCurrentStock.Location = New System.Drawing.Point(25, 185)
        Me.txtSCurrentStock.Name = "txtSCurrentStock"
        Me.txtSCurrentStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSCurrentStock.Radius = 3
        Me.txtSCurrentStock.Size = New System.Drawing.Size(223, 30)
        Me.txtSCurrentStock.TabIndex = 12
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(22, 233)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(70, 17)
        Me.GunaLabel11.TabIndex = 11
        Me.GunaLabel11.Text = "Add Stock"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(22, 164)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(91, 17)
        Me.GunaLabel12.TabIndex = 9
        Me.GunaLabel12.Text = "Current Stock"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.Location = New System.Drawing.Point(22, 87)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(96, 17)
        Me.GunaLabel15.TabIndex = 3
        Me.GunaLabel15.Text = "Product Name"
        '
        'txtSProdName
        '
        Me.txtSProdName.BackColor = System.Drawing.Color.Transparent
        Me.txtSProdName.BaseColor = System.Drawing.Color.White
        Me.txtSProdName.BorderColor = System.Drawing.Color.Silver
        Me.txtSProdName.BorderSize = 1
        Me.txtSProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSProdName.Enabled = False
        Me.txtSProdName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSProdName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSProdName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSProdName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSProdName.Location = New System.Drawing.Point(25, 108)
        Me.txtSProdName.Name = "txtSProdName"
        Me.txtSProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSProdName.Radius = 3
        Me.txtSProdName.Size = New System.Drawing.Size(223, 30)
        Me.txtSProdName.TabIndex = 2
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(22, 18)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(54, 17)
        Me.GunaLabel16.TabIndex = 1
        Me.GunaLabel16.Text = "Item ID"
        '
        'txtSItemID
        '
        Me.txtSItemID.BackColor = System.Drawing.Color.Transparent
        Me.txtSItemID.BaseColor = System.Drawing.Color.White
        Me.txtSItemID.BorderColor = System.Drawing.Color.Silver
        Me.txtSItemID.BorderSize = 1
        Me.txtSItemID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSItemID.Enabled = False
        Me.txtSItemID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSItemID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSItemID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSItemID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSItemID.Location = New System.Drawing.Point(25, 39)
        Me.txtSItemID.Name = "txtSItemID"
        Me.txtSItemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSItemID.Radius = 3
        Me.txtSItemID.Size = New System.Drawing.Size(223, 30)
        Me.txtSItemID.TabIndex = 0
        '
        'pnlShadow
        '
        Me.pnlShadow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlShadow.Location = New System.Drawing.Point(0, 37)
        Me.pnlShadow.Name = "pnlShadow"
        Me.pnlShadow.Size = New System.Drawing.Size(602, 2)
        Me.pnlShadow.TabIndex = 2
        '
        'InventoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 585)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.pnlSeperator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryManager"
        Me.pnlSeperator.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabItems.ResumeLayout(False)
        Me.pnlItemFooter.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.tabCategory.ResumeLayout(False)
        Me.pnlMcategoryFooter.ResumeLayout(False)
        Me.GunaPanel5.ResumeLayout(False)
        Me.pnlCategoryHeader.ResumeLayout(False)
        Me.tabCatItems.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.tabItemStock.ResumeLayout(False)
        Me.GunaPanel6.ResumeLayout(False)
        Me.GunaPanel7.ResumeLayout(False)
        Me.GunaPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblTitle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnlSeperator As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabItems As TabPage
    Friend WithEvents pnlItemFooter As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tabCategory As TabPage
    Friend WithEvents txtPrice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtStock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtpExpire As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtProductName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtItemid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents chkbExpire As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents pnlMcategoryFooter As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnAddCategory As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlCategoryHeader As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents flpCategory As FlowLayoutPanel
    Friend WithEvents tabCatItems As TabPage
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnCategorySave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCategoryCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtCategory As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tabItemStock As TabPage
    Friend WithEvents GunaPanel6 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnStockSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnStockCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel7 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtSAddStock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtSCurrentStock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSProdName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSItemID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlShadow As Guna.UI.WinForms.GunaPanel
End Class
