<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashsearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashsearch))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblind = New Guna.UI.WinForms.GunaLabel()
        Me.btnclose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnrearch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlmonth = New Guna.UI.WinForms.GunaPanel()
        Me.cbmonth = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.pnlmonth.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.lblind)
        Me.GunaPanel1.Controls.Add(Me.btnclose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(284, 32)
        Me.GunaPanel1.TabIndex = 3
        '
        'lblind
        '
        Me.lblind.AutoSize = True
        Me.lblind.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblind.ForeColor = System.Drawing.Color.White
        Me.lblind.Location = New System.Drawing.Point(12, 9)
        Me.lblind.Name = "lblind"
        Me.lblind.Size = New System.Drawing.Size(13, 15)
        Me.lblind.TabIndex = 4
        Me.lblind.Text = "0"
        Me.lblind.Visible = False
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.AnimationHoverSpeed = 0.07!
        Me.btnclose.AnimationSpeed = 0.03!
        Me.btnclose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclose.BorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnclose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedForeColor = System.Drawing.Color.White
        Me.btnclose.CheckedImage = CType(resources.GetObject("btnclose.CheckedImage"), System.Drawing.Image)
        Me.btnclose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FocusedColor = System.Drawing.Color.Empty
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnclose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(244, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnclose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnclose.OnHoverImage = Nothing
        Me.btnclose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.OnPressedColor = System.Drawing.Color.Black
        Me.btnclose.Size = New System.Drawing.Size(40, 32)
        Me.btnclose.TabIndex = 3
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy"
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(30, 96)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(223, 30)
        Me.GunaDateTimePicker1.TabIndex = 4
        Me.GunaDateTimePicker1.Text = "Friday, 29 May 2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 5, 29, 15, 50, 25, 823)
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(27, 76)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(76, 17)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Select Date:"
        '
        'btnrearch
        '
        Me.btnrearch.Animated = True
        Me.btnrearch.AnimationHoverSpeed = 0.07!
        Me.btnrearch.AnimationSpeed = 0.03!
        Me.btnrearch.BackColor = System.Drawing.Color.Transparent
        Me.btnrearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnrearch.BorderColor = System.Drawing.Color.Black
        Me.btnrearch.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnrearch.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnrearch.CheckedForeColor = System.Drawing.Color.White
        Me.btnrearch.CheckedImage = CType(resources.GetObject("btnrearch.CheckedImage"), System.Drawing.Image)
        Me.btnrearch.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnrearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnrearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrearch.ForeColor = System.Drawing.Color.White
        Me.btnrearch.Image = Nothing
        Me.btnrearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnrearch.Location = New System.Drawing.Point(49, 173)
        Me.btnrearch.Name = "btnrearch"
        Me.btnrearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnrearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnrearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnrearch.OnHoverImage = Nothing
        Me.btnrearch.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnrearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnrearch.Radius = 5
        Me.btnrearch.Size = New System.Drawing.Size(180, 42)
        Me.btnrearch.TabIndex = 6
        Me.btnrearch.Text = "Search"
        Me.btnrearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlmonth
        '
        Me.pnlmonth.Controls.Add(Me.cbmonth)
        Me.pnlmonth.Controls.Add(Me.GunaLabel2)
        Me.pnlmonth.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlmonth.Location = New System.Drawing.Point(0, 32)
        Me.pnlmonth.Name = "pnlmonth"
        Me.pnlmonth.Size = New System.Drawing.Size(284, 121)
        Me.pnlmonth.TabIndex = 7
        Me.pnlmonth.Visible = False
        '
        'cbmonth
        '
        Me.cbmonth.BackColor = System.Drawing.Color.Transparent
        Me.cbmonth.BaseColor = System.Drawing.Color.White
        Me.cbmonth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbmonth.BorderSize = 1
        Me.cbmonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmonth.FocusedColor = System.Drawing.Color.Empty
        Me.cbmonth.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbmonth.ForeColor = System.Drawing.Color.Black
        Me.cbmonth.FormattingEnabled = True
        Me.cbmonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbmonth.Location = New System.Drawing.Point(49, 54)
        Me.cbmonth.Name = "cbmonth"
        Me.cbmonth.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbmonth.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbmonth.Size = New System.Drawing.Size(180, 26)
        Me.cbmonth.TabIndex = 1
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(46, 34)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(87, 17)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Select Month:"
        '
        'cashsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 254)
        Me.Controls.Add(Me.pnlmonth)
        Me.Controls.Add(Me.btnrearch)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaDateTimePicker1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cashsearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cashsearch"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.pnlmonth.ResumeLayout(False)
        Me.pnlmonth.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlmonth As Guna.UI.WinForms.GunaPanel
    Friend WithEvents cbmonth As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnrearch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblind As Guna.UI.WinForms.GunaLabel
End Class
