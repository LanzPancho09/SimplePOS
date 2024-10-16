<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exdata
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblno = New Guna.UI.WinForms.GunaLabel()
        Me.lbldes = New Guna.UI.WinForms.GunaLabel()
        Me.lblprice = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.Location = New System.Drawing.Point(210, 10)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(33, 16)
        Me.lblno.TabIndex = 0
        Me.lblno.Text = "NO."
        Me.lblno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldes
        '
        Me.lbldes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldes.Location = New System.Drawing.Point(371, 10)
        Me.lbldes.Name = "lbldes"
        Me.lbldes.Size = New System.Drawing.Size(588, 15)
        Me.lbldes.TabIndex = 1
        Me.lbldes.Text = "Description"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblprice.Location = New System.Drawing.Point(1026, 10)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(40, 16)
        Me.lblprice.TabIndex = 2
        Me.lblprice.Text = "Price"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lbldes)
        Me.Controls.Add(Me.lblno)
        Me.Name = "Exdata"
        Me.Size = New System.Drawing.Size(1335, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblno As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldes As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblprice As Guna.UI.WinForms.GunaLabel
End Class
