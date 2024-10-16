<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categorydata
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
        Me.lblno = New Guna.UI.WinForms.GunaLabel()
        Me.lblcat = New Guna.UI.WinForms.GunaLabel()
        Me.btnDelete = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaCircleButton()
        Me.SuspendLayout()
        '
        'lblno
        '
        Me.lblno.BackColor = System.Drawing.Color.Transparent
        Me.lblno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.Location = New System.Drawing.Point(33, 11)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(23, 15)
        Me.lblno.TabIndex = 0
        Me.lblno.Text = "No"
        Me.lblno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcat
        '
        Me.lblcat.BackColor = System.Drawing.Color.Transparent
        Me.lblcat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.Location = New System.Drawing.Point(186, 11)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(185, 15)
        Me.lblcat.TabIndex = 1
        Me.lblcat.Text = "Category"
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.SimplePOS.My.Resources.Resources.delete_96px_g
        Me.btnDelete.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnDelete.Location = New System.Drawing.Point(550, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Global.SimplePOS.My.Resources.Resources.delete_96px
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(20, 20)
        Me.btnDelete.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.SimplePOS.My.Resources.Resources.pencil_96px_g
        Me.btnUpdate.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnUpdate.Location = New System.Drawing.Point(514, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Global.SimplePOS.My.Resources.Resources.pencil_96px
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(20, 20)
        Me.btnUpdate.TabIndex = 15
        '
        'categorydata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.lblno)
        Me.Name = "categorydata"
        Me.Size = New System.Drawing.Size(600, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblno As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcat As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaCircleButton
End Class
