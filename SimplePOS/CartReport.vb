Public Class CartReport

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click


        If lblcloseind.Text = 0 Then
            Me.Close()
        Else
            Me.Close()
            shadowback.Close()
            lblcloseind.Text = 0
        End If


    End Sub

    
    Private Sub CartReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblreport' table. You can move, or remove it, as needed.
        Me.tblreportTableAdapter.Fill(Me.SMPOSDataSet.tblreport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class