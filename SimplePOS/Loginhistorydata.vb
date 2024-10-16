Imports System.Data.SqlClient
Public Class Loginhistorydata
    Dim command As SqlCommand
    Dim ctr As Integer

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()


        Dim delete As New SqlDataAdapter("delete from tblhistory where logout='" & CDate(lbllogout.Text) & "'", connection)
        Dim table As New DataTable
        delete.Fill(table)

        Form2.btnloghistory.PerformClick()
    End Sub
End Class
