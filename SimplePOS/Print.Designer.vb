<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnclose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnptrans = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnreprint = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnclose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(315, 32)
        Me.GunaPanel1.TabIndex = 0
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
        Me.btnclose.Location = New System.Drawing.Point(275, 0)
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
        'btnptrans
        '
        Me.btnptrans.Animated = True
        Me.btnptrans.AnimationHoverSpeed = 0.07!
        Me.btnptrans.AnimationSpeed = 0.03!
        Me.btnptrans.BackColor = System.Drawing.Color.Transparent
        Me.btnptrans.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnptrans.BorderColor = System.Drawing.Color.Black
        Me.btnptrans.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnptrans.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnptrans.CheckedForeColor = System.Drawing.Color.White
        Me.btnptrans.CheckedImage = CType(resources.GetObject("btnptrans.CheckedImage"), System.Drawing.Image)
        Me.btnptrans.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnptrans.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnptrans.FocusedColor = System.Drawing.Color.Empty
        Me.btnptrans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnptrans.ForeColor = System.Drawing.Color.White
        Me.btnptrans.Image = CType(resources.GetObject("btnptrans.Image"), System.Drawing.Image)
        Me.btnptrans.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnptrans.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnptrans.Location = New System.Drawing.Point(26, 120)
        Me.btnptrans.Name = "btnptrans"
        Me.btnptrans.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnptrans.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnptrans.OnHoverForeColor = System.Drawing.Color.White
        Me.btnptrans.OnHoverImage = Nothing
        Me.btnptrans.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnptrans.OnPressedColor = System.Drawing.Color.Black
        Me.btnptrans.Radius = 5
        Me.btnptrans.Size = New System.Drawing.Size(260, 42)
        Me.btnptrans.TabIndex = 2
        Me.btnptrans.Text = "Print Item(s) By transaction"
        '
        'btnreprint
        '
        Me.btnreprint.Animated = True
        Me.btnreprint.AnimationHoverSpeed = 0.07!
        Me.btnreprint.AnimationSpeed = 0.03!
        Me.btnreprint.BackColor = System.Drawing.Color.Transparent
        Me.btnreprint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnreprint.BorderColor = System.Drawing.Color.Black
        Me.btnreprint.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnreprint.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnreprint.CheckedForeColor = System.Drawing.Color.White
        Me.btnreprint.CheckedImage = CType(resources.GetObject("btnreprint.CheckedImage"), System.Drawing.Image)
        Me.btnreprint.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnreprint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnreprint.FocusedColor = System.Drawing.Color.Empty
        Me.btnreprint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreprint.ForeColor = System.Drawing.Color.White
        Me.btnreprint.Image = CType(resources.GetObject("btnreprint.Image"), System.Drawing.Image)
        Me.btnreprint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnreprint.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnreprint.Location = New System.Drawing.Point(26, 56)
        Me.btnreprint.Name = "btnreprint"
        Me.btnreprint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnreprint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnreprint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnreprint.OnHoverImage = Nothing
        Me.btnreprint.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnreprint.OnPressedColor = System.Drawing.Color.Black
        Me.btnreprint.Radius = 5
        Me.btnreprint.Size = New System.Drawing.Size(260, 42)
        Me.btnreprint.TabIndex = 1
        Me.btnreprint.Text = "Reprint"
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 192)
        Me.Controls.Add(Me.btnptrans)
        Me.Controls.Add(Me.btnreprint)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Print"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnptrans As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnreprint As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaAdvenceButton
End Class
