<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expenses))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlshad = New Guna.UI.WinForms.GunaPanel()
        Me.txtdes = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtprice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnadd = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblind = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'pnlshad
        '
        Me.pnlshad.Location = New System.Drawing.Point(1, 49)
        Me.pnlshad.Name = "pnlshad"
        Me.pnlshad.Size = New System.Drawing.Size(387, 10)
        Me.pnlshad.TabIndex = 7
        '
        'txtdes
        '
        Me.txtdes.BackColor = System.Drawing.Color.White
        Me.txtdes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdes.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtdes.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.ForeColor = System.Drawing.Color.Black
        Me.txtdes.LineColor = System.Drawing.Color.Silver
        Me.txtdes.LineSize = 2
        Me.txtdes.Location = New System.Drawing.Point(56, 103)
        Me.txtdes.MaxLength = 50
        Me.txtdes.Name = "txtdes"
        Me.txtdes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdes.Size = New System.Drawing.Size(268, 26)
        Me.txtdes.TabIndex = 1
        Me.txtdes.Text = "Description..."
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.White
        Me.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtprice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Black
        Me.txtprice.LineColor = System.Drawing.Color.Silver
        Me.txtprice.LineSize = 2
        Me.txtprice.Location = New System.Drawing.Point(57, 178)
        Me.txtprice.MaxLength = 10
        Me.txtprice.Name = "txtprice"
        Me.txtprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprice.Size = New System.Drawing.Size(268, 26)
        Me.txtprice.TabIndex = 2
        Me.txtprice.Text = "Enter Price..."
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(151, 16)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(79, 19)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Expenses"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(54, 84)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(81, 16)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Description"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(54, 159)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(40, 16)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Price"
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
        Me.btnback.Location = New System.Drawing.Point(12, 8)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 20
        Me.btnback.Size = New System.Drawing.Size(36, 33)
        Me.btnback.TabIndex = 6
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnadd
        '
        Me.btnadd.Animated = True
        Me.btnadd.AnimationHoverSpeed = 0.07!
        Me.btnadd.AnimationSpeed = 0.03!
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnadd.BorderColor = System.Drawing.Color.Black
        Me.btnadd.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnadd.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnadd.CheckedForeColor = System.Drawing.Color.White
        Me.btnadd.CheckedImage = Nothing
        Me.btnadd.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnadd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnadd.FocusedColor = System.Drawing.Color.Empty
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = Nothing
        Me.btnadd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnadd.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(98, 230)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnadd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnadd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnadd.OnHoverImage = Nothing
        Me.btnadd.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnadd.OnPressedColor = System.Drawing.Color.Black
        Me.btnadd.Radius = 15
        Me.btnadd.Size = New System.Drawing.Size(192, 49)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add"
        Me.btnadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(389, 50)
        Me.GunaPanel1.TabIndex = 8
        '
        'lblind
        '
        Me.lblind.AutoSize = True
        Me.lblind.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblind.Location = New System.Drawing.Point(12, 288)
        Me.lblind.Name = "lblind"
        Me.lblind.Size = New System.Drawing.Size(13, 15)
        Me.lblind.TabIndex = 9
        Me.lblind.Text = "0"
        Me.lblind.Visible = False
        '
        'Expenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 312)
        Me.Controls.Add(Me.lblind)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.pnlshad)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Expenses"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expenses"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnlshad As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtdes As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtprice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnadd As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblind As Guna.UI.WinForms.GunaLabel
End Class
