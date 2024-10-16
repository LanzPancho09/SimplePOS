Imports System.Data.SqlClient
Public Class Exdata
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        connection.Open()

        Dim result As MsgBoxResult

        result = MsgBox("Are you sure to Delete?", vbYesNo)

        If result = MsgBoxResult.Yes Then
            Dim delete As New SqlDataAdapter("delete from tblexpenses where no='" & Val(lblno.Text) & "'", connection)
            Dim table As New DataTable
            delete.Fill(table)

            Form2.btnexpenses.PerformClick()
        End If

        connection.Close()
    End Sub


End Class
