<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Removeitem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Removeitem))
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnremoveid = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtremoveid = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btncancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnrlock = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtremovelock = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel2)
        Me.GunaElipsePanel1.Controls.Add(Me.btncancel)
        Me.GunaElipsePanel1.Controls.Add(Me.btnrlock)
        Me.GunaElipsePanel1.Controls.Add(Me.txtremovelock)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 25
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(484, 105)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.btnremoveid)
        Me.GunaElipsePanel2.Controls.Add(Me.txtremoveid)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 25
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(484, 105)
        Me.GunaElipsePanel2.TabIndex = 4
        '
        'btnremoveid
        '
        Me.btnremoveid.Animated = True
        Me.btnremoveid.AnimationHoverSpeed = 0.07!
        Me.btnremoveid.AnimationSpeed = 0.03!
        Me.btnremoveid.BackColor = System.Drawing.Color.Transparent
        Me.btnremoveid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnremoveid.BorderColor = System.Drawing.Color.Black
        Me.btnremoveid.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnremoveid.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnremoveid.CheckedForeColor = System.Drawing.Color.White
        Me.btnremoveid.CheckedImage = Nothing
        Me.btnremoveid.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnremoveid.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnremoveid.FocusedColor = System.Drawing.Color.Empty
        Me.btnremoveid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremoveid.ForeColor = System.Drawing.Color.White
        Me.btnremoveid.Image = Nothing
        Me.btnremoveid.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnremoveid.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnremoveid.Location = New System.Drawing.Point(157, 70)
        Me.btnremoveid.Name = "btnremoveid"
        Me.btnremoveid.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnremoveid.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnremoveid.OnHoverForeColor = System.Drawing.Color.White
        Me.btnremoveid.OnHoverImage = Nothing
        Me.btnremoveid.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnremoveid.OnPressedColor = System.Drawing.Color.Black
        Me.btnremoveid.Radius = 15
        Me.btnremoveid.Size = New System.Drawing.Size(160, 30)
        Me.btnremoveid.TabIndex = 6
        Me.btnremoveid.Text = "Remove Item"
        Me.btnremoveid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtremoveid
        '
        Me.txtremoveid.BackColor = System.Drawing.Color.Transparent
        Me.txtremoveid.BaseColor = System.Drawing.Color.White
        Me.txtremoveid.BorderColor = System.Drawing.Color.Silver
        Me.txtremoveid.BorderSize = 1
        Me.txtremoveid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtremoveid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtremoveid.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtremoveid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtremoveid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtremoveid.Location = New System.Drawing.Point(39, 33)
        Me.txtremoveid.Name = "txtremoveid"
        Me.txtremoveid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremoveid.Radius = 15
        Me.txtremoveid.Size = New System.Drawing.Size(409, 30)
        Me.txtremoveid.TabIndex = 5
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(36, 5)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(124, 23)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Enter Item Id"
        '
        'btncancel
        '
        Me.btncancel.Animated = True
        Me.btncancel.AnimationHoverSpeed = 0.07!
        Me.btncancel.AnimationSpeed = 0.03!
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.BorderColor = System.Drawing.Color.Black
        Me.btncancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncancel.CheckedForeColor = System.Drawing.Color.White
        Me.btncancel.CheckedImage = Nothing
        Me.btncancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncancel.FocusedColor = System.Drawing.Color.Empty
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = Nothing
        Me.btncancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncancel.Location = New System.Drawing.Point(241, 70)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btncancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancel.OnHoverImage = Nothing
        Me.btncancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncancel.OnPressedColor = System.Drawing.Color.Black
        Me.btncancel.Radius = 15
        Me.btncancel.Size = New System.Drawing.Size(160, 30)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnrlock
        '
        Me.btnrlock.Animated = True
        Me.btnrlock.AnimationHoverSpeed = 0.07!
        Me.btnrlock.AnimationSpeed = 0.03!
        Me.btnrlock.BackColor = System.Drawing.Color.Transparent
        Me.btnrlock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnrlock.BorderColor = System.Drawing.Color.Black
        Me.btnrlock.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnrlock.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnrlock.CheckedForeColor = System.Drawing.Color.White
        Me.btnrlock.CheckedImage = Nothing
        Me.btnrlock.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnrlock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrlock.FocusedColor = System.Drawing.Color.Empty
        Me.btnrlock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrlock.ForeColor = System.Drawing.Color.White
        Me.btnrlock.Image = Nothing
        Me.btnrlock.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrlock.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnrlock.Location = New System.Drawing.Point(70, 70)
        Me.btnrlock.Name = "btnrlock"
        Me.btnrlock.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnrlock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnrlock.OnHoverForeColor = System.Drawing.Color.White
        Me.btnrlock.OnHoverImage = Nothing
        Me.btnrlock.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnrlock.OnPressedColor = System.Drawing.Color.Black
        Me.btnrlock.Radius = 15
        Me.btnrlock.Size = New System.Drawing.Size(160, 30)
        Me.btnrlock.TabIndex = 2
        Me.btnrlock.Text = "Remove Item"
        Me.btnrlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtremovelock
        '
        Me.txtremovelock.BackColor = System.Drawing.Color.Transparent
        Me.txtremovelock.BaseColor = System.Drawing.Color.White
        Me.txtremovelock.BorderColor = System.Drawing.Color.Silver
        Me.txtremovelock.BorderSize = 1
        Me.txtremovelock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtremovelock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtremovelock.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtremovelock.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtremovelock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtremovelock.Location = New System.Drawing.Point(33, 33)
        Me.txtremovelock.Name = "txtremovelock"
        Me.txtremovelock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtremovelock.Radius = 15
        Me.txtremovelock.Size = New System.Drawing.Size(409, 30)
        Me.txtremovelock.TabIndex = 1
        Me.txtremovelock.UseSystemPasswordChar = True
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(30, 5)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(258, 23)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Please Enter Your Password"
        '
        'Removeitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 105)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Removeitem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Removeitem"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnrlock As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtremovelock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btncancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnremoveid As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtremoveid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
