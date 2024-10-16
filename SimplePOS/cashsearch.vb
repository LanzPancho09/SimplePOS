Imports System.Data.SqlClient
Public Class cashsearch
    Dim command As SqlCommand
    Dim ctr As Integer
    Private Sub Cashreport_refresh(ByVal Query As String)
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        command = New SqlCommand(Query, connection)
        reader = command.ExecuteReader()

        Form2.FlowlayoutCREPORT.Controls.Clear()
        While reader.Read
            Dim creport As Creportdata
            creport = New Creportdata

            ctr = ctr + 1

            If ctr = 1 Then
                With creport
                    .BackColor = Color.White
                    .lbldate.Text = reader.GetString(2) & " " & reader.GetString(3)
                    .lbltransid.Text = reader.GetString(0)
                    .lblcosid.Text = reader.GetString(1)
                    .lblcashier.Text = reader.GetString(8)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblearnings.Text = reader.GetString(4)
                End With
            Else
                With creport
                    .BackColor = Color.GhostWhite
                    .lbldate.Text = reader.GetString(2) & " " & reader.GetString(3)
                    .lbltransid.Text = reader.GetString(0)
                    .lblcosid.Text = reader.GetString(1)
                    .lblcashier.Text = reader.GetString(8)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblearnings.Text = reader.GetString(4)
                End With
                ctr = 0
            End If

            Form2.FlowlayoutCREPORT.Controls.Add(creport)
        End While
    End Sub

    Private Sub btnrearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrearch.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connect.Open()
        connection.Open()
        Dim reader As SqlDataReader

        Form2.GunaLabel22.Visible = True
        Form2.GunaLabel31.Visible = True
        Form2.GunaLabel32.Visible = True
        Form2.lbltotalsalesc.Visible = True
        Form2.lbltotalexpenses.Visible = True
        Form2.lbltotalsalese.Visible = True
        Form2.GunaPanel14.Visible = True
        Form2.GunaPanel15.Visible = True
        Form2.GunaPanel16.Visible = True


        If lblind.Text = 0 Then
            Dim search As New SqlDataAdapter("select * from tbltrans where date like '%" & GunaDateTimePicker1.Text & "%'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                'cartreport resfresh
                Cashreport_refresh("select * from tbltrans where date like '%" & GunaDateTimePicker1.Text & "%'")

                Form2.lblcrprtdate.Text = GunaDateTimePicker1.Text
                Form2.lblcrprtdate.Visible = True

                Form2.lbltotalsalesc.Text = "0"
                Form2.lbltotalexpenses.Text = "0"
                Form2.lbltotalsalese.Text = "0"

                command = New SqlCommand("select * from tbltrans where date like '%" & GunaDateTimePicker1.Text & "%'", connection)
                reader = command.ExecuteReader


                While reader.Read
                    Form2.lbltotalsalesc.Text = Val(Form2.lbltotalsalesc.Text) + Val(reader.GetString(4))
                End While

                command = New SqlCommand("select * from tblexpenses where date like '%" & Format(CDate(GunaDateTimePicker1.Text), "dd MMMM yyyy") & "%'", connect)
                reader = command.ExecuteReader

                Dim expenses As Double

                While reader.Read
                    expenses = expenses + Val(reader.GetString(2))
                End While

                Form2.lbltotalexpenses.Text = expenses
                Form2.lbltotalsalese.Text = Val(Form2.lbltotalsalesc.Text) - expenses

                'Dim wholenum As Integer
                'wholenum = Val(Form2.lbltotalsalesc.Text)

                'If wholenum = Int(wholenum) Then
                '    Form2.lbltotalsalesc.Text = wholenum & ".00"
                'Else
                '    Form2.lbltotalsalesc.Text = wholenum
                'End If

                Me.Close()
                shadowback.Close()
            Else
                MsgBox("No Record Found!", vbInformation)
            End If

        Else



            Dim search As New SqlDataAdapter("select * from tbltrans where date like '%" & cbmonth.Text & " " & Format(Today, "yyyy") & "%'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                'cartreport resfresh
                Cashreport_refresh("select * from tbltrans where date like '%" & cbmonth.Text & " " & Format(Today, "yyyy") & "%'")

                Form2.lblcrprtdate.Text = cbmonth.Text & " " & Format(Today, "yyyy")
                Form2.lblcrprtdate.Visible = True

                Form2.lbltotalsalesc.Text = "0"
                Form2.lbltotalexpenses.Text = "0"
                Form2.lbltotalsalese.Text = "0"

                command = New SqlCommand("select * from tbltrans where date like '%" & cbmonth.Text & " " & Format(Today, "yyyy") & "%'", connection)
                reader = command.ExecuteReader



                While reader.Read
                    Form2.lbltotalsalesc.Text = Val(Form2.lbltotalsalesc.Text) + Val(reader.GetString(4))
                End While

                command = New SqlCommand("select * from tblexpenses where date like '%" & cbmonth.Text & " " & Format(Today, "yyyy") & "%'", connect)
                reader = command.ExecuteReader

                Dim expenses As Double

                While reader.Read
                    expenses = expenses + Val(reader.GetString(2))
                End While

                Form2.lbltotalexpenses.Text = expenses
                Form2.lbltotalsalese.Text = Val(Form2.lbltotalsalesc.Text) - expenses

                'Dim wholenum As Integer
                'wholenum = Val(Form2.lbltotalsalese.Text)

                'If wholenum = Int(wholenum) Then
                '    Form2.lbltotalsalese.Text = wholenum & ".00"
                'Else
                '    Form2.lbltotalsalese.Text = wholenum
                'End If

                Me.Close()
                shadowback.Close()
            Else
                MsgBox("No Record Exists!", vbInformation)
            End If

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub
End Class