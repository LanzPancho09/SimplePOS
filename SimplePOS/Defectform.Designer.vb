<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Defectform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Defectform))
        Me.pnlSeperator = New Guna.UI.WinForms.GunaPanel()
        Me.lblTitle = New Guna.UI.WinForms.GunaLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GunaPanel6 = New Guna.UI.WinForms.GunaPanel()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel7 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtItemId = New Guna.UI.WinForms.GunaTextBox()
        Me.txtDescription = New Guna.UI.WinForms.GunaTextBox()
        Me.txtValue = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.txtAffectedStock = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaCircleButton()
        Me.pnlSeperator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GunaPanel6.SuspendLayout()
        Me.GunaPanel7.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSeperator
        '
        Me.pnlSeperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.pnlSeperator.Controls.Add(Me.lblTitle)
        Me.pnlSeperator.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSeperator.Location = New System.Drawing.Point(0, 0)
        Me.pnlSeperator.Name = "pnlSeperator"
        Me.pnlSeperator.Size = New System.Drawing.Size(347, 585)
        Me.pnlSeperator.TabIndex = 3
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
        Me.lblTitle.Text = "Add Defect Item"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(338, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(616, 560)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GunaPanel6)
        Me.TabPage1.Controls.Add(Me.GunaPanel7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(608, 534)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GunaPanel6
        '
        Me.GunaPanel6.Controls.Add(Me.btnSave)
        Me.GunaPanel6.Controls.Add(Me.btnCancel)
        Me.GunaPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel6.Location = New System.Drawing.Point(3, 472)
        Me.GunaPanel6.Name = "GunaPanel6"
        Me.GunaPanel6.Size = New System.Drawing.Size(602, 59)
        Me.GunaPanel6.TabIndex = 5
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
        'GunaPanel7
        '
        Me.GunaPanel7.AutoScroll = True
        Me.GunaPanel7.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel7.Controls.Add(Me.txtItemId)
        Me.GunaPanel7.Controls.Add(Me.txtDescription)
        Me.GunaPanel7.Controls.Add(Me.txtValue)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel11)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel12)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel15)
        Me.GunaPanel7.Controls.Add(Me.txtAffectedStock)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel16)
        Me.GunaPanel7.Controls.Add(Me.txtpname)
        Me.GunaPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel7.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel7.Name = "GunaPanel7"
        Me.GunaPanel7.Size = New System.Drawing.Size(602, 528)
        Me.GunaPanel7.TabIndex = 4
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(22, 16)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(52, 17)
        Me.GunaLabel1.TabIndex = 15
        Me.GunaLabel1.Text = "Item Id"
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.Transparent
        Me.txtItemId.BaseColor = System.Drawing.Color.White
        Me.txtItemId.BorderColor = System.Drawing.Color.Silver
        Me.txtItemId.BorderSize = 1
        Me.txtItemId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemId.FocusedBaseColor = System.Drawing.Color.White
        Me.txtItemId.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemId.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemId.Location = New System.Drawing.Point(25, 37)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemId.Radius = 3
        Me.txtItemId.Size = New System.Drawing.Size(223, 30)
        Me.txtItemId.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtDescription.BaseColor = System.Drawing.Color.White
        Me.txtDescription.BorderColor = System.Drawing.Color.Silver
        Me.txtDescription.BorderSize = 1
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(25, 314)
        Me.txtDescription.MultiLine = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.Radius = 3
        Me.txtDescription.Size = New System.Drawing.Size(323, 94)
        Me.txtDescription.TabIndex = 13
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.Transparent
        Me.txtValue.BaseColor = System.Drawing.Color.White
        Me.txtValue.BorderColor = System.Drawing.Color.Silver
        Me.txtValue.BorderSize = 1
        Me.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValue.FocusedBaseColor = System.Drawing.Color.White
        Me.txtValue.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValue.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtValue.Location = New System.Drawing.Point(25, 245)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValue.Radius = 3
        Me.txtValue.Size = New System.Drawing.Size(223, 30)
        Me.txtValue.TabIndex = 12
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(22, 293)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(79, 17)
        Me.GunaLabel11.TabIndex = 11
        Me.GunaLabel11.Text = "Description"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(22, 224)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(42, 17)
        Me.GunaLabel12.TabIndex = 9
        Me.GunaLabel12.Text = "Value"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.Location = New System.Drawing.Point(22, 154)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(97, 17)
        Me.GunaLabel15.TabIndex = 3
        Me.GunaLabel15.Text = "Affected Stock"
        '
        'txtAffectedStock
        '
        Me.txtAffectedStock.BackColor = System.Drawing.Color.Transparent
        Me.txtAffectedStock.BaseColor = System.Drawing.Color.White
        Me.txtAffectedStock.BorderColor = System.Drawing.Color.Silver
        Me.txtAffectedStock.BorderSize = 1
        Me.txtAffectedStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAffectedStock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAffectedStock.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAffectedStock.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAffectedStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAffectedStock.Location = New System.Drawing.Point(25, 175)
        Me.txtAffectedStock.Name = "txtAffectedStock"
        Me.txtAffectedStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAffectedStock.Radius = 3
        Me.txtAffectedStock.Size = New System.Drawing.Size(223, 30)
        Me.txtAffectedStock.TabIndex = 2
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(22, 85)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(96, 17)
        Me.GunaLabel16.TabIndex = 1
        Me.GunaLabel16.Text = "Product Name"
        '
        'txtpname
        '
        Me.txtpname.BackColor = System.Drawing.Color.Transparent
        Me.txtpname.BaseColor = System.Drawing.Color.White
        Me.txtpname.BorderColor = System.Drawing.Color.Silver
        Me.txtpname.BorderSize = 1
        Me.txtpname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpname.Location = New System.Drawing.Point(25, 106)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpname.Radius = 3
        Me.txtpname.Size = New System.Drawing.Size(223, 30)
        Me.txtpname.TabIndex = 0
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(347, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(600, 58)
        Me.GunaPanel1.TabIndex = 5
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
        'Defectform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 585)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.pnlSeperator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Defectform"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Defectform"
        Me.pnlSeperator.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GunaPanel6.ResumeLayout(False)
        Me.GunaPanel7.ResumeLayout(False)
        Me.GunaPanel7.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSeperator As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblTitle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaPanel6 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel7 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtDescription As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtValue As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtAffectedStock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtItemId As Guna.UI.WinForms.GunaTextBox
End Class
