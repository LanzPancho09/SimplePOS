Imports System.Data.SqlClient
Public Class timenotif
    Dim h, m, s As Integer

    Function savetime(ByVal time As String)
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim check As New SqlDataAdapter("select * from tblactivation where activated='" & True & "' and computer='" & System.Environment.MachineName & "'", connection)
        Dim table As New DataTable
        check.Fill(table)

        If table.Rows.Count > 0 Then
            Dim id As Integer = table.Rows(0)(0)

            Dim update As New SqlDataAdapter("update tblactivation set time='" & time & "'where id ='" & id & "'", connection)
            Dim updatetable As New DataTable
            update.Fill(updatetable)
        End If


    End Function

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        shadowback.Hide()
        Me.Hide()
    End Sub

    Private Sub timenotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim check As New SqlDataAdapter("select * from tblactivation where activated='" & True & "' and computer='" & System.Environment.MachineName & "'", connection)
        Dim table As New DataTable
        check.Fill(table)

        If table.Rows.Count > 0 Then
            Dim timeleft As String = table.Rows(0)(5)

            Dim values() As String = timeleft.Split(New Char() {":"c})

            Dim timevalue As New List(Of String)

            For Each value As String In values
                timevalue.Add(value)
            Next

            h = Convert.ToInt32(timevalue(0))
            m = Convert.ToInt32(timevalue(1))
            s = Convert.ToInt32(timevalue(2))

            lblhour.Text = h.ToString("00")
            lblmin.Text = m.ToString("00")
            lblsec.Text = s.ToString("00")

            Timer1.Start()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If s = 0 Then

            If m = 0 Then

                If h = 0 Then
                    h = 0
                Else
                    h -= 1
                    m += 59
                    s += 59

                End If

            Else
                m -= 1
                s += 59
            End If

        Else
            s -= 1
        End If

        Dim tm As String = h.ToString("00") & ":" & m.ToString("00") & ":" & s.ToString("00")

        If h = 0 And m = 0 And s = 0 Then
            lblhour.Text = h.ToString("00")
            lblmin.Text = m.ToString("00")
            lblsec.Text = s.ToString("00")
            savetime(tm)

            Timer1.Stop()
            MsgBox("Your Product key has Expired! Please Contact Us to Buy the Full Application.", vbOK)
            Application.Exit()
        Else

            If h = 0 And m = 5 And s = 0 Then
                shadowback.Show()
                Me.Show()
            End If

            lblhour.Text = h.ToString("00")
            lblmin.Text = m.ToString("00")
            lblsec.Text = s.ToString("00")
            savetime(tm)
        End If



    End Sub
End Class