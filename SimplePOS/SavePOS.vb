Imports System.Data.SqlClient
Imports System.Globalization
Public Class SavePOS
    Dim gen, ctr, discounts, total, change As Integer
    Dim command As SqlCommand
    Dim ind As Boolean = False
    Dim discountused As Boolean = False

    Function isvalid(ByVal input As String) As Boolean
        For i = 0 To input.Length - 1

            If Char.IsLetter(input.Chars(i)) Then
                Return False
            End If

            If Not Char.IsLetter(input.Chars(i)) And Not Char.IsDigit(input.Chars(i)) Then
                Return False
            End If

        Next
        Return True
    End Function

    Private Sub txtpayment_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayment.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnback.PerformClick()
        End If

    End Sub



    Private Sub btnpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpay.Click
        Dim totaldiscount As Double

        If isvalid(txtpayment.Text) = True Then

            txtpayment.FocusedBorderColor = Color.FromArgb(0, 0, 0)

            Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
            connection.Open()
            Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
            connect.Open()

            If Val(txtpayment.Text) < Val(lbltotal.Text) Then
                MsgBox("Insufficient Cash!", vbCritical)
                txtpayment.Select()
                txtpayment.Text = ""
            Else
                Dim rows, solve As Integer
                Dim reader As SqlDataReader

                'translating string to type double
                Dim subtotal, change, disc, comp As Double
                Dim stotal, schange, sdisc As String

                stotal = lbltotal.Text
                schange = lblchange.Text
                sdisc = lbldiscount.Text
                subtotal = stotal.Replace(",", String.Empty)
                change = schange.Replace(",", String.Empty)
                disc = sdisc.Replace(",", String.Empty)
                comp = disc * -1

                Dim save As New SqlCommand("insert into tbltrans" & "(transid,cosid,date,time,subtotal,disc,pay,change,cashier,dt) values (@transid,@cosid,@date,@time,@subtotal,@disc,@pay,@change,@cashier,@dt)", connection)
                'save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NChar)).Value = Form2.lbltransid.Text
                'save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = Form2.lblcosid.Text
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = Format(Today, "dddd, dd MMMM yyyy")
                save.Parameters.Add(New SqlParameter("@time", SqlDbType.NVarChar)).Value = Format(TimeOfDay, "hh:mm tt")
                save.Parameters.Add(New SqlParameter("@subtotal", SqlDbType.NVarChar)).Value = subtotal
                save.Parameters.Add(New SqlParameter("@disc", SqlDbType.NVarChar)).Value = comp
                save.Parameters.Add(New SqlParameter("@pay", SqlDbType.NVarChar)).Value = txtpayment.Text
                save.Parameters.Add(New SqlParameter("@change", SqlDbType.NVarChar)).Value = change
                save.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NVarChar)).Value = Form2.lbluser.Text
                save.Parameters.Add(New SqlParameter("@dt", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
                save.ExecuteNonQuery()

                totaldiscount = Val(lbldiscount.Text) * -1


                Try
                    command = New SqlCommand("select * from tblcart", connection)
                    reader = command.ExecuteReader
                    While reader.Read
                        Dim search As New SqlDataAdapter("select * from tblreport where itemid='" & RTrim(reader.GetString(1)) & "'", connect)
                        Dim table As New DataTable
                        search.Fill(table)

                        If table.Rows.Count > 0 Then
                            Dim quan As Integer
                            Dim price As Double

                            quan = Val(table.Rows(0)(2)) + Val(reader.GetString(4))
                            price = Val(table.Rows(0)(3)) + Val(reader.GetString(5))

                            Dim update As New SqlDataAdapter("update tblreport set quan='" & quan & "',earnings='" & price & "'where itemid='" & table.Rows(0)(0) & "'", connect)
                            Dim updtable As New DataTable
                            update.Fill(updtable)
                        Else

                            If ind = False Then
                                Dim ad As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount) values (@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connect)
                                ad.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                                ad.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                                ad.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
                                ad.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(5)
                                'ad.Parameters.Add(New SqlParameter("@transid", SqlDbType.NChar)).Value = Form2.lbltransid.Text
                                ad.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NChar)).Value = Form2.lbluser.Text
                                ad.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = txtpayment.Text
                                ad.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = lblchange.Text
                                ad.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
                                ad.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
                                'ad.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NVarChar)).Value = Form2.lblcosid.Text
                                ad.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = totaldiscount
                                ad.ExecuteNonQuery()


                                ind = True
                            Else
                                Dim ad As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount) values (@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connect)
                                ad.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                                ad.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NChar)).Value = reader.GetString(2)
                                ad.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
                                ad.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(5)
                                'ad.Parameters.Add(New SqlParameter("@transid", SqlDbType.NChar)).Value = Form2.lbltransid.Text
                                ad.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NChar)).Value = Form2.lbluser.Text
                                ad.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = "0"
                                ad.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = "0"
                                ad.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
                                ad.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
                                'ad.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NVarChar)).Value = Form2.lblcosid.Text
                                ad.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = totaldiscount
                                ad.ExecuteNonQuery()

                            End If


                        End If
                    End While

                    CartReport.Show()
                    shadowback.Show()
                    CartReport.TopMost = True

                    Dim delte As New SqlDataAdapter("delete from tblreport where row='" & 0 & "'", connect)
                    Dim tabled As New DataTable
                    delte.Fill(tabled)

                    connect.Close()
                    connection.Close()
                Catch ex As Exception
                    MsgBox("Error 404" & " " & ex.Message)
                End Try


                Dim read As New SqlDataAdapter("select * from tblcart", connection)
                Dim tableread As New DataTable
                read.Fill(tableread)

                rows = tableread.Rows.Count


                connection.Open()
                Try
                    gen = 1
                    While gen > 0
                        'ayusin mo yung adding data to tblsales
                        Dim search As New SqlDataAdapter("select * from tblcart where row='" & gen & "'", connection)
                        Dim table As New DataTable
                        search.Fill(table)

                        If table.Rows.Count > 0 Then
                            Dim inventory As New SqlDataAdapter("select * from tblinventory where itemid='" & table.Rows(0)(1) & "'", connection)
                            Dim tableinv As New DataTable
                            inventory.Fill(tableinv)

                            Dim add As New SqlCommand("insert into tblsales" & "(cosid,itemid,prodn,cat,itemsold,stock,earnings,date,month) values (@cosid,@itemid,@prodn,@cat,@itemsold,@stock,@earnings,@date,@month)", connection)
                            add.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = table.Rows(0)(0)
                            add.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = table.Rows(0)(1)
                            add.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = table.Rows(0)(2)
                            add.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = table.Rows(0)(3)
                            add.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = table.Rows(0)(4)
                            add.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = tableinv.Rows(0)(5)
                            add.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = table.Rows(0)(5)
                            add.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = TimeOfDay & " " & Format(Today, "dddd, dd MMMM yyyy")
                            add.Parameters.Add(New SqlParameter("@month", SqlDbType.NVarChar)).Value = Format(Today, "dd MMMM yyyy")
                            add.ExecuteNonQuery()

                            Dim chart As New SqlCommand("insert into tblchart" & "(no,exp,date) values (@no,@exp,@date)", connection)
                            chart.Parameters.Add(New SqlParameter("@no", SqlDbType.NVarChar)).Value = "profit"
                            chart.Parameters.Add(New SqlParameter("@exp", SqlDbType.NChar)).Value = table.Rows(0)(5)
                            chart.Parameters.Add(New SqlParameter("@date", SqlDbType.NChar)).Value = TimeOfDay & " " & Format(Today, "dddd, dd MMMM yyyy")
                            chart.ExecuteNonQuery()

                            Dim delete As New SqlDataAdapter("delete from tblcart where row='" & gen & "'", connection)
                            Dim deltable As New DataTable
                            delete.Fill(table)

                            solve = solve + 1

                            If solve = rows Then
                                gen = 0
                            Else
                                gen = gen + 1
                            End If
                        Else

                            If solve = rows Then
                                gen = 0
                            Else
                                gen = gen + 1
                            End If

                        End If
                    End While

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                connection.Close()
                connection.Open()


                'cart clearer
                Form2.flowlayoutPOS.Controls.Clear()
                Try
                    command = New SqlCommand("select * from tblcart", connection)
                    reader = command.ExecuteReader
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
                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'sales refrsh
                Form2.flowlayoutSALES.Controls.Clear()
                Try
                    connection.Open()
                    command = New SqlCommand("select * from tblsales", connection)
                    reader = command.ExecuteReader
                    Dim constat As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
                    constat.Open()

                    Dim delete As New SqlDataAdapter("delete from tblsummary where row='" & 0 & "'", constat)
                    Dim deletetable As New DataTable
                    delete.Fill(deletetable)

                    While reader.Read
                        Dim find As New SqlDataAdapter("select * from tblinventory where itemid='" & reader.GetString(1) & "'", constat)
                        Dim tablefind As New DataTable
                        find.Fill(tablefind)

                        Dim search As New SqlDataAdapter("select * from tblsummary where itemid='" & reader.GetString(1) & "'", constat)
                        Dim table As New DataTable
                        search.Fill(table)

                        If table.Rows.Count > 0 Then

                            Dim itemsold, stock As Integer
                            Dim earnings As Double

                            itemsold = Val(table.Rows(0)(3)) + reader.GetString(4)
                            stock = tablefind.Rows(0)(5)
                            earnings = Val(table.Rows(0)(5)) + reader.GetString(6)



                            Dim update As New SqlDataAdapter("update tblsummary set itemsold='" & itemsold & "',stockleft='" & stock & "',earnings='" & earnings & "'where itemid='" & reader.GetString(1) & "'", constat)
                            Dim tableupd As New DataTable
                            update.Fill(tableupd)

                        Else

                            Dim saves As New SqlCommand("insert into tblsummary" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row)", constat)
                            saves.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                            saves.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                            saves.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                            saves.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                            saves.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
                            saves.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                            saves.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
                            saves.ExecuteNonQuery()
                        End If

                    End While
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Form2.flowlayoutSALES.Controls.Clear()
                Try
                    connection.Open()
                    command = New SqlCommand("select * from tblsummary", connection)
                    reader = command.ExecuteReader
                    While reader.Read
                        Dim saledata As Salesdata
                        saledata = New Salesdata

                        ctr = ctr + 1
                        If ctr = 1 Then
                            With saledata
                                .lblitemid.Text = reader.GetString(0)
                                .lblproductn.Text = reader.GetString(1)
                                .lblcategory.Text = reader.GetString(2)
                                .lblsold.Text = reader.GetString(3)
                                .lblstockleft.Text = reader.GetString(4)
                                .lblearnings.Text = reader.GetString(5)
                                .BackColor = Color.GhostWhite
                            End With
                        Else
                            With saledata
                                .lblitemid.Text = reader.GetString(0)
                                .lblproductn.Text = reader.GetString(1)
                                .lblcategory.Text = reader.GetString(2)
                                .lblsold.Text = reader.GetString(3)
                                .lblstockleft.Text = reader.GetString(4)
                                .lblearnings.Text = reader.GetString(5)
                                .BackColor = Color.White
                            End With
                            ctr = 0
                        End If
                        Form2.flowlayoutSALES.Controls.Add(saledata)
                    End While

                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Form2.lbltotal.Text = "0.00"

                Dim pay As Integer
                pay = txtpayment.Text
                txtpayment.Text = pay.ToString("N")
                txtpayment.Select()

                txtpayment.Enabled = False
                pnlpay.Visible = False

                Form2.btnPOS.PerformClick()
                btnundo.Visible = False
            End If
        Else
            txtpayment.FocusedBorderColor = Color.FromArgb(201, 0, 0)
            MsgBox("Invalid Value", vbInformation)
        End If



    End Sub

    Private Sub txtpayment_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayment.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnpay.PerformClick()
        End If

        If e.KeyChar = "d" Then
            btndiscount.PerformClick()
        End If
    End Sub


    Private Sub SavePOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 50, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)



        Dim stotal As String
        stotal = Form2.lbltotal.Text

        total = stotal.Replace(",", String.Empty)
        lbltotal.Text = Form2.lbltotal.Text
    End Sub

    Private Sub btnundo_Click(sender As Object, e As EventArgs) Handles btnundo.Click
        Dim discount, total As Double

        If Val(lbldiscount.Text) < 0 Then
            discount = Val(lbldiscount.Text) * -1

            total = Val(lbltotal.Text) + discount

            lbldiscount.Text = "0.00"
            lbltotal.Text = total

            btndiscount.Enabled = True
            btnundo.Visible = False

        End If
    End Sub

    Private Sub btnback_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If Form2.cbscan.Checked = True Then
            Form2.txtitemcode.Select()
        Else
            Form2.txtprodn.Select()
        End If

        Me.Close()
        shadowback.Close()
        Form2.Show()
    End Sub

    Private Sub btndiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiscount.Click
        Me.Close()
        Discount.Show()
        Discount.TopMost = True

        Discount.txtrate.Select()
    End Sub

    Private Sub txtpayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayment.TextChanged

        If isvalid(txtpayment.Text) = True Then
            txtpayment.FocusedBorderColor = Color.FromArgb(0, 0, 0)
            Dim change, finalprice As Double
            Dim subtotal As String
            subtotal = lbltotal.Text
            finalprice = subtotal.Replace(",", String.Empty)

            If txtpayment.Text = "" Then
                lblchange.Text = "0.00"
            Else
                Dim payment As Double
                Dim total As String
                total = txtpayment.Text
                payment = total.Replace(",", String.Empty)

                change = payment - finalprice
            End If



            If change = Int(change) Then
                lblchange.Text = change.ToString("N")
            Else
                lblchange.Text = change.ToString("N", CultureInfo.InvariantCulture)
            End If
        Else
            txtpayment.FocusedBorderColor = Color.FromArgb(201, 0, 0)
        End If



    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        If Form2.cbscan.Checked = True Then
            Form2.txtitemcode.Select()
        Else
            Form2.txtprodn.Select()
        End If

        Me.Close()
        shadowback.Close()
        Form2.Show()
    End Sub
End Class