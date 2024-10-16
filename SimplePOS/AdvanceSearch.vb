Imports System.Data.SqlClient
Public Class AdvanceSearch
    Dim gen, ctr As Integer
    Dim command As SqlCommand


    Private Sub AdvanceSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        TransparentPanel1.BringToFront()
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(TransparentPanel1, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'controlpanel
        flowlayoutINV.AutoScroll = False
        flowlayoutINV.HorizontalScroll.Enabled = False
        flowlayoutINV.AutoScroll = True

        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        flowlayoutINV.Controls.Clear()
        Try
            command = New SqlCommand("select * from tblinventory", connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim invdata As advancesearchdata
                invdata = New advancesearchdata
                invdata.Margin = New Padding(0)

                ctr = ctr + 1

                If ctr = 1 Then
                    With invdata
                        .lblitemid.Text = RTrim(reader.GetString(1))
                        .lblprodn.Text = reader.GetString(2)
                        .lblprice.Text = reader.GetString(6)
                        .BackColor = Color.White
                    End With
                Else
                    With invdata
                        .lblitemid.Text = RTrim(reader.GetString(1))
                        .lblprodn.Text = reader.GetString(2)
                        .lblprice.Text = reader.GetString(6)
                        .BackColor = Color.GhostWhite
                    End With
                    ctr = 0
                End If

                flowlayoutINV.Controls.Add(invdata)
            End While
            ctr = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If Form2.cbscan.Checked = True Then
            Form2.txtitemcode.Select()
        Else
            Form2.txtprodn.Select()
        End If

        Me.Close()
        shadowback.Close()
        Form2.Show()

    End Sub


    Private Sub txtsearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Enter
        If txtsearch.Text = "Search Item..." Then
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Leave
        If txtsearch.Text = "" Then
            txtsearch.Text = "Search Item..."
            txtsearch.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtsearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnsearch.PerformClick()
        End If

        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            btnback.PerformClick()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then
            Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
            connection.Open()
            Dim reader As SqlDataReader

            flowlayoutINV.Controls.Clear()
            Try
                command = New SqlCommand("select * from tblinventory", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim invdata As advancesearchdata
                    invdata = New advancesearchdata
                    invdata.Margin = New Padding(0)

                    ctr = ctr + 1

                    If ctr = 1 Then
                        With invdata
                            .lblitemid.Text = RTrim(reader.GetString(1))
                            .lblprodn.Text = reader.GetString(2)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.White
                        End With
                    Else
                        With invdata
                            .lblitemid.Text = RTrim(reader.GetString(1))
                            .lblprodn.Text = reader.GetString(2)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.GhostWhite
                        End With
                        ctr = 0
                    End If

                    flowlayoutINV.Controls.Add(invdata)
                End While
                ctr = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If txtsearch.Text.Contains("""") Or txtsearch.Text.Contains("'") Then
            MsgBox("Double And Single Quotes Are Prohibited!", vbCritical)
            txtsearch.Select()
            txtsearch.Text = ""
        Else
            Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
            connection.Open()
            Dim reader As SqlDataReader

            flowlayoutINV.Controls.Clear()
            Try
                command = New SqlCommand("select * from tblinventory where prodn like '%" & txtsearch.Text & "%' or itemid like '%" & txtsearch.Text & "%'", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim invdata As advancesearchdata
                    invdata = New advancesearchdata
                    invdata.Margin = New Padding(0)

                    ctr = ctr + 1

                    If ctr = 1 Then
                        With invdata
                            .lblitemid.Text = RTrim(reader.GetString(1))
                            .lblprodn.Text = reader.GetString(2)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.White
                        End With
                    Else
                        With invdata
                            .lblitemid.Text = RTrim(reader.GetString(1))
                            .lblprodn.Text = reader.GetString(2)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.GhostWhite
                        End With
                        ctr = 0
                    End If

                    flowlayoutINV.Controls.Add(invdata)
                End While
                ctr = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            txtsearch.Select()

        End If
    End Sub


End Class