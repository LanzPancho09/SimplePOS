Public Class Printtrans

    Private Sub Printtrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblreport' table. You can move, or remove it, as needed.
        Me.tblreportTableAdapter.Fill(Me.SMPOSDataSet.tblreport)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub
End Class