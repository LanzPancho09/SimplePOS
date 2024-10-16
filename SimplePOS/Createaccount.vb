Imports System.Data.SqlClient
Imports System.IO
Public Class Createaccount
    Dim ctr, gen As Integer
    Dim newacc As Boolean = False
    Dim command As SqlCommand

    Private Sub accrefresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Form2.flowlayoutACC.Controls.Clear()
        Try
            command = New SqlCommand("Select * from tblacc", connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim accdata As Accountdata
                accdata = New Accountdata

                accdata.Margin = New Padding(0)

                ctr = ctr + 1

                Dim byt() As Byte
                byt = reader(1)
                Dim img As New MemoryStream(byt)

                If ctr = 1 Then

                    With accdata
                        .lblaccid.Text = reader.GetString(0)
                        .profileimg.Image = Image.FromStream(img)
                        .lblAccType.Text = reader.GetString(2)
                        .lblName.Text = reader.GetString(3)
                        .lblUsername.Text = reader.GetString(4)
                        .lblPassword.Text = reader.GetString(5)
                        .BackColor = Color.White
                    End With

                Else
                    With accdata
                        .lblaccid.Text = reader.GetString(0)
                        .profileimg.Image = Image.FromStream(img)
                        .lblAccType.Text = reader.GetString(2)
                        .lblName.Text = reader.GetString(3)
                        .lblUsername.Text = reader.GetString(4)
                        .lblPassword.Text = reader.GetString(5)
                        .BackColor = Color.GhostWhite
                        ctr = 0
                    End With

                End If

                Form2.flowlayoutACC.Controls.Add(accdata)
            End While
            ctr = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Createaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'shadow
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'sql
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        'account id generator
        If cbind.Checked = False Then
            gen = 1
            While gen > 0
                Dim search As New SqlDataAdapter("select * from tblacc where accid='" & gen & "'", connection)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count > 0 Then
                    gen = gen + 1
                Else
                    txtaccid.Text = gen
                    gen = 0
                End If
            End While
        End If


        Dim find As New SqlDataAdapter("select * from tblacc", connection)
        Dim findtable As New DataTable
        find.Fill(findtable)

        If findtable.Rows.Count > 0 Then
            newacc = True
        Else
            newacc = False
        End If

    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim check As New SqlDataAdapter("select * from tblacc", connection)
        Dim table As New DataTable
        check.Fill(table)

        If table.Rows.Count > 0 Then
            Me.Close()
            shadowback.Close()
            Form2.Show()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub txtusername_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.Enter
        If txtusername.Text = "Enter Username..." Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.Leave
        If txtusername.Text = "" Then
            txtusername.Text = "Enter Username..."
            txtusername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Enter
        If txtpassword.Text = "Enter Password..." Then
            txtpassword.Text = ""
            txtpassword.UseSystemPasswordChar = True
            txtpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Leave
        If txtpassword.Text = "" Then
            txtpassword.UseSystemPasswordChar = False
            txtpassword.Text = "Enter Password..."
            txtpassword.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtconfirmp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmp.Enter
        If txtconfirmp.Text = "Confirm Password..." Then
            txtconfirmp.Text = ""
            txtconfirmp.UseSystemPasswordChar = True
            txtconfirmp.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtconfirmp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmp.Leave
        If txtconfirmp.Text = "" Then
            txtconfirmp.Text = "Confirm Password..."
            txtconfirmp.UseSystemPasswordChar = False
            txtconfirmp.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.Enter
        If txtname.Text = "Enter Name..." Then
            txtname.Text = ""
            txtname.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.Leave
        If txtname.Text = "" Then
            txtname.Text = "Enter Name..."
            txtname.ForeColor = Color.Silver

        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If Not pbprofile.Image Is Nothing And Not txtaccid.Text = "" And Not txtname.Text = "Enter Name..." And Not txtusername.Text = "Enter Username..." And Not txtpassword.Text = "Enter Password..." And Not cbaccesstype.Text = "" Then
            Dim update As New SqlCommand("Update tblacc set name=@name,profile=@profile,username=@username,password=@password,accesstype=@accesstype where accid=@id", connection)

            Dim ms As New MemoryStream
            pbprofile.Image.Save(ms, pbprofile.Image.RawFormat)

            update.Parameters.AddWithValue("@id", txtaccid.Text)
            update.Parameters.AddWithValue("@name", txtname.Text)
            update.Parameters.AddWithValue("@profile", ms.ToArray)
            update.Parameters.AddWithValue("@username", txtusername.Text)
            update.Parameters.AddWithValue("@password", txtpassword.Text)
            update.Parameters.AddWithValue("@accesstype", cbaccesstype.Text)
            update.ExecuteNonQuery()

            MsgBox("Account Updated!", vbInformation)
            cbind.Checked = False

            'Form2.btnaccback.PerformClick()

            Dim save As New SqlCommand("insert into tblacclog" & "(username,action,date)values(@username,@action,@date)", connection)
            save.Parameters.Add(New SqlParameter("@username", SqlDbType.NVarChar)).Value = txtname.Text
            save.Parameters.Add(New SqlParameter("@action", SqlDbType.NVarChar)).Value = "Update"
            save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
            save.ExecuteNonQuery()

            Me.Close()
            shadowback.Close()
            Form2.Show()
        Else
            MsgBox("Please Complete Your info!", vbInformation)
        End If


    End Sub

    Private Sub btncreateacc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateacc.Click

        'sql
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader
        Dim acctype As Integer

        Dim ms As New MemoryStream
        pbprofile.Image.Save(ms, pbprofile.Image.RawFormat)

        If cbaccesstype.Text = "Administrator" Then
            acctype = 0
        End If

        If cbaccesstype.Text = "Employee" Then
            acctype = 1
        End If

        If cbaccesstype.Text = "Tester" Then
            acctype = 2
        End If

        If cbaccesstype.Text = "Cashier" Then
            acctype = 3
        End If

        If Not pbprofile.Image Is Nothing And Not txtaccid.Text = "" And Not txtname.Text = "" And Not txtusername.Text = "" And Not txtpassword.Text = "" And Not cbaccesstype.Text = "" Then

            If txtpassword.Text = txtconfirmp.Text Then

                Dim save As New SqlCommand("insert into tblacc" & "(accid,profile,name,username,password,accesstype,servertype) values (@accid,@profile,@name,@username,@password,@accesstype,@servertype)", connection)
                save.Parameters.Add(New SqlParameter("@accid", SqlDbType.NChar)).Value = txtaccid.Text
                save.Parameters.Add(New SqlParameter("@profile", SqlDbType.Image)).Value = ms.ToArray
                save.Parameters.Add(New SqlParameter("@name", SqlDbType.Text)).Value = txtname.Text
                save.Parameters.Add(New SqlParameter("@username", SqlDbType.NVarChar)).Value = txtusername.Text
                save.Parameters.Add(New SqlParameter("@password", SqlDbType.NVarChar)).Value = txtpassword.Text
                save.Parameters.Add(New SqlParameter("@accesstype", SqlDbType.Text)).Value = cbaccesstype.Text
                save.Parameters.Add(New SqlParameter("@servertype", SqlDbType.NChar)).Value = ("" & acctype & "")
                save.ExecuteNonQuery()

                MsgBox("Account Created Successfully", vbInformation)

                Dim saves As New SqlCommand("insert into tblacclog" & "(username,action,date)values(@username,@action,@date)", connection)
                saves.Parameters.Add(New SqlParameter("@username", SqlDbType.NVarChar)).Value = txtname.Text
                saves.Parameters.Add(New SqlParameter("@action", SqlDbType.NVarChar)).Value = "Add"
                saves.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
                saves.ExecuteNonQuery()

                accrefresh()

                If newacc = False Then
                    Me.Close()
                    Form1.Show()
                Else
                    Me.Close()
                    shadowback.Close()
                    Form2.Show()
                End If

            Else
                txtconfirmp.Text = ""
                MsgBox("Your Password Not Match!", vbInformation, "Confirm Your Password")
            End If
        Else
            MsgBox("Please Fill Up empty Spaces", vbInformation)
        End If
    End Sub

    Private Sub btneditprofile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditprofile.Click

        Dim obf As New OpenFileDialog
        obf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If obf.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbprofile.Image = Image.FromFile(obf.FileName)
        End If

    End Sub

    Private Sub cbcheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcheck.CheckedChanged
        If txtpassword.UseSystemPasswordChar = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        If txtname.Text.Contains("""") Or txtname.Text.Contains("'") Then
            MsgBox("Double and Sigle quotes are proibited!", vbInformation)
            txtname.Text = ""
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        If txtusername.Text.Contains("""") Or txtusername.Text.Contains("'") Then
            MsgBox("Double and Sigle quotes are proibited!", vbInformation)
            txtusername.Text = ""
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text.Contains("""") Or txtpassword.Text.Contains("'") Then
            MsgBox("Double and Sigle quotes are proibited!", vbInformation)
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub txtconfirmp_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmp.TextChanged
        If txtconfirmp.Text.Contains("""") Or txtconfirmp.Text.Contains("'") Then
            MsgBox("Double and Sigle quotes are proibited!", vbInformation)
            txtconfirmp.Text = ""
        End If
    End Sub

    Private Sub cbpassc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpassc.CheckedChanged
        If txtconfirmp.UseSystemPasswordChar = True Then
            txtconfirmp.UseSystemPasswordChar = False
        Else
            txtconfirmp.UseSystemPasswordChar = True
        End If
    End Sub

End Class