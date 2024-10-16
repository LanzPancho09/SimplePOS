<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnclose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Comonth = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtyear = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlrange = New Guna.UI.WinForms.GunaPanel()
        Me.dtpto = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtpfrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsearch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rbtnmonth = New Guna.UI.WinForms.GunaRadioButton()
        Me.rbtnyear = New Guna.UI.WinForms.GunaRadioButton()
        Me.rbtnrange = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaPanel1.SuspendLayout()
        Me.pnlrange.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnclose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 28)
        Me.GunaPanel1.TabIndex = 0
        '
        'btnclose
        '
        Me.btnclose.AnimationHoverSpeed = 0.07!
        Me.btnclose.AnimationSpeed = 0.03!
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BaseColor = System.Drawing.Color.Transparent
        Me.btnclose.BorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnclose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedForeColor = System.Drawing.Color.White
        Me.btnclose.CheckedImage = Nothing
        Me.btnclose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FocusedColor = System.Drawing.Color.Empty
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnclose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(395, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnclose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnclose.OnHoverImage = Nothing
        Me.btnclose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.OnPressedColor = System.Drawing.Color.Black
        Me.btnclose.Size = New System.Drawing.Size(40, 28)
        Me.btnclose.TabIndex = 9
        Me.btnclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comonth
        '
        Me.Comonth.BackColor = System.Drawing.Color.Transparent
        Me.Comonth.BaseColor = System.Drawing.Color.White
        Me.Comonth.BorderColor = System.Drawing.Color.Silver
        Me.Comonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Comonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comonth.FocusedColor = System.Drawing.Color.Empty
        Me.Comonth.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Comonth.ForeColor = System.Drawing.Color.Black
        Me.Comonth.FormattingEnabled = True
        Me.Comonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Comonth.Location = New System.Drawing.Point(82, 90)
        Me.Comonth.Name = "Comonth"
        Me.Comonth.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comonth.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Comonth.Size = New System.Drawing.Size(267, 26)
        Me.Comonth.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(79, 72)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(43, 15)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Month"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(79, 136)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(29, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Year"
        '
        'txtyear
        '
        Me.txtyear.BaseColor = System.Drawing.Color.White
        Me.txtyear.BorderColor = System.Drawing.Color.Silver
        Me.txtyear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtyear.FocusedBaseColor = System.Drawing.Color.White
        Me.txtyear.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyear.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtyear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtyear.Location = New System.Drawing.Point(82, 154)
        Me.txtyear.MaxLength = 4
        Me.txtyear.Name = "txtyear"
        Me.txtyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyear.Size = New System.Drawing.Size(267, 30)
        Me.txtyear.TabIndex = 9
        Me.txtyear.Text = "0"
        Me.txtyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlrange
        '
        Me.pnlrange.Controls.Add(Me.dtpto)
        Me.pnlrange.Controls.Add(Me.dtpfrom)
        Me.pnlrange.Controls.Add(Me.GunaLabel3)
        Me.pnlrange.Controls.Add(Me.GunaLabel4)
        Me.pnlrange.Location = New System.Drawing.Point(67, 63)
        Me.pnlrange.Name = "pnlrange"
        Me.pnlrange.Size = New System.Drawing.Size(300, 135)
        Me.pnlrange.TabIndex = 10
        '
        'dtpto
        '
        Me.dtpto.BaseColor = System.Drawing.Color.White
        Me.dtpto.BorderColor = System.Drawing.Color.Silver
        Me.dtpto.CustomFormat = "MM/dd/yyyy"
        Me.dtpto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpto.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpto.ForeColor = System.Drawing.Color.Black
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(18, 84)
        Me.dtpto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpto.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpto.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpto.OnPressedColor = System.Drawing.Color.Black
        Me.dtpto.Size = New System.Drawing.Size(264, 30)
        Me.dtpto.TabIndex = 14
        Me.dtpto.Text = "05/27/2020"
        Me.dtpto.Value = New Date(2020, 5, 27, 12, 35, 7, 930)
        '
        'dtpfrom
        '
        Me.dtpfrom.BaseColor = System.Drawing.Color.White
        Me.dtpfrom.BorderColor = System.Drawing.Color.Silver
        Me.dtpfrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpfrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpfrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpfrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpfrom.ForeColor = System.Drawing.Color.Black
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(18, 27)
        Me.dtpfrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpfrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpfrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpfrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpfrom.OnPressedColor = System.Drawing.Color.Black
        Me.dtpfrom.Size = New System.Drawing.Size(264, 30)
        Me.dtpfrom.TabIndex = 13
        Me.dtpfrom.Text = "05/27/2020"
        Me.dtpfrom.Value = New Date(2020, 5, 27, 12, 35, 7, 930)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(15, 66)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel3.TabIndex = 12
        Me.GunaLabel3.Text = "Date To:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 6)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Date From:"
        '
        'btnsearch
        '
        Me.btnsearch.AnimationHoverSpeed = 0.07!
        Me.btnsearch.AnimationSpeed = 0.03!
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnsearch.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnsearch.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnsearch.CheckedForeColor = System.Drawing.Color.White
        Me.btnsearch.CheckedImage = CType(resources.GetObject("btnsearch.CheckedImage"), System.Drawing.Image)
        Me.btnsearch.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsearch.Location = New System.Drawing.Point(129, 289)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearch.OnHoverImage = Nothing
        Me.btnsearch.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearch.Radius = 3
        Me.btnsearch.Size = New System.Drawing.Size(178, 39)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtnmonth
        '
        Me.rbtnmonth.BaseColor = System.Drawing.SystemColors.Control
        Me.rbtnmonth.Checked = True
        Me.rbtnmonth.CheckedOffColor = System.Drawing.Color.Gray
        Me.rbtnmonth.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtnmonth.FillColor = System.Drawing.Color.White
        Me.rbtnmonth.ForeColor = System.Drawing.Color.White
        Me.rbtnmonth.Location = New System.Drawing.Point(85, 209)
        Me.rbtnmonth.Name = "rbtnmonth"
        Me.rbtnmonth.Size = New System.Drawing.Size(77, 20)
        Me.rbtnmonth.TabIndex = 11
        Me.rbtnmonth.Text = "By Month"
        '
        'rbtnyear
        '
        Me.rbtnyear.BaseColor = System.Drawing.SystemColors.Control
        Me.rbtnyear.CheckedOffColor = System.Drawing.Color.Gray
        Me.rbtnyear.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtnyear.FillColor = System.Drawing.Color.White
        Me.rbtnyear.ForeColor = System.Drawing.Color.White
        Me.rbtnyear.Location = New System.Drawing.Point(85, 232)
        Me.rbtnyear.Name = "rbtnyear"
        Me.rbtnyear.Size = New System.Drawing.Size(70, 20)
        Me.rbtnyear.TabIndex = 12
        Me.rbtnyear.Text = "By Year"
        '
        'rbtnrange
        '
        Me.rbtnrange.BaseColor = System.Drawing.SystemColors.Control
        Me.rbtnrange.CheckedOffColor = System.Drawing.Color.Gray
        Me.rbtnrange.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtnrange.FillColor = System.Drawing.Color.White
        Me.rbtnrange.ForeColor = System.Drawing.Color.White
        Me.rbtnrange.Location = New System.Drawing.Point(85, 255)
        Me.rbtnrange.Name = "rbtnrange"
        Me.rbtnrange.Size = New System.Drawing.Size(106, 20)
        Me.rbtnrange.TabIndex = 13
        Me.rbtnrange.Text = "By Date Range"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 349)
        Me.Controls.Add(Me.rbtnrange)
        Me.Controls.Add(Me.rbtnyear)
        Me.Controls.Add(Me.rbtnmonth)
        Me.Controls.Add(Me.pnlrange)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Comonth)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Search"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.GunaPanel1.ResumeLayout(False)
        Me.pnlrange.ResumeLayout(False)
        Me.pnlrange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnlrange As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtyear As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnsearch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Comonth As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents dtpto As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtpfrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rbtnrange As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents rbtnyear As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents rbtnmonth As Guna.UI.WinForms.GunaRadioButton
End Class
