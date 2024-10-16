<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creportdata
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
        Me.lbltransid = New Guna.UI.WinForms.GunaLabel()
        Me.lbldate = New Guna.UI.WinForms.GunaLabel()
        Me.lblcosid = New Guna.UI.WinForms.GunaLabel()
        Me.lblCashier = New Guna.UI.WinForms.GunaLabel()
        Me.lblDiscount = New Guna.UI.WinForms.GunaLabel()
        Me.lblEarnings = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lbltransid
        '
        Me.lbltransid.BackColor = System.Drawing.Color.IndianRed
        Me.lbltransid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransid.Location = New System.Drawing.Point(30, 11)
        Me.lbltransid.Name = "lbltransid"
        Me.lbltransid.Size = New System.Drawing.Size(134, 13)
        Me.lbltransid.TabIndex = 0
        Me.lbltransid.Text = "TRANS ID"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.IndianRed
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(240, 11)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(134, 13)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "DATE"
        '
        'lblcosid
        '
        Me.lblcosid.BackColor = System.Drawing.Color.IndianRed
        Me.lblcosid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcosid.Location = New System.Drawing.Point(468, 11)
        Me.lblcosid.Name = "lblcosid"
        Me.lblcosid.Size = New System.Drawing.Size(134, 13)
        Me.lblcosid.TabIndex = 2
        Me.lblcosid.Text = "COSTUMER ID"
        '
        'lblCashier
        '
        Me.lblCashier.BackColor = System.Drawing.Color.IndianRed
        Me.lblCashier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(680, 11)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(134, 13)
        Me.lblCashier.TabIndex = 3
        Me.lblCashier.Text = "CASHIER"
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.IndianRed
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(858, 11)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(134, 13)
        Me.lblDiscount.TabIndex = 4
        Me.lblDiscount.Text = "DISCOUNT"
        '
        'lblEarnings
        '
        Me.lblEarnings.BackColor = System.Drawing.Color.IndianRed
        Me.lblEarnings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarnings.Location = New System.Drawing.Point(1065, 11)
        Me.lblEarnings.Name = "lblEarnings"
        Me.lblEarnings.Size = New System.Drawing.Size(134, 13)
        Me.lblEarnings.TabIndex = 5
        Me.lblEarnings.Text = "EARNINGS"
        '
        'Creportdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblEarnings)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.lblcosid)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltransid)
        Me.Name = "Creportdata"
        Me.Size = New System.Drawing.Size(1342, 35)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbltransid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcosid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCashier As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblDiscount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblEarnings As Guna.UI.WinForms.GunaLabel
End Class
