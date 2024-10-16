<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Defectitem
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
        Me.components = New System.ComponentModel.Container()
        Me.lblItemID = New Guna.UI.WinForms.GunaLabel()
        Me.lblprodn = New Guna.UI.WinForms.GunaLabel()
        Me.lblAffstock = New Guna.UI.WinForms.GunaLabel()
        Me.lblValue = New Guna.UI.WinForms.GunaLabel()
        Me.lblDesc = New Guna.UI.WinForms.GunaLabel()
        Me.lblDate = New Guna.UI.WinForms.GunaLabel()
        Me.btnReturn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblItemID
        '
        Me.lblItemID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(43, 10)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(47, 15)
        Me.lblItemID.TabIndex = 5
        Me.lblItemID.Text = "ITEM ID"
        '
        'lblprodn
        '
        Me.lblprodn.AutoEllipsis = True
        Me.lblprodn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprodn.Location = New System.Drawing.Point(178, 10)
        Me.lblprodn.Name = "lblprodn"
        Me.lblprodn.Size = New System.Drawing.Size(129, 15)
        Me.lblprodn.TabIndex = 6
        Me.lblprodn.Text = "PRODUCT"
        '
        'lblAffstock
        '
        Me.lblAffstock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAffstock.Location = New System.Drawing.Point(381, 10)
        Me.lblAffstock.Name = "lblAffstock"
        Me.lblAffstock.Size = New System.Drawing.Size(42, 15)
        Me.lblAffstock.TabIndex = 7
        Me.lblAffstock.Text = "AFFECTED STOCK"
        '
        'lblValue
        '
        Me.lblValue.AutoEllipsis = True
        Me.lblValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(515, 10)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(239, 15)
        Me.lblValue.TabIndex = 8
        Me.lblValue.Text = "VALUE"
        '
        'lblDesc
        '
        Me.lblDesc.AutoEllipsis = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(770, 10)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(180, 15)
        Me.lblDesc.TabIndex = 12
        Me.lblDesc.Text = "DESCRIPTION"
        '
        'lblDate
        '
        Me.lblDate.AutoEllipsis = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(976, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(101, 15)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "DATE"
        '
        'btnReturn
        '
        Me.btnReturn.Animated = True
        Me.btnReturn.AnimationHoverSpeed = 0.07!
        Me.btnReturn.AnimationSpeed = 0.03!
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BaseColor = System.Drawing.Color.Transparent
        Me.btnReturn.BorderColor = System.Drawing.Color.Black
        Me.btnReturn.CheckedBaseColor = System.Drawing.Color.Firebrick
        Me.btnReturn.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnReturn.CheckedForeColor = System.Drawing.Color.White
        Me.btnReturn.CheckedImage = Nothing
        Me.btnReturn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReturn.FocusedColor = System.Drawing.Color.Empty
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Silver
        Me.btnReturn.Image = Global.SimplePOS.My.Resources.Resources.open_view_48px_g
        Me.btnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnReturn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReturn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(1257, 6)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReturn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReturn.OnHoverImage = Global.SimplePOS.My.Resources.Resources.open_view_48px
        Me.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReturn.OnPressedColor = System.Drawing.Color.Black
        Me.btnReturn.Radius = 5
        Me.btnReturn.Size = New System.Drawing.Size(35, 25)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return Item")
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BaseColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedBaseColor = System.Drawing.Color.Firebrick
        Me.btnEdit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedForeColor = System.Drawing.Color.White
        Me.btnEdit.CheckedImage = Nothing
        Me.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Silver
        Me.btnEdit.Image = Global.SimplePOS.My.Resources.Resources.edit_property_48px_b
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEdit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(1216, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Global.SimplePOS.My.Resources.Resources.edit_property_48px
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Radius = 5
        Me.btnEdit.Size = New System.Drawing.Size(35, 25)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Edit Record")
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.AnimationHoverSpeed = 0.07!
        Me.btndelete.AnimationSpeed = 0.03!
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BaseColor = System.Drawing.Color.Transparent
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
        Me.btndelete.Image = Global.SimplePOS.My.Resources.Resources.delete_view_48px
        Me.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btndelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(1298, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Global.SimplePOS.My.Resources.Resources.delete_48px
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Radius = 5
        Me.btndelete.Size = New System.Drawing.Size(35, 25)
        Me.btndelete.TabIndex = 11
        Me.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btndelete, "Delete Item")
        '
        'Defectitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblAffstock)
        Me.Controls.Add(Me.lblprodn)
        Me.Controls.Add(Me.lblItemID)
        Me.Name = "Defectitem"
        Me.Size = New System.Drawing.Size(1342, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblItemID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblprodn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAffstock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblValue As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblDesc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnReturn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
