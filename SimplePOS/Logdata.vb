Imports System.Data.SqlClient
Public Class Logdata
    Dim command As SqlCommand
    Dim ctr As Integer
    Private Sub Logdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblLogId.AutoSize = False
        lblLogId.AutoEllipsis = True
    End Sub



    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        Dim delete As New SqlDataAdapter("delete from tblinvlog where date='" & CDate(lblHistory.Text) & "'", connection)
        Dim table As New DataTable
        delete.Fill(table)

        command = New SqlCommand("select * from tblinvlog", connection)
        reader = command.ExecuteReader

        Form2.flowlayoutLOG.Controls.Clear()
        While reader.Read
            Dim logcontrol As Logdata
            logcontrol = New Logdata
            ctr = ctr + 1

            If ctr = 1 Then
                With logcontrol
                    .BackColor = Color.GhostWhite
                    .lblLogId.Text = reader.GetString(0)
                    .lblProdName.Text = reader.GetString(1)
                    .lblHistory.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
            Else
                With logcontrol
                    .BackColor = Color.White
                    .lblLogId.Text = reader.GetString(0)
                    .lblProdName.Text = reader.GetString(1)
                    .lblHistory.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
                End With
                ctr = 0
            End If

            Form2.flowlayoutLOG.Controls.Add(logcontrol)
        End While
    End Sub

End Class
