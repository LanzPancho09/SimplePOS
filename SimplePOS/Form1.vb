Imports System.Data.SqlClient
Imports System.IO
Public Class Form1

    Private Sub Admin()
        Form2.btninventory.Visible = True
        Form2.btnsales.Visible = True
        Form2.btntransactions.Visible = True
        Form2.btnlogmanager.Visible = True
        Form2.btntransactions.Visible = True
        Form2.btncashreport.Visible = True
        Form2.btnaccount.Visible = True
    End Sub

    Private Sub Employee()
        Form2.btninventory.Visible = False
        Form2.btnsales.Visible = False
        Form2.btntransactions.Visible = False
        Form2.btnlogmanager.Visible = False
        Form2.btntransactions.Visible = False
        Form2.btncashreport.Visible = False
        Form2.btnaccount.Visible = False
    End Sub

    Function checkaccount() As Boolean
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim check As New SqlDataAdapter("select * from tblactivation where activated='" & True & "' and computer='" & System.Environment.MachineName & "'", connection)
        Dim tablecheck As New DataTable
        check.Fill(tablecheck)

        If tablecheck.Rows.Count > 0 Then
            Dim trial As Boolean = tablecheck.Rows(0)(4)

            If trial = True Then
                Return True
            Else
                Return False
            End If

        End If


    End Function

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Application.ExitThread()
    End Sub

    Private Sub txtuser_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Enter
        'placeholder
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtuser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtpass_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.Enter
        If txtpass.Text = "Password" Then
            lblnc.Visible = False
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        If txtpass.Text = "" Then
            txtpass.Text = "Password"
            txtpass.ForeColor = Color.Silver

            If txtpass.Text = "Password" Then
                txtpass.UseSystemPasswordChar = False
            End If

        End If
    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblacc where username='" & txtuser.Text & "'and password='" & txtpass.Text & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If txtuser.Text = "Username" Or txtpass.Text = "Password" Then
            MsgBox("Please Fill Up Empty Spaces!", vbInformation)
        Else
            If table.Rows.Count > 0 Then
                Dim int As Integer = table.Rows(0)(6)

                Dim byt() As Byte
                byt = table.Rows(0)(1)
                Dim img As New MemoryStream(byt)


                'admin
                If int = 0 Then
                    Admin()


                    Form2.Show()

                    If checkaccount() = True Then
                        shadowback.Show()
                        timenotif.Show()
                    End If

                    Me.Hide()


                    Form2.pbuserprofile.Image = Image.FromStream(img)
                    Form2.pblogut.Image = Image.FromStream(img)
                    Form2.lblusername.Text = table.Rows(0)(3)
                    Form2.lblaccesstype.Text = table.Rows(0)(5)
                    Form2.lbluser.Text = table.Rows(0)(2)
                    Form2.txtitemcode.TabIndex = 0
                    Form2.txtprodn.Select()

                    Form2.lblaccess.Text = "Administrator"
                ElseIf int = 1 Then 'employee

                    Employee()

                    Form2.Show()

                    If checkaccount() = True Then
                        shadowback.Show()
                        timenotif.Show()
                    End If

                    Me.Hide()

                    Form2.pbuserprofile.Image = Image.FromStream(img)
                    Form2.pblogut.Image = Image.FromStream(img)
                    Form2.lblusername.Text = table.Rows(0)(3)
                    Form2.lblaccesstype.Text = table.Rows(0)(5)
                    Form2.lbluser.Text = table.Rows(0)(2)
                    Form2.txtitemcode.TabIndex = 0
                    Form2.txtprodn.Select()

                    Form2.lblaccess.Text = "Employee"
                ElseIf int = 2 Then           'tester

                    Admin()

                    Form2.Show()

                    If checkaccount() = True Then
                        shadowback.Show()
                        timenotif.Show()
                    End If

                    Me.Hide()

                    Form2.pbuserprofile.Image = Image.FromStream(img)
                    Form2.pblogut.Image = Image.FromStream(img)
                    Form2.lblusername.Text = table.Rows(0)(3)
                    Form2.lblaccesstype.Text = table.Rows(0)(5)
                    Form2.lbluser.Text = table.Rows(0)(2)
                    Form2.txtitemcode.TabIndex = 0
                    Form2.txtprodn.Select()

                    Form2.lblaccess.Text = "Tester"
                Else                  'cashier

                    Form2.pbuserprofile.Image = Image.FromStream(img)
                    Form2.pblogut.Image = Image.FromStream(img)
                    Form2.lblusername.Text = table.Rows(0)(3)
                    Form2.lblaccesstype.Text = table.Rows(0)(5)

                    Employee()

                    Form2.Show()

                    If checkaccount() = True Then
                        shadowback.Show()
                        timenotif.Show()
                    End If

                    Me.Hide()

                    Form2.lbluser.Text = table.Rows(0)(2)
                    Form2.txtitemcode.TabIndex = 0
                    Form2.txtprodn.Select()

                    Form2.lblaccess.Text = "Cashier"
                End If

                Form2.lbltimeind.Text = Today & " " & Format(TimeOfDay, "hh:mm:ss tt")

                txtuser.Text = ""
                txtpass.Text = ""

                If txtpass.Text = "" Then
                    txtpass.Text = "Password"
                    txtpass.ForeColor = Color.Silver
                End If

                If txtuser.Text = "" Then
                    txtuser.Text = "Username"
                    txtuser.ForeColor = Color.Silver
                End If

                lblnc.Visible = False
            Else
                lblnc.Visible = True
                txtpass.Text = ""

                Dim find As New SqlDataAdapter("select * from tblacc where username like '%" & txtuser.Text & "%'", connection)
                Dim tablefind As New DataTable
                find.Fill(tablefind)

                If tablefind.Rows.Count > 0 Then

                    Dim byt() As Byte
                    byt = tablefind.Rows(0)(1)
                    Dim img As New MemoryStream(byt)

                    userprofile.Image = Image.FromStream(img)

                End If


            End If
        End If




    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCheckBox1.CheckedChanged
        If GunaCheckBox1.Checked = True Then
            If txtpass.Text = "Password" Then
                txtpass.Text = ""
            End If

            txtpass.UseSystemPasswordChar = False

        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            txtpass.Select()
        End If
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Btnlogin.PerformClick()
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        If txtuser.Text.Contains("""") Or txtuser.Text.Contains("'") Then
            MsgBox("Single and double quotes are prohibited!", vbInformation)
            txtuser.Text = ""
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.Text.Contains("""") Or txtpass.Text.Contains("'") Then
            MsgBox("Single and double quotes are prohibited!", vbInformation)
            txtpass.Text = ""
        End If
    End Sub
End Class
