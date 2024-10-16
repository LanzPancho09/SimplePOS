<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expireditemdata
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
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.lblprodn = New Guna.UI.WinForms.GunaLabel()
        Me.lbldatexpire = New Guna.UI.WinForms.GunaLabel()
        Me.lblstockexp = New Guna.UI.WinForms.GunaLabel()
        Me.btnMoveDefect = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblstatus = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblitemid
        '
        Me.lblitemid.AutoEllipsis = True
        Me.lblitemid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblitemid.Location = New System.Drawing.Point(32, 10)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(51, 15)
        Me.lblitemid.TabIndex = 5
        Me.lblitemid.Text = "ITEM ID"
        '
        'lblprodn
        '
        Me.lblprodn.AutoEllipsis = True
        Me.lblprodn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblprodn.Location = New System.Drawing.Point(194, 10)
        Me.lblprodn.Name = "lblprodn"
        Me.lblprodn.Size = New System.Drawing.Size(291, 15)
        Me.lblprodn.TabIndex = 6
        Me.lblprodn.Text = "PRODUCT NAME"
        '
        'lbldatexpire
        '
        Me.lbldatexpire.AutoEllipsis = True
        Me.lbldatexpire.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldatexpire.Location = New System.Drawing.Point(582, 10)
        Me.lbldatexpire.Name = "lbldatexpire"
        Me.lbldatexpire.Size = New System.Drawing.Size(79, 15)
        Me.lbldatexpire.TabIndex = 7
        Me.lbldatexpire.Text = "EXPIRY DATE"
        '
        'lblstockexp
        '
        Me.lblstockexp.AutoEllipsis = True
        Me.lblstockexp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblstockexp.ForeColor = System.Drawing.Color.Black
        Me.lblstockexp.Location = New System.Drawing.Point(867, 10)
        Me.lblstockexp.Name = "lblstockexp"
        Me.lblstockexp.Size = New System.Drawing.Size(55, 15)
        Me.lblstockexp.TabIndex = 9
        Me.lblstockexp.Text = "STOCK"
        '
        'btnMoveDefect
        '
        Me.btnMoveDefect.Animated = True
        Me.btnMoveDefect.AnimationHoverSpeed = 0.07!
        Me.btnMoveDefect.AnimationSpeed = 0.03!
        Me.btnMoveDefect.BackColor = System.Drawing.Color.Transparent
        Me.btnMoveDefect.BaseColor = System.Drawing.SystemColors.Control
        Me.btnMoveDefect.BorderColor = System.Drawing.Color.Black
        Me.btnMoveDefect.CheckedBaseColor = System.Drawing.Color.Firebrick
        Me.btnMoveDefect.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnMoveDefect.CheckedForeColor = System.Drawing.Color.White
        Me.btnMoveDefect.CheckedImage = Nothing
        Me.btnMoveDefect.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnMoveDefect.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMoveDefect.FocusedColor = System.Drawing.Color.Empty
        Me.btnMoveDefect.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveDefect.ForeColor = System.Drawing.Color.Silver
        Me.btnMoveDefect.Image = Nothing
        Me.btnMoveDefect.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMoveDefect.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMoveDefect.Location = New System.Drawing.Point(1230, 6)
        Me.btnMoveDefect.Name = "btnMoveDefect"
        Me.btnMoveDefect.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMoveDefect.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMoveDefect.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMoveDefect.OnHoverImage = Nothing
        Me.btnMoveDefect.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMoveDefect.OnPressedColor = System.Drawing.Color.Black
        Me.btnMoveDefect.Radius = 5
        Me.btnMoveDefect.Size = New System.Drawing.Size(109, 22)
        Me.btnMoveDefect.TabIndex = 12
        Me.btnMoveDefect.Text = "Make Defect"
        Me.btnMoveDefect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblstatus
        '
        Me.lblstatus.AutoEllipsis = True
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblstatus.Location = New System.Drawing.Point(1080, 10)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(63, 15)
        Me.lblstatus.TabIndex = 8
        Me.lblstatus.Text = "EXPIRED"
        '
        'Expireditemdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.btnMoveDefect)
        Me.Controls.Add(Me.lblstockexp)
        Me.Controls.Add(Me.lbldatexpire)
        Me.Controls.Add(Me.lblprodn)
        Me.Controls.Add(Me.lblitemid)
        Me.Name = "Expireditemdata"
        Me.Size = New System.Drawing.Size(1342, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblprodn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldatexpire As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblstockexp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnMoveDefect As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblstatus As Guna.UI.WinForms.GunaLabel

End Class
