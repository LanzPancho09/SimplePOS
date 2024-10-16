Imports System.Data.SqlClient
Public Class Accountlog
    Dim command As SqlCommand
    Dim ctr As Integer
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        Dim delete As New SqlDataAdapter("delete from tblacclog where date='" & CDate(lblUsername.Text) & "'", connection)
        Dim table As New DataTable
        delete.Fill(table)


        command = New SqlCommand("select * from tblacclog", connection)
        reader = command.ExecuteReader

        Form2.flowlayoutLOG.Controls.Clear()
        While reader.Read
            'dataload
            Dim acclog As Accountlog
            acclog = New Accountlog

            ctr = ctr + 1
            If ctr = 1 Then
                With acclog
                    .BackColor = Color.GhostWhite
                    .lblHistory.Text = reader.GetString(0)
                    .lblLogId.Text = reader.GetString(1)
                    .lblUsername.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
            Else
                With acclog
                    .BackColor = Color.White
                    .lblHistory.Text = reader.GetString(0)
                    .lblLogId.Text = reader.GetString(1)
                    .lblUsername.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
                ctr = 0
            End If

            Form2.flowlayoutLOG.Controls.Add(acclog)
        End While


    End Sub
End Class
