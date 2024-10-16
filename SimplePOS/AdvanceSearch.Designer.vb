<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvanceSearch))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txtsearch = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnsearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.TransparentPanel1 = New MyControlLibrary.TransparentPanel()
        Me.flowlayoutINV = New System.Windows.Forms.FlowLayoutPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'txtsearch
        '
        Me.txtsearch.BaseColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.Silver
        Me.txtsearch.BorderSize = 0
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedBaseColor = System.Drawing.Color.White
        Me.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(16, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Size = New System.Drawing.Size(417, 26)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.Text = "Search Item..."
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnback)
        Me.GunaPanel1.Controls.Add(Me.GunaElipsePanel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(797, 54)
        Me.GunaPanel1.TabIndex = 1
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
        Me.btnback.Location = New System.Drawing.Point(6, 5)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 20
        Me.btnback.Size = New System.Drawing.Size(45, 42)
        Me.btnback.TabIndex = 5
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.btnsearch)
        Me.GunaElipsePanel1.Controls.Add(Me.txtsearch)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(154, 7)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(484, 42)
        Me.GunaElipsePanel1.TabIndex = 2
        '
        'btnsearch
        '
        Me.btnsearch.AnimationHoverSpeed = 0.07!
        Me.btnsearch.AnimationSpeed = 0.03!
        Me.btnsearch.BaseColor = System.Drawing.Color.Transparent
        Me.btnsearch.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearch.Location = New System.Drawing.Point(439, 7)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.OnHoverBaseColor = System.Drawing.Color.GhostWhite
        Me.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearch.OnHoverImage = Nothing
        Me.btnsearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearch.Size = New System.Drawing.Size(30, 30)
        Me.btnsearch.TabIndex = 1
        '
        'TransparentPanel1
        '
        Me.TransparentPanel1.AutoScroll = True
        Me.TransparentPanel1.Location = New System.Drawing.Point(-1, 90)
        Me.TransparentPanel1.Name = "TransparentPanel1"
        Me.TransparentPanel1.Size = New System.Drawing.Size(797, 10)
        Me.TransparentPanel1.TabIndex = 6
        '
        'flowlayoutINV
        '
        Me.flowlayoutINV.BackColor = System.Drawing.Color.White
        Me.flowlayoutINV.Location = New System.Drawing.Point(0, 92)
        Me.flowlayoutINV.Margin = New System.Windows.Forms.Padding(6)
        Me.flowlayoutINV.Name = "flowlayoutINV"
        Me.flowlayoutINV.Size = New System.Drawing.Size(797, 328)
        Me.flowlayoutINV.TabIndex = 3
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 54)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(797, 37)
        Me.GunaPanel3.TabIndex = 4
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(524, 11)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(43, 17)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "PRICE"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(673, 11)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(57, 17)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "ACTION"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(290, 11)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(111, 17)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "PRODUCT NAME"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(62, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(57, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "ITEM ID"
        '
        'AdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 419)
        Me.Controls.Add(Me.TransparentPanel1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.flowlayoutINV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdvanceSearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvanceSearch"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents flowlayoutINV As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnsearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents TransparentPanel1 As MyControlLibrary.TransparentPanel
End Class
