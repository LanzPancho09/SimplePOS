Imports System.Data.SqlClient
Public Class Search
    Dim command As SqlCommand
    Dim ctr As Integer
    Private Sub transaction_search(ByVal query As String)
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Transdata.query = query

        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader

        Form2.flowlayoutTRANS.Controls.Clear()
        While reader.Read
            Dim trans As Transdata
            trans = New Transdata
            trans.Margin = New Padding(0)

            ctr = ctr + 1

            If ctr = 1 Then
                With trans
                    .BackColor = Color.White
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)
                    .lblsubtotal.Text = reader.GetString(4)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblchange.Text = reader.GetString(7)
                    .lblpay.Text = reader.GetString(6)
                End With
            Else
                With trans
                    .BackColor = Color.GhostWhite
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)
                    .lblsubtotal.Text = reader.GetString(4)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblchange.Text = reader.GetString(7)
                    .lblpay.Text = reader.GetString(6)
                End With
                ctr = 0
            End If

            Form2.flowlayoutTRANS.Controls.Add(trans)
        End While
    End Sub

    Private Sub rbtnmonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnmonth.CheckedChanged
        If rbtnmonth.Checked = True Then
            pnlrange.Visible = False
            GunaLabel1.Visible = True
            Comonth.Visible = True
            GunaLabel2.Visible = True
            txtyear.Visible = True
        End If
    End Sub

    Private Sub rbtnyear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnyear.CheckedChanged
        If rbtnyear.Checked = True Then
            pnlrange.Visible = False
            GunaLabel1.Visible = False
            Comonth.Visible = False
            GunaLabel2.Visible = True
            txtyear.Visible = True
        End If
    End Sub

    Private Sub rbtnrange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnrange.CheckedChanged

        If rbtnrange.Checked = True Then
            pnlrange.Visible = True
            GunaLabel1.Visible = False
            Comonth.Visible = False
            GunaLabel2.Visible = False
            txtyear.Visible = False
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If rbtnmonth.Checked = True Then

            If Not Comonth.Text = "" And Not txtyear.Text = "" Then
                Dim searchqueary As String = "select * from tbltrans where date like '%" & Comonth.Text + " " + txtyear.Text & "%'"

                Dim search As New SqlDataAdapter(searchqueary, connection)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count > 0 Then
                    transaction_search(searchqueary)
                    Me.Close()
                    shadowback.Close()
                Else
                    MsgBox("No Record Exists!", vbInformation)
                End If
            Else
                MsgBox("Please Select Month And Enter Year!", vbInformation)
            End If

        ElseIf rbtnyear.Checked = True Then

            If Not txtyear.Text = "" Then
                Dim searchquery As String = "select * from tbltrans where date like '%" & txtyear.Text & "%'"

                Dim search As New SqlDataAdapter(searchquery, connection)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count > 0 Then
                    transaction_search(searchquery)
                    Me.Close()
                    shadowback.Close()
                Else
                    MsgBox("No Record Exists!", vbInformation)
                End If

            Else
                MsgBox("Please Select Month And Enter Year!", vbInformation)
            End If
        Else
            Dim searchquery As String = "select * from tbltrans where dt Between'" & dtpfrom.Text & "'and'" & dtpto.Text & "'"

            Dim search As New SqlDataAdapter(searchquery, connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                transaction_search(searchquery)
                Me.Close()
                shadowback.Close()
            Else
                MsgBox("No Record Exists!", vbInformation)
            End If

        End If

    End Sub
End Class