<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addstock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addstock))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlshad = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel40 = New Guna.UI.WinForms.GunaLabel()
        Me.txtprodname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel42 = New Guna.UI.WinForms.GunaLabel()
        Me.txtstock = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtaddstock = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnaddstock = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'pnlshad
        '
        Me.pnlshad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlshad.Location = New System.Drawing.Point(0, 37)
        Me.pnlshad.Name = "pnlshad"
        Me.pnlshad.Size = New System.Drawing.Size(372, 11)
        Me.pnlshad.TabIndex = 25
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(372, 37)
        Me.GunaPanel1.TabIndex = 24
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(148, 11)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 16)
        Me.GunaLabel2.TabIndex = 24
        Me.GunaLabel2.Text = "Add Stock"
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
        'GunaLabel40
        '
        Me.GunaLabel40.AutoSize = True
        Me.GunaLabel40.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel40.Location = New System.Drawing.Point(136, 97)
        Me.GunaLabel40.Name = "GunaLabel40"
        Me.GunaLabel40.Size = New System.Drawing.Size(100, 16)
        Me.GunaLabel40.TabIndex = 26
        Me.GunaLabel40.Text = "Product Name"
        '
        'txtprodname
        '
        Me.txtprodname.Animated = True
        Me.txtprodname.BackColor = System.Drawing.Color.White
        Me.txtprodname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprodname.Enabled = False
        Me.txtprodname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtprodname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprodname.LineColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtprodname.LineSize = 2
        Me.txtprodname.Location = New System.Drawing.Point(27, 116)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprodname.Size = New System.Drawing.Size(319, 30)
        Me.txtprodname.TabIndex = 27
        '
        'GunaLabel42
        '
        Me.GunaLabel42.AutoSize = True
        Me.GunaLabel42.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel42.Location = New System.Drawing.Point(24, 167)
        Me.GunaLabel42.Name = "GunaLabel42"
        Me.GunaLabel42.Size = New System.Drawing.Size(95, 16)
        Me.GunaLabel42.TabIndex = 28
        Me.GunaLabel42.Text = "Current Stock"
        '
        'txtstock
        '
        Me.txtstock.Animated = True
        Me.txtstock.BackColor = System.Drawing.Color.White
        Me.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstock.Enabled = False
        Me.txtstock.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtstock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtstock.LineColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtstock.LineSize = 2
        Me.txtstock.Location = New System.Drawing.Point(27, 186)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstock.Size = New System.Drawing.Size(319, 30)
        Me.txtstock.TabIndex = 29
        Me.txtstock.Text = "0"
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 234)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(43, 16)
        Me.GunaLabel1.TabIndex = 30
        Me.GunaLabel1.Text = "Stock"
        '
        'txtaddstock
        '
        Me.txtaddstock.Animated = True
        Me.txtaddstock.BackColor = System.Drawing.Color.White
        Me.txtaddstock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddstock.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtaddstock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddstock.LineColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtaddstock.LineSize = 2
        Me.txtaddstock.Location = New System.Drawing.Point(27, 253)
        Me.txtaddstock.MaxLength = 10
        Me.txtaddstock.Name = "txtaddstock"
        Me.txtaddstock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddstock.Size = New System.Drawing.Size(319, 30)
        Me.txtaddstock.TabIndex = 31
        Me.txtaddstock.Text = "0"
        Me.txtaddstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnaddstock
        '
        Me.btnaddstock.Animated = True
        Me.btnaddstock.AnimationHoverSpeed = 0.07!
        Me.btnaddstock.AnimationSpeed = 0.03!
        Me.btnaddstock.BackColor = System.Drawing.Color.Transparent
        Me.btnaddstock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddstock.BorderColor = System.Drawing.Color.Black
        Me.btnaddstock.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnaddstock.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnaddstock.CheckedForeColor = System.Drawing.Color.White
        Me.btnaddstock.CheckedImage = Nothing
        Me.btnaddstock.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnaddstock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnaddstock.FocusedColor = System.Drawing.Color.Empty
        Me.btnaddstock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddstock.ForeColor = System.Drawing.Color.White
        Me.btnaddstock.Image = Nothing
        Me.btnaddstock.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnaddstock.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnaddstock.Location = New System.Drawing.Point(96, 298)
        Me.btnaddstock.Name = "btnaddstock"
        Me.btnaddstock.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnaddstock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnaddstock.OnHoverForeColor = System.Drawing.Color.White
        Me.btnaddstock.OnHoverImage = Nothing
        Me.btnaddstock.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnaddstock.OnPressedColor = System.Drawing.Color.Black
        Me.btnaddstock.Radius = 20
        Me.btnaddstock.Size = New System.Drawing.Size(180, 42)
        Me.btnaddstock.TabIndex = 32
        Me.btnaddstock.Text = "Add Stock"
        Me.btnaddstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 51)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(53, 16)
        Me.GunaLabel3.TabIndex = 33
        Me.GunaLabel3.Text = "Item Id"
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.Location = New System.Drawing.Point(12, 73)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(15, 16)
        Me.lblitemid.TabIndex = 34
        Me.lblitemid.Text = "0"
        '
        'Addstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 350)
        Me.Controls.Add(Me.pnlshad)
        Me.Controls.Add(Me.lblitemid)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.btnaddstock)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txtaddstock)
        Me.Controls.Add(Me.GunaLabel42)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.GunaLabel40)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Addstock"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addstock"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnlshad As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel40 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtprodname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtaddstock As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel42 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtstock As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnaddstock As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
