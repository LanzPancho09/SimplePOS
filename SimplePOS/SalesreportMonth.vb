Public Class SalesreportMonth

    Private Sub SalesreportMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblsalesreport' table. You can move, or remove it, as needed.
        Me.tblsalesreportTableAdapter.Fill(Me.SMPOSDataSet.tblsalesreport)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub
End Class