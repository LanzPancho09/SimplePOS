<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datapanel1
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
        Me.lblquantity = New Guna.UI.WinForms.GunaLabel()
        Me.lblprodn = New Guna.UI.WinForms.GunaLabel()
        Me.lblpcode = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblprice.Location = New System.Drawing.Point(993, 9)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(38, 15)
        Me.lblprice.TabIndex = 7
        Me.lblprice.Text = "PRICE"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblquantity
        '
        Me.lblquantity.BackColor = System.Drawing.Color.Transparent
        Me.lblquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblquantity.Location = New System.Drawing.Point(678, 8)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(66, 15)
        Me.lblquantity.TabIndex = 6
        Me.lblquantity.Text = "QUANTITY"
        Me.lblquantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprodn
        '
        Me.lblprodn.BackColor = System.Drawing.Color.Transparent
        Me.lblprodn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblprodn.Location = New System.Drawing.Point(205, 8)
        Me.lblprodn.Name = "lblprodn"
        Me.lblprodn.Size = New System.Drawing.Size(353, 15)
        Me.lblprodn.TabIndex = 5
        Me.lblprodn.Text = "PRODUCT NAME                                                                     " &
    "                "
        '
        'lblpcode
        '
        Me.lblpcode.BackColor = System.Drawing.Color.Transparent
        Me.lblpcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblpcode.Location = New System.Drawing.Point(44, 8)
        Me.lblpcode.Name = "lblpcode"
        Me.lblpcode.Size = New System.Drawing.Size(69, 15)
        Me.lblpcode.TabIndex = 4
        Me.lblpcode.Text = "ITEM CODE"
        Me.lblpcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Datapanel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lblprodn)
        Me.Controls.Add(Me.lblpcode)
        Me.Name = "Datapanel1"
        Me.Size = New System.Drawing.Size(1350, 33)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblprice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblquantity As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblprodn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblpcode As Guna.UI.WinForms.GunaLabel

End Class
