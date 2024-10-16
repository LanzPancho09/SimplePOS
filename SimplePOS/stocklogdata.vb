Imports System.Data.SqlClient
Public Class stocklogdata
    Dim command As SqlCommand
    Dim ctr As Integer
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        Dim delete As New SqlDataAdapter("delete from tblstocklog where date='" & CDate(lbldate.Text) & "'", connection)
        Dim table As New DataTable
        delete.Fill(table)

        command = New SqlCommand("select * from tblstocklog", connection)
        reader = command.ExecuteReader

        Form2.flowlayoutLOG.Controls.Clear()
        While reader.Read
            Dim logcontrol As stocklogdata
            logcontrol = New stocklogdata
            ctr = ctr + 1

            If ctr = 1 Then
                With logcontrol
                    .BackColor = Color.GhostWhite
                    .lblprod.Text = reader.GetString(0)
                    .lblaction.Text = reader.GetString(1)
                    .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
            Else
                With logcontrol
                    .BackColor = Color.White
                    .lblprod.Text = reader.GetString(0)
                    .lblaction.Text = reader.GetString(1)
                    .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
                ctr = 0
            End If

            Form2.flowlayoutLOG.Controls.Add(logcontrol)
        End While
    End Sub

    Private Sub lblprod_Click(sender As Object, e As EventArgs) Handles lblprod.Click

    End Sub
End Class
