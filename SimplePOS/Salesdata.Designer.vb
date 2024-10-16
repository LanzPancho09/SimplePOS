<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salesdata
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
        Me.lblsold = New Guna.UI.WinForms.GunaLabel()
        Me.lblearnings = New Guna.UI.WinForms.GunaLabel()
        Me.lblstockleft = New Guna.UI.WinForms.GunaLabel()
        Me.lblcategory = New Guna.UI.WinForms.GunaLabel()
        Me.lblproductn = New Guna.UI.WinForms.GunaLabel()
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblsold
        '
        Me.lblsold.AutoSize = True
        Me.lblsold.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblsold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblsold.Location = New System.Drawing.Point(752, 10)
        Me.lblsold.Name = "lblsold"
        Me.lblsold.Size = New System.Drawing.Size(69, 15)
        Me.lblsold.TabIndex = 13
        Me.lblsold.Text = "ITEM SOLD"
        '
        'lblearnings
        '
        Me.lblearnings.AutoSize = True
        Me.lblearnings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblearnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblearnings.Location = New System.Drawing.Point(1142, 10)
        Me.lblearnings.Name = "lblearnings"
        Me.lblearnings.Size = New System.Drawing.Size(65, 15)
        Me.lblearnings.TabIndex = 12
        Me.lblearnings.Text = "EARNINGS"
        '
        'lblstockleft
        '
        Me.lblstockleft.AutoSize = True
        Me.lblstockleft.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblstockleft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblstockleft.Location = New System.Drawing.Point(919, 10)
        Me.lblstockleft.Name = "lblstockleft"
        Me.lblstockleft.Size = New System.Drawing.Size(72, 15)
        Me.lblstockleft.TabIndex = 11
        Me.lblstockleft.Text = "STOCK LEFT"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcategory.Location = New System.Drawing.Point(582, 10)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(65, 15)
        Me.lblcategory.TabIndex = 10
        Me.lblcategory.Text = "CATEGORY"
        '
        'lblproductn
        '
        Me.lblproductn.AutoSize = True
        Me.lblproductn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblproductn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblproductn.Location = New System.Drawing.Point(181, 10)
        Me.lblproductn.Name = "lblproductn"
        Me.lblproductn.Size = New System.Drawing.Size(323, 15)
        Me.lblproductn.TabIndex = 9
        Me.lblproductn.Text = "PRODUCT NAME                                                                     " &
    "      "
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblitemid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblitemid.Location = New System.Drawing.Point(20, 10)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(51, 15)
        Me.lblitemid.TabIndex = 8
        Me.lblitemid.Text = "ITEM ID"
        '
        'Salesdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblsold)
        Me.Controls.Add(Me.lblearnings)
        Me.Controls.Add(Me.lblstockleft)
        Me.Controls.Add(Me.lblcategory)
        Me.Controls.Add(Me.lblproductn)
        Me.Controls.Add(Me.lblitemid)
        Me.Name = "Salesdata"
        Me.Size = New System.Drawing.Size(1358, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsold As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblearnings As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblstockleft As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcategory As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblproductn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel

End Class
