Public Class Cashreport

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub

    Private Sub Cashreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblcashreport' table. You can move, or remove it, as needed.
        Me.tblcashreportTableAdapter.Fill(Me.SMPOSDataSet.tblcashreport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class