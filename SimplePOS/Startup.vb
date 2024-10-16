Imports System.Data.SqlClient
Imports System.IO
Public Class Startup
    Dim connected As Boolean = False
    Dim activated As Boolean = False
    Dim ctr As Integer

    Function single_double_quote(ByVal input As String)

        If input.Contains("""") Or input.Contains("'") Then
            MsgBox("Single and Double Quotes are prohibited!")
            Return False
        Else
            Return True
        End If

    End Function


    Function Encrypt(ByVal input As String)
        Dim key As String = ""

        For Each x As Char In input

            If Char.IsLower(x) Then
                Dim diff As Integer = Asc(x) - Asc("a")
                key += Chr(Asc("z") - diff)

            ElseIf Char.IsUpper(x) Then
                Dim diff As Integer = Asc(x) - Asc("A")
                key += Chr(Asc("Z") - diff)
            Else
                key += x
            End If

        Next

        Return key
    End Function

    Private Sub check_acc()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblacc", connection)
        Dim table As New DataTable
        search.Fill(table)

        Dim check As New SqlDataAdapter("select * from tblactivation where activated='" & True & "' and computer='" & System.Environment.MachineName & "'", connection)
        Dim tablecheck As New DataTable
        check.Fill(tablecheck)

        If tablecheck.Rows.Count > 0 Then
            Dim trial As Boolean = tablecheck.Rows(0)(4)
            Dim timetrial As String = tablecheck.Rows(0)(5)


            If trial = True Then

                'make a notification for time left

                If timetrial = "00:00:00" Then

                    MsgBox("Your Product key has expired, Please contact us to Purchase Our Product Thanks!", vbInformation)
                    pgbar.Value = 0
                    pnlactivation.Visible = True

                Else

                    If table.Rows.Count > 0 Then
                        Me.Hide()
                        Form1.Show()
                    Else
                        Createaccount.Show()
                        Createaccount.pnledit.Visible = False
                        Me.Hide()
                    End If

                End If

            Else

                ' if not trial
                If table.Rows.Count > 0 Then
                    Me.Hide()
                    Form1.Show()
                Else
                    Createaccount.Show()
                    Createaccount.pnledit.Visible = False
                    Me.Hide()
                End If

            End If

        End If

        'If table.Rows.Count > 0 Then
        '    Me.Hide()
        '    Form1.Show()
        'Else
        '    Createaccount.Show()
        '    Createaccount.pnledit.Visible = False
        '    Me.Hide()
        'End If
    End Sub

    Private Function Check_connection() As Boolean
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If connection.State = ConnectionState.Open = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function Check_ActivationKey() As Boolean
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim check As New SqlDataAdapter("select * from tblactivation where activated='" & True & "' and computer='" & System.Environment.MachineName & "'", connection)
        Dim table As New DataTable
        check.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tmloading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmloading.Tick
        If pgbar.Value = 40 Then


            If Check_ActivationKey() = True Then
                activated = True
                pgbar.Increment(1)
            Else
                'activation key
                tmloading.Stop()
                pgbar.Value = 0
                pnlactivation.Visible = True
            End If


        Else
            If activated = True Then

                If pgbar.Value = 90 Then

                    If Check_connection() = True Then
                        connected = True
                        pgbar.Increment(1)

                    Else
                        MsgBox("Connection Failed!", vbInformation)
                        tmloading.Stop()
                        pgbar.Value = 0
                    End If

                Else
                    If connected = True Then

                        If pgbar.Value = 100 Then
                            tmloading.Stop()
                            check_acc()
                        Else
                            pgbar.Increment(1)
                        End If

                    Else
                        pgbar.Increment(1)

                        ctr = ctr + 1
                        If ctr = 10 Then
                            lblloading.Text = "Checking For Connection."
                        ElseIf ctr = 20 Then
                            lblloading.Text = "Checking For Connection.."
                        ElseIf ctr = 30 Then
                            lblloading.Text = "Checking For Connection..."
                            ctr = 0
                        End If
                    End If
                End If

            Else
                pgbar.Increment(1)

                ctr = ctr + 1
                If ctr = 10 Then
                    lblloading.Text = "Checking For Licence."
                ElseIf ctr = 20 Then
                    lblloading.Text = "Checking For Licence.."
                ElseIf ctr = 30 Then
                    lblloading.Text = "Checking For Licence..."
                    ctr = 0
                End If

            End If
        End If



    End Sub

    Private Sub Startup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tmloading.Start()

        Dim connection As New SqlConnection("Data Source=DESKTOP-J94MAMS\SQLEXPRESS;Initial Catalog=SMPOS;User ID=sa;Password=1234")

        Try
            connection.Open()

            MsgBox("Connection Succeeded!", vbInformation, "SQL Connection")
        Catch ex As Exception
            Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
            MsgBox("Connection Error", vbCritical, "SQL Connection")
        End Try

        Form2.Show()

    End Sub

    Private Sub Startup_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Hide()
    End Sub


    Private Sub txtact1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact1.Enter
        If txtact1.Text = "XXXX" Then
            txtact1.Text = ""
        End If
    End Sub

    Private Sub txtact1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact1.Leave
        If txtact1.Text = "" Then
            txtact1.Text = "XXXX"
        End If
    End Sub

    Private Sub txtact1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact1.TextChanged

        If single_double_quote(txtact1.Text) = False Then
            txtact1.Text = ""
        End If

        If txtact1.Text.Length = 4 Then
            txtact1.Text = txtact1.Text.ToUpper()
            txtact2.Select()
        End If
    End Sub

    Private Sub txtact2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact2.Enter
        If txtact2.Text = "XXXX" Then
            txtact2.Text = ""
        End If
    End Sub

    Private Sub txtact2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact2.Leave
        If txtact2.Text = "" Then
            txtact2.Text = "XXXX"
        End If
    End Sub

    Private Sub txtact2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact2.TextChanged

        If single_double_quote(txtact2.Text) = False Then
            txtact2.Text = ""
        End If

        If txtact2.Text.Length = 4 Then
            txtact2.Text = txtact2.Text.ToUpper()
            txtact3.Select()
        End If
    End Sub

    Private Sub txtact3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact3.Enter
        If txtact3.Text = "XXXX" Then
            txtact3.Text = ""
        End If
    End Sub

    Private Sub txtact3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact3.Leave
        If txtact3.Text = "" Then
            txtact3.Text = "XXXX"
        End If
    End Sub

    Private Sub txtact3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact3.TextChanged

        If single_double_quote(txtact3.Text) = False Then
            txtact3.Text = ""
        End If

        If txtact3.Text.Length = 4 Then
            txtact3.Text = txtact3.Text.ToUpper()
            txtact4.Select()
        End If
    End Sub

    Private Sub txtact4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact4.Enter
        If txtact4.Text = "XXXX" Then
            txtact4.Text = ""
        End If
    End Sub

    Private Sub txtact4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact4.Leave
        If txtact4.Text = "" Then
            txtact4.Text = "XXXX"
        End If
    End Sub

    Private Sub txtact4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact4.TextChanged

        If single_double_quote(txtact4.Text) = False Then
            txtact4.Text = ""
        End If

        If txtact4.Text.Length = 4 Then
            txtact4.Text = txtact4.Text.ToUpper()
            txtact5.Select()
        End If
    End Sub

    Private Sub txtact5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact5.Enter
        If txtact5.Text = "XXXX" Then
            txtact5.Text = ""
        End If
    End Sub

    Private Sub txtact5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact5.Leave
        If txtact5.Text = "" Then
            txtact5.Text = "XXXX"
        End If
    End Sub

    Private Sub txtact5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtact5.TextChanged

        If single_double_quote(txtact5.Text) = False Then
            txtact5.Text = ""
        End If

        If txtact5.Text.Length = 4 Then
            txtact5.Text = txtact5.Text.ToUpper()
            btnactivate.Select()
        End If
    End Sub

    Private Sub clear_text()
        txtact1.Text = ""
        txtact2.Text = ""
        txtact3.Text = ""
        txtact4.Text = ""
        txtact5.Text = ""
    End Sub

    Private Sub btnactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactivate.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        'key Checker
        Dim key As String

        key = Encrypt(txtact1.Text + txtact2.Text + txtact3.Text + txtact4.Text + txtact5.Text)

        Dim search As New SqlDataAdapter("select * from tblactivation where prodkey='" & key & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            Dim id As Integer = table.Rows(0)(0)
            Dim used As Boolean = table.Rows(0)(1)
            Dim trial As Boolean = table.Rows(0)(4)
            Dim timetrial As String = table.Rows(0)(5)



            If used = False Then
                Dim update As New SqlDataAdapter("update tblactivation set activated='" & True & "',computer='" & System.Environment.MachineName & "'where id ='" & id & "'", connection)
                Dim updatetable As New DataTable
                update.Fill(updatetable)


                If trial = True Then

                    'make a notification for time left

                    If timetrial = "00:00:00" Then
                        MsgBox("Your Product key has expired, Please contact us to Purchase Our Product Thanks!", vbInformation)
                    Else
                        MsgBox("Your System Has Been Timed Activated! Thanks For Purchasing!", vbInformation)
                        clear_text()

                        pnlactivation.Visible = False
                        tmloading.Start()
                    End If

                Else
                    MsgBox("Your System Has Been Activated! Thanks For Purchasing!", vbInformation)
                    clear_text()

                    pnlactivation.Visible = False
                    tmloading.Start()
                End If


            Else
                Dim check As New SqlDataAdapter("select * from tblactivation where computer='" & System.Environment.MachineName & "'", connection)
                Dim tablecheck As New DataTable
                check.Fill(tablecheck)

                If tablecheck.Rows.Count > 0 Then
                    MsgBox("Key Is Already Been Used!", vbInformation)
                    clear_text()
                End If

            End If
        Else
            MsgBox("Wrong Key!", vbCritical)
            clear_text()
            txtact1.Select()
        End If
    End Sub

    
    Private Sub btnbuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuy.Click
        'Dim path As String = "C:\Users\Raquel Pancho\Desktop\Mytext.txt"

        'Dim createtxt As String = "Hello BOi!"

        'File.WriteAllText(path, createtxt)
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Application.Exit()
    End Sub

End Class