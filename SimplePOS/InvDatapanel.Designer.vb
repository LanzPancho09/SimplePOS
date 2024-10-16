<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvDatapanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblprice = New Guna.UI.WinForms.GunaLabel()
        Me.lblstock = New Guna.UI.WinForms.GunaLabel()
        Me.lblcat = New Guna.UI.WinForms.GunaLabel()
        Me.lblproductn = New Guna.UI.WinForms.GunaLabel()
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.btnaddstk = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlbutton = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnedit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlbutton.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblprice
        '
        Me.lblprice.AutoEllipsis = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.Black
        Me.lblprice.Location = New System.Drawing.Point(955, 10)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(38, 15)
        Me.lblprice.TabIndex = 6
        Me.lblprice.Text = "PRICE"
        '
        'lblstock
        '
        Me.lblstock.AutoEllipsis = True
        Me.lblstock.BackColor = System.Drawing.Color.Transparent
        Me.lblstock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.ForeColor = System.Drawing.Color.Black
        Me.lblstock.Location = New System.Drawing.Point(780, 10)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(42, 15)
        Me.lblstock.TabIndex = 8
        Me.lblstock.Text = "STOCK"
        '
        'lblcat
        '
        Me.lblcat.AutoEllipsis = True
        Me.lblcat.BackColor = System.Drawing.Color.Transparent
        Me.lblcat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.ForeColor = System.Drawing.Color.Black
        Me.lblcat.Location = New System.Drawing.Point(567, 10)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(65, 15)
        Me.lblcat.TabIndex = 7
        Me.lblcat.Text = "CATEGORY"
        '
        'lblproductn
        '
        Me.lblproductn.AutoEllipsis = True
        Me.lblproductn.BackColor = System.Drawing.Color.Transparent
        Me.lblproductn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductn.ForeColor = System.Drawing.Color.Black
        Me.lblproductn.Location = New System.Drawing.Point(194, 10)
        Me.lblproductn.Name = "lblproductn"
        Me.lblproductn.Size = New System.Drawing.Size(302, 15)
        Me.lblproductn.TabIndex = 5
        Me.lblproductn.Text = "PRODUCT NAME"
        '
        'lblitemid
        '
        Me.lblitemid.AutoEllipsis = True
        Me.lblitemid.BackColor = System.Drawing.Color.Transparent
        Me.lblitemid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.ForeColor = System.Drawing.Color.Black
        Me.lblitemid.Location = New System.Drawing.Point(30, 10)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(143, 15)
        Me.lblitemid.TabIndex = 4
        Me.lblitemid.Text = "ITEM ID"
        '
        'btnaddstk
        '
        Me.btnaddstk.Animated = True
        Me.btnaddstk.AnimationHoverSpeed = 0.07!
        Me.btnaddstk.AnimationSpeed = 0.03!
        Me.btnaddstk.BackColor = System.Drawing.Color.Transparent
        Me.btnaddstk.BaseColor = System.Drawing.Color.SeaGreen
        Me.btnaddstk.BorderColor = System.Drawing.Color.Black
        Me.btnaddstk.CheckedBaseColor = System.Drawing.Color.SeaGreen
        Me.btnaddstk.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnaddstk.CheckedForeColor = System.Drawing.Color.White
        Me.btnaddstk.CheckedImage = Nothing
        Me.btnaddstk.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnaddstk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnaddstk.FocusedColor = System.Drawing.Color.Empty
        Me.btnaddstk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddstk.ForeColor = System.Drawing.Color.White
        Me.btnaddstk.Image = Nothing
        Me.btnaddstk.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnaddstk.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnaddstk.Location = New System.Drawing.Point(1083, 7)
        Me.btnaddstk.Name = "btnaddstk"
        Me.btnaddstk.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnaddstk.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnaddstk.OnHoverForeColor = System.Drawing.Color.White
        Me.btnaddstk.OnHoverImage = Nothing
        Me.btnaddstk.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnaddstk.OnPressedColor = System.Drawing.Color.Black
        Me.btnaddstk.Radius = 5
        Me.btnaddstk.Size = New System.Drawing.Size(98, 22)
        Me.btnaddstk.TabIndex = 9
        Me.btnaddstk.Text = "Add Stock"
        Me.btnaddstk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.AnimationHoverSpeed = 0.07!
        Me.btndelete.AnimationSpeed = 0.03!
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BaseColor = System.Drawing.SystemColors.Control
        Me.btndelete.BorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedBaseColor = System.Drawing.Color.Firebrick
        Me.btndelete.CheckedBorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedForeColor = System.Drawing.Color.White
        Me.btndelete.CheckedImage = Nothing
        Me.btndelete.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btndelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndelete.FocusedColor = System.Drawing.Color.Empty
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Silver
        Me.btndelete.Image = Nothing
        Me.btndelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(1187, 7)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Radius = 5
        Me.btndelete.Size = New System.Drawing.Size(98, 22)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlbutton
        '
        Me.pnlbutton.BackColor = System.Drawing.Color.Transparent
        Me.pnlbutton.BaseColor = System.Drawing.Color.Transparent
        Me.pnlbutton.Controls.Add(Me.btnedit)
        Me.pnlbutton.Location = New System.Drawing.Point(1083, 7)
        Me.pnlbutton.Name = "pnlbutton"
        Me.pnlbutton.Radius = 8
        Me.pnlbutton.Size = New System.Drawing.Size(202, 22)
        Me.pnlbutton.TabIndex = 11
        Me.pnlbutton.Visible = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnedit.Animated = True
        Me.btnedit.AnimationHoverSpeed = 0.07!
        Me.btnedit.AnimationSpeed = 0.03!
        Me.btnedit.BackColor = System.Drawing.Color.Transparent
        Me.btnedit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnedit.BorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedBaseColor = System.Drawing.Color.SeaGreen
        Me.btnedit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnedit.CheckedForeColor = System.Drawing.Color.White
        Me.btnedit.CheckedImage = Nothing
        Me.btnedit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnedit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnedit.FocusedColor = System.Drawing.Color.Empty
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Image = Nothing
        Me.btnedit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnedit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(53, 0)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnedit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnedit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnedit.OnHoverImage = Nothing
        Me.btnedit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnedit.OnPressedColor = System.Drawing.Color.Black
        Me.btnedit.Radius = 5
        Me.btnedit.Size = New System.Drawing.Size(98, 22)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InvDatapanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlbutton)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnaddstk)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblstock)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.lblproductn)
        Me.Controls.Add(Me.lblitemid)
        Me.Name = "InvDatapanel"
        Me.Size = New System.Drawing.Size(1358, 35)
        Me.pnlbutton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblprice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblstock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcat As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblproductn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnaddstk As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlbutton As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnedit As Guna.UI.WinForms.GunaAdvenceButton

End Class
