<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashreport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashreport))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblcashreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMPOSDataSet = New SimplePOS.SMPOSDataSet()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnclose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblcashreportTableAdapter = New SimplePOS.SMPOSDataSetTableAdapters.tblcashreportTableAdapter()
        CType(Me.tblcashreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblcashreportBindingSource
        '
        Me.tblcashreportBindingSource.DataMember = "tblcashreport"
        Me.tblcashreportBindingSource.DataSource = Me.SMPOSDataSet
        '
        'SMPOSDataSet
        '
        Me.SMPOSDataSet.DataSetName = "SMPOSDataSet"
        Me.SMPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.btnclose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(832, 27)
        Me.GunaPanel1.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.AnimationHoverSpeed = 0.07!
        Me.btnclose.AnimationSpeed = 0.03!
        Me.btnclose.BaseColor = System.Drawing.Color.Transparent
        Me.btnclose.BorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnclose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnclose.CheckedForeColor = System.Drawing.Color.White
        Me.btnclose.CheckedImage = CType(resources.GetObject("btnclose.CheckedImage"), System.Drawing.Image)
        Me.btnclose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FocusedColor = System.Drawing.Color.Empty
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnclose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(793, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnclose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnclose.OnHoverImage = Nothing
        Me.btnclose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnclose.OnPressedColor = System.Drawing.Color.Black
        Me.btnclose.Size = New System.Drawing.Size(39, 27)
        Me.btnclose.TabIndex = 0
        Me.btnclose.Text = "GunaAdvenceButton1"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cashreport"
        ReportDataSource1.Value = Me.tblcashreportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SimplePOS.Cashreport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(832, 433)
        Me.ReportViewer1.TabIndex = 2
        '
        'tblcashreportTableAdapter
        '
        Me.tblcashreportTableAdapter.ClearBeforeFill = True
        '
        'Cashreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cashreport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashreport"
        CType(Me.tblcashreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents tblcashreportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SMPOSDataSet As SimplePOS.SMPOSDataSet
    Friend WithEvents tblcashreportTableAdapter As SimplePOS.SMPOSDataSetTableAdapters.tblcashreportTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
