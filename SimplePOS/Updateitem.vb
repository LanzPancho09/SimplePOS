Imports System.Data.SqlClient
Public Class Updateitem
    Dim gen, ctr As Integer
    Dim ID As String
    Dim command As SqlCommand
    Dim bool As Boolean = False
    Dim edit As Boolean = False

    Function checkstr(ByVal input As String, ByVal types As String) As Boolean

        If types = "letter" Then

            For i = 0 To input.Length - 1

                If Char.IsLetter(input.Chars(i)) Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "digit" Then

            For i = 0 To input.Length - 1

                If Char.IsDigit(input.Chars(i)) Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "special" Then

            For i = 0 To input.Length - 1

                If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "specials" Then

            For i = 0 To input.Length - 1

                If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) And Not Asc(input.Chars(i)) = Keys.Space Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "letterspecial" Then
            For i = 0 To input.Length - 1

                If Char.IsLetter(input.Chars(i)) Then
                    Return False
                End If

                If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "digitspecial" Then
            For i = 0 To input.Length - 1

                If Char.IsDigit(input.Chars(i)) Then
                    Return False
                End If

                If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) Then
                    Return False
                End If

            Next
            Return True

        ElseIf types = "letterspecials" Then
            For i = 0 To input.Length - 1

                If Char.IsLetter(input.Chars(i)) And Not Asc(input.Chars(i)) = 46 Then
                    Return False
                End If

                If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) And Not Asc(input.Chars(i)) = 46 Then
                    Return False
                End If

            Next
            Return True

        End If


    End Function
    Function quotes() As Boolean

        If txtitemid.Text.Contains("""") Or txtitemid.Text.Contains("'") Then
            GunaPictureBox0.Visible = True
            Return False
        ElseIf txtprodname.Text.Contains("""") Or txtprodname.Text.Contains("'") Then
            GunaPictureBox1.Visible = True
            Return False
        ElseIf cbcategory.Text.Contains("""") Or cbcategory.Text.Contains("'") Then
            GunaPictureBox2.Visible = True
            Return False
        ElseIf txtstock.Text.Contains("""") Or txtstock.Text.Contains("'") Then
            GunaPictureBox3.Visible = True
            Return False
        ElseIf txtprice.Text.Contains("""") Or txtstock.Text.Contains("'") Then
            GunaPictureBox4.Visible = True
            Return False
        Else
            Return True
        End If

    End Function
    Function nospace() As Boolean

        If txtitemid.Text = "" Then
            GunaPictureBox0.Visible = True
            Return False
        ElseIf txtprodname.Text = "" Then
            GunaPictureBox1.Visible = True
            Return False
        ElseIf cbcategory.Text = "" Then
            GunaPictureBox2.Visible = True
            Return False
        ElseIf txtstock.Text = "" Then
            GunaPictureBox3.Visible = True
            Return False
        ElseIf txtprice.Text = "" Then
            GunaPictureBox4.Visible = True
            Return False
        Else
            Return True
        End If

    End Function
    Function restriction() As Boolean

        If checkstr(txtitemid.Text, "letterspecial") = False Then
            Return False
        ElseIf cbcategory.Text = "" Then
            Return False
        ElseIf checkstr(txtstock.Text, "letterspecial") = False Then
            Return False
        ElseIf checkstr(txtprice.Text, "letterspecials") = False Then
            Return False
        Else
            Return True
        End If

    End Function


    Function isformvalid() As Boolean

        If nospace() = True And restriction() = True And quotes() = True Then
            Return True
        Else

            If nospace() = False Then
                MsgBox("Please complete the info!", vbInformation)
            End If

            If restriction() = False Then
                MsgBox("Input Invalid!", vbInformation)
            End If

            If quotes() = False Then
                MsgBox("Double and Singles Quotes are Invalid!", vbInformation)
            End If

            Return False
        End If

    End Function

    Private Sub Updateitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 30, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'sql
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        command = New SqlCommand("select * from tblcat", connection)
        reader = command.ExecuteReader
        While reader.Read
            If Not cbcategory.Items.Contains(reader.GetString(1)) Then
                cbcategory.Items.Add(reader.GetString(1))
            End If
        End While

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        shadowback.Close()
        Form2.Show()
    End Sub


    Private Sub btnexpr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexpr.Click
        If bool = False Then
            bool = True
            dtpexpr.Enabled = True
        Else
            bool = False
            dtpexpr.Enabled = False
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader
        Dim invid As Integer

        If isformvalid() = True Then

            If edit = True Then
                gen = 1
                While gen > 0
                    Dim search As New SqlDataAdapter("select * from tblinventory where invid='" & gen & "'", connection)
                    Dim table As New DataTable
                    search.Fill(table)

                    If table.Rows.Count > 0 Then
                        gen = gen + 1
                    Else
                        invid = gen
                        gen = 0
                    End If
                End While

                If bool = True Then
                    Dim save As New SqlCommand("insert into tblinventory" & "(invid,itemid,prodn,cat,expdt,stock,price) values (@invid,@itemid,@prodn,@cat,@expdt,@stock,@price)", connection)

                    save.Parameters.Add(New SqlParameter("@invid", SqlDbType.NChar)).Value = invid
                    save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemid.Text
                    save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtprodname.Text
                    save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbcategory.Text
                    save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.NVarChar)).Value = Format(dtpexpr.Value, "MM/dd/yyyy")
                    save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = txtstock.Text
                    save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = txtprice.Text
                    save.ExecuteNonQuery()
                Else
                    Dim save As New SqlCommand("insert into tblinventory" & "(invid,itemid,prodn,cat,expdt,stock,price) values (@invid,@itemid,@prodn,@cat,@expdt,@stock,@price)", connection)
                    save.Parameters.Add(New SqlParameter("@invid", SqlDbType.NChar)).Value = invid
                    save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemid.Text
                    save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtprodname.Text
                    save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbcategory.Text
                    save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.NVarChar)).Value = ""
                    save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = txtstock.Text
                    save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = txtprice.Text
                    save.ExecuteNonQuery()

                End If
                MsgBox("Data Updated Successfully! qwe", vbInformation)


                Dim delete As New SqlDataAdapter("delete from tblinventory where itemid='" & ID & "'", connection)
                Dim deltable As New DataTable
                delete.Fill(deltable)

            Else
                Dim upd As New SqlDataAdapter("update tblinventory set prodn='" & txtprodname.Text & "',cat='" & cbcategory.Text & "',expdt='" & Format(dtpexpr.Value, "MM/dd/yyyy") & "',stock='" & txtstock.Text & "',price='" & txtprice.Text & "' where itemid='" & txtitemid.Text & "'", connection)
                Dim table As New DataTable
                upd.Fill(table)
                MsgBox("Data Updated Successfully!", vbInformation)
            End If

            Dim saves As New SqlCommand("insert into tblinvlog" & "(product,action,date) values (@product,@action,@date)", connection)
            saves.Parameters.Add(New SqlParameter("@product", SqlDbType.NVarChar)).Value = txtprodname.Text
            saves.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Update"
            saves.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = Today & " " & Format(TimeOfDay, "hh:mm:ss tt")
            saves.ExecuteNonQuery()

            'Form2.btnback.PerformClick()

            Me.Close()
            shadowback.Close()
            Form2.Show()
        End If



    End Sub

    Private Sub txtitemid_TextChanged(sender As Object, e As EventArgs) Handles txtitemid.TextChanged
        If checkstr(txtitemid.Text, "letterspecial") = False Then
            GunaPictureBox0.Visible = True
            txtitemid.LineColor = Color.FromArgb(220, 77, 65)
            txtitemid.FocusedLineColor = Color.FromArgb(220, 77, 65)
        Else
            GunaPictureBox0.Visible = False
            txtitemid.LineColor = Color.FromArgb(26, 128, 59)
            txtitemid.FocusedLineColor = Color.FromArgb(26, 128, 59)
        End If
    End Sub

    Private Sub txtprodname_TextChanged(sender As Object, e As EventArgs) Handles txtprodname.TextChanged
        If txtprodname.Text.Contains("""") Or txtprodname.Text.Contains("'") Then
            GunaPictureBox1.Visible = True
            txtprodname.LineColor = Color.FromArgb(220, 77, 65)
        Else
            GunaPictureBox1.Visible = False
            txtprodname.LineColor = Color.FromArgb(26, 128, 59)
        End If
    End Sub

    Private Sub txtstock_TextChanged(sender As Object, e As EventArgs) Handles txtstock.TextChanged
        If checkstr(txtstock.Text, "letterspecial") = False Then
            GunaPictureBox3.Visible = True
            txtstock.LineColor = Color.FromArgb(220, 77, 65)
            txtstock.FocusedLineColor = Color.FromArgb(220, 77, 65)
        Else
            GunaPictureBox3.Visible = False
            txtstock.LineColor = Color.FromArgb(26, 128, 59)
            txtstock.FocusedLineColor = Color.FromArgb(26, 128, 59)
        End If
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        Dim price As String = txtprice.Text
        Dim result() As String
        result = price.Split(".")

        If result.Count > 2 Then
            MsgBox("Please Input Proper Value!", vbInformation)
            txtprice.Text = ""
        End If

        If txtprice.Text.Contains("""") Or txtprice.Text.Contains("'") Then
            GunaPictureBox4.Visible = True
            txtprice.LineColor = Color.FromArgb(220, 77, 65)
            txtprice.FocusedLineColor = Color.FromArgb(220, 77, 65)
        Else
            GunaPictureBox4.Visible = False
            txtprice.LineColor = Color.FromArgb(26, 128, 59)
            txtprice.FocusedLineColor = Color.FromArgb(26, 128, 59)
        End If

    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        If cbcategory.Text = "" Then
            GunaPictureBox2.Visible = True
        Else
            GunaPictureBox2.Visible = False
        End If
    End Sub

    Private Sub txtprodname_MouseEnter(sender As Object, e As EventArgs) Handles txtprodname.MouseEnter
        If txtprodname.Text.Contains("""") Or txtprodname.Text.Contains("'") Then
            GunaPictureBox1.Visible = True
            txtprodname.LineColor = Color.FromArgb(220, 77, 65)
            txtprodname.FocusedLineColor = Color.FromArgb(220, 77, 65)
        Else
            GunaPictureBox1.Visible = False
            txtprodname.LineColor = Color.FromArgb(26, 128, 59)
            txtprodname.FocusedLineColor = Color.FromArgb(26, 128, 59)
        End If
    End Sub

    Private Sub btnedID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedID.Click

        If edit = False Then
            edit = True
            ID = txtitemid.Text
            txtitemid.Text = ""
            txtitemid.Enabled = True
            txtitemid.Select()
        Else
            edit = False
            txtitemid.Text = ID
            txtitemid.Enabled = False
        End If
    End Sub
End Class