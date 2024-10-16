Public Class advancesearchdata

   
    Private Sub advancesearchdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselect.Click
        Form2.txtitemcode.Text = lblitemid.Text
        Form2.txtprodn.Text = lblprodn.Text
        Form2.txtPOSprice.Text = lblprice.Text

        AdvanceSearch.Close()
        shadowback.Close()
        Form2.Show()
        If Form2.cbscan.Checked = False Then
            Form2.txtprodn.Select()
        Else
            Form2.txtitemcode.Select()
        End If

    End Sub
End Class
