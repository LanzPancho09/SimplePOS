<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costumerdata
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
        Me.lblproductname = New Guna.UI.WinForms.GunaLabel()
        Me.lblitemid = New Guna.UI.WinForms.GunaLabel()
        Me.lblearnings = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblproductname.Location = New System.Drawing.Point(368, 10)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(98, 15)
        Me.lblproductname.TabIndex = 4
        Me.lblproductname.Text = "PRODUCT NAME"
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblitemid.Location = New System.Drawing.Point(134, 10)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(51, 15)
        Me.lblitemid.TabIndex = 3
        Me.lblitemid.Text = "ITEM ID"
        '
        'lblearnings
        '
        Me.lblearnings.AutoSize = True
        Me.lblearnings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblearnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblearnings.Location = New System.Drawing.Point(1143, 10)
        Me.lblearnings.Name = "lblearnings"
        Me.lblearnings.Size = New System.Drawing.Size(65, 15)
        Me.lblearnings.TabIndex = 5
        Me.lblearnings.Text = "EARNINGS"
        '
        'Costumerdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblearnings)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.lblitemid)
        Me.Name = "Costumerdata"
        Me.Size = New System.Drawing.Size(1358, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblproductname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblitemid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblearnings As Guna.UI.WinForms.GunaLabel

End Class
