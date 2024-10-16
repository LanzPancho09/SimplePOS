Imports System.Data.SqlClient
Public Class Removeitem
    Dim ctr As Integer
    Dim command As SqlCommand
    Private Sub btnrlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrlock.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If txtremovelock.Text.Contains("""") Or txtremovelock.Text.Contains("'") Then
            MsgBox("Single And Double Quotes Are Prohibited!", vbCritical)
            txtremovelock.Text = ""
        Else
            Dim search As New SqlDataAdapter("select * from tblacc where username='" & Form2.lblusername.Text & "'and password='" & txtremovelock.Text & "'", connection)
            Dim table As New DataTable
            search.Fill(table)
            Dim accesstype As Integer

            If table.Rows.Count > 0 Then
                accesstype = table.Rows(0)(6)

                If accesstype = 0 Then
                    GunaElipsePanel2.Visible = True
                    txtremovelock.Text = ""
                Else
                    Dim username, password As String
                    Dim result As MsgBoxResult

                    result = MsgBox("You Are not An Administrator, Please Enter Valid Administrator Account!", vbYesNo)

                    If result = MsgBoxResult.Yes Then
                        Me.TopMost = False
                        username = InputBox("Enter Your Username", "Administrator Access")
                        password = InputBox("Enter Your Password", "Administrator Access")

                        Dim validate As New SqlDataAdapter("select * from tblacc where username='" & username & "'and password='" & password & "'", connection)
                        Dim valtable As New DataTable
                        validate.Fill(valtable)

                        If valtable.Rows.Count > 0 Then
                            GunaElipsePanel2.Visible = True
                            txtremovelock.Text = ""
                        Else
                            MsgBox("Wrong Password!", vbCritical)
                            txtremovelock.Text = ""
                            Me.TopMost = True
                        End If

                    End If


                End If
            Else
                MsgBox("Wrong Password!", vbCritical)
                txtremovelock.Text = ""
                txtremovelock.Select()
            End If


        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        If Form2.cbscan.Checked = True Then
            Form2.txtitemcode.Select()
        Else
            Form2.txtprodn.Select()
        End If

        Me.Close()
        shadowback.Close()
        Form2.Show()

    End Sub

    Private Sub Removeitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GunaElipsePanel2.Visible = False
    End Sub

    Private Sub txtremoveid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtremoveid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnremoveid.PerformClick()
        End If
    End Sub

    Private Sub btnremoveid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremoveid.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If txtremoveid.Text.Contains("""") Or txtremoveid.Text.Contains("'") Then
            MsgBox("Single And Double Quotes Are Prohibited!", vbCritical)
            txtremoveid.Text = ""
        Else
            Dim updstock As Integer
            Dim search As New SqlDataAdapter("select * from tblcart where itemid='" & txtremoveid.Text & "'", connection)
            Dim tbl As New DataTable
            search.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                Dim find As New SqlDataAdapter("select * from tblinventory where itemid='" & txtremoveid.Text & "'", connection)
                Dim tblfind As New DataTable
                find.Fill(tblfind)

                If tblfind.Rows.Count > 0 Then
                    updstock = Val(tblfind.Rows(0)(5)) + Val(tbl.Rows(0)(4))

                    Dim update As New SqlDataAdapter("update tblinventory set stock='" & updstock & "'where itemid='" & txtremoveid.Text & "'", connection)
                    Dim updtable As New DataTable
                    update.Fill(updtable)

                    Dim delete As New SqlDataAdapter("delete from tblcart where itemid='" & txtremoveid.Text & "'", connection)
                    Dim table As New DataTable
                    delete.Fill(table)

                    Dim reader As SqlDataReader
                    Form2.flowlayoutPOS.Controls.Clear()
                    Try
                        command = New SqlCommand("select * from tblcart", connection)
                        reader = command.ExecuteReader
                        Form2.lbltotal.Text = "0"
                        While reader.Read
                            Dim datapanel As Datapanel1
                            datapanel = New Datapanel1

                            ctr = ctr + 1
                            If ctr = 1 Then
                                With datapanel
                                    .BackColor = Color.GhostWhite
                                    .lblpcode.Text = reader.GetString(1)
                                    .lblprodn.Text = reader.GetString(2)
                                    .lblquantity.Text = reader.GetString(4)
                                    .lblprice.Text = reader.GetString(5)
                                End With
                            Else
                                With datapanel
                                    .BackColor = Color.White
                                    .lblpcode.Text = reader.GetString(1)
                                    .lblprodn.Text = reader.GetString(2)
                                    .lblquantity.Text = reader.GetString(4)
                                    .lblprice.Text = reader.GetString(5)
                                End With
                                ctr = 0
                            End If
                            Form2.flowlayoutPOS.Controls.Add(datapanel)

                            Dim sale As Double = RTrim(Val(reader.GetString(5)))
                            Dim total As Double
                            total = sale + total

                            If total = Int(total) Then
                                Form2.lbltotal.Text = total & ".00"
                            Else
                                Form2.lbltotal.Text = total
                            End If

                        End While

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MsgBox("Item Id Is Invalid!", vbInformation)
            End If



            txtremoveid.Text = ""

            If Form2.cbscan.Checked = True Then
                Form2.txtitemcode.Select()
            Else
                Form2.txtprodn.Select()
            End If

            Me.Close()
            shadowback.Close()
            Form2.Show()

            End If


    End Sub

    Private Sub txtremovelock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtremovelock.KeyPress


        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnrlock.PerformClick()
            txtremoveid.Select()
        End If

        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            btncancel.PerformClick()
        End If
    End Sub


End Class