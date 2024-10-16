<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advancesearchdata
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
        Me.lblprodn = New Guna.UI.WinForms.GunaLabel()
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.btnselect = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblprice.Location = New System.Drawing.Point(520, 10)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(43, 17)
        Me.lblprice.TabIndex = 7
        Me.lblprice.Text = "PRICE"
        '
        'lblprodn
        '
        Me.lblprodn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprodn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblprodn.Location = New System.Drawing.Point(168, 10)
        Me.lblprodn.Name = "lblprodn"
        Me.lblprodn.Size = New System.Drawing.Size(293, 15)
        Me.lblprodn.TabIndex = 5
        Me.lblprodn.Text = "PRODUCT NAME"
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblitemid.Location = New System.Drawing.Point(19, 10)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(53, 17)
        Me.lblitemid.TabIndex = 4
        Me.lblitemid.Text = "Item ID"
        Me.lblitemid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnselect
        '
        Me.btnselect.Animated = True
        Me.btnselect.AnimationHoverSpeed = 0.07!
        Me.btnselect.AnimationSpeed = 0.03!
        Me.btnselect.BackColor = System.Drawing.Color.Transparent
        Me.btnselect.BaseColor = System.Drawing.SystemColors.Control
        Me.btnselect.BorderColor = System.Drawing.Color.Black
        Me.btnselect.CheckedBaseColor = System.Drawing.Color.Firebrick
        Me.btnselect.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnselect.CheckedForeColor = System.Drawing.Color.White
        Me.btnselect.CheckedImage = Nothing
        Me.btnselect.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnselect.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnselect.FocusedColor = System.Drawing.Color.Empty
        Me.btnselect.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.Silver
        Me.btnselect.Image = Nothing
        Me.btnselect.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnselect.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnselect.Location = New System.Drawing.Point(644, 7)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnselect.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnselect.OnHoverForeColor = System.Drawing.Color.White
        Me.btnselect.OnHoverImage = Nothing
        Me.btnselect.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnselect.OnPressedColor = System.Drawing.Color.Black
        Me.btnselect.Radius = 5
        Me.btnselect.Size = New System.Drawing.Size(109, 22)
        Me.btnselect.TabIndex = 13
        Me.btnselect.Text = "Select"
        Me.btnselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'advancesearchdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblprodn)
        Me.Controls.Add(Me.lblitemid)
        Me.Name = "advancesearchdata"
        Me.Size = New System.Drawing.Size(797, 37)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblprice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblprodn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnselect As Guna.UI.WinForms.GunaAdvenceButton

End Class
