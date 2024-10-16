<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discount))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtrate = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblcomputed = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsolve = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnsubmit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(469, 29)
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
        Me.btnback.Location = New System.Drawing.Point(1, -1)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 5
        Me.btnback.Size = New System.Drawing.Size(31, 31)
        Me.btnback.TabIndex = 8
        Me.btnback.TabStop = False
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtrate
        '
        Me.txtrate.BackColor = System.Drawing.Color.Transparent
        Me.txtrate.BaseColor = System.Drawing.Color.White
        Me.txtrate.BorderColor = System.Drawing.Color.Silver
        Me.txtrate.BorderSize = 1
        Me.txtrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrate.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrate.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtrate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtrate.Location = New System.Drawing.Point(74, 84)
        Me.txtrate.MaxLength = 2
        Me.txtrate.Name = "txtrate"
        Me.txtrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrate.Radius = 10
        Me.txtrate.Size = New System.Drawing.Size(212, 30)
        Me.txtrate.TabIndex = 1
        Me.txtrate.Text = "0%"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(82, 63)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(131, 16)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Discount By Rate %"
        '
        'lblcomputed
        '
        Me.lblcomputed.AutoSize = True
        Me.lblcomputed.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomputed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblcomputed.Location = New System.Drawing.Point(78, 164)
        Me.lblcomputed.Name = "lblcomputed"
        Me.lblcomputed.Size = New System.Drawing.Size(88, 41)
        Me.lblcomputed.TabIndex = 4
        Me.lblcomputed.Text = "0.00"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(82, 141)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(122, 16)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Total Amount Due"
        '
        'btnsolve
        '
        Me.btnsolve.Animated = True
        Me.btnsolve.AnimationHoverSpeed = 0.07!
        Me.btnsolve.AnimationSpeed = 0.03!
        Me.btnsolve.BackColor = System.Drawing.Color.Transparent
        Me.btnsolve.BaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnsolve.BorderColor = System.Drawing.Color.Black
        Me.btnsolve.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnsolve.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnsolve.CheckedForeColor = System.Drawing.Color.White
        Me.btnsolve.CheckedImage = CType(resources.GetObject("btnsolve.CheckedImage"), System.Drawing.Image)
        Me.btnsolve.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnsolve.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsolve.FocusedColor = System.Drawing.Color.Empty
        Me.btnsolve.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsolve.ForeColor = System.Drawing.Color.White
        Me.btnsolve.Image = Nothing
        Me.btnsolve.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsolve.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsolve.Location = New System.Drawing.Point(292, 84)
        Me.btnsolve.Name = "btnsolve"
        Me.btnsolve.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsolve.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsolve.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsolve.OnHoverImage = Nothing
        Me.btnsolve.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsolve.OnPressedColor = System.Drawing.Color.Black
        Me.btnsolve.Radius = 10
        Me.btnsolve.Size = New System.Drawing.Size(105, 26)
        Me.btnsolve.TabIndex = 7
        Me.btnsolve.Text = "Compute"
        Me.btnsolve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsubmit
        '
        Me.btnsubmit.AnimationHoverSpeed = 0.07!
        Me.btnsubmit.AnimationSpeed = 0.03!
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnsubmit.BorderColor = System.Drawing.Color.Black
        Me.btnsubmit.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnsubmit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnsubmit.CheckedForeColor = System.Drawing.Color.White
        Me.btnsubmit.CheckedImage = CType(resources.GetObject("btnsubmit.CheckedImage"), System.Drawing.Image)
        Me.btnsubmit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnsubmit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsubmit.Enabled = False
        Me.btnsubmit.FocusedColor = System.Drawing.Color.Empty
        Me.btnsubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Image = Nothing
        Me.btnsubmit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsubmit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsubmit.Location = New System.Drawing.Point(145, 233)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsubmit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsubmit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsubmit.OnHoverImage = Nothing
        Me.btnsubmit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsubmit.OnPressedColor = System.Drawing.Color.Black
        Me.btnsubmit.Radius = 15
        Me.btnsubmit.Size = New System.Drawing.Size(178, 38)
        Me.btnsubmit.TabIndex = 1
        Me.btnsubmit.Text = "Submit Discount"
        Me.btnsubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(469, 294)
        Me.Controls.Add(Me.btnsolve)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.lblcomputed)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Discount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtrate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnsubmit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcomputed As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsolve As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
End Class
