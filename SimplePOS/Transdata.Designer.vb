<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transdata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transdata))
        Me.lbldiscount = New Guna.UI.WinForms.GunaLabel()
        Me.lblsubtotal = New Guna.UI.WinForms.GunaLabel()
        Me.lbldate = New Guna.UI.WinForms.GunaLabel()
        Me.lblcosid = New Guna.UI.WinForms.GunaLabel()
        Me.lblcashier = New Guna.UI.WinForms.GunaLabel()
        Me.lbltransactionID = New Guna.UI.WinForms.GunaLabel()
        Me.lblpay = New Guna.UI.WinForms.GunaLabel()
        Me.lblchange = New Guna.UI.WinForms.GunaLabel()
        Me.btnselect = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'lbldiscount
        '
        Me.lbldiscount.BackColor = System.Drawing.Color.Transparent
        Me.lbldiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldiscount.Location = New System.Drawing.Point(813, 10)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(67, 15)
        Me.lbldiscount.TabIndex = 11
        Me.lbldiscount.Text = "DISCOUNT"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblsubtotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblsubtotal.Location = New System.Drawing.Point(640, 9)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(64, 15)
        Me.lblsubtotal.TabIndex = 10
        Me.lblsubtotal.Text = "SUBTOTAL"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldate.Location = New System.Drawing.Point(438, 10)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 15)
        Me.lbldate.TabIndex = 9
        Me.lbldate.Text = "DATE"
        '
        'lblcosid
        '
        Me.lblcosid.BackColor = System.Drawing.Color.Transparent
        Me.lblcosid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcosid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcosid.Location = New System.Drawing.Point(302, 10)
        Me.lblcosid.Name = "lblcosid"
        Me.lblcosid.Size = New System.Drawing.Size(85, 15)
        Me.lblcosid.TabIndex = 8
        Me.lblcosid.Text = "COSTUMER ID"
        '
        'lblcashier
        '
        Me.lblcashier.AutoEllipsis = True
        Me.lblcashier.BackColor = System.Drawing.Color.Transparent
        Me.lblcashier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcashier.Location = New System.Drawing.Point(162, 10)
        Me.lblcashier.Name = "lblcashier"
        Me.lblcashier.Size = New System.Drawing.Size(88, 15)
        Me.lblcashier.TabIndex = 7
        Me.lblcashier.Text = "CASHIER"
        '
        'lbltransactionID
        '
        Me.lbltransactionID.BackColor = System.Drawing.Color.Transparent
        Me.lbltransactionID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransactionID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltransactionID.Location = New System.Drawing.Point(7, 9)
        Me.lbltransactionID.Name = "lbltransactionID"
        Me.lbltransactionID.Size = New System.Drawing.Size(105, 15)
        Me.lbltransactionID.TabIndex = 6
        Me.lbltransactionID.Text = "TRANSACTION ID"
        Me.lbltransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpay
        '
        Me.lblpay.BackColor = System.Drawing.Color.Transparent
        Me.lblpay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblpay.Location = New System.Drawing.Point(1118, 10)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(27, 15)
        Me.lblpay.TabIndex = 13
        Me.lblpay.Text = "PAY"
        '
        'lblchange
        '
        Me.lblchange.BackColor = System.Drawing.Color.Transparent
        Me.lblchange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblchange.Location = New System.Drawing.Point(957, 10)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(54, 15)
        Me.lblchange.TabIndex = 12
        Me.lblchange.Text = "CHANGE"
        '
        'btnselect
        '
        Me.btnselect.Animated = True
        Me.btnselect.AnimationHoverSpeed = 0.07!
        Me.btnselect.AnimationSpeed = 0.03!
        Me.btnselect.BackColor = System.Drawing.Color.Transparent
        Me.btnselect.BaseColor = System.Drawing.Color.Transparent
        Me.btnselect.BorderColor = System.Drawing.Color.Black
        Me.btnselect.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnselect.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnselect.CheckedForeColor = System.Drawing.Color.White
        Me.btnselect.CheckedImage = CType(resources.GetObject("btnselect.CheckedImage"), System.Drawing.Image)
        Me.btnselect.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnselect.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnselect.FocusedColor = System.Drawing.Color.Empty
        Me.btnselect.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.Silver
        Me.btnselect.Image = Nothing
        Me.btnselect.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnselect.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnselect.Location = New System.Drawing.Point(1231, 6)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnselect.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnselect.OnHoverForeColor = System.Drawing.Color.White
        Me.btnselect.OnHoverImage = Nothing
        Me.btnselect.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnselect.OnPressedColor = System.Drawing.Color.Black
        Me.btnselect.Radius = 5
        Me.btnselect.Size = New System.Drawing.Size(88, 24)
        Me.btnselect.TabIndex = 14
        Me.btnselect.Text = "Select"
        Me.btnselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Transdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblcosid)
        Me.Controls.Add(Me.lblcashier)
        Me.Controls.Add(Me.lbltransactionID)
        Me.Name = "Transdata"
        Me.Size = New System.Drawing.Size(1347, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldiscount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblsubtotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcosid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcashier As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbltransactionID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblpay As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblchange As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnselect As Guna.UI.WinForms.GunaAdvenceButton

End Class
