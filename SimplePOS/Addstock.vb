Imports System.Data.SqlClient
Public Class Addstock
    Dim ctr = ctr + 1
    Dim command As SqlCommand
    Private Sub Addstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        txtaddstock.Select()
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        shadowback.Close()
        Form2.Show()
    End Sub

    Private Sub txtstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstock.TextChanged
        If Val(txtstock.Text) = 0 Then
            txtstock.LineColor = System.Drawing.Color.FromArgb(188, 48, 40)
        ElseIf Val(txtstock.Text) <= 20 Then
            txtstock.LineColor = System.Drawing.Color.FromArgb(248, 163, 0)
        Else
            txtstock.LineColor = System.Drawing.Color.FromArgb(15, 115, 0)
        End If
    End Sub

    Private Sub btnaddstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstock.Click

        If isvalid(txtaddstock.Text) = True Then
            Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
            connection.Open()
            Dim reader As SqlDataReader

            Dim total As Integer
            total = (Val(txtstock.Text) + Val(txtaddstock.Text))

            Dim edit As New SqlDataAdapter("update tblsales set stock='" & total & "'where itemid='" & RTrim(lblitemid.Text) & "'", connection)
            Dim tabledit As New DataTable
            edit.Fill(tabledit)


            Dim upd As New SqlDataAdapter("update tblinventory set stock='" & total & "'where itemid='" & lblitemid.Text & "'", connection)
            Dim table As New DataTable
            upd.Fill(table)
            connection.Close()


            Form2.flowlayoutinv.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("select * from tblinventory", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim inv As InvDatapanel
                    inv = New InvDatapanel

                    ctr = ctr + 1
                    If ctr = 1 Then
                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.White
                            .pnlbutton.Visible = False
                        End With
                    Else
                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.GhostWhite
                            .pnlbutton.Visible = False
                            ctr = 0
                        End With
                    End If
                    Form2.flowlayoutinv.Controls.Add(inv)
                End While
                ctr = 0

                connection.Close()
                connection.Open()

                Dim save As New SqlCommand("insert into tblstocklog" & "(product,stocklog,date) values (@product,@stocklog,@date)", connection)
                save.Parameters.Add(New SqlParameter("@product", SqlDbType.NVarChar)).Value = txtprodname.Text
                save.Parameters.Add(New SqlParameter("@stocklog", SqlDbType.NChar)).Value = txtaddstock.Text
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = Today & " " & Format(TimeOfDay, "hh:mm:ss tt")
                save.ExecuteNonQuery()

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
            shadowback.Close()
            Form2.Show()
            'Form2.btnback.PerformClick()
        Else
            MsgBox("Please Input digits only", vbInformation)
        End If


    End Sub

    Private Sub txtaddstock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddstock.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back AndAlso Asc(e.KeyChar) <> Keys.Return Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnaddstock.PerformClick()
        End If
    End Sub

    Function isvalid(ByVal input As String) As Boolean
        For i = 0 To input.Length - 1

            If Char.IsLetter(input.Chars(i)) Then
                Return False
            End If


            If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) Then
                Return False
            End If

        Next

        If input = "" Then
            Return False
        End If

        Return True
    End Function

    Private Sub txtaddstock_TextChanged(sender As Object, e As EventArgs) Handles txtaddstock.TextChanged

        If isvalid(txtaddstock.Text) = False Then
            txtaddstock.FocusedLineColor = Color.FromArgb(201, 0, 0)
        Else
            txtaddstock.FocusedLineColor = Color.FromArgb(10, 118, 0)
        End If

    End Sub
End Class