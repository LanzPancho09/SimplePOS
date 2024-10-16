Imports System.Data.SqlClient
Imports System.IO
Public Class Accountdata
    Dim ctr As Integer

    'sql
    Dim command As SqlCommand
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader

        connection.Open()
        Dim delete As New SqlDataAdapter("delete from tblacc where accid='" & Val(lblaccid.Text) & "'", connection)
        Dim ref As New DataTable
        delete.Fill(ref)

        Dim save As New SqlCommand("insert into tblacclog" & "(username,action,date)values(@username,@action,@date)", connection)
        save.Parameters.Add(New SqlParameter("@username", SqlDbType.NVarChar)).Value = lblAccType.Text
        save.Parameters.Add(New SqlParameter("@action", SqlDbType.NVarChar)).Value = "Delete"
        save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
        save.ExecuteNonQuery()

        'refresh
        Form2.flowlayoutACC.Controls.Clear()

        Try
            command = New SqlCommand("Select * from tblacc", connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim accdata As Accountdata
                accdata = New Accountdata
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
                        .pnlbtn.Visible = True
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
                        .pnlbtn.Visible = True
                        .BackColor = Color.GhostWhite
                        ctr = 0
                    End With

                End If

                Form2.flowlayoutACC.Controls.Add(accdata)
            End While
            ctr = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If Form2.flowlayoutACC.Controls.Count = 1 Then
            Form2.flowlayoutACC.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("Select * from tblacc", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim accdata As Accountdata
                    accdata = New Accountdata
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
                            .pnlbtn.Visible = False
                            .BackColor = Color.White
                            .btndelete.Visible = False
                            .btnedit.Visible = False
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
                            .pnlbtn.Visible = False
                            .btndelete.Visible = False
                            .btnedit.Visible = False
                            ctr = 0
                        End With

                    End If

                    Form2.flowlayoutACC.Controls.Add(accdata)
                End While
                ctr = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Createaccount.lblconfirmp.Visible = False
        Createaccount.txtconfirmp.Visible = False
        Createaccount.lblaccesstype.Location = New System.Drawing.Point(113, 502)
        Createaccount.cbaccesstype.Location = New System.Drawing.Point(21, 522)
        Createaccount.pnledit.Visible = True
        Createaccount.lblcreate.Text = "Edit Account"
        Createaccount.cbpassc.Visible = False
        Createaccount.cbcheck.Visible = False

        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Try
            Dim search As New SqlDataAdapter("select * from tblacc where accid='" & RTrim(lblaccid.Text) & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                Dim str As String
                str = RTrim(table.Rows(0)(0))

                Dim byt() As Byte
                byt = table.Rows(0)(1)
                Dim img As New MemoryStream(byt)

                'set properties to create account form
                Createaccount.txtaccid.Text = str
                Createaccount.pbprofile.Image = Image.FromStream(img)
                Createaccount.txtname.Text = lblAccType.Text
                Createaccount.txtusername.Text = lblName.Text
                Createaccount.txtpassword.Text = lblUsername.Text
                Createaccount.cbaccesstype.Text = lblPassword.Text
                Createaccount.cbind.Checked = True
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

        Createaccount.Show()
        shadowback.Show()
        Createaccount.TopMost = True
    End Sub


    Private Sub Accountdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblAccType.AutoEllipsis = True
    End Sub

    Private Sub lblacctype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPassword.Click

    End Sub
End Class
