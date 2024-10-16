Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization

Public Class Form2
    Dim ctr, gen, drop, point, btn, rows, log, salesrind As Integer
    Dim bool As Boolean = True
    Dim mult As Boolean = False
    Dim scan As Boolean = False
    Dim edit As Boolean = False
    Dim ofs As Boolean = False
    Dim defect As Boolean = False
    Dim exp As Boolean = False
    Dim btns As Boolean = False

    Private Function SQLConnect() As SqlConnection
        Dim connection As New SqlConnection("Data Source=DESKTOP-J94MAMS\SQLEXPRESS;Initial Catalog=SMPOS;User ID=sa;Password=1234")

        Try
            connection.Open()
            Console.WriteLine("Connection Succeeded! SQL Connection")
            Return connection
        Catch ex As Exception
            Console.WriteLine("Connection Error! SQL Connection")
            Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
            Return Nothing
        End Try

    End Function


    Dim command As SqlCommand
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


    Private Sub accrefresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        'account data refresh
        flowlayoutACC.Controls.Clear()
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

                flowlayoutACC.Controls.Add(accdata)
            End While
            ctr = 0
            connection.Close()
        Catch ex As Exception
            MsgBox("Error 101" & ex.Message)
        End Try

        If flowlayoutACC.Controls.Count = 1 Then
            flowlayoutACC.Controls.Clear()
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
                            .BackColor = Color.White
                            .pnlbtn.Visible = False
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

                    flowlayoutACC.Controls.Add(accdata)
                End While
                ctr = 0
                connection.Close()
            Catch ex As Exception
                MsgBox("Error 102" & ex.Message)
            End Try
        End If


        gen = 0
        ctr = 0
    End Sub

    Private Sub trans_cosid_gen()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim randomnum As New Random

        gen = 1
        While gen > 0
            Dim TrasID As Integer = randomnum.Next(0, 100000000)

            Dim search As New SqlDataAdapter("select * from tbltrans where transid='" & TrasID & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                gen = gen + 1
            Else
                'lbltransid.Text = TrasID
                gen = 0
            End If
        End While

        gen = 1
        While gen > 0
            Dim search As New SqlDataAdapter("select * from tbltrans where cosid='" & gen & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                gen = gen + 1
            Else
                'lblcosid.Text = gen
                gen = 0
            End If
        End While
    End Sub

    'inventory + inentory generator
    Private Sub inventory_refresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        flowlayoutinv.Controls.Clear()
        Try
            command = New SqlCommand("select * from tblinventory", connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim inv As InvDatapanel
                inv = New InvDatapanel
                Dim price As Double = reader.GetString(6)
                inv.Margin = New Padding(0)

                If reader.GetString(5) = 0 Then

                    With inv
                        .lblitemid.Text = reader.GetString(1)
                        .lblproductn.Text = reader.GetString(2)
                        .lblcat.Text = reader.GetString(3)
                        .lblstock.Text = reader.GetString(5)

                        If price = Int(price) Then
                            .lblprice.Text = price.ToString("N")
                        Else
                            .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
                        .pnlbutton.Visible = False
                        .lblitemid.ForeColor = Color.White
                        .lblproductn.ForeColor = Color.White
                        .lblcat.ForeColor = Color.White
                        .lblstock.ForeColor = Color.White
                        .lblprice.ForeColor = Color.White
                    End With
                Else
                    ctr = ctr + 1
                    If ctr = 1 Then

                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)

                            If price = Int(price) Then
                                .lblprice.Text = price.ToString("N")
                            Else
                                .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
                            End If

                            .BackColor = Color.White
                            .pnlbutton.Visible = False
                        End With
                    Else
                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)

                            If price = Int(price) Then
                                .lblprice.Text = price.ToString("N")
                            Else
                                .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
                            End If

                            .BackColor = Color.GhostWhite
                            .pnlbutton.Visible = False
                            ctr = 0
                        End With
                    End If
                End If
                flowlayoutinv.Controls.Add(inv)
            End While
            ctr = 0
            connection.Close()
        Catch ex As Exception
            MsgBox("Error 103" & ex.Message)
        End Try

    End Sub

    Private Sub Inventory_generator()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        'inventory generator
        gen = 1
        While gen > 0
            Dim invid As New SqlDataAdapter("select * from tblinventory where invid='" & gen & "'", connection)
            Dim invtb As New DataTable
            invid.Fill(invtb)

            If invtb.Rows.Count > 0 Then
                gen = gen + 1
            Else
                'lblinvid.Text = gen
                gen = 0
            End If
        End While
        gen = 0


    End Sub

    Private Sub itemidgen()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        ' itemid generator
        gen = 1
        While gen > 0
            Dim itemid As New SqlDataAdapter("select * from tblinventory where itemid='" & gen & "'", connection)
            Dim table As New DataTable
            itemid.Fill(table)

            If table.Rows.Count > 0 Then
                gen = gen + 1
            Else
                'txtitemid.Text = gen
                gen = 0
            End If

        End While
    End Sub

    Private Sub category_refresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        'flowlayoutCAT.Controls.Clear()
        Try
            command = New SqlCommand("select * from tblcat", connection)
            reader = command.ExecuteReader
            While reader.Read

                'If Not cbcategory.Items.Contains(reader.GetString(1)) Then
                '    cbcategory.Items.Add(reader.GetString(1))
                'End If

                Dim cats As categorydata
                cats = New categorydata
                ctr = ctr + 1
                cats.Margin = New Padding(0)

                If ctr = 1 Then
                    With cats
                        .lblno.Text = reader.GetString(0)
                        .lblcat.Text = reader.GetString(1)
                        .BackColor = Color.GhostWhite
                    End With

                Else
                    With cats
                        .lblno.Text = reader.GetString(0)
                        .lblcat.Text = reader.GetString(1)
                        .BackColor = Color.GhostWhite
                    End With
                End If
                'flowlayoutCAT.Controls.Add(cats)
            End While
            ctr = 0
            connection.Close()
        Catch ex As Exception
            MsgBox("Error 104" & ex.Message)
        End Try
    End Sub

    Private Sub Sales_refresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        'compress same values
        flowlayoutSALES.Controls.Clear()
        Try
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

                If tablefind.Rows.Count > 0 Then
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
                        Dim save As New SqlCommand("insert into tblsummary" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row)", constat)
                        save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                        save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                        save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)


                        save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                        save.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
                        save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                        save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
                        save.ExecuteNonQuery()
                    End If
                End If

            End While
            connection.Close()
        Catch ex As Exception
            MsgBox("Error 105" & ex.Message)
        End Try

        'display values on panels
        flowlayoutSALES.Controls.Clear()
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
                flowlayoutSALES.Controls.Add(saledata)

                'sum of earnings
                Dim profit As Double = reader.GetString(5)
                lblprofit.Text = Val(lblprofit.Text) + profit
            End While

            connection.Close()
        Catch ex As Exception
            MsgBox("Error 106" & ex.Message)
        End Try
    End Sub
    Private Sub sum_expenses()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Try
            command = New SqlCommand("select * from tblexpenses", connection)
            reader = command.ExecuteReader
            lblprofitloss.Text = "0"
            While reader.Read

                'sum of expenses
                Dim less As Double = reader.GetString(2)
                lblprofitloss.Text = Val(lblprofitloss.Text) + less

                Dim exp As Double = lblprofitloss.Text

                If exp = Int(exp) Then
                    lblprofitloss.Text = exp.ToString("N")
                Else
                    lblprofitloss.Text = exp.ToString("N", CultureInfo.InvariantCulture)
                End If

            End While
            ctr = 0
        Catch ex As Exception
            MsgBox("Error 107" & ex.Message)
        End Try
    End Sub

    Private Sub transaction_refresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        command = New SqlCommand("select * from tbltrans", connection)
        reader = command.ExecuteReader

        flowlayoutTRANS.Controls.Clear()
        While reader.Read
            Dim trans As Transdata

            trans = New Transdata
            trans.Margin = New Padding(0)

            ctr = ctr + 1

            If ctr = 1 Then
                With trans
                    Dim price As Double

                    .BackColor = Color.GhostWhite
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)


                    price = reader.GetString(4)
                    If price = Int(price) Then
                        .lblsubtotal.Text = price.ToString("N")
                    Else
                        .lblsubtotal.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(5)
                    If price = Int(price) Then
                        .lbldiscount.Text = price.ToString("N")
                    Else
                        .lbldiscount.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    .lblchange.Text = reader.GetString(7)
                    price = reader.GetString(7)
                    If price = Int(price) Then
                        .lblchange.Text = price.ToString("N")
                    Else
                        .lblchange.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblpay.Text = price.ToString("N")
                    Else
                        .lblpay.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                End With
            Else
                With trans
                    Dim price As Double

                    .BackColor = Color.White
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)


                    price = reader.GetString(4)
                    If price = Int(price) Then
                        .lblsubtotal.Text = price.ToString("N")
                    Else
                        .lblsubtotal.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(5)
                    If price = Int(price) Then
                        .lbldiscount.Text = price.ToString("N")
                    Else
                        .lbldiscount.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    .lblchange.Text = reader.GetString(7)
                    price = reader.GetString(7)
                    If price = Int(price) Then
                        .lblchange.Text = price.ToString("N")
                    Else
                        .lblchange.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblpay.Text = price.ToString("N")
                    Else
                        .lblpay.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If
                End With
                ctr = 0
            End If

            flowlayoutTRANS.Controls.Add(trans)
        End While

        'Dim tran As New SqlDataAdapter("select * from tbltrans", connection)
        'Dim table As New DataTable
        'tran.Fill(table)
        'dvg1.DataSource = table

        'Dim cos As New SqlDataAdapter("select * from tblsales", connection)
        'Dim table2 As New DataTable
        'cos.Fill(table2)
        'dvg2.DataSource = table2


    End Sub

    Private Sub transaction_search(ByVal query As String)
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Transdata.query = query

        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader

        flowlayoutTRANS.Controls.Clear()
        While reader.Read
            Dim trans As Transdata
            trans = New Transdata
            trans.Margin = New Padding(0)
            ctr = ctr + 1

            If ctr = 1 Then
                With trans
                    Dim price As Double

                    .BackColor = Color.White
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)

                    price = reader.GetString(4)
                    If price = Int(price) Then
                        .lblsubtotal.Text = price.ToString("N")
                    Else
                        .lblsubtotal.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(5)
                    If price = Int(price) Then
                        .lbldiscount.Text = price.ToString("N")
                    Else
                        .lbldiscount.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    .lblchange.Text = reader.GetString(7)
                    price = reader.GetString(7)
                    If price = Int(price) Then
                        .lblchange.Text = price.ToString("N")
                    Else
                        .lblchange.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblpay.Text = price.ToString("N")
                    Else
                        .lblpay.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                End With
            Else
                With trans
                    Dim price As Double

                    .BackColor = Color.GhostWhite
                    .lbltransactionID.Text = reader.GetString(0)
                    .lblcashier.Text = reader.GetString(8)
                    .lblcosid.Text = reader.GetString(1)
                    .lbldate.Text = Format(CDate(reader.GetString(2)), "dd-MM-yyyy") & " " & reader.GetString(3)


                    price = reader.GetString(4)
                    If price = Int(price) Then
                        .lblsubtotal.Text = price.ToString("N")
                    Else
                        .lblsubtotal.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(5)
                    If price = Int(price) Then
                        .lbldiscount.Text = price.ToString("N")
                    Else
                        .lbldiscount.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    .lblchange.Text = reader.GetString(7)
                    price = reader.GetString(7)
                    If price = Int(price) Then
                        .lblchange.Text = price.ToString("N")
                    Else
                        .lblchange.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblpay.Text = price.ToString("N")
                    Else
                        .lblpay.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If
                End With
                ctr = 0
            End If

            flowlayoutTRANS.Controls.Add(trans)
        End While
    End Sub

    Private Sub Cashreport_refresh()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        command = New SqlCommand("select * from tbltrans", connection)
        reader = command.ExecuteReader()

        FlowlayoutCREPORT.Controls.Clear()
        While reader.Read
            Dim creport As Creportdata
            creport = New Creportdata

            ctr = ctr + 1

            If ctr = 1 Then
                With creport
                    .BackColor = Color.White
                    .lbldate.Text = reader.GetString(2) & " " & reader.GetString(3)
                    .lbltransid.Text = reader.GetString(0)
                    .lblcosid.Text = reader.GetString(1)
                    .lblcashier.Text = reader.GetString(8)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblearnings.Text = reader.GetString(4)
                End With
            Else
                With creport
                    .BackColor = Color.GhostWhite
                    .lbldate.Text = reader.GetString(2) & " " & reader.GetString(3)
                    .lbltransid.Text = reader.GetString(0)
                    .lblcosid.Text = reader.GetString(1)
                    .lblcashier.Text = reader.GetString(8)
                    .lbldiscount.Text = reader.GetString(5)
                    .lblearnings.Text = reader.GetString(4)
                End With
                ctr = 0
            End If

            FlowlayoutCREPORT.Controls.Add(creport)
        End While
    End Sub

    Private Sub Show_total()
        Dim sprof, sploss As String
        Dim profit, ploss As Double

        sprof = lblprofit.Text
        sploss = lblprofitloss.Text
        profit = sprof.Replace(",", String.Empty)
        ploss = sploss.Replace(",", String.Empty)

        lblovera.Text = Val(profit) - Val(ploss)

        Dim overall As Double = lblovera.Text

        If overall = Int(overall) Then
            lblovera.Text = overall.ToString("N")
        Else
            lblovera.Text = overall.ToString("N", CultureInfo.InvariantCulture)
        End If
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblexpenses' table. You can move, or remove it, as needed.
        'Me.TblexpensesTableAdapter.Fill(Me.SMPOSDataSet.tblexpenses)
        'TODO: This line of code loads data into the 'SMPOSDataSet.tblsales' table. You can move, or remove it, as needed.
        'Me.TblsalesTableAdapter.Fill(Me.SMPOSDataSet.tblsales)
        'TODO: This line of code loads data into the 'SMPOSDataSet.tbltrans' table. You can move, or remove it, as needed.
        'Me.TbltransTableAdapter.Fill(Me.SMPOSDataSet.tbltrans)

        Me.WindowState = FormWindowState.Maximized
        tmday.Start()

        RePositionTableLabelColumns()



        'sql reader
        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connection.Open()
        'Dim reader As SqlDataReader

        'shadows
        'Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 30, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad3, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlInvShadow, Color.Black, 15, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad13, Color.Black, 50, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad14, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnltrans, Color.Black, 40, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnltrans1, Color.Black, 40, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Pnltranshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlcosshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'panel transparency


        'auto ellipsis
        'lbluser.AutoEllipsis = True

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        GunaLabel1.Location = New Point((screenWidth / 2) - GunaLabel1.Size.Width / 2, (GunaPanel1.Size.Height / 2) - GunaLabel1.Size.Height / 2)

        'Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        'load panels
        'Try
        '    If connection.State = ConnectionState.Open = True Then
        '        pbdbase.Image = Image.FromFile("C:\Users\Lanz Pancho\Documents\Visual Studio Files (2010)\SimplePOS\SimplePOS\Resources\database_view_26px.png")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'accrefresh
        'accrefresh()

        'inventory data refresh and generator
        'inventory_refresh()

        'Transaction Id Genereator and Costumer Id Generator
        'trans_cosid_gen()

        'category data refresh
        'category_refresh()

        'sales refrsh
        'Sales_refresh()

        'calculate the sum of expenses
        'sum_expenses()

        'item id generator
        'itemidgen()

    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOS.Click

        'Transaction Id Genereator and Costumer Id Generator
        'trans_cosid_gen()

        TabControl.SelectedTab = tbpos
        pnlshadow.BackColor = Color.White
        txtprodn.Select()
    End Sub

    Private Sub btninventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninventory.Click
        'inventory_refresh()
        RepoINVHeaderLabels()
        TabControl.SelectedTab = tabinventory
        inventoryState = InventoryButtonState.None
        Me.btninvref.PerformClick()

        'pnlshadow.BackColor = System.Drawing.Color.FromArgb(248, 248, 248)
    End Sub

    Private Sub btnsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsales.Click
        TabControl.SelectedTab = tabsales

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow5, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow6, Color.Black, 30, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        RepoSalesHeaderLabels()

        'pnlshadow.BackColor = System.Drawing.Color.FromArgb(248, 248, 248)
        'btnsosales.PerformClick()
    End Sub

    Private Sub btnlogmanager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogmanager.Click
        TabControl.SelectedTab = tablog
        'pnlshadow.BackColor = System.Drawing.Color.FromArgb(248, 248, 248)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow9, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow10, Color.Black, 30, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'btninvlog.PerformClick()
    End Sub

    Function charcheck() As Boolean

        If checkstr(txtitemcode.Text, "letterspecial") = False Then
            Return False
        ElseIf checkstr(txtquantity.Text, "letterspecial") = False Then
            Return False
        Else
            Return True
        End If

    End Function
    Function specialquote() As Boolean

        If txtitemcode.Text.Contains("""") Or txtitemcode.Text.Contains("'") Then
            Return False
        ElseIf txtquantity.Text.Contains("""") Or txtquantity.Text.Contains("'") Then
            Return False
        ElseIf txtprodn.Text.Contains("""") Or txtprodn.Text.Contains("'") Then
            Return False
        Else
            Return True
        End If

    End Function
    Function isblank() As Boolean

        If cbscan.Checked = False Then

            If txtquantity.Text = "" Or txtprodn.Text = "" Then
                Return False
            Else
                Return True
            End If

        Else

            If txtitemcode.Text = "" Or txtquantity.Text = "" Then
                Return False
            Else
                Return True
            End If

        End If

    End Function

    Function verify() As Boolean

        If charcheck() = True And specialquote() = True And isblank() = True Then
            Return True
        Else

            If charcheck() = False Then
                MsgBox("invalid input!", vbInformation)
            End If

            If specialquote() = False Then
                MsgBox("Double and Signle Quote!", vbInformation)
            End If

            If isblank() = False Then
                MsgBox("Please input item", vbInformation)
            End If

            txtitemcode.Text = ""
            txtquantity.Text = "1"
            txtprodn.Text = ""
            'txtprice.Text = ""

            If scan = True Then
                txtitemcode.Select()
            Else
                txtprodn.Select()
            End If

            Return False
        End If

    End Function

    Dim splitter As Boolean = False

    Dim POSHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        Dim ctrl As New Datapanel1
        Dim controlOffset As Integer = 22
        With ctrl
            .Margin = New Padding(0)
            .Width = pnlPosLabelHeader.Size.Width - controlOffset

            .lblpcode.Text = "123456789"
            .lblprodn.Text = "'SimplePOS.exe' (CLR v4.0.30319: SimplePOS.exe): Loaded 'C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Numerics\v4.0_4.0.0.0__b77a5c561934e089\System.Numerics.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled."
            .lblquantity.Text = "1"
            .lblprice.Text = "12.00"

            'Dim workingArea As Integer = .Width
            'Dim labels As Integer = ctrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
            'workingArea = workingArea / labels

            ''Console.WriteLine(workingArea)

            'Dim xP As Integer = workingArea / 2
            'Dim yP As Integer = .Size.Height / 2

            Dim i As Integer = 0
            Dim labelOffset As Integer = 10
            For Each lbl As Control In ctrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                lbl.Size = POSHeaderLabels(i).Size
                lbl.Location = POSHeaderLabels(i).Location
                'lbl.Size = New Size(workingArea - labelOffset, lbl.Size.Height)
                'lbl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP)
                'Console.WriteLine(lbl.Location.X)
                i += 1
                'xP += workingArea
            Next

            If splitter Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            splitter = Not splitter

        End With

        flowlayoutPOS.Controls.Add(ctrl)

        Return


        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()


        'If verify() = True Then
        '    Dim check As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemcode.Text & "'", connection)
        '    Dim chktable As New DataTable
        '    check.Fill(chktable)

        '    Dim search As New SqlDataAdapter("select * from tblcart where itemid='" & txtitemcode.Text & "'", connection)
        '    Dim table As New DataTable
        '    search.Fill(table)

        '    If chktable.Rows.Count > 0 Then

        '        Dim stock As Integer = chktable.Rows(0)(5)
        '        Dim stockleft As Integer = stock - Val(txtquantity.Text)

        '        If Val(txtquantity.Text) > stock Then

        '            MsgBox("Item Out Of Stock", vbInformation)

        '        Else

        '            If stock <= 0 Then
        '                MsgBox("Item Out Of Stock", vbInformation)
        '            Else

        '                If table.Rows.Count > 0 Then
        '                    Dim upstock, invstock As Integer
        '                    Dim uprice As Double

        '                    upstock = Val(table.Rows(0)(4)) + Val(txtquantity.Text)
        '                    uprice = Val(table.Rows(0)(5)) + (Val(txtPOSprice.Text) * Val(txtquantity.Text))

        '                    Dim upd As New SqlDataAdapter("update tblcart set quan='" & upstock & "',price='" & uprice & "'where itemid='" & txtitemcode.Text & "'", connection)
        '                    Dim updtable As New DataTable
        '                    upd.Fill(updtable)

        '                    Dim inv As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemcode.Text & "'", connection)
        '                    Dim tableinv As New DataTable
        '                    inv.Fill(tableinv)

        '                    invstock = Val(tableinv.Rows(0)(5)) - Val(txtquantity.Text)


        '                    Dim ref As New SqlDataAdapter("update tblinventory set stock='" & invstock & "'where itemid='" & txtitemcode.Text & "'", connection)
        '                    Dim reftable As New DataTable
        '                    ref.Fill(reftable)
        '                Else
        '                    gen = 1
        '                    While gen > 0
        '                        Dim searchrow As New SqlDataAdapter("select * from tblcart where row='" & gen & "'", connection)
        '                        Dim tablesearch As New DataTable
        '                        searchrow.Fill(tablesearch)

        '                        If tablesearch.Rows.Count > 0 Then
        '                            gen = gen + 1
        '                        Else
        '                            rows = gen
        '                            gen = 0
        '                        End If
        '                    End While
        '                    Dim invstock As Integer
        '                    Dim save As New SqlCommand("insert into tblcart" & "(cosid,itemid,prodn,cat,quan,price,date,row) values (@cosid,@itemid,@prodn,@cat,@quan,@price,@date,@row)", connection)

        '                    'save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = lblcosid.Text
        '                    save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemcode.Text
        '                    save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = lblproduct.Text
        '                    save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = lblcategor.Text
        '                    save.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = txtquantity.Text
        '                    save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = Val(txtquantity.Text) * Val(txtPOSprice.Text)
        '                    save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = TimeOfDay & " " & Format(Today, "dddd, dd MMMM yyyy")
        '                    save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = rows
        '                    save.ExecuteNonQuery()

        '                    Dim inv As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemcode.Text & "'", connection)
        '                    Dim tableinv As New DataTable
        '                    inv.Fill(tableinv)

        '                    invstock = Val(tableinv.Rows(0)(5)) - Val(txtquantity.Text)

        '                    Dim ref As New SqlDataAdapter("update tblinventory set stock='" & invstock & "'where itemid='" & txtitemcode.Text & "'", connection)
        '                    Dim reftable As New DataTable
        '                    ref.Fill(reftable)
        '                End If
        '                connection.Close()

        '                flowlayoutPOS.Controls.Clear()
        '                Try
        '                    connection.Open()
        '                    command = New SqlCommand("select * from tblcart", connection)
        '                    reader = command.ExecuteReader
        '                    lbltotal.Text = "0"
        '                    While reader.Read
        '                        Dim datapanel As Datapanel1
        '                        datapanel = New Datapanel1
        '                        datapanel.Margin = New Padding(0)

        '                        ctr = ctr + 1
        '                        If ctr = 1 Then
        '                            With datapanel
        '                                .BackColor = Color.GhostWhite
        '                                .lblpcode.Text = reader.GetString(1)
        '                                .lblprodn.Text = reader.GetString(2)
        '                                .lblquantity.Text = reader.GetString(4)
        '                                .lblprice.Text = reader.GetString(5)
        '                            End With
        '                        Else
        '                            With datapanel
        '                                .BackColor = Color.White
        '                                .lblpcode.Text = reader.GetString(1)
        '                                .lblprodn.Text = reader.GetString(2)
        '                                .lblquantity.Text = reader.GetString(4)
        '                                .lblprice.Text = reader.GetString(5)
        '                            End With
        '                            ctr = 0
        '                        End If
        '                        flowlayoutPOS.Controls.Add(datapanel)

        '                        Dim sale As Double = RTrim(Val(reader.GetString(5)))
        '                        Dim total As Double
        '                        total = sale + total

        '                        If total = Int(total) Then
        '                            lbltotal.Text = total.ToString("N")
        '                        Else
        '                            lbltotal.Text = total.ToString("N", CultureInfo.InvariantCulture)
        '                        End If

        '                    End While

        '                Catch ex As Exception
        '                    MsgBox(ex.Message)
        '                End Try
        '            End If
        '        End If

        '        If scan = True Then
        '            txtitemcode.Select()
        '        Else
        '            txtprodn.Select()
        '        End If

        '        btnmult.BaseColor = System.Drawing.Color.FromArgb(233, 48, 40)
        '        txtquantity.Enabled = False
        '        txtitemcode.Text = ""
        '        txtquantity.Text = "1"
        '        txtprodn.Text = ""
        '        'txtprice.Text = ""

        '    Else
        '        MsgBox("Item not available", vbInformation)
        '        txtitemcode.Text = ""
        '        txtquantity.Text = "1"
        '        txtprodn.Text = ""
        '        'txtprice.Text = ""

        '    End If



        'End If


    End Sub



    Private Sub btnedititem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedititem.Click

        'shadowback.Show()
        'InventoryManager.TabControl1.SelectedTab = InventoryManager.tabItems
        'InventoryManager.lblTitle.Text = "Edit Item"
        'InventoryManager.ShowDialog()

        Dim invdatapanelcount As Integer = 0
        If flowlayoutinv.Controls.Count > 0 Then
            For Each control As InvDatapanel In flowlayoutinv.Controls.OfType(Of InvDatapanel)
                control.pnlbutton.Visible = True
                invdatapanelcount += 1
            Next

            If invdatapanelcount = 0 Then
                MsgBox("Invalid datatable. For editing please select 'My Inventory tab'.", vbCritical, "Editing Items")
            End If
        End If



        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader


        'flowlayoutinv.Controls.Clear()
        'Try
        '    connection.Open()
        '    command = New SqlCommand("select * from tblinventory", connection)
        '    reader = command.ExecuteReader
        '    While reader.Read
        '        Dim inv As InvDatapanel
        '        inv = New InvDatapanel
        '        Dim price As Double = reader.GetString(6)
        '        inv.Margin = New Padding(0)

        '        ctr = ctr + 1
        '        If ctr = 1 Then
        '            With inv
        '                .lblitemid.Text = reader.GetString(1)
        '                .lblproductn.Text = reader.GetString(2)
        '                .lblcat.Text = reader.GetString(3)
        '                .lblstock.Text = reader.GetString(5)

        '                If price = Int(price) Then
        '                    .lblprice.Text = price.ToString("N")
        '                Else
        '                    .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                End If

        '                .BackColor = Color.White
        '                .pnlbutton.Visible = True
        '            End With
        '        Else
        '            With inv
        '                .lblitemid.Text = reader.GetString(1)
        '                .lblproductn.Text = reader.GetString(2)
        '                .lblcat.Text = reader.GetString(3)
        '                .lblstock.Text = reader.GetString(5)

        '                If price = Int(price) Then
        '                    .lblprice.Text = price.ToString("N")
        '                Else
        '                    .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                End If

        '                .BackColor = Color.GhostWhite
        '                .pnlbutton.Visible = True
        '            End With
        '            ctr = 0
        '        End If
        '        flowlayoutinv.Controls.Add(inv)
        '    End While
        '    ctr = 0
        '    connection.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'edit = True

        'lblstock.Text = "STOCK"

        'lblcat.Text = "CATEGORY"
        'lblcat.Location = New System.Drawing.Point(573, 10)
        'lblaction.Location = New System.Drawing.Point(1162, 10)
        'lblprice.Location = New System.Drawing.Point(961, 10)
        'lblprice.Text = "PRICE"
        'lblstock.Visible = True
        'lblprice.Visible = True

        'btninvref.Visible = False
        'btnadditem.Visible = False
        'btnedititem.Visible = False
        'btnoutofstock.Visible = False
        'btndefect.Visible = False
        'btnexpired.Visible = False


        'btnback.Visible = True

        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(TransparentPanel1, Color.Black, 20, 7, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'inventory refresh
        'inventory_refresh()

        edit = False
        ofs = False
        defect = False

        lblstock.Text = "STOCK"

        lblcat.Text = "CATEGORY"
        lblcat.Location = New System.Drawing.Point(573, 10)
        lblaction.Location = New System.Drawing.Point(1162, 10)
        lblprice.Location = New System.Drawing.Point(961, 10)
        lblprice.Text = "PRICE"
        lblstock.Visible = True
        lblprice.Visible = True

        pnlSearchBar.Visible = True
        'pnlshadow4.BackColor = Color.GhostWhite
        flowlayoutinv.BackColor = System.Drawing.Color.FromArgb(248, 248, 248)
        lblprice.Location = New System.Drawing.Point(961, 10)
        btnadditem.Visible = True
        btnedititem.Visible = True
        btnoutofstock.Visible = True
        btndefect.Visible = True
        btnexpired.Visible = True
        btninvref.Visible = True
        'btnback.Visible = False
    End Sub

    Private Sub btnoutofstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoutofstock.Click

        Dim i As Integer = 0
        Dim headerText() As String = {"ITEM ID", "PRODUCT NAME", "CATEGORY", "STOCK", "PRICE", "ACTION"}

        Dim widthOffset As Integer = 17
        Dim headerWidth As Integer = pnlInvHeader.Size.Width - widthOffset
        Dim workingArea As Integer = headerWidth / headerText.Length

        Dim labelOffset As Integer = 10
        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlInvHeader.Size.Height / 2


        Dim headerTextList As New List(Of Control)
        For Each hctrl As Control In pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            If i < headerText.Length Then
                hctrl.Size = New Size(workingArea - labelOffset, hctrl.Size.Height)
                hctrl.Location = New Point(xP - (hctrl.Size.Width / 2) + (labelOffset / 2), yP - (hctrl.Size.Height / 2))
                hctrl.Text = headerText(i)
                hctrl.Visible = True

                headerTextList.Add(hctrl)
                xP += workingArea
            Else
                hctrl.Visible = False
            End If

            i += 1
        Next

        Dim pOffset() As Integer = {-(headerTextList(0).Size.Width / 3), (headerTextList(1).Size.Width * 1), (headerTextList(2).Size.Width / 2), (headerTextList(3).Size.Width * 0.4), (headerTextList(4).Size.Width / 3)}
        For j As Integer = 0 To headerTextList.Count - 2
            'current text label
            headerTextList(j).Size = New Size(headerTextList(j).Size.Width + pOffset(j), headerTextList(j).Size.Height)

            'next text label
            headerTextList(j + 1).Location = New Point(headerTextList(j + 1).Location.X + pOffset(j), headerTextList(j + 1).Location.Y)
            headerTextList(j + 1).Size = New Size(headerTextList(j + 1).Size.Width - pOffset(j), headerTextList(j + 1).Size.Height)
        Next

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim adaptor As New SqlDataAdapter("SELECT * FROM tblinventory WHERE stock <= 0", connection)
        Dim table As New DataTable
        adaptor.Fill(table)

        inventoryPage(1) = Math.Truncate(table.Rows.Count / inventoryPage(2))

        If Not inventoryState = InventoryButtonState.OutOfStock Then
            inventoryState = InventoryButtonState.OutOfStock
            inventoryPage(0) = 0

            Console.WriteLine(inventoryPage(0) & "  " & inventoryPage(1))
            If inventoryPage(0) = inventoryPage(1) Then
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = False
                btnEndPage.Enabled = False
            Else
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = True
                btnEndPage.Enabled = True
            End If
        End If

        While flowlayoutinv.Controls.Count > 0
            Dim invControl As Control = flowlayoutinv.Controls.Item(0)
            flowlayoutinv.Controls.RemoveAt(0)
            invControl.Dispose()
        End While

        Dim command As New SqlCommand("SELECT * FROM tblinventory WHERE stock <= 0", connection)
        Dim reader As SqlDataReader = command.ExecuteReader

        Dim currentRow As Integer = 0
        While reader.Read

            If Not (currentRow >= (inventoryPage(0) * inventoryPage(2)) And currentRow < ((inventoryPage(0) * inventoryPage(2)) + inventoryPage(2))) Then
                'Console.WriteLine(currentRow)
                currentRow += 1
                Continue While
            End If

            Dim ctrl As New InvDatapanel
            With ctrl
                .Margin = New Padding(0)
                .Width = headerWidth
                .lblstock.ForeColor = Color.FromArgb(232, 17, 35)

                Dim rowData(7) As Object
                'inventory id
                rowData(0) = reader.GetInt32(0)
                'item id / number
                rowData(1) = reader.GetString(1)
                'product name
                rowData(2) = reader.GetString(2)
                'category
                rowData(3) = reader.GetString(3)

                'date
                If reader.IsDBNull(4) Then
                    rowData(4) = Nothing
                Else
                    rowData(4) = reader.GetDateTime(4)
                End If

                'stock
                rowData(5) = reader.GetInt32(5)
                'price
                rowData(6) = reader.GetDecimal(6)
                'isExp (is Expiration active)
                rowData(7) = reader.GetBoolean(7)
                'assign raw data
                .ControlData(rowData)

                'max id char 20 chars
                .lblitemid.Text = reader.GetString(1).Trim
                .lblproductn.Text = reader.GetString(2).Trim
                .lblcat.Text = reader.GetString(3).Trim
                .lblstock.Text = reader.GetInt32(5).ToString
                .lblprice.Text = reader.GetDecimal(6).ToString

                'Offsets
                Dim j As Integer = 0
                For Each c As Control In ctrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                    c.Size = headerTextList(j).Size
                    c.Location = headerTextList(j).Location
                    j += 1
                Next
                'Console.WriteLine(i)


                .btnaddstk.Size = New Size((headerTextList(j).Size.Width / 2) - labelOffset, .btnaddstk.Size.Height)
                .btnaddstk.Location = New Point(headerTextList(j).Location.X + (labelOffset / 2), (.Size.Height / 2) - (.btnaddstk.Size.Height / 2))

                .btndelete.Size = New Size((headerTextList(j).Size.Width / 2) - labelOffset, .btndelete.Size.Height)
                .btndelete.Location = New Point(headerTextList(j).Location.X + .btnaddstk.Size.Width + labelOffset, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

                .pnlbutton.Size = New Size(headerTextList(j).Size.Width, .pnlbutton.Height)
                .pnlbutton.Location = New Point(headerTextList(j).Location.X, (.Size.Height / 2) - (.pnlbutton.Size.Height / 2))

            End With
            flowlayoutinv.Controls.Add(ctrl)
            currentRow += 1

        End While
        connection.Close()



        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader

        'flowlayoutinv.Controls.Clear()
        'Try
        '    connection.Open()
        '    command = New SqlCommand("select * from tblinventory where stock='" & 0 & "'", connection)
        '    reader = command.ExecuteReader
        '    While reader.Read
        '        Dim invpanel As InvDatapanel
        '        invpanel = New InvDatapanel
        '        Dim price As Double = reader.GetString(6)
        '        invpanel.Margin = New Padding(0)

        '        ctr = ctr + 1
        '        If ctr = 1 Then
        '            With invpanel
        '                .pnlbutton.Visible = False
        '                .btndelete.Visible = False
        '                .btnaddstk.Location = New System.Drawing.Point(1101, 7)
        '                .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
        '                .lblitemid.ForeColor = Color.White
        '                .lblproductn.ForeColor = Color.White
        '                .lblcat.ForeColor = Color.White
        '                .lblstock.ForeColor = Color.White
        '                .lblprice.ForeColor = Color.White
        '                .lblitemid.Text = reader.GetString(1)
        '                .lblproductn.Text = reader.GetString(2)
        '                .lblcat.Text = reader.GetString(3)
        '                .lblstock.Text = reader.GetString(5)

        '                If price = Int(price) Then
        '                    .lblprice.Text = price.ToString("N")
        '                Else
        '                    .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                End If

        '            End With
        '        Else
        '            With invpanel
        '                .pnlbutton.Visible = False
        '                .btndelete.Visible = False
        '                .btnaddstk.Location = New System.Drawing.Point(1101, 6)
        '                .BackColor = System.Drawing.Color.FromArgb(223, 48, 40)
        '                .lblitemid.ForeColor = Color.White
        '                .lblproductn.ForeColor = Color.White
        '                .lblcat.ForeColor = Color.White
        '                .lblstock.ForeColor = Color.White
        '                .lblprice.ForeColor = Color.White
        '                .lblitemid.Text = reader.GetString(1)
        '                .lblproductn.Text = reader.GetString(2)
        '                .lblcat.Text = reader.GetString(3)
        '                .lblstock.Text = reader.GetString(5)

        '                If price = Int(price) Then
        '                    .lblprice.Text = price.ToString("N")
        '                Else
        '                    .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                End If
        '            End With
        '            ctr = 0
        '        End If
        '        flowlayoutinv.Controls.Add(invpanel)
        '    End While
        '    ctr = 0
        '    connection.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'ofs = True

        ''pnlshadow4.BackColor = System.Drawing.Color.FromArgb(188, 48, 40)

        'lblstock.Text = "STOCK"
        'lblprice.Text = "PRICE"
        'lblcat.Text = "CATEGORY"
        'lblcat.Location = New System.Drawing.Point(573, 10)
        'lblaction.Location = New System.Drawing.Point(1162, 10)
        'lblprice.Location = New System.Drawing.Point(961, 10)

        'lblstock.Visible = True
        'lblprice.Visible = True

        'btninvref.Visible = False
        'btnadditem.Visible = False
        'btnedititem.Visible = False
        'btnoutofstock.Visible = False
        'btndefect.Visible = False
        'btnexpired.Visible = False

        'btnback.Visible = True
        'flowlayoutinv.BackColor = System.Drawing.Color.FromArgb(188, 48, 40)

    End Sub

    Private Sub txtsearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Enter
        If txtsearch.Text = "Search" Then
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Leave
        If txtsearch.Text = "" Then
            txtsearch.Text = "Search"
            txtsearch.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnstocklog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstocklog.Click
        'loglbl1.Location = New System.Drawing.Point(210, 10)
        'loglbl2.Location = New System.Drawing.Point(455, 10)
        'loglbl3.Location = New System.Drawing.Point(728, 10)
        'loglbl4.Visible = False

        'loglbl1.Text = "PRODUCT NAME"
        'loglbl2.Text = "STOCK IN/OUT"
        'loglbl3.Text = "DATE"

        'Dim logcontrol As New stocklogdata

        'With logcontrol
        '    .Margin = New Padding(0)

        '    .lblprod.Text = "product shit qweasd xcaseqwpeojqpsdj paoepqowe "
        '    .lblaction.Text = "3....2.....1.....Action"
        '    .lbldate.Text = "date to day motherfucker"

        '    If logColorSwitch Then
        '        .BackColor = Color.White
        '    Else
        '        .BackColor = Color.GhostWhite
        '    End If
        '    logColorSwitch = Not logColorSwitch
        'End With
        'flowlayoutLOG.Controls.Add(logcontrol)

        Dim headerLabels() As String = {"LOG ID", "PRODUCT NAME", "HISTORY / STOCK IN", "DATE", "ACTION"}

        Dim headerOffset As Integer = 17
        Dim headerWidth As Integer = pnlLogHeader.Width - headerOffset
        Dim labelCount As Integer = headerLabels.Length
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlLogHeader.Height / 2

        Dim logHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlLogHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse

            If i < headerLabels.Length Then
                ctrl.Text = headerLabels(i)
                ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
                ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
                ctrl.Visible = True
                logHeaderLabels.Add(ctrl)
            Else
                ctrl.Visible = False
            End If

            i += 1
            xP += workingArea
        Next

        Dim pOffset() As Integer = {-(logHeaderLabels(0).Size.Width / 3), (logHeaderLabels(1).Size.Width / 2), (logHeaderLabels(2).Size.Width / 1.5), (logHeaderLabels(4).Size.Width / 3)}
        For j As Integer = 0 To logHeaderLabels.Count - 2
            'current text label
            logHeaderLabels(j).Size = New Size(logHeaderLabels(j).Size.Width + pOffset(j), logHeaderLabels(j).Size.Height)

            'next text label
            logHeaderLabels(j + 1).Location = New Point(logHeaderLabels(j + 1).Location.X + pOffset(j), logHeaderLabels(j + 1).Location.Y)
            logHeaderLabels(j + 1).Size = New Size(logHeaderLabels(j + 1).Size.Width - pOffset(j), logHeaderLabels(j + 1).Size.Height)
        Next

        Dim logcontrol As New Logdata
        With logcontrol
            .Margin = New Padding(0)
            .Width = headerWidth

            .lblLogId.Text = "123456789"
            .lblProdName.Text = "product shit qweasd xcaseqwpeojqpsdj paoepqowe"
            .lblHistory.Text = "3....2.....1.....Action"
            .lblDate.Text = "date to day motherfucker"

            Dim j As Integer = 0
            For Each ctrl As Control In logcontrol.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = logHeaderLabels(j).Size
                ctrl.Location = logHeaderLabels(j).Location
                j += 1
            Next

            .btndelete.Size = New Size(logHeaderLabels(j).Size.Width, .btndelete.Size.Height)
            .btndelete.Location = New Point(logHeaderLabels(j).Location.X, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

            If logColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            logColorSwitch = Not logColorSwitch

        End With
        flowlayoutLOG.Controls.Add(logcontrol)


        'logcontrol.Margin = New Padding(0)

        'ctr = ctr + 1

        'If ctr = 1 Then
        '    With logcontrol
        '        .BackColor = Color.GhostWhite
        '        .lblprod.Text = reader.GetString(0)
        '        .lblaction.Text = reader.GetString(1)
        '        .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '    End With
        'Else
        '    With logcontrol
        '        .BackColor = Color.White
        '        .lblprod.Text = reader.GetString(0)
        '        .lblaction.Text = reader.GetString(1)
        '        .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '    End With
        '    ctr = 0
        'End If

        'flowlayoutLOG.Controls.Add(logcontrol)


        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()

        'log = 1

        'flowlayoutLOG.Controls.Clear()

        'command = New SqlCommand("select * from tblstocklog", connection)
        'reader = command.ExecuteReader

        'While reader.Read
        '    Dim logcontrol As stocklogdata
        '    logcontrol = New stocklogdata
        '    logcontrol.Margin = New Padding(0)

        '    ctr = ctr + 1

        '    If ctr = 1 Then
        '        With logcontrol
        '            .BackColor = Color.GhostWhite
        '            .lblprod.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '    Else
        '        With logcontrol
        '            .BackColor = Color.White
        '            .lblprod.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '        ctr = 0
        '    End If

        '    flowlayoutLOG.Controls.Add(logcontrol)
        'End While


        'gen = 0
    End Sub

    Private Sub btnacclog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacclog.Click
        'loglbl1.Location = New System.Drawing.Point(210, 10)
        'loglbl2.Location = New System.Drawing.Point(455, 10)
        'loglbl3.Location = New System.Drawing.Point(728, 10)

        ''setting new location
        'loglbl1.Location = New System.Drawing.Point(110, 10)
        'loglbl2.Location = New System.Drawing.Point(181, 10)
        'loglbl3.Location = New System.Drawing.Point(550, 10)
        'loglbl4.Location = New System.Drawing.Point(899, 10)
        'loglbl5.Location = New System.Drawing.Point(1156, 10)

        ''visibility
        'loglbl4.Visible = True

        ''setting text
        'loglbl1.Text = ""
        'loglbl2.Text = "USERNAME"
        'loglbl3.Text = "ACTION"
        'loglbl4.Text = "DATE"
        'loglbl5.Text = "ACTION"

        'Dim acclog As New Accountlog
        'With acclog
        '    .Margin = New Padding(0)

        '    .lblusername.Text = "username shit qweasd xcaseqwpeojqpsdj paoepqowe "
        '    .lblaction.Text = "3....2.....1.....Action"
        '    .lbldate.Text = "date to day motherfucker"

        '    If logColorSwitch Then
        '        .BackColor = Color.White
        '    Else
        '        .BackColor = Color.GhostWhite
        '    End If
        '    logColorSwitch = Not logColorSwitch
        'End With
        'flowlayoutLOG.Controls.Add(acclog)

        Dim headerLabels() As String = {"LOG ID", "USERNAME", "HISTORY", "DATE", "ACTION"}

        Dim headerOffset As Integer = 17
        Dim headerWidth As Integer = pnlLogHeader.Width - headerOffset
        Dim labelCount As Integer = headerLabels.Length
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlLogHeader.Height / 2

        Dim logHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlLogHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse

            If i < headerLabels.Length Then
                ctrl.Text = headerLabels(i)
                ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
                ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
                ctrl.Visible = True
                logHeaderLabels.Add(ctrl)
            Else
                ctrl.Visible = False
            End If

            i += 1
            xP += workingArea
        Next

        Dim pOffset() As Integer = {-(logHeaderLabels(0).Size.Width / 3), (logHeaderLabels(1).Size.Width / 2), (logHeaderLabels(2).Size.Width / 1.5), (logHeaderLabels(4).Size.Width / 3)}
        For j As Integer = 0 To logHeaderLabels.Count - 2
            'current text label
            logHeaderLabels(j).Size = New Size(logHeaderLabels(j).Size.Width + pOffset(j), logHeaderLabels(j).Size.Height)

            'next text label
            logHeaderLabels(j + 1).Location = New Point(logHeaderLabels(j + 1).Location.X + pOffset(j), logHeaderLabels(j + 1).Location.Y)
            logHeaderLabels(j + 1).Size = New Size(logHeaderLabels(j + 1).Size.Width - pOffset(j), logHeaderLabels(j + 1).Size.Height)
        Next

        Dim acclog As New Accountlog
        With acclog
            .Margin = New Padding(0)
            .Width = headerWidth

            .lblLogId.Text = "123456789"
            .lblUsername.Text = "Unknown user"
            .lblHistory.Text = "3....2.....1.....Action"
            .lblDate.Text = "date to day"


            Dim j As Integer = 0
            For Each ctrl As Control In acclog.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = logHeaderLabels(j).Size
                ctrl.Location = logHeaderLabels(j).Location
                j += 1
            Next

            .btndelete.Size = New Size(logHeaderLabels(j).Size.Width, .btndelete.Size.Height)
            .btndelete.Location = New Point(logHeaderLabels(j).Location.X, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

            If logColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            logColorSwitch = Not logColorSwitch

        End With
        flowlayoutLOG.Controls.Add(acclog)


        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()

        'log = 2

        'flowlayoutLOG.Controls.Clear()

        'command = New SqlCommand("select * from tblacclog", connection)
        'reader = command.ExecuteReader

        'While reader.Read
        '    'dataload
        '    Dim acclog As Accountlog
        '    acclog = New Accountlog
        '    acclog.Margin = New Padding(0)

        '    ctr = ctr + 1
        '    If ctr = 1 Then
        '        With acclog
        '            .BackColor = Color.GhostWhite
        '            .lblusername.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '    Else
        '        With acclog
        '            .BackColor = Color.White
        '            .lblusername.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '        ctr = 0
        '    End If

        '    flowlayoutLOG.Controls.Add(acclog)
        'End While

        'gen = 0
    End Sub

    Private Sub btnloghistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloghistory.Click
        'loglbl1.Location = New System.Drawing.Point(110, 10)
        'loglbl2.Location = New System.Drawing.Point(355, 10)
        'loglbl3.Location = New System.Drawing.Point(628, 10)
        'loglbl4.Location = New System.Drawing.Point(899, 10)
        'loglbl5.Location = New System.Drawing.Point(1156, 10)

        'loglbl4.Visible = True

        'loglbl1.Text = "USERNAME"
        'loglbl2.Text = "ACCESS TYPE"
        'loglbl3.Text = "LOG IN DATE"
        'loglbl4.Text = "LOG OUT DATE"

        'Dim logdata As New Loginhistorydata
        'With logdata
        '    .Margin = New Padding(0)

        '    .lblusername.Text = "Unknown user"
        '    .lblaccesstype.Text = "Admin"
        '    'time format "dddd, dd MMMM yyyy hh:mm:ss tt"
        '    .lbllogin.Text = "dddd, dd MMMM yyyy hh:mm:ss tt"
        '    .lbllogout.Text = "dddd, dd MMMM yyyy hh:mm:ss tt"

        '    If logColorSwitch Then
        '        .BackColor = Color.White
        '    Else
        '        .BackColor = Color.GhostWhite
        '    End If
        '    logColorSwitch = Not logColorSwitch
        'End With

        Dim headerLabels() As String = {"USERNAME", "ACCESS TYPE", "LOG IN DATE", "LOG OUT DATE", "ACTION"}

        Dim headerOffset As Integer = 17
        Dim headerWidth As Integer = pnlLogHeader.Width - headerOffset
        Dim labelCount As Integer = headerLabels.Length
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlLogHeader.Height / 2

        Dim logHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
        Dim labelOffset As Integer = 10
        Dim i As Integer = 0

        For Each ctrl As Control In pnlLogHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse

            If i < headerLabels.Length Then
                ctrl.Text = headerLabels(i)
                ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
                ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
                ctrl.Visible = True
                logHeaderLabels.Add(ctrl)
            Else
                ctrl.Visible = False
            End If

            i += 1
            xP += workingArea
        Next

        Dim pOffset() As Integer = {-(logHeaderLabels(0).Size.Width / 3), -(logHeaderLabels(2).Size.Width / 1.5), -(logHeaderLabels(2).Size.Width / 3.5), (logHeaderLabels(4).Size.Width / 3)}
        For j As Integer = 0 To logHeaderLabels.Count - 2
            'current text label
            logHeaderLabels(j).Size = New Size(logHeaderLabels(j).Size.Width + pOffset(j), logHeaderLabels(j).Size.Height)

            'next text label
            logHeaderLabels(j + 1).Location = New Point(logHeaderLabels(j + 1).Location.X + pOffset(j), logHeaderLabels(j + 1).Location.Y)
            logHeaderLabels(j + 1).Size = New Size(logHeaderLabels(j + 1).Size.Width - pOffset(j), logHeaderLabels(j + 1).Size.Height)
        Next

        Dim logdata As New Loginhistorydata
        With logdata
            .Margin = New Padding(0)
            .Width = headerWidth

            .lblusername.Text = "Unknown user"
            .lblaccesstype.Text = "administration"
            'time Format "dddd, dd MMMM yyyy hh:mm:ss tt"
            .lbllogin.Text = "dddd, dd MMMM yyyy hh:mm:ss tt"
            .lbllogout.Text = "dddd, dd MMMM yyyy hh:mm:ss tt"


            Dim j As Integer = 0
            For Each ctrl As Control In logdata.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = logHeaderLabels(j).Size
                ctrl.Location = logHeaderLabels(j).Location
                j += 1
            Next

            .btndelete.Size = New Size(logHeaderLabels(j).Size.Width, .btndelete.Size.Height)
            .btndelete.Location = New Point(logHeaderLabels(j).Location.X, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

            If logColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            logColorSwitch = Not logColorSwitch

        End With
        flowlayoutLOG.Controls.Add(logdata)



        'ctr = ctr + 1

        'If ctr = 1 Then
        '    With logdata
        '        .BackColor = Color.GhostWhite
        '        .lblusername.Text = reader.GetString(0)
        '        .lblaccesstype.Text = reader.GetString(1)
        '        .lbllogin.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '        .lbllogout.Text = Format(reader.GetDateTime(3), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '    End With
        'Else
        '    With logdata
        '        .BackColor = Color.White
        '        .lblusername.Text = reader.GetString(0)
        '        .lblaccesstype.Text = reader.GetString(1)
        '        .lbllogin.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '        .lbllogout.Text = Format(reader.GetDateTime(3), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '    End With
        '    ctr = 0
        'End If

        'flowlayoutLOG.Controls.Add(logdata)


        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()

        'log = 3

        'flowlayoutLOG.Controls.Clear()

        'command = New SqlCommand("select * from tblhistory", connection)
        'reader = command.ExecuteReader

        'While reader.Read
        '    Dim logdata As Loginhistorydata
        '    logdata = New Loginhistorydata
        '    logdata.Margin = New Padding(0)

        '    ctr = ctr + 1

        '    If ctr = 1 Then
        '        With logdata
        '            .BackColor = Color.GhostWhite
        '            .lblusername.Text = reader.GetString(0)
        '            .lblaccesstype.Text = reader.GetString(1)
        '            .lbllogin.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '            .lbllogout.Text = Format(reader.GetDateTime(3), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '        End With
        '    Else
        '        With logdata
        '            .BackColor = Color.White
        '            .lblusername.Text = reader.GetString(0)
        '            .lblaccesstype.Text = reader.GetString(1)
        '            .lbllogin.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '            .lbllogout.Text = Format(reader.GetDateTime(3), "dddd, dd MMMM yyyy hh:mm:ss tt")
        '        End With
        '        ctr = 0
        '    End If

        '    flowlayoutLOG.Controls.Add(logdata)
        'End While


        'gen = 0
    End Sub

    Private Sub btnadditem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadditem.Click

        shadowback.Show()
        InventoryManager.TabControl1.SelectedTab = InventoryManager.tabItems
        InventoryManager.lblTitle.Text = "Add Item"
        InventoryManager.SetSaveState(True)
        InventoryManager.ShowDialog()



        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()

        'TabControl.SelectedTab = tabadditem
        'pnlshadow.BackColor = System.Drawing.Color.FromArgb(31, 61, 64)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 200, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'pnlbutton.Enabled = False
        'pnlbutton.BackColor = System.Drawing.Color.FromArgb(202, 202, 202)

        'generators
        'itemidgen()
        'Inventory_generator()

        'Try
        '    command = New SqlCommand("select * from tblcat", connection)
        '    reader = command.ExecuteReader
        '    cbcategory.Items.Clear()

        '    While reader.Read

        '        If Not cbcategory.Items.Contains(reader.GetString(1)) Then
        '            cbcategory.Items.Add(reader.GetString(1))
        '        End If

        '    End While

        '    connection.Close()

        'Catch ex As Exception
        '    MsgBox("Error 104" & ex.Message)
        'End Try

        'Dim contain As Integer
        'contain = cbcategory.Items.Count

        'If contain <= 0 Then
        '    cbcategory.Enabled = False
        'Else
        '    cbcategory.Enabled = True
        'End If

    End Sub

    'Private Sub txtprodname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtprodname.Text = "Enter Product" Then
    '        txtprodname.Text = ""
    '        txtprodname.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtprodname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtprodname.Text = "" Then
    '        txtprodname.Text = "Enter Product"
    '        txtprodname.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub txtstock_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtstock.Text = "Enter Stock" Then
    '        txtstock.Text = ""
    '        txtstock.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtstock_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If txtstock.Text = "" Then
    '        txtstock.Text = "Enter Stock"
    '        txtstock.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub txtprice_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtprice.Text = "Enter Price" Then
    '        txtprice.Text = ""
    '        txtprice.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtprice_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If txtprice.Text = "" Then
    '        txtprice.Text = "Enter Price"
    '        txtprice.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub GunaCircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtitemid.Text = ""
    '    txtprodname.Text = "Enter Product"
    '    cbcategory.Text = ""
    '    txtstock.Text = "Enter Stock"
    '    txtprice.Text = "Enter Price"
    '    TabControl.SelectedTab = tabinventory
    '    pnlbutton.Enabled = True
    '    pnlbutton.BackColor = Color.White
    '    pnlshadow.BackColor = Color.GhostWhite
    '    Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    'End Sub

    'Function quotes() As Boolean

    '    If txtitemid.Text.Contains("""") Or txtitemid.Text.Contains("'") Then
    '        GunaPictureBox0.Visible = True
    '        Return False
    '    ElseIf txtprodname.Text.Contains("""") Or txtprodname.Text.Contains("'") Then
    '        GunaPictureBox2.Visible = True
    '        Return False
    '    ElseIf cbcategory.Text.Contains("""") Or cbcategory.Text.Contains("'") Then
    '        GunaPictureBox3.Visible = True
    '        Return False
    '    ElseIf txtstock.Text.Contains("""") Or txtstock.Text.Contains("'") Then
    '        GunaPictureBox4.Visible = True
    '        Return False
    '    ElseIf txtprice.Text.Contains("""") Or txtstock.Text.Contains("'") Then
    '        GunaPictureBox5.Visible = True
    '        Return False
    '    Else
    '        Return True
    '    End If

    'End Function

    'Function nospace() As Boolean

    '    If txtitemid.Text = "" Then
    '        GunaPictureBox0.Visible = True
    '        Return False
    '    ElseIf txtprodname.Text = "" Or txtprodname.Text = "Enter Product" Then
    '        GunaPictureBox2.Visible = True
    '        txtprodname.Text = "Enter Product"
    '        txtprodname.ForeColor = Color.Silver
    '        Return False
    '    ElseIf cbcategory.Text = "" Then
    '        GunaPictureBox3.Visible = True
    '        Return False
    '    ElseIf txtstock.Text = "" Or txtstock.Text = "Enter Stock" Then
    '        GunaPictureBox4.Visible = True
    '        txtstock.Text = "Enter Stock"
    '        txtstock.ForeColor = Color.Silver
    '        Return False
    '    ElseIf txtprice.Text = "" Or txtprice.Text = "Enter Price" Then
    '        txtprice.Text = "Enter Price"
    '        txtprice.ForeColor = Color.Silver
    '        GunaPictureBox5.Visible = True
    '        Return False
    '    Else
    '        Return True
    '    End If

    'End Function

    'Function restriction() As Boolean

    '    If checkstr(txtitemid.Text, "letterspecial") = False Then
    '        txtitemid.Text = ""
    '        Return False
    '    ElseIf cbcategory.Text = "" Then
    '        Return False
    '    ElseIf checkstr(txtstock.Text, "letterspecial") = False Then
    '        txtstock.Text = ""
    '        Return False
    '    ElseIf checkstr(txtprice.Text, "letterspecials") = False Then
    '        txtprice.Text = ""
    '        Return False
    '    Else
    '        Return True
    '    End If

    'End Function

    'Function isformvalid() As Boolean

    '    If nospace() = True And restriction() = True And quotes() = True Then
    '        Return True
    '    Else

    '        If nospace() = False Then
    '            MsgBox("Please complete the info!", vbInformation)
    '        End If

    '        If restriction() = False Then
    '            MsgBox("Input Invalid!", vbInformation)
    '        End If

    '        If quotes() = False Then
    '            MsgBox("Double and Singles Quotes are Invalid!", vbInformation)
    '        End If

    '        txtprodname.Select()

    '        Return False
    '    End If

    'End Function

    'Private Sub btnaddf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()
    '    Dim reader As SqlDataReader

    '    If isformvalid() = True Then

    '        Dim search As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemid.Text & "'", connection)
    '        Dim table As New DataTable
    '        search.Fill(table)

    '        If table.Rows.Count > 0 Then
    '            MsgBox("Item Id Already Exists!", vbInformation)
    '        Else

    '            If btns = True Then

    '                Dim save As New SqlCommand("insert into tblinventory" & "(invid,itemid,prodn,cat,expdt,stock,price) values (@invid,@itemid,@prodn,@cat,@expdt,@stock,@price)", connection)

    '                save.Parameters.Add(New SqlParameter("@invid", SqlDbType.NChar)).Value = lblinvid.Text
    '                save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemid.Text
    '                save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtprodname.Text
    '                save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbcategory.Text
    '                save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.NVarChar)).Value = Format(dtpexpr.Value, "MM/dd/yyyy")
    '                save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = txtstock.Text
    '                save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = txtprice.Text
    '                save.ExecuteNonQuery()

    '                MsgBox("Data Added To Inventory!", vbInformation)


    '            Else
    '                'year advance for the expirydate
    '                Dim year As Integer
    '                year = Val(Format(Today, "yyyy"))
    '                year = year + 3

    '                Dim daym, dt As String
    '                daym = Format(Today, "MM/dd/")
    '                dt = daym & year

    '                Dim d As Date = dt

    '                Dim save As New SqlCommand("insert into tblinventory" & "(invid,itemid,prodn,cat,expdt,stock,price) values (@invid,@itemid,@prodn,@cat,@expdt,@stock,@price)", connection)

    '                save.Parameters.Add(New SqlParameter("@invid", SqlDbType.NChar)).Value = lblinvid.Text
    '                save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemid.Text
    '                save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtprodname.Text
    '                save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbcategory.Text
    '                save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.NVarChar)).Value = Format(d, "MM/dd/yyyy")
    '                save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = txtstock.Text
    '                save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = txtprice.Text
    '                save.ExecuteNonQuery()

    '                MsgBox("Data Added To Inventory!", vbInformation)


    '            End If

    '            Dim saves As New SqlCommand("insert into tblinvlog" & "(product,action,date) values (@product,@action,@date)", connection)
    '            saves.Parameters.Add(New SqlParameter("@product", SqlDbType.NVarChar)).Value = txtprodname.Text
    '            saves.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Add"
    '            saves.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
    '            saves.ExecuteNonQuery()

    '            'inventory_refresh()

    '            txtitemid.Text = ""
    '            txtprodname.Text = "Enter Product"
    '            cbcategory.Text = ""
    '            txtstock.Text = "Enter Stock"
    '            txtprice.Text = "Enter Price"
    '            txtprodname.ForeColor = Color.Silver
    '            txtstock.ForeColor = Color.Silver
    '            txtprice.ForeColor = Color.Silver

    '            TabControl.SelectedTab = tabinventory
    '            pnlbutton.Enabled = True
    '            pnlshadow.BackColor = Color.GhostWhite
    '            pnlbutton.BackColor = Color.White
    '            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    '            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(TransparentPanel1, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    '        End If

    '    End If

    'End Sub

    Private Sub btncategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncategory.Click

        shadowback.Show()
        InventoryManager.TabControl1.SelectedTab = InventoryManager.tabCategory
        InventoryManager.lblTitle.Text = "Categories"
        InventoryManager.LoadCategoryTable()
        InventoryManager.ShowDialog()

        'category data refresh
        'category_refresh()


        'TabControl.SelectedTab = tabcategory
        'pnlshadow.BackColor = System.Drawing.Color.FromArgb(254, 172, 0)
        'pnlbutton.Enabled = False
        'pnlbutton.BackColor = System.Drawing.Color.FromArgb(202, 202, 202)

        'lblstock.Text = "STOCK"

        'lblcat.Text = "CATEGORY"
        'lblcat.Location = New System.Drawing.Point(573, 10)
        'lblaction.Location = New System.Drawing.Point(1162, 10)

        'lblprice.Visible = True
    End Sub

    Private Sub btncatback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlbutton.Enabled = True
        pnlshadow.BackColor = Color.GhostWhite
        pnlbutton.BackColor = Color.White
        btnadditem.PerformClick()
    End Sub

    Private Sub GunaAdvenceButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton5.Click
        Expenses.Show()
        shadowback.Show()
        Expenses.TopMost = True
    End Sub

    Private Sub btnexpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexpenses.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Try
            flowlayoutSALES.Controls.Clear()
            command = New SqlCommand("select * from tblexpenses", connection)
            reader = command.ExecuteReader
            lblprofitloss.Text = "0"
            While reader.Read
                Dim expensedata As Exdata
                expensedata = New Exdata
                expensedata.Margin = New Padding(0)
                Dim price As Double = reader.GetString(2)

                ctr = ctr + 1
                If ctr = 1 Then
                    With expensedata
                        .lblno.Text = reader.GetString(0)
                        .lbldes.Text = reader.GetString(1)

                        If price = Int(price) Then
                            .lblprice.Text = price.ToString("N")
                        Else
                            .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.GhostWhite
                    End With
                Else
                    With expensedata
                        .lblno.Text = reader.GetString(0)
                        .lbldes.Text = reader.GetString(1)

                        If price = Int(price) Then
                            .lblprice.Text = price.ToString("N")
                        Else
                            .lblprice.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.White
                    End With
                    ctr = 0
                End If

                flowlayoutSALES.Controls.Add(expensedata)

                Dim less As Double = reader.GetString(2)
                lblprofitloss.Text = Val(lblprofitloss.Text) + less

                Dim profitloss As Double = lblprofitloss.Text

                If profitloss = Int(profitloss) Then
                    lblprofitloss.Text = profitloss.ToString("N")
                Else
                    lblprofitloss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
                End If
            End While
            ctr = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'refresh total
        Show_total()

        GunaLabel29.Location = New System.Drawing.Point(210, 10)
        GunaLabel28.Location = New System.Drawing.Point(455, 10)
        GunaLabel25.Location = New System.Drawing.Point(1025, 10)
        GunaLabel27.Visible = False
        GunaLabel24.Visible = False
        GunaLabel26.Visible = False
        GunaLabel25.Text = "EXPENSES"
        GunaLabel28.Text = "DESCRIPTION"


    End Sub

    Dim SalesHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
    Dim colorSwitch As Boolean = True
    Private Sub btnsosales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsosales.Click

        Dim price As Double = 9000
        Dim controlOffset As Integer = 22
        Dim saledata As New Salesdata
        With saledata
            .Margin = New Padding(0)
            .Width = pnlSalesHeader.Width - controlOffset

            .lblitemid.Text = "123123912747124192301239"
            .lblproductn.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            .lblcategory.Text = "Techonology"
            .lblsold.Text = "3"
            .lblstockleft.Text = "2"
            .lblearnings.Text = DecimalToStringFormat(price)

            Dim i As Integer = 0
            For Each ctrl As Control In saledata.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = SalesHeaderLabels(i).Size
                ctrl.Location = SalesHeaderLabels(i).Location
                i += 1
            Next

            If colorSwitch Then
                .BackColor = Color.GhostWhite
            Else
                .BackColor = Color.White
            End If
            colorSwitch = Not colorSwitch

        End With
        flowlayoutSALES.Controls.Add(saledata)

        '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        '    connection.Open()
        '    Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        '    connect.Open()
        '    Dim reader As SqlDataReader


        '    Try
        '        Dim delete As New SqlDataAdapter("delete from tblsummary where row='" & 0 & "'", connection)
        '        Dim del As New DataTable
        '        delete.Fill(del)

        '        command = New SqlCommand("select * from tblsales", connection)
        '        reader = command.ExecuteReader

        '        While reader.Read
        '            Dim search As New SqlDataAdapter("select * from tblsummary where itemid='" & reader.GetString(1) & "'", connect)
        '            Dim table As New DataTable
        '            search.Fill(table)

        '            If table.Rows.Count > 0 Then
        '                Dim itemsold, stock As Integer
        '                Dim earnings As Double

        '                stock = Val(table.Rows(0)(4))

        '                If stock > Val(reader.GetString(5)) Then
        '                    stock = Val(reader.GetString(5))
        '                End If

        '                itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
        '                earnings = Val(table.Rows(0)(5)) + Val(reader.GetString(6))

        '                Dim update As New SqlDataAdapter("update tblsummary set itemsold='" & itemsold & "',stockleft='" & stock & "',earnings='" & earnings & "'where itemid='" & table.Rows(0)(0) & "'", connect)
        '                Dim updtable As New DataTable
        '                update.Fill(updtable)

        '            Else
        '                Dim save As New SqlCommand("insert into tblsummary" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row)", connect)
        '                save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '                save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '                save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
        '                save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
        '                save.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
        '                save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
        '                save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
        '                save.ExecuteNonQuery()
        '            End If

        '        End While

        '        connect.Close()
        '        connection.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        '    flowlayoutSALES.Controls.Clear()
        '    Try
        '        connection.Open()
        '        command = New SqlCommand("select * from tblsummary", connection)
        '        reader = command.ExecuteReader
        '        lblprof.Text = "Earnings"
        '        lblprofit.Text = "0"
        '        While reader.Read


        '            Dim saledata As Salesdata
        '            saledata = New Salesdata
        '            Dim price As Double = reader.GetString(5)
        '            saledata.Margin = New Padding(0)

        '            ctr = ctr + 1
        '            If ctr = 1 Then
        '                With saledata
        '                    .lblitemid.Text = reader.GetString(0)
        '                    .lblproductn.Text = reader.GetString(1)
        '                    .lblcategory.Text = reader.GetString(2)
        '                    .lblsold.Text = reader.GetString(3)
        '                    .lblstockleft.Text = reader.GetString(4)

        '                    If price = Int(price) Then
        '                        .lblearnings.Text = price.ToString("N")
        '                    Else
        '                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                    End If

        '                    .BackColor = Color.GhostWhite
        '                End With
        '            Else
        '                With saledata
        '                    .lblitemid.Text = reader.GetString(0)
        '                    .lblproductn.Text = reader.GetString(1)
        '                    .lblcategory.Text = reader.GetString(2)
        '                    .lblsold.Text = reader.GetString(3)
        '                    .lblstockleft.Text = reader.GetString(4)

        '                    If price = Int(price) Then
        '                        .lblearnings.Text = price.ToString("N")
        '                    Else
        '                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                    End If

        '                    .BackColor = Color.White
        '                End With
        '                ctr = 0
        '            End If
        '            flowlayoutSALES.Controls.Add(saledata)

        '            'sum of earnings
        '            Dim profit As Double = reader.GetString(5)
        '            lblprofit.Text = Val(lblprofit.Text) + profit

        '        End While

        '        Dim earnings As Double = lblprofit.Text

        '        If earnings = Int(earnings) Then
        '            lblprofit.Text = earnings.ToString("N")
        '        Else
        '            lblprofit.Text = earnings.ToString("N", CultureInfo.InvariantCulture)
        '        End If

        '        connection.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        '    'refresh total
        '    Show_total()

        '    'sum_expenses()

        '    GunaLabel29.Location = New System.Drawing.Point(60, 10)
        '    GunaLabel28.Location = New System.Drawing.Point(199, 10)
        '    GunaLabel26.Location = New System.Drawing.Point(919, 10)
        '    GunaLabel25.Location = New System.Drawing.Point(1142, 10)
        '    GunaLabel27.Visible = True
        '    GunaLabel24.Visible = True
        '    GunaLabel26.Visible = True
        '    GunaLabel25.Text = "EARNINGS"
        '    GunaLabel28.Text = "PRODUCT NAME"

        '    salesrind = 0
        'End Sub

        'Private Sub btndailys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndailys.Click
        '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        '    Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        '    Dim reader As SqlDataReader
        '    connection.Open()
        '    connect.Open()

        '    Dim delete As New SqlDataAdapter("delete from tblday where row='" & 0 & "'", connection)
        '    Dim del As New DataTable
        '    delete.Fill(del)


        '    command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connection)
        '    reader = command.ExecuteReader

        '    While reader.Read
        '        Dim search As New SqlDataAdapter("select * from tblday where itemid='" & reader.GetString(1) & "'", connect)
        '        Dim table As New DataTable
        '        search.Fill(table)

        '        If table.Rows.Count > 0 Then
        '            Dim itemsold, stock As Integer
        '            Dim earnings As Double
        '            stock = Val(table.Rows(0)(4))

        '            If stock > Val(reader.GetString(5)) Then
        '                stock = Val(reader.GetString(5))
        '            End If

        '            itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
        '            earnings = Val(table.Rows(0)(5)) + Val(reader.GetString(6))


        '            Dim update As New SqlDataAdapter("update tblday set itemsold='" & itemsold & "',stockleft='" & stock & "',earnings='" & earnings & "'where itemid='" & reader.GetString(1) & "'", connect)
        '            Dim tableupd As New DataTable
        '            update.Fill(tableupd)

        '        Else
        '            Dim save As New SqlCommand("insert into tblday" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row,date) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row,@date)", connect)
        '            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
        '            save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
        '            save.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
        '            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
        '            save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
        '            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = reader.GetString(7)
        '            save.ExecuteNonQuery()
        '        End If
        '    End While
        '    connect.Close()
        '    connection.Close()

        '    'expenses counter
        '    Try
        '        connection.Open()
        '        command = New SqlCommand("select * from tblexpenses where date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connection)
        '        reader = command.ExecuteReader
        '        lblprofitloss.Text = "0"
        '        While reader.Read

        '            Dim less As Double = reader.GetString(2)
        '            lblprofitloss.Text = Val(lblprofitloss.Text) + less

        '        End While

        '        Dim profitloss As Double = lblprofitloss.Text

        '        If profitloss = Int(profitloss) Then
        '            lblprofitloss.Text = profitloss.ToString("N")
        '        Else
        '            lblprofitloss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
        '        End If

        '        connection.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try


        '    flowlayoutSALES.Controls.Clear()
        '    Try
        '        connection.Open()
        '        command = New SqlCommand("select * from tblday", connection)
        '        reader = command.ExecuteReader
        '        lblprof.Text = "Daily Profit"
        '        lblprofit.Text = "0"

        '        While reader.Read

        '            Dim saledata As Salesdata
        '            saledata = New Salesdata
        '            Dim price As Double = reader.GetString(5)
        '            saledata.Margin = New Padding(0)

        '            ctr = ctr + 1
        '            If ctr = 1 Then
        '                With saledata
        '                    .lblitemid.Text = reader.GetString(0)
        '                    .lblproductn.Text = reader.GetString(1)
        '                    .lblcategory.Text = reader.GetString(2)
        '                    .lblsold.Text = reader.GetString(3)
        '                    .lblstockleft.Text = reader.GetString(4)

        '                    If price = Int(price) Then
        '                        .lblearnings.Text = price.ToString("N")
        '                    Else
        '                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                    End If

        '                    .BackColor = Color.GhostWhite
        '                End With
        '            Else
        '                With saledata
        '                    .lblitemid.Text = reader.GetString(0)
        '                    .lblproductn.Text = reader.GetString(1)
        '                    .lblcategory.Text = reader.GetString(2)
        '                    .lblsold.Text = reader.GetString(3)
        '                    .lblstockleft.Text = reader.GetString(4)

        '                    If price = Int(price) Then
        '                        .lblearnings.Text = price.ToString("N")
        '                    Else
        '                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
        '                    End If

        '                    .BackColor = Color.White
        '                End With
        '                ctr = 0
        '            End If
        '            flowlayoutSALES.Controls.Add(saledata)

        '            Dim profit As Double = reader.GetString(5)
        '            lblprofit.Text = Val(lblprofit.Text) + profit

        '        End While

        '        Dim pof As Double = lblprofit.Text

        '        If pof = Int(pof) Then
        '            lblprofit.Text = pof.ToString("N")
        '        Else
        '            lblprofit.Text = pof.ToString("N", CultureInfo.InvariantCulture)
        '        End If

        '        connection.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        '    'refresh total
        '    Show_total()

        '    GunaLabel29.Location = New System.Drawing.Point(60, 10)
        '    GunaLabel28.Location = New System.Drawing.Point(199, 10)
        '    GunaLabel26.Location = New System.Drawing.Point(919, 10)
        '    GunaLabel25.Location = New System.Drawing.Point(1142, 10)
        '    GunaLabel27.Visible = True
        '    GunaLabel24.Visible = True
        '    GunaLabel26.Visible = True
        '    GunaLabel25.Text = "EARNINGS"
        '    GunaLabel28.Text = "PRODUCT NAME"

        '    salesrind = 1
    End Sub

    Private Sub btnmontlys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmontlys.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()
        connect.Open()

        Dim delete As New SqlDataAdapter("delete from tblday where row='" & 0 & "'", connection)
        Dim del As New DataTable
        delete.Fill(del)


        command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "MMMM yyyy") & "%'", connection)
        reader = command.ExecuteReader

        While reader.Read
            Dim search As New SqlDataAdapter("select * from tblday where itemid='" & reader.GetString(1) & "'", connect)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                Dim itemsold, stock As Integer
                Dim earnings As Double
                stock = Val(table.Rows(0)(4))

                If stock > Val(reader.GetString(5)) Then
                    stock = Val(reader.GetString(5))
                End If

                itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                earnings = Val(table.Rows(0)(5)) + Val(reader.GetString(6))


                Dim update As New SqlDataAdapter("update tblday set itemsold='" & itemsold & "',stockleft='" & stock & "',earnings='" & earnings & "'where itemid='" & reader.GetString(1) & "'", connect)
                Dim tableupd As New DataTable
                update.Fill(tableupd)

            Else
                Dim save As New SqlCommand("insert into tblday" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row,date) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row,@date)", connect)
                save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                save.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
                save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = reader.GetString(7)
                save.ExecuteNonQuery()
            End If
        End While
        connect.Close()
        connection.Close()


        Try
            connection.Open()
            command = New SqlCommand("select * from tblexpenses where date like '%" & Format(Today, "MMMM yyyy") & "%'", connection)
            reader = command.ExecuteReader
            lblprofitloss.Text = "0"
            While reader.Read

                Dim less As Double = reader.GetString(2)
                lblprofitloss.Text = Val(lblprofitloss.Text) + less

            End While

            Dim profitloss As Double = lblprofitloss.Text

            If profitloss = Int(profitloss) Then
                lblprofitloss.Text = profitloss.ToString("N")
            Else
                lblprofitloss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        flowlayoutSALES.Controls.Clear()
        Try
            connection.Open()
            command = New SqlCommand("select * from tblday", connection)
            reader = command.ExecuteReader
            lblprof.Text = "Monthly Profit"
            lblprofit.Text = "0"
            While reader.Read
                Dim saledata As Salesdata
                saledata = New Salesdata
                Dim price As Double = reader.GetString(5)
                saledata.Margin = New Padding(0)

                ctr = ctr + 1
                If ctr = 1 Then
                    With saledata
                        .lblitemid.Text = reader.GetString(0)
                        .lblproductn.Text = reader.GetString(1)
                        .lblcategory.Text = reader.GetString(2)
                        .lblsold.Text = reader.GetString(3)
                        .lblstockleft.Text = reader.GetString(4)

                        If price = Int(price) Then
                            .lblearnings.Text = price.ToString("N")
                        Else
                            .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.GhostWhite
                    End With
                Else
                    With saledata
                        .lblitemid.Text = reader.GetString(0)
                        .lblproductn.Text = reader.GetString(1)
                        .lblcategory.Text = reader.GetString(2)
                        .lblsold.Text = reader.GetString(3)
                        .lblstockleft.Text = reader.GetString(4)

                        If price = Int(price) Then
                            .lblearnings.Text = price.ToString("N")
                        Else
                            .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.White
                    End With
                    ctr = 0
                End If
                flowlayoutSALES.Controls.Add(saledata)

                Dim profit As Double = reader.GetString(5)
                lblprofit.Text = Val(lblprofit.Text) + profit

            End While

            Dim pof As Double = lblprofit.Text

            If pof = Int(pof) Then
                lblprofit.Text = pof.ToString("N")
            Else
                lblprofit.Text = pof.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'refresh total
        Show_total()

        GunaLabel29.Location = New System.Drawing.Point(60, 10)
        GunaLabel28.Location = New System.Drawing.Point(199, 10)
        GunaLabel26.Location = New System.Drawing.Point(919, 10)
        GunaLabel25.Location = New System.Drawing.Point(1142, 10)
        GunaLabel27.Visible = True
        GunaLabel24.Visible = True
        GunaLabel26.Visible = True
        GunaLabel25.Text = "EARNINGS"
        GunaLabel28.Text = "PRODUCT NAME"

        salesrind = 2
    End Sub

    Private Sub btnannualys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnannualys.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()
        connect.Open()

        Dim delete As New SqlDataAdapter("delete from tblday where row='" & 0 & "'", connection)
        Dim del As New DataTable
        delete.Fill(del)


        command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "yyyy") & "%'", connection)
        reader = command.ExecuteReader

        While reader.Read
            Dim search As New SqlDataAdapter("select * from tblday where itemid='" & reader.GetString(1) & "'", connect)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                Dim itemsold, stock As Integer
                Dim earnings As Double
                stock = Val(table.Rows(0)(4))

                If stock > Val(reader.GetString(5)) Then
                    stock = Val(reader.GetString(5))
                End If

                itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                earnings = Val(table.Rows(0)(5)) + Val(reader.GetString(6))


                Dim update As New SqlDataAdapter("update tblday set itemsold='" & itemsold & "',stockleft='" & stock & "',earnings='" & earnings & "'where itemid='" & reader.GetString(1) & "'", connect)
                Dim tableupd As New DataTable
                update.Fill(tableupd)

            Else
                Dim save As New SqlCommand("insert into tblday" & "(itemid,prodn,cat,itemsold,stockleft,earnings,row,date) values (@itemid,@prodn,@cat,@itemsold,@stockleft,@earnings,@row,@date)", connect)
                save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                save.Parameters.Add(New SqlParameter("@stockleft", SqlDbType.NChar)).Value = reader.GetString(5)
                save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = 0
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = reader.GetString(7)
                save.ExecuteNonQuery()
            End If
        End While
        connect.Close()
        connection.Close()

        Try
            connection.Open()
            command = New SqlCommand("select * from tblexpenses where date like '%" & Format(Today, "yyyy") & "%'", connection)
            reader = command.ExecuteReader
            lblprofitloss.Text = "0"
            While reader.Read

                Dim less As Double = reader.GetString(2)
                lblprofitloss.Text = Val(lblprofitloss.Text) + less

            End While

            Dim profitloss As Double = lblprofitloss.Text

            If profitloss = Int(profitloss) Then
                lblprofitloss.Text = profitloss.ToString("N")
            Else
                lblprofitloss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        flowlayoutSALES.Controls.Clear()
        Try
            connection.Open()
            command = New SqlCommand("select * from tblday", connection)
            reader = command.ExecuteReader
            lblprof.Text = "Annnual Profit"
            lblprofit.Text = "0"
            While reader.Read
                Dim saledata As Salesdata
                saledata = New Salesdata
                saledata.Margin = New Padding(0)

                Dim price As Double = reader.GetString(5)
                ctr = ctr + 1
                If ctr = 1 Then
                    With saledata
                        .lblitemid.Text = reader.GetString(0)
                        .lblproductn.Text = reader.GetString(1)
                        .lblcategory.Text = reader.GetString(2)
                        .lblsold.Text = reader.GetString(3)
                        .lblstockleft.Text = reader.GetString(4)

                        If price = Int(price) Then
                            .lblearnings.Text = price.ToString("N")
                        Else
                            .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.GhostWhite
                    End With
                Else
                    With saledata
                        .lblitemid.Text = reader.GetString(0)
                        .lblproductn.Text = reader.GetString(1)
                        .lblcategory.Text = reader.GetString(2)
                        .lblsold.Text = reader.GetString(3)
                        .lblstockleft.Text = reader.GetString(4)

                        If price = Int(price) Then
                            .lblearnings.Text = price.ToString("N")
                        Else
                            .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                        End If

                        .BackColor = Color.White
                    End With
                    ctr = 0
                End If
                flowlayoutSALES.Controls.Add(saledata)

                Dim profit As Double = reader.GetString(5)
                lblprofit.Text = Val(lblprofit.Text) + profit

            End While
            Dim pof As Double = lblprofit.Text

            If pof = Int(pof) Then
                lblprofit.Text = pof.ToString("N")
            Else
                lblprofit.Text = pof.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'refresh total
        Show_total()

        GunaLabel29.Location = New System.Drawing.Point(60, 10)
        GunaLabel28.Location = New System.Drawing.Point(199, 10)
        GunaLabel26.Location = New System.Drawing.Point(919, 10)
        GunaLabel25.Location = New System.Drawing.Point(1142, 10)
        GunaLabel27.Visible = True
        GunaLabel24.Visible = True
        GunaLabel26.Visible = True
        GunaLabel25.Text = "EARNINGS"
        GunaLabel28.Text = "PRODUCT NAME"

        salesrind = 3
    End Sub


    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditacc.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Createaccount.pnledit.Visible = True
        'btnaccback.Visible = True
        btncreateacc.Visible = False
        btneditacc.Visible = False

        'account data refresh
        flowlayoutACC.Controls.Clear()
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
                        .pnlbtn.Visible = False
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
                        .pnlbtn.Visible = False
                        .BackColor = Color.GhostWhite
                        ctr = 0
                    End With

                End If

                flowlayoutACC.Controls.Add(accdata)
            End While
            ctr = 0
            connection.Close()
        Catch ex As Exception
            MsgBox("Error 101" & ex.Message)
        End Try

        If flowlayoutACC.Controls.Count = 1 Then
            flowlayoutACC.Controls.Clear()
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
                            .BackColor = Color.White
                            .pnlbtn.Visible = False
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

                    flowlayoutACC.Controls.Add(accdata)
                End While
                ctr = 0
                connection.Close()
            Catch ex As Exception
                MsgBox("Error 102" & ex.Message)
            End Try
        End If


        gen = 0
        ctr = 0


    End Sub



    Private Sub btnlogdrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogdrop.Click
        drop = drop + 1

        If drop = 3 Then
            drop = 1
        End If
        pnlogout.BringToFront()
        tmanimate.Start()
    End Sub

    Private Sub tmanimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmanimate.Tick
        If drop = 1 Then
            point = point + 15

            If point >= 363 Then
                tmanimate.Stop()
            Else
                pnlogout.Size = New System.Drawing.Point(265, point)
            End If
        Else
            point = point - 15
            If point <= 10 Then
                tmanimate.Stop()
                pnlogout.SendToBack()
            Else
                pnlogout.Size = New System.Drawing.Point(265, point)
            End If
        End If
    End Sub


    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connect.Open()
        connection.Open()
        Dim reader As SqlDataReader

        Dim search As New SqlDataAdapter("select * from tblcart", connection)
        Dim table As New DataTable
        search.Fill(table)

        Dim save As New SqlCommand("insert into tblhistory" & "(username,access,login,logout)values(@username,@access,@login,@logout)", connection)
        save.Parameters.Add(New SqlParameter("@username", SqlDbType.NVarChar)).Value = lbluser.Text
        save.Parameters.Add(New SqlParameter("@access", SqlDbType.NVarChar)).Value = lblaccess.Text
        save.Parameters.Add(New SqlParameter("@login", SqlDbType.DateTime)).Value = CDate(lbltimeind.Text)
        save.Parameters.Add(New SqlParameter("@logout", SqlDbType.DateTime)).Value = CDate(lbltime.Text)
        save.ExecuteNonQuery()


        If table.Rows.Count > 0 Then

            command = New SqlCommand("select * from tblcart", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblcart where cosid='" & table.Rows(0)(0) & "'", connect)
                Dim deltable As New DataTable
                delete.Fill(deltable)
            End While

            Me.Close()
            Form1.Show()
        Else
            Me.Close()
            Form1.Show()
        End If


    End Sub


    Private Sub btnsalesgraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalesgraph.Click
        pnlshadow.BackColor = Color.White
        TabControl.SelectedTab = tabsalesgraph
        btnodate.PerformClick()
    End Sub


    Private Sub btnbackadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtitemid.Text = ""
        'txtprodname.Text = "Enter Product"
        'cbcategory.Text = ""
        'txtstock.Text = "Enter Stock"
        'txtprice.Text = "Enter Price"
        TabControl.SelectedTab = tabinventory
        pnlbutton.Enabled = True
        pnlbutton.BackColor = Color.White
        pnlshadow.BackColor = Color.GhostWhite
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    End Sub


    Private Sub btnodate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnodate.Click
        drop = 1

        tmghppnl.Start()
        pnlghpdate.Visible = True
        pnlghpdate.Size = New System.Drawing.Point(10, 245)
    End Sub

    Private Sub tmghppnl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmghppnl.Tick
        If drop = 1 Then
            point = point + 15

            If point >= 266 Then
                tmghppnl.Stop()
            Else
                pnlghpdate.Size = New System.Drawing.Point(point, 245)
            End If
        Else
            point = point - 15

            If point <= 10 Then
                tmghppnl.Stop()
                pnlghpdate.Visible = False
                drop = 0
            Else
                pnlghpdate.Size = New System.Drawing.Point(point, 245)
            End If
        End If
    End Sub

    Private Sub btnbpanl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbpanl.Click
        drop = 2
        tmghppnl.Start()
    End Sub

    Private Sub btnsaleback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaleback.Click
        TabControl.SelectedTab = tabsales
        drop = 2
        tmghppnl.Start()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblcart", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            Removeitem.Show()
            shadowback.Show()
            Removeitem.TopMost = True
        Else
            MsgBox("There's No Item in the cart!", vbInformation)
            txtprodn.Select()
        End If


    End Sub

    Private Sub btndefect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefect.Click

        Dim i As Integer = 0
        Dim headerText() As String = {"ITEM ID", "PRODUCT NAME", "AFFECTED STOCK", "VALUE", "DESCRIPTION", "DATE", "ACTION"}

        'pnlInvHeader.Size.Width
        Dim widthOffset As Integer = 20
        Dim headerWidth As Integer = pnlInvHeader.Size.Width - widthOffset
        Dim workingArea As Integer = headerWidth / headerText.Length

        Dim labelOffset As Integer = 10
        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlInvHeader.Size.Height / 2

        Dim headerTextList As New List(Of Control)
        For Each hctrl As Control In pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            If i < headerText.Length Then
                hctrl.Size = New Size(workingArea - labelOffset, hctrl.Size.Height)
                hctrl.Location = New Point((xP + (labelOffset / 2)) - (hctrl.Size.Width / 2), yP - (hctrl.Size.Height / 2))
                hctrl.Text = headerText(i)
                hctrl.Visible = True

                headerTextList.Add(hctrl)
                xP += workingArea
            Else
                hctrl.Visible = False
            End If

            i += 1
        Next

        'Header Offset
        Dim pOffset() As Integer = {-(headerTextList(0).Size.Width / 3), 0, -(headerTextList(2).Size.Width / 2.3), -(headerTextList(3).Size.Width / 1.2), (headerTextList(4).Size.Width / 3), (headerTextList(5).Size.Width / 4)}
        For j As Integer = 0 To headerTextList.Count - 2
            'current text label
            headerTextList(j).Size = New Size(headerTextList(j).Size.Width + pOffset(j), headerTextList(j).Size.Height)

            'next text label
            headerTextList(j + 1).Location = New Point(headerTextList(j + 1).Location.X + pOffset(j), headerTextList(j + 1).Location.Y)
            headerTextList(j + 1).Size = New Size(headerTextList(j + 1).Size.Width - pOffset(j), headerTextList(j + 1).Size.Height)
        Next

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim adaptor As New SqlDataAdapter("SELECT * FROM tbldefect", connection)
        Dim table As New DataTable
        adaptor.Fill(table)

        inventoryPage(1) = Math.Truncate(table.Rows.Count / inventoryPage(2))

        If Not inventoryState = InventoryButtonState.Defect Then
            inventoryState = InventoryButtonState.Defect
            inventoryPage(0) = 0

            Console.WriteLine(inventoryPage(0) & "  " & inventoryPage(1))
            If inventoryPage(0) = inventoryPage(1) Then
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = False
                btnEndPage.Enabled = False
            Else
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = True
                btnEndPage.Enabled = True
            End If
        End If

        While flowlayoutinv.Controls.Count > 0
            Dim invControl As Control = flowlayoutinv.Controls.Item(0)
            flowlayoutinv.Controls.RemoveAt(0)
            invControl.Dispose()
        End While

        Dim command As New SqlCommand("SELECT * FROM tbldefect", connection)
        Dim reader As SqlDataReader = command.ExecuteReader

        Dim currentRow As Integer = 0
        While reader.Read

            If Not (currentRow >= (inventoryPage(0) * inventoryPage(2)) And currentRow < ((inventoryPage(0) * inventoryPage(2)) + inventoryPage(2))) Then
                'Console.WriteLine(currentRow)
                currentRow += 1
                Continue While
            End If

            Dim defctrl As New Defectitem
            With defctrl
                .Margin = New Padding(0)
                .Size = New Size(headerWidth, .Size.Height)

                Dim data(6) As Object
                data(0) = reader.GetInt32(0) 'defect id
                data(1) = reader.GetString(1) 'itemid
                data(2) = reader.GetString(2) 'product name
                data(3) = reader.GetInt32(3) ' affstock
                data(4) = reader.GetDecimal(4) 'value
                data(5) = reader.GetString(5) ' description
                data(6) = reader.GetDateTime(6) ' date
                .AssignData(data)

                .lblItemID.Text = reader.GetString(1).Trim
                .lblprodn.Text = reader.GetString(2)
                .lblAffstock.Text = reader.GetInt32(3).ToString
                .lblValue.Text = reader.GetDecimal(4).ToString
                .lblDesc.Text = reader.GetString(5)

                Dim dt As DateTime = reader.GetDateTime(6)
                .lblDate.Text = Format(dt, "dd-MMMM-yyyy").ToString

                Dim k As Integer = 0
                For Each ctrl As Control In defctrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                    ctrl.Size = headerTextList(k).Size
                    ctrl.Location = headerTextList(k).Location
                    k += 1
                Next

                Dim buttonOffset As Integer = 5
                .btnEdit.Size = New Size((headerTextList(k).Size.Width / 3) - buttonOffset, .btnEdit.Size.Height)
                .btnEdit.Location = New Point(headerTextList(k).Location.X + (buttonOffset / 2), (.Height / 2) - .btnEdit.Size.Height / 2)

                .btnReturn.Size = New Size((headerTextList(k).Size.Width / 3) - buttonOffset, .btnReturn.Size.Height)
                .btnReturn.Location = New Point(headerTextList(k).Location.X + (buttonOffset / 2) + (headerTextList(k).Size.Width / 3), (.Height / 2) - .btnReturn.Size.Height / 2)

                .btndelete.Size = New Size((headerTextList(k).Size.Width / 3) - buttonOffset, .btndelete.Size.Height)
                .btndelete.Location = New Point(headerTextList(k).Location.X + ((headerTextList(k).Size.Width / 3) * 2) + (buttonOffset / 2), (.Height / 2) - .btndelete.Size.Height / 2)

            End With
            flowlayoutinv.Controls.Add(defctrl)
            currentRow += 1

        End While
        connection.Close()

        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connection.Open()
        'Dim reader As SqlDataReader

        'flowlayoutinv.Controls.Clear()
        'Try
        '    command = New SqlCommand("select * from tbldefect", connection)
        '    reader = command.ExecuteReader
        '    While reader.Read
        '        Dim defectpanel As Defectitem
        '        defectpanel = New Defectitem
        '        defectpanel.Margin = New Padding(0)
        '        ctr = ctr + 1

        '        If ctr = 1 Then
        '            With defectpanel
        '                .lblitemid.Text = reader.GetString(0)
        '                .lblprodn.Text = reader.GetString(1)
        '                .lblstock.Text = reader.GetString(2)
        '                .lbldesc.Text = reader.GetString(3)
        '                .lblaname.Text = reader.GetString(4)
        '                .BackColor = Color.White
        '            End With
        '        Else
        '            With defectpanel
        '                .lblitemid.Text = reader.GetString(0)
        '                .lblprodn.Text = reader.GetString(1)
        '                .lblstock.Text = reader.GetString(2)
        '                .lbldesc.Text = reader.GetString(3)
        '                .lblaname.Text = reader.GetString(4)
        '                .BackColor = Color.GhostWhite
        '            End With
        '            ctr = 0
        '        End If

        '        flowlayoutinv.Controls.Add(defectpanel)

        '    End While
        '    ctr = 0
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'defect = True



        'lblstock.Text = "DESCRIPTION"

        'lblcat.Text = "STOCK"
        'lblstock.Visible = True
        'lblcat.Location = New System.Drawing.Point(567, 10)
        'lblaction.Location = New System.Drawing.Point(1210, 10)
        'lblprice.Location = New System.Drawing.Point(961, 10)

        'lblprice.Text = "USERNAME"
        'lblprice.Visible = True

        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(TransparentPanel1, Color.Black, 20, 7, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub

    Private Sub btnexpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexpired.Click

        Dim i As Integer = 0
        Dim headerText() As String = {"ITEM ID", "PRODUCT NAME", "EXPIRY DATE", "STOCK EXPIRED", "STATUS", "ACTION"}

        Dim widthOffset As Integer = 17
        Dim headerWidth As Integer = pnlInvHeader.Size.Width - widthOffset
        Dim workingArea As Integer = headerWidth / headerText.Length

        Dim labelOffset As Integer = 10
        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlInvHeader.Size.Height / 2


        Dim headerTextList As New List(Of Control)
        For Each hctrl As Control In pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            If i < headerText.Length Then
                hctrl.Size = New Size(workingArea - labelOffset, hctrl.Size.Height)
                hctrl.Location = New Point(xP - (hctrl.Size.Width / 2) + (labelOffset / 2), yP - (hctrl.Size.Height / 2))
                hctrl.Text = headerText(i)
                hctrl.Visible = True

                headerTextList.Add(hctrl)
                xP += workingArea
            Else
                hctrl.Visible = False
            End If

            i += 1
        Next

        Dim pOffset() As Integer = {-(headerTextList(0).Size.Width / 3), (headerTextList(2).Size.Width / 1.8), (headerTextList(2).Size.Width / 2), (headerTextList(3).Size.Width * 0.4), (headerTextList(4).Size.Width / 3)}
        For j As Integer = 0 To headerTextList.Count - 2
            'current text label
            headerTextList(j).Size = New Size(headerTextList(j).Size.Width + pOffset(j), headerTextList(j).Size.Height)

            'next text label
            headerTextList(j + 1).Location = New Point(headerTextList(j + 1).Location.X + pOffset(j), headerTextList(j + 1).Location.Y)
            headerTextList(j + 1).Size = New Size(headerTextList(j + 1).Size.Width - pOffset(j), headerTextList(j + 1).Size.Height)
        Next

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim adaptor As New SqlDataAdapter("SELECT * FROM tblinventory WHERE expdt <= '" & DateTime.Today & "'", connection)
        Dim table As New DataTable
        adaptor.Fill(table)

        inventoryPage(1) = Math.Truncate(table.Rows.Count / inventoryPage(2))

        If Not inventoryState = InventoryButtonState.Expired Then
            inventoryState = InventoryButtonState.Expired
            inventoryPage(0) = 0

            Console.WriteLine(inventoryPage(0) & "  " & inventoryPage(1))
            If inventoryPage(0) = inventoryPage(1) Then
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = False
                btnEndPage.Enabled = False
            Else
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = True
                btnEndPage.Enabled = True
            End If
        End If

        While flowlayoutinv.Controls.Count > 0
            Dim invControl As Control = flowlayoutinv.Controls.Item(0)
            flowlayoutinv.Controls.RemoveAt(0)
            invControl.Dispose()
        End While

        Dim command As New SqlCommand("SELECT * FROM tblinventory WHERE expdt <= '" & DateTime.Today & "'", connection)
        Dim reader As SqlDataReader = command.ExecuteReader

        Dim currentRow As Integer = 0
        While reader.Read

            If Not (currentRow >= (inventoryPage(0) * inventoryPage(2)) And currentRow < ((inventoryPage(0) * inventoryPage(2)) + inventoryPage(2))) Then
                'Console.WriteLine(currentRow)
                currentRow += 1
                Continue While
            End If

            Dim expCtrl As New Expireditemdata
            With expCtrl
                .Margin = New Padding(0)
                .Size = New Size(headerWidth, .Size.Height)

                Dim rowData(7) As Object
                'inventory id
                rowData(0) = reader.GetInt32(0)
                'item id / number
                rowData(1) = reader.GetString(1)
                'product name
                rowData(2) = reader.GetString(2)
                'category
                rowData(3) = reader.GetString(3)

                'date
                If reader.IsDBNull(4) Then
                    rowData(4) = Nothing
                Else
                    rowData(4) = reader.GetDateTime(4)
                End If

                'stock
                rowData(5) = reader.GetInt32(5)
                'price
                rowData(6) = reader.GetDecimal(6)
                'isExp (is Expiration active)
                rowData(7) = reader.GetBoolean(7)
                .AssignData(rowData)

                .lblitemid.Text = reader.GetString(1).ToString.Trim
                .lblprodn.Text = reader.GetString(2).ToString.Trim
                .lbldatexpire.Text = Format(DateTime.Parse(reader.GetDateTime(4)), "dd MMMM yyyy").ToString
                .lblstockexp.Text = Convert.ToInt32(reader.GetInt32(5))

                .lblitemid.TextAlign = ContentAlignment.MiddleCenter

                Dim j As Integer = 0
                For Each ctrl As Control In expCtrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                    ctrl.Size = headerTextList(j).Size
                    ctrl.Location = headerTextList(j).Location
                    j += 1
                Next

                .btnMoveDefect.Size = New Size(headerTextList(j).Size.Width - labelOffset, .btnMoveDefect.Size.Height)
                .btnMoveDefect.Location = New Point(headerTextList(j).Location.X + (labelOffset / 2), (.Size.Height / 2) - (.btnMoveDefect.Size.Height / 2))


            End With
            flowlayoutinv.Controls.Add(expCtrl)
            currentRow += 1

        End While
        connection.Close()

    End Sub



    Private Sub btnadcsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadcsearch.Click
        AdvanceSearch.Show()
        shadowback.Show()
        AdvanceSearch.TopMost = True
        AdvanceSearch.txtsearch.Select()
    End Sub


    Private Sub btnsavePOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavePOS.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblcart", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            SavePOS.Show()
            shadowback.Show()
            SavePOS.TopMost = True
        Else
            MsgBox("Please Order An Item First!", vbInformation)

            If cbscan.Checked = True Then
                txtitemcode.Select()
            Else
                txtprodn.Select()
            End If

        End If


    End Sub


    Private Sub btnexpr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If btns = False Then
        '    dtpexpr.Enabled = True
        '    btns = True
        'Else
        '    dtpexpr.Enabled = False
        '    btns = False
        'End If

    End Sub




    'Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim search As New SqlDataAdapter("select * from tblcart", connection)
    '    Dim table As New DataTable
    '    search.Fill(table)

    '    If table.Rows.Count > 0 Then
    '        Defectform.Show()
    '        shadowback.Show()
    '        Defectform.TopMost = True
    '    Else
    '        MsgBox("There's No Item in the cart!", vbInformation)
    '        txtprodn.Select()
    '    End If

    'End Sub

    Private Sub btnsavePOS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnsavePOS.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnsavePOS.PerformClick()
        End If
    End Sub



    Private Sub txtitemcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemcode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnadd.PerformClick()
            txtitemcode.Select()
        End If


    End Sub

    Private Sub txtitemcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemcode.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnsavePOS.PerformClick()
        End If

        If e.KeyCode = Keys.F2 Then
            btnreft.PerformClick()
        End If

        If e.KeyCode = Keys.F3 Then
            btnremove.PerformClick()
        End If

        If e.KeyCode = Keys.F4 Then
            btnreturn.PerformClick()
        End If

        If e.KeyCode = Keys.F5 Then
            btnadcsearch.PerformClick()
        End If

        If e.KeyCode = Keys.F6 Then
            btnmult.PerformClick()
        End If
    End Sub




    Private Sub btneditem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If bool = True Then
        '    txtitemid.Enabled = True
        '    txtitemid.Text = ""
        '    txtitemid.Select()
        '    bool = False
        'Else
        '    txtitemid.Enabled = False
        '    itemidgen()
        '    bool = True
        'End If

    End Sub


    Private Sub txtquantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back AndAlso Asc(e.KeyChar) <> Keys.Return Then
            e.Handled = True
        End If

        If scan = True Then
            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                If Not txtitemcode.Text = "" Then
                    btnadd.PerformClick()
                Else
                    txtitemcode.Select()
                End If

            End If
        Else
            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                If Not txtprodn.Text = "" Then
                    btnadd.PerformClick()
                Else
                    txtprodn.Select()
                End If


            End If
        End If
    End Sub

    Private Sub cbscan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbscan.CheckedChanged
        If cbscan.Checked = True Then
            scan = True
            txtquantity.Text = "1"
            txtitemcode.Text = ""

            txtprodn.Enabled = False
            txtitemcode.Enabled = True
            'GunaLabel18.Visible = False
            'lblproduct.Visible = False
            txtitemcode.Select()
        Else
            scan = False
            txtquantity.Text = "1"

            txtprodn.Text = ""
            txtprodn.Enabled = True
            txtitemcode.Enabled = False
            'GunaLabel18.Visible = False
            'lblproduct.Visible = False
            txtprodn.Select()
        End If
    End Sub

    Private Sub btnmult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmult.Click
        txtquantity.Enabled = True
        txtquantity.Text = ""
        txtquantity.Select()

        btnmult.BaseColor = System.Drawing.Color.FromArgb(188, 48, 40)
    End Sub


    Private Sub txtprodn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprodn.TextChanged
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If txtprodn.Text.Contains("""") Or txtprodn.Text.Contains("'") Then
            MsgBox("Double and single quotes are prohibited!", vbInformation)
            txtprodn.Text = ""
        Else
            If checkstr(txtprodn.Text, "specials") = True Then

                txtprodn.FocusedBorderColor = Color.FromArgb(100, 88, 255)

                If scan = False Then
                    If txtprodn.Text = "" Then
                        'code
                        btnreft.PerformClick()
                        'GunaLabel18.Visible = False
                        'lblproduct.Visible = False
                    Else
                        'code
                        Dim search As New SqlDataAdapter("select * from tblinventory where prodn like '%" & txtprodn.Text & "%'", connection)
                        Dim table As New DataTable
                        search.Fill(table)

                        If table.Rows.Count > 0 Then
                            txtitemcode.Text = table.Rows(0)(1)
                            txtPOSprice.Text = table.Rows(0)(6)
                            'lblproduct.Text = table.Rows(0)(2)
                            'lblcategor.Text = table.Rows(0)(3)

                            ' GunaLabel18.Visible = True
                            'lblproduct.Visible = True
                        End If

                    End If

                End If
            Else
                txtprodn.FocusedBorderColor = Color.FromArgb(201, 0, 0)
            End If
        End If





    End Sub

    Private Sub txtprodn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprodn.KeyPress
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Dim search As New SqlDataAdapter("select * from tblinventory where prodn like '%" & txtprodn.Text & "%'", connection)
            Dim table As New DataTable
            search.Fill(table)

            Dim find As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemcode.Text & "'", connection)
            Dim tablefind As New DataTable
            find.Fill(tablefind)

            If tablefind.Rows.Count > 0 Then
                txtprodn.Text = tablefind.Rows(0)(2)
            End If

            btnadd.PerformClick()
        End If
    End Sub

    Private Sub txtprodn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprodn.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnsavePOS.PerformClick()
        End If

        If e.KeyCode = Keys.F2 Then
            btnreft.PerformClick()
        End If

        If e.KeyCode = Keys.F3 Then
            btnremove.PerformClick()
        End If

        If e.KeyCode = Keys.F4 Then
            btnreturn.PerformClick()
        End If

        If e.KeyCode = Keys.F5 Then
            btnadcsearch.PerformClick()
        End If

        If e.KeyCode = Keys.F6 Then
            btnmult.PerformClick()
        End If
    End Sub


    Private Sub btnreft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreft.Click
        If scan = False Then
            txtitemcode.Text = ""
            txtquantity.Text = "1"
            txtPOSprice.Text = ""
            txtprodn.Text = ""
            ' lblcategor.Text = ""
            txtprodn.Select()
        Else
            txtitemcode.Text = ""
            txtquantity.Text = "1"
            txtPOSprice.Text = ""
            'lblcategor.Text = ""
            txtprodn.Text = ""
            txtitemcode.Select()
        End If


    End Sub

    Private Sub btninvref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninvref.Click

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        'inventory refresh
        'inventory_refresh()

        Dim i As Integer = 0
        Dim headerText() As String = {"ITEM ID", "PRODUCT NAME", "CATEGORY", "STOCK", "PRICE", "ACTION"}

        Dim widthOffset As Integer = 17
        Dim headerWidth As Integer = pnlInvHeader.Size.Width - widthOffset
        Dim workingArea As Integer = headerWidth / headerText.Length

        Dim labelOffset As Integer = 10
        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlInvHeader.Size.Height / 2


        Dim headerTextList As New List(Of Control)
        For Each hctrl As Control In pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            If i < headerText.Length Then
                hctrl.Size = New Size(workingArea - labelOffset, hctrl.Size.Height)
                hctrl.Location = New Point(xP - (hctrl.Size.Width / 2) + (labelOffset / 2), yP - (hctrl.Size.Height / 2))
                hctrl.Text = headerText(i)
                hctrl.Visible = True

                headerTextList.Add(hctrl)
                xP += workingArea
            Else
                hctrl.Visible = False
            End If
            i += 1
        Next

        Dim pOffset() As Integer = {-(headerTextList(0).Size.Width / 3), (headerTextList(1).Size.Width * 1), (headerTextList(2).Size.Width / 2), (headerTextList(3).Size.Width * 0.4), (headerTextList(4).Size.Width / 3)}
        For j As Integer = 0 To headerTextList.Count - 2
            'current text label
            headerTextList(j).Size = New Size(headerTextList(j).Size.Width + pOffset(j), headerTextList(j).Size.Height)

            'next text label
            headerTextList(j + 1).Location = New Point(headerTextList(j + 1).Location.X + pOffset(j), headerTextList(j + 1).Location.Y)
            headerTextList(j + 1).Size = New Size(headerTextList(j + 1).Size.Width - pOffset(j), headerTextList(j + 1).Size.Height)
        Next

        'Dim adapter As New SqlDataAdapter("DELETE FROM tblinventory WHERE invid='" & 3 & "'", connection)
        'Dim dt As New DataTable
        'adapter.Fill(dt)
        'Return


        'POPULATING DATA FROM DATABASE

        Dim adaptor As New SqlDataAdapter("SELECT * FROM tblinventory", connection)
        Dim table As New DataTable
        adaptor.Fill(table)

        inventoryPage(1) = Math.Truncate(table.Rows.Count / inventoryPage(2))

        If Not inventoryState = InventoryButtonState.Item Then
            inventoryState = InventoryButtonState.Item
            inventoryPage(0) = 0

            Console.WriteLine(inventoryPage(0) & "  " & inventoryPage(1))
            If inventoryPage(0) = inventoryPage(1) Then
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = False
                btnEndPage.Enabled = False
            Else
                btnStartPage.Enabled = False
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = True
                btnEndPage.Enabled = True
            End If
        End If

        Dim command As New SqlCommand("SELECT * FROM tblinventory", connection)
        Dim reader As SqlDataReader = command.ExecuteReader

        While flowlayoutinv.Controls.Count > 0
            Dim invControl As Control = flowlayoutinv.Controls.Item(0)
            flowlayoutinv.Controls.RemoveAt(0)
            invControl.Dispose()
        End While

        Dim currentRow As Integer = 0
        While reader.Read

            If Not (currentRow >= (inventoryPage(0) * inventoryPage(2)) And currentRow < ((inventoryPage(0) * inventoryPage(2)) + inventoryPage(2))) Then
                'Console.WriteLine(currentRow)
                currentRow += 1
                Continue While
            End If

            'Console.WriteLine(currentRow)
            Dim ctrl As New InvDatapanel
            With ctrl
                .Margin = New Padding(0)
                .Width = headerWidth

                Dim rowData(7) As Object
                'inventory id
                rowData(0) = reader.GetInt32(0)
                'item id / number
                rowData(1) = reader.GetString(1)
                'product name
                rowData(2) = reader.GetString(2)
                'category
                rowData(3) = reader.GetString(3)

                'date
                If reader.IsDBNull(4) Then
                    rowData(4) = Nothing
                Else
                    rowData(4) = reader.GetDateTime(4)
                End If

                'stock
                rowData(5) = reader.GetInt32(5)
                'price
                rowData(6) = reader.GetDecimal(6)
                'isExp (is Expiration active)
                rowData(7) = reader.GetBoolean(7)
                'assign raw data
                .ControlData(rowData)

                'Populate data
                .lblitemid.Text = reader.GetString(1).Trim
                .lblproductn.Text = reader.GetString(2).Trim
                .lblcat.Text = reader.GetString(3).Trim
                .lblstock.Text = reader.GetInt32(5).ToString
                .lblprice.Text = DecimalToStringFormat(Decimal.ToDouble(reader.GetDecimal(6)))

                'Offsets
                Dim j As Integer = 0
                For Each c As Control In ctrl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                    c.Size = headerTextList(j).Size
                    c.Location = headerTextList(j).Location
                    j += 1
                Next

                .btnaddstk.Size = New Size((headerTextList(j).Size.Width / 2) - labelOffset, .btnaddstk.Size.Height)
                .btnaddstk.Location = New Point(headerTextList(j).Location.X + (labelOffset / 2), (.Size.Height / 2) - (.btnaddstk.Size.Height / 2))

                .btndelete.Size = New Size((headerTextList(j).Size.Width / 2) - labelOffset, .btndelete.Size.Height)
                .btndelete.Location = New Point(headerTextList(j).Location.X + .btnaddstk.Size.Width + labelOffset, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

                .pnlbutton.Size = New Size(headerTextList(j).Size.Width, .pnlbutton.Height)
                .pnlbutton.Location = New Point(headerTextList(j).Location.X, (.Size.Height / 2) - (.pnlbutton.Size.Height / 2))

            End With
            flowlayoutinv.Controls.Add(ctrl)
            currentRow += 1


        End While
        connection.Close()
        'lblstock.Text = "STOCK"

        'lblcat.Text = "CATEGORY"
        ''lblcat.Location = New System.Drawing.Point(573, 10)
        ''lblaction.Location = New System.Drawing.Point(1162, 10)
        ''lblprice.Location = New System.Drawing.Point(961, 10)
        'lblprice.Text = "PRICE"
        'lblstock.Visible = True
        'lblprice.Visible = True

    End Sub

    Private Sub txtsearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnsearch.PerformClick()
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader

        If edit = True Then

            flowlayoutinv.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("select * from tblinventory where prodn like '%" & txtsearch.Text & "%'", connection)
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
                            .pnlbutton.Visible = True
                        End With
                    Else
                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = Color.GhostWhite
                            .pnlbutton.Visible = True
                        End With
                        ctr = 0
                    End If
                    flowlayoutinv.Controls.Add(inv)
                End While
                ctr = 0
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If ofs = True Then
            flowlayoutinv.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("select * from tblinventory where stock='" & 0 & "' and prodn like '%" & txtsearch.Text & "%'", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim invpanel As InvDatapanel
                    invpanel = New InvDatapanel

                    ctr = ctr + 1
                    If ctr = 1 Then
                        With invpanel
                            .pnlbutton.Visible = False
                            .btndelete.Visible = False
                            .btnaddstk.Location = New System.Drawing.Point(1101, 7)
                            .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
                            .lblitemid.ForeColor = Color.White
                            .lblproductn.ForeColor = Color.White
                            .lblcat.ForeColor = Color.White
                            .lblstock.ForeColor = Color.White
                            .lblprice.ForeColor = Color.White
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                        End With
                    Else
                        With invpanel
                            .pnlbutton.Visible = False
                            .btndelete.Visible = False
                            .btnaddstk.Location = New System.Drawing.Point(1101, 6)
                            .BackColor = System.Drawing.Color.FromArgb(223, 48, 40)
                            .lblitemid.ForeColor = Color.White
                            .lblproductn.ForeColor = Color.White
                            .lblcat.ForeColor = Color.White
                            .lblstock.ForeColor = Color.White
                            .lblprice.ForeColor = Color.White
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                        End With
                        ctr = 0
                    End If
                    flowlayoutinv.Controls.Add(invpanel)
                End While
                ctr = 0
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If defect = True Then
            flowlayoutinv.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("select * from tbldefect where prod like '%" & txtsearch.Text & "%'", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim defectpanel As Defectitem
                    defectpanel = New Defectitem

                    ctr = ctr + 1

                    If ctr = 1 Then
                        With defectpanel
                            .lblItemID.Text = reader.GetString(0)
                            .lblprodn.Text = reader.GetString(1)
                            .lblAffstock.Text = reader.GetString(2)
                            .lblValue.Text = reader.GetString(3)
                            '.lblaname.Text = reader.GetString(4)
                            .BackColor = Color.White
                        End With
                    Else
                        With defectpanel
                            .lblItemID.Text = reader.GetString(0)
                            .lblprodn.Text = reader.GetString(1)
                            .lblAffstock.Text = reader.GetString(2)
                            .lblValue.Text = reader.GetString(3)
                            '.lblaname.Text = reader.GetString(4)
                            .BackColor = Color.GhostWhite
                        End With
                        ctr = 0
                    End If

                    flowlayoutinv.Controls.Add(defectpanel)

                End While
                ctr = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If edit = False And ofs = False And defect = False Then
            flowlayoutinv.Controls.Clear()
            Try
                connection.Open()
                command = New SqlCommand("select * from tblinventory where prodn like '%" & txtsearch.Text & "%'", connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim inv As InvDatapanel
                    inv = New InvDatapanel

                    If reader.GetString(5) = 0 Then
                        With inv
                            .lblitemid.Text = reader.GetString(1)
                            .lblproductn.Text = reader.GetString(2)
                            .lblcat.Text = reader.GetString(3)
                            .lblstock.Text = reader.GetString(5)
                            .lblprice.Text = reader.GetString(6)
                            .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
                            .pnlbutton.Visible = False
                            .lblitemid.ForeColor = Color.White
                            .lblproductn.ForeColor = Color.White
                            .lblcat.ForeColor = Color.White
                            .lblstock.ForeColor = Color.White
                            .lblprice.ForeColor = Color.White
                        End With
                    Else
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
                    End If
                    flowlayoutinv.Controls.Add(inv)
                End While
                ctr = 0
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        txtsearch.Select()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader


        If edit = True Then
            If txtsearch.Text = "" Then
                flowlayoutinv.Controls.Clear()
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
                                .pnlbutton.Visible = True
                            End With
                        Else
                            With inv
                                .lblitemid.Text = reader.GetString(1)
                                .lblproductn.Text = reader.GetString(2)
                                .lblcat.Text = reader.GetString(3)
                                .lblstock.Text = reader.GetString(5)
                                .lblprice.Text = reader.GetString(6)
                                .BackColor = Color.GhostWhite
                                .pnlbutton.Visible = True
                            End With
                            ctr = 0
                        End If
                        flowlayoutinv.Controls.Add(inv)
                    End While
                    ctr = 0
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If

        If ofs = True Then
            If txtsearch.Text = "" Then
                connection.Open()
                flowlayoutinv.Controls.Clear()
                Try
                    command = New SqlCommand("select * from tblinventory where stock='" & 0 & "'", connection)
                    reader = command.ExecuteReader
                    While reader.Read
                        Dim inv As InvDatapanel
                        inv = New InvDatapanel

                        If reader.GetString(5) = 0 Then
                            ctr = ctr + 1

                            If ctr = 1 Then
                                With inv
                                    .lblitemid.Text = reader.GetString(1)
                                    .lblproductn.Text = reader.GetString(2)
                                    .lblcat.Text = reader.GetString(3)
                                    .lblstock.Text = reader.GetString(5)
                                    .lblprice.Text = reader.GetString(6)
                                    .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
                                    .pnlbutton.Visible = False
                                    .btndelete.Visible = False
                                    .lblitemid.ForeColor = Color.White
                                    .lblproductn.ForeColor = Color.White
                                    .lblcat.ForeColor = Color.White
                                    .lblstock.ForeColor = Color.White
                                    .lblprice.ForeColor = Color.White
                                End With
                            Else
                                With inv
                                    .lblitemid.Text = reader.GetString(1)
                                    .lblproductn.Text = reader.GetString(2)
                                    .lblcat.Text = reader.GetString(3)
                                    .lblstock.Text = reader.GetString(5)
                                    .lblprice.Text = reader.GetString(6)
                                    .BackColor = System.Drawing.Color.FromArgb(223, 48, 40)
                                    .pnlbutton.Visible = False
                                    .btndelete.Visible = False
                                    .lblitemid.ForeColor = Color.White
                                    .lblproductn.ForeColor = Color.White
                                    .lblcat.ForeColor = Color.White
                                    .lblstock.ForeColor = Color.White
                                    .lblprice.ForeColor = Color.White
                                End With
                                ctr = 0
                            End If

                        End If
                        flowlayoutinv.Controls.Add(inv)
                    End While
                    ctr = 0
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        If defect = True Then
            If txtsearch.Text = "" Then
                flowlayoutinv.Controls.Clear()
                Try
                    connection.Open()
                    command = New SqlCommand("select * from tbldefect", connection)
                    reader = command.ExecuteReader
                    While reader.Read
                        Dim defectpanel As Defectitem
                        defectpanel = New Defectitem

                        ctr = ctr + 1

                        If ctr = 1 Then
                            With defectpanel
                                .lblItemID.Text = reader.GetString(0)
                                .lblprodn.Text = reader.GetString(1)
                                .lblAffstock.Text = reader.GetString(2)
                                .lblValue.Text = reader.GetString(3)
                                '.lblaname.Text = reader.GetString(4)
                                .BackColor = Color.White
                            End With
                        Else
                            With defectpanel
                                .lblItemID.Text = reader.GetString(0)
                                .lblprodn.Text = reader.GetString(1)
                                .lblAffstock.Text = reader.GetString(2)
                                .lblValue.Text = reader.GetString(3)
                                '.lblaname.Text = reader.GetString(4)
                                .BackColor = Color.GhostWhite
                            End With
                            ctr = 0
                        End If

                        flowlayoutinv.Controls.Add(defectpanel)

                    End While
                    ctr = 0
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        If edit = False And ofs = False And defect = False Then
            If txtsearch.Text = "" Then
                flowlayoutinv.Controls.Clear()
                Try
                    connection.Open()
                    command = New SqlCommand("select * from tblinventory", connection)
                    reader = command.ExecuteReader
                    While reader.Read
                        Dim inv As InvDatapanel
                        inv = New InvDatapanel

                        If reader.GetString(5) = 0 Then
                            With inv
                                .lblitemid.Text = reader.GetString(1)
                                .lblproductn.Text = reader.GetString(2)
                                .lblcat.Text = reader.GetString(3)
                                .lblstock.Text = reader.GetString(5)
                                .lblprice.Text = reader.GetString(6)
                                .BackColor = System.Drawing.Color.FromArgb(188, 48, 40)
                                .pnlbutton.Visible = False
                                .lblitemid.ForeColor = Color.White
                                .lblproductn.ForeColor = Color.White
                                .lblcat.ForeColor = Color.White
                                .lblstock.ForeColor = Color.White
                                .lblprice.ForeColor = Color.White
                            End With
                        Else
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
                        End If
                        flowlayoutinv.Controls.Add(inv)
                    End While
                    ctr = 0
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If





    End Sub

    Private Sub txtitemcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemcode.TextChanged
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader

        If checkstr(txtitemcode.Text, "letterpsecial") = True Then
            If cbscan.Checked = True Then
                If txtitemcode.Text = "" Then
                    btnreft.PerformClick()
                Else
                    Dim search As New SqlDataAdapter("select * from tblinventory where itemid like'%" & txtitemcode.Text & "%'", connection)
                    Dim table As New DataTable
                    search.Fill(table)

                    If table.Rows.Count > 0 Then
                        txtprodn.Text = table.Rows(0)(2)
                        txtPOSprice.Text = table.Rows(0)(6)
                        'lblcategor.Text = table.Rows(0)(3)
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btngphday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngphday.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        SalesChart.Series("Profit").Points.Clear()
        Try

            command = New SqlCommand("select * from tblchart where date like '%" & Format(Today, "dd MMMM yyyy") & "%' ORDER BY date ASC", connection)
            reader = command.ExecuteReader

            lbltploss.Text = "0"
            lbltprofit.Text = "0"
            lbloprofit.Text = "0"

            While reader.Read
                Dim tt As String = Format(CDate(reader.GetString(2)), "tt")
                If tt = "AM" Then
                    SalesChart.Series("Profit").Points.AddXY(Format(CDate(reader.GetString(2)), "hh:mm tt"), reader.GetString(1))
                End If
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where date like '%" & Format(Today, "dd MMMM yyyy") & "%' ORDER BY date ASC", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim tt As String = Format(CDate(reader.GetString(2)), "tt")
                If tt = "PM" Then
                    SalesChart.Series("Profit").Points.AddXY(Format(CDate(reader.GetString(2)), "hh:mm tt"), reader.GetString(1))
                End If
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "expenses" & "'and date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltploss.Text += Val(RTrim(reader.GetString(1)))
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "profit" & "'and date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltprofit.Text += Val(reader.GetString(1))
            End While

            lbloprofit.Text = Val(lbltprofit.Text) + Val(lbltploss.Text)

            Dim profitloss As Double = Val(lbltploss.Text)

            If profitloss = Int(profitloss) Then
                lbltploss.Text = profitloss.ToString("N")
            Else
                lbltploss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim profit As Double = Val(lbltprofit.Text)

            If profit = Int(profit) Then
                lbltprofit.Text = "+" & profit.ToString("N")
            Else
                lbltprofit.Text = "+" & profit.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim price As Double = Val(lbloprofit.Text)

            If price = Int(price) Then
                lbloprofit.Text = price.ToString("N")
            Else
                lbloprofit.Text = price.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        btnbpanl.PerformClick()
    End Sub


    Private Sub btnghpmonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnghpmonth.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        SalesChart.Series("Profit").Points.Clear()
        Try

            command = New SqlCommand("select * from tblchart where date like '%" & Format(Today, "MMMM yyyy") & "%' ORDER BY date ASC", connection)
            reader = command.ExecuteReader

            lbltploss.Text = "0"
            lbltprofit.Text = "0"
            lbloprofit.Text = "0"

            While reader.Read
                SalesChart.Series("Profit").Points.AddXY(Format(CDate(reader.GetString(2)), "dd MMMM"), reader.GetString(1))
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "expenses" & "'and date like '%" & Format(Today, "MMMM yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltploss.Text += Val(RTrim(reader.GetString(1)))
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "profit" & "'and date like '%" & Format(Today, "MMMM yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltprofit.Text += Val(reader.GetString(1))
            End While

            lbloprofit.Text = Val(lbltprofit.Text) + Val(lbltploss.Text)

            Dim profitloss As Double = Val(lbltploss.Text)

            If profitloss = Int(profitloss) Then
                lbltploss.Text = profitloss.ToString("N")
            Else
                lbltploss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim profit As Double = Val(lbltprofit.Text)

            If profit = Int(profit) Then
                lbltprofit.Text = "+" & profit.ToString("N")
            Else
                lbltprofit.Text = "+" & profit.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim price As Double = Val(lbloprofit.Text)

            If price = Int(price) Then
                lbloprofit.Text = price.ToString("N")
            Else
                lbloprofit.Text = price.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnbpanl.PerformClick()
    End Sub

    Private Sub btnghpannual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnghpannual.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim reader As SqlDataReader
        connection.Open()

        SalesChart.Series("Profit").Points.Clear()
        Try

            command = New SqlCommand("select * from tblchart where date like '%" & Format(Today, "yyyy") & "%' ORDER BY date ASC", connection)
            reader = command.ExecuteReader

            lbltploss.Text = "0"
            lbltprofit.Text = "0"
            lbloprofit.Text = "0"

            While reader.Read
                SalesChart.Series("Profit").Points.AddXY(Format(CDate(reader.GetString(2)), "MMMM yyyy"), reader.GetString(1))
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "expenses" & "'and date like '%" & Format(Today, "yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltploss.Text += Val(RTrim(reader.GetString(1)))
            End While

            connection.Close()
            connection.Open()

            command = New SqlCommand("select * from tblchart where no='" & "profit" & "'and date like '%" & Format(Today, "yyyy") & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                lbltprofit.Text += Val(reader.GetString(1))
            End While

            lbloprofit.Text = Val(lbltprofit.Text) + Val(lbltploss.Text)

            Dim profitloss As Double = Val(lbltploss.Text)

            If profitloss = Int(profitloss) Then
                lbltploss.Text = profitloss.ToString("N")
            Else
                lbltploss.Text = profitloss.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim profit As Double = Val(lbltprofit.Text)

            If profit = Int(profit) Then
                lbltprofit.Text = "+" & profit.ToString("N")
            Else
                lbltprofit.Text = "+" & profit.ToString("N", CultureInfo.InvariantCulture)
            End If

            Dim price As Double = Val(lbloprofit.Text)

            If price = Int(price) Then
                lbloprofit.Text = price.ToString("N")
            Else
                lbloprofit.Text = price.ToString("N", CultureInfo.InvariantCulture)
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnbpanl.PerformClick()
    End Sub

    Private Sub lblprofitloss_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprofitloss.TextChanged
        lblovera.Text = Val(lblprofit.Text) - Val(lblprofitloss.Text)
    End Sub

    'Private Sub txtcatsch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Return

    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    Dim reader As SqlDataReader
    '    connection.Open()


    '    Try
    '        If txtcatsch.Text.Contains("""") Or txtcatsch.Text.Contains("'") Then
    '            MsgBox("Double Quotes And Single Quotes Are Prohibited", vbInformation)
    '        Else

    '            If txtcatsch.Text = "" Then

    '                'category data refresh
    '                flowlayoutCAT.Controls.Clear()
    '                command = New SqlCommand("select * from tblcat", connection)
    '                reader = command.ExecuteReader
    '                While reader.Read

    '                    'If Not cbcategory.Items.Contains(reader.GetString(1)) Then
    '                    '    cbcategory.Items.Add(reader.GetString(1))
    '                    'End If

    '                    Dim cats As categorydata
    '                    cats = New categorydata
    '                    ctr = ctr + 1

    '                    cats.Margin = New Padding(0)

    '                    If ctr = 1 Then
    '                        With cats
    '                            .lblno.Text = reader.GetString(0)
    '                            .lblcat.Text = reader.GetString(1)
    '                            .BackColor = Color.GhostWhite
    '                        End With

    '                    Else
    '                        With cats
    '                            .lblno.Text = reader.GetString(0)
    '                            .lblcat.Text = reader.GetString(1)
    '                            .BackColor = Color.GhostWhite
    '                        End With
    '                    End If
    '                    flowlayoutCAT.Controls.Add(cats)
    '                End While
    '                ctr = 0
    '                connection.Close()


    '            Else

    '                command = New SqlCommand("select * from tblcat where cat like '%" & txtcatsch.Text & "%'", connection)
    '                reader = command.ExecuteReader
    '                flowlayoutCAT.Controls.Clear()

    '                While reader.Read
    '                    Dim cats As categorydata
    '                    cats = New categorydata
    '                    ctr = ctr + 1
    '                    cats.Margin = New Padding(0)

    '                    If ctr = 1 Then
    '                        With cats
    '                            .lblno.Text = reader.GetString(0)
    '                            .lblcat.Text = reader.GetString(1)
    '                            .BackColor = Color.GhostWhite
    '                        End With

    '                    Else
    '                        With cats
    '                            .lblno.Text = reader.GetString(0)
    '                            .lblcat.Text = reader.GetString(1)
    '                            .BackColor = Color.GhostWhite
    '                        End With
    '                    End If
    '                    flowlayoutCAT.Controls.Add(cats)
    '                End While

    '            End If
    '        End If

    '        connection.Close()
    '    Catch ex As Exception
    '        MsgBox("Error Category Search" & " " & ex.Message)
    '    End Try


    'End Sub


    Private Sub lblovera_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblovera.TextChanged
        If Val(lblovera.Text) < 0 Then
            lblovera.ForeColor = System.Drawing.Color.FromArgb(217, 23, 40)
        Else
            lblovera.ForeColor = System.Drawing.Color.FromArgb(15, 115, 0)
        End If
    End Sub

    'Private Sub txtitemid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtitemid.Text = "" Then
    '        txtitemid.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtitemid_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtitemid.Text = "0" Then
    '        txtitemid.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Dim accHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)

    Private Sub btnaccount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccount.Click
        'accrefresh()
        TabControl.SelectedTab = tabaccount

        RepoAccHeaderLabels()

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow7, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow8, Color.Black, 30, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    End Sub


    Dim transHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
    Private Sub btntransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransactions.Click
        TabControl.SelectedTab = tabtrans

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Pnltranshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnltrans, Color.Black, 40, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        RepoTransHeaderLabels()

        'NOTE: Ilipat mo na lang ung detailed transaction is isang form para doon na lang naten ichecheck para malinis tsaka di masikip.


        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connection.Open()
        'Dim reader As SqlDataReader

        'btntransprint.Visible = False

        'command = New SqlCommand("select * from tbltrans", connection)
        'reader = command.ExecuteReader

        'While reader.Read
        '    If Not cbcashier.Items.Contains(reader.GetString(8)) Then
        '        cbcashier.Items.Add(reader.GetString(8))
        '    End If
        'End While

        'transaction_refresh()
        'flowlayoutCOS.Controls.Clear()
    End Sub

    Private Sub btntransprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransprint.Click
        Print.Show()
        shadowback.Show()
        Print.TopMost = True
    End Sub

    Dim transColorSwitch As Boolean = True
    Private Sub btntrasnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrasnsearch.Click

        Dim trans As New Transdata
        Dim controlOffset As Integer = 18
        With trans
            .Margin = New Padding(0)
            .Width = pnlTransHeader.Size.Width - controlOffset

            .lbltransactionID.Text = "123456789123456789"
            .lblcashier.Text = "Unknown person"
            .lblcosid.Text = "987654321"
            'date format dd-MM-yyyy
            .lbldate.Text = "03-March-2002"
            .lblsubtotal.Text = DecimalToStringFormat(5000)
            .lbldiscount.Text = DecimalToStringFormat(500)
            .lblchange.Text = DecimalToStringFormat(500)
            .lblpay.Text = DecimalToStringFormat(4500)

            Dim i As Integer = 0
            For Each ctrl As Control In trans.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = transHeaderLabels(i).Size
                ctrl.Location = New Point(transHeaderLabels(i).Location.X, (.Size.Height / 2) - (ctrl.Size.Height / 2))
                i += 1
            Next

            .btnselect.Size = New Size(transHeaderLabels(i).Size.Width, .btnselect.Size.Height)
            .btnselect.Location = New Point(transHeaderLabels(i).Location.X, (.Size.Height / 2) - (.btnselect.Size.Height / 2))

            If transColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            transColorSwitch = Not transColorSwitch

        End With
        flowlayoutTRANS.Controls.Add(trans)

        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connection.Open()

        'If cbdate.Checked = True And cbcholder.Checked = True Then
        '    Dim searchquery As String = "select * from tbltrans where cashier='" & cbcashier.Text & "' and date like'%" & dtptrans.Text & "%'"

        '    Dim find As New SqlDataAdapter(searchquery, connection)
        '    Dim findtable As New DataTable
        '    find.Fill(findtable)

        '    If findtable.Rows.Count > 0 Then
        '        transaction_search(searchquery)
        '    Else
        '        MsgBox("No record exists!", vbInformation)
        '    End If


        'Else
        '    If cbdate.Checked = True Then
        '        Dim searchquery As String = "select * from tbltrans where date like '%" & dtptrans.Text & "%'"

        '        Dim search As New SqlDataAdapter(searchquery, connection)
        '        Dim table As New DataTable
        '        search.Fill(table)

        '        If table.Rows.Count > 0 Then
        '            transaction_search(searchquery)
        '        Else
        '            MsgBox("No Record Exists!")
        '        End If


        '    End If

        '    If cbcholder.Checked = True Then

        '        If Not cbcashier.Text = "" Then
        '            Dim searchquery As String = "select * from tbltrans where cashier='" & cbcashier.Text & "'"

        '            Dim search As New SqlDataAdapter(searchquery, connection)
        '            Dim table As New DataTable
        '            search.Fill(table)

        '            If table.Rows.Count > 0 Then
        '                transaction_search(searchquery)
        '            Else
        '                MsgBox("No Record Exists!")
        '            End If

        '        Else
        '            MsgBox("Select Cashier Holder!", vbInformation)
        '        End If

        '    End If

        'End If


    End Sub


    Private Sub btnasearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasearch.Click
        Search.Show()
        shadowback.Show()
        Search.TopMost = True
    End Sub



    Private Sub btnclearlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearlog.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connect.Open()
        connection.Open()

        Dim reader As SqlDataReader

        If log = 0 Then
            command = New SqlCommand("select * from tblinvlog", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblinvlog where date='" & reader.GetDateTime(2) & "'", connect)
                Dim table As New DataTable
                delete.Fill(table)
            End While

            MsgBox("Log Cleared Successfully!", vbInformation)
            btninvlog.PerformClick()

        ElseIf log = 1 Then
            command = New SqlCommand("select * from tblstocklog", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblstocklog where date='" & reader.GetDateTime(2) & "'", connect)
                Dim table As New DataTable
                delete.Fill(table)
            End While

            MsgBox("Log Cleared Successfully!", vbInformation)
            btnstocklog.PerformClick()
        ElseIf log = 2 Then
            command = New SqlCommand("select * from tblacclog", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblacclog where date='" & reader.GetDateTime(2) & "'", connect)
                Dim table As New DataTable
                delete.Fill(table)
            End While

            MsgBox("Log Cleared Successfully!", vbInformation)
            btnacclog.PerformClick()
        Else
            command = New SqlCommand("select * from tblhistory", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblhistory where logout='" & reader.GetDateTime(3) & "'", connect)
                Dim table As New DataTable
                delete.Fill(table)
            End While

            MsgBox("Log Cleared Successfully!", vbInformation)
            btnloghistory.PerformClick()
        End If
    End Sub

    Private Sub tmday_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmday.Tick
        lbltime.Text = Date.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")
    End Sub


    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        connect.Open()
        Dim reader As SqlDataReader


        If salesrind = 0 Then

            Dim check As New SqlDataAdapter("select * from tblsales", connect)
            Dim tables As New DataTable
            check.Fill(tables)

            If tables.Rows.Count > 0 Then

                Loading.Show()
                shadowback.Show()
                Loading.TopMost = True

                Try
                    command = New SqlCommand("select * from tblsales", connection)
                    reader = command.ExecuteReader

                    While reader.Read

                        Dim search As New SqlDataAdapter("select * from tblsalesreport where itemid='" & reader.GetString(1) & "'", connect)
                        Dim table As New DataTable
                        search.Fill(table)



                        If table.Rows.Count > 0 Then
                            Dim itemsold, stock, earn As Integer

                            stock = table.Rows(0)(4) + 0

                            itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                            earn = Val(table.Rows(0)(5)) + Val(reader.GetString(6))

                            Dim update As New SqlDataAdapter("update tblsalesreport set itemsold='" & itemsold & "',stock='" & stock & "',earnings='" & earn & "' where itemid='" & reader.GetString(1) & "'", connect)
                            Dim tableupd As New DataTable
                            update.Fill(tableupd)

                        Else
                            Dim stock As New SqlDataAdapter("select * from tblinventory where itemid='" & reader.GetString(1) & "'", connect)
                            Dim stocktable As New DataTable
                            stock.Fill(stocktable)

                            Dim stockleft As Integer

                            If stocktable.Rows.Count > 0 Then
                                stockleft = stocktable.Rows(0)(5)
                            Else
                                stockleft = 0
                            End If

                            Dim save As New SqlCommand("insert into tblsalesreport" & "(itemid,prodn,cat,itemsold,stock,earnings,date)values(@itemid,@prodn,@cat,@itemsold,@stock,@earnings,@date)", connect)
                            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                            save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                            save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = stockleft
                            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = CDate(reader.GetString(7))
                            save.ExecuteNonQuery()
                        End If

                    End While

                    Salesreport.Show()
                    Salesreport.TopMost = True

                    connection.Close()
                    connect.Close()
                    connection.Open()
                    connect.Open()

                    command = New SqlCommand("select * from tblsalesreport", connection)
                    reader = command.ExecuteReader

                    While reader.Read
                        Dim delete As New SqlDataAdapter("delete  from tblsalesreport where itemid='" & reader.GetString(0) & "'", connect)
                        Dim deltable As New DataTable
                        delete.Fill(deltable)
                    End While

                    connection.Close()
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("There's No Available Record!", vbInformation)
            End If



        ElseIf salesrind = 1 Then
            Dim check As New SqlDataAdapter("select * from tblsales where date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connect)
            Dim tables As New DataTable
            check.Fill(tables)

            If tables.Rows.Count > 0 Then

                Loading.Show()
                shadowback.Show()
                Loading.TopMost = True

                Try
                    command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "dd MMMM yyyy") & "%'", connection)
                    reader = command.ExecuteReader

                    While reader.Read

                        Dim search As New SqlDataAdapter("select * from tblsalesreport where itemid='" & reader.GetString(1) & "'", connect)
                        Dim table As New DataTable
                        search.Fill(table)


                        If table.Rows.Count > 0 Then
                            Dim itemsold, stock, earn As Integer

                            stock = table.Rows(0)(4) + 0

                            itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                            earn = Val(table.Rows(0)(5)) + Val(reader.GetString(6))

                            Dim update As New SqlDataAdapter("update tblsalesreport set itemsold='" & itemsold & "',stock='" & stock & "',earnings='" & earn & "' where itemid='" & reader.GetString(1) & "'", connect)
                            Dim tableupd As New DataTable
                            update.Fill(tableupd)

                        Else
                            Dim stock As New SqlDataAdapter("select * from tblinventory where itemid='" & reader.GetString(1) & "'", connect)
                            Dim stocktable As New DataTable
                            stock.Fill(stocktable)

                            Dim stockleft As Integer

                            If stocktable.Rows.Count > 0 Then
                                stockleft = stocktable.Rows(0)(5)
                            Else
                                stockleft = 0
                            End If

                            Dim save As New SqlCommand("insert into tblsalesreport" & "(itemid,prodn,cat,itemsold,stock,earnings,date)values(@itemid,@prodn,@cat,@itemsold,@stock,@earnings,@date)", connect)
                            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                            save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                            save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = stockleft
                            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NChar)).Value = CDate(reader.GetString(7))
                            save.ExecuteNonQuery()
                        End If

                    End While

                    SalesreportDay.Show()
                    SalesreportDay.TopMost = True

                    connection.Close()
                    connect.Close()
                    connection.Open()
                    connect.Open()

                    command = New SqlCommand("select * from tblsalesreport", connection)
                    reader = command.ExecuteReader

                    While reader.Read
                        Dim delete As New SqlDataAdapter("delete  from tblsalesreport where itemid='" & reader.GetString(0) & "'", connect)
                        Dim deltable As New DataTable
                        delete.Fill(deltable)
                    End While

                    connection.Close()
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("There's No Available Record!", vbInformation)
            End If


        ElseIf salesrind = 2 Then
            Dim check As New SqlDataAdapter("select * from tblsales where date like '%" & Format(Today, "MMMM yyyy") & "%'", connect)
            Dim tables As New DataTable
            check.Fill(tables)

            If tables.Rows.Count > 0 Then

                Loading.Show()
                shadowback.Show()
                Loading.TopMost = True

                Try
                    command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "MMMM yyyy") & "%'", connection)
                    reader = command.ExecuteReader

                    While reader.Read

                        Dim search As New SqlDataAdapter("select * from tblsalesreport where itemid='" & reader.GetString(1) & "'", connect)
                        Dim table As New DataTable
                        search.Fill(table)


                        If table.Rows.Count > 0 Then
                            Dim itemsold, stock, earn As Integer

                            stock = table.Rows(0)(4) + 0

                            itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                            earn = Val(table.Rows(0)(5)) + Val(reader.GetString(6))

                            Dim update As New SqlDataAdapter("update tblsalesreport set itemsold='" & itemsold & "',stock='" & stock & "',earnings='" & earn & "' where itemid='" & reader.GetString(1) & "'", connect)
                            Dim tableupd As New DataTable
                            update.Fill(tableupd)

                        Else
                            Dim stock As New SqlDataAdapter("select * from tblinventory where itemid='" & reader.GetString(1) & "'", connect)
                            Dim stocktable As New DataTable
                            stock.Fill(stocktable)

                            Dim stockleft As Integer

                            If stocktable.Rows.Count > 0 Then
                                stockleft = stocktable.Rows(0)(5)
                            Else
                                stockleft = 0
                            End If


                            Dim save As New SqlCommand("insert into tblsalesreport" & "(itemid,prodn,cat,itemsold,stock,earnings,date)values(@itemid,@prodn,@cat,@itemsold,@stock,@earnings,@date)", connect)
                            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                            save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                            save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = stockleft
                            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NChar)).Value = CDate(reader.GetString(7))
                            save.ExecuteNonQuery()
                        End If

                    End While

                    SalesreportMonth.Show()
                    SalesreportMonth.TopMost = True

                    connection.Close()
                    connect.Close()
                    connection.Open()
                    connect.Open()

                    command = New SqlCommand("select * from tblsalesreport", connection)
                    reader = command.ExecuteReader

                    While reader.Read
                        Dim delete As New SqlDataAdapter("delete  from tblsalesreport where itemid='" & reader.GetString(0) & "'", connect)
                        Dim deltable As New DataTable
                        delete.Fill(deltable)
                    End While

                    connection.Close()
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("There's No Available Record!", vbInformation)
            End If



        Else
            Dim check As New SqlDataAdapter("select * from tblsales where date like '%" & Format(Today, "yyyy") & "%'", connect)
            Dim tables As New DataTable
            check.Fill(tables)

            If tables.Rows.Count > 0 Then

                Loading.Show()
                shadowback.Show()
                Loading.TopMost = True

                Try
                    command = New SqlCommand("select * from tblsales where date like '%" & Format(Today, "yyyy") & "%'", connection)
                    reader = command.ExecuteReader

                    While reader.Read

                        Dim search As New SqlDataAdapter("select * from tblsalesreport where itemid='" & reader.GetString(1) & "'", connect)
                        Dim table As New DataTable
                        search.Fill(table)


                        If table.Rows.Count > 0 Then
                            Dim itemsold, stock, earn As Integer

                            stock = table.Rows(0)(4) + 0

                            itemsold = Val(table.Rows(0)(3)) + Val(reader.GetString(4))
                            earn = Val(table.Rows(0)(5)) + Val(reader.GetString(6))

                            Dim update As New SqlDataAdapter("update tblsalesreport set itemsold='" & itemsold & "',stock='" & stock & "',earnings='" & earn & "' where itemid='" & reader.GetString(1) & "'", connect)
                            Dim tableupd As New DataTable
                            update.Fill(tableupd)

                        Else
                            Dim stock As New SqlDataAdapter("select * from tblinventory where itemid='" & reader.GetString(1) & "'", connect)
                            Dim stocktable As New DataTable
                            stock.Fill(stocktable)

                            Dim stockleft As Integer

                            If stocktable.Rows.Count > 0 Then
                                stockleft = stocktable.Rows(0)(5)
                            Else
                                stockleft = 0
                            End If

                            Dim save As New SqlCommand("insert into tblsalesreport" & "(itemid,prodn,cat,itemsold,stock,earnings,date)values(@itemid,@prodn,@cat,@itemsold,@stock,@earnings,@date)", connect)
                            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
                            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
                            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = reader.GetString(3)
                            save.Parameters.Add(New SqlParameter("@itemsold", SqlDbType.NChar)).Value = reader.GetString(4)
                            save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = stockleft
                            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(6)
                            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NChar)).Value = CDate(reader.GetString(7))
                            save.ExecuteNonQuery()
                        End If

                    End While

                    SalesreportAnnual.Show()
                    SalesreportAnnual.TopMost = True

                    connection.Close()
                    connect.Close()
                    connection.Open()
                    connect.Open()

                    command = New SqlCommand("select * from tblsalesreport", connection)
                    reader = command.ExecuteReader

                    While reader.Read
                        Dim delete As New SqlDataAdapter("delete  from tblsalesreport where itemid='" & reader.GetString(0) & "'", connect)
                        Dim deltable As New DataTable
                        delete.Fill(deltable)
                    End While

                    connection.Close()
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("There's No Available Record!", vbInformation)
            End If


        End If

    End Sub

    Private Sub btncashreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncashreport.Click
        TabControl.SelectedTab = tabcreport

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadcreport, Color.Black, 40, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlcshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        RepoReportHeaderLabels()
        'cashreport refresh
        'Cashreport_refresh()

        'GunaLabel22.Visible = False
        'GunaLabel31.Visible = False
        'GunaLabel32.Visible = False
        'lbltotalsalesc.Visible = False
        'lbltotalexpenses.Visible = False
        'lbltotalsalese.Visible = False
        'GunaPanel14.Visible = False
        'GunaPanel15.Visible = False
        'GunaPanel16.Visible = False

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)
        pnlbutton.BackColor = Color.White
        pnlshadow.BackColor = Color.GhostWhite
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshadow, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        btncategory.PerformClick()
    End Sub

    Private Sub GunaPictureBox2_MouseHover(sender As Object, e As EventArgs)
        Dim tp As New ToolTip

        'tp.SetToolTip(GunaPictureBox2, "Digits only")
    End Sub

    Private Sub txtitemid_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back AndAlso Asc(e.KeyChar) <> Keys.Return Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back AndAlso Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

    'Private Sub txtitemid_TextChanged(sender As Object, e As EventArgs)
    '    If checkstr(txtitemid.Text, "letterspecial") = False Then
    '        GunaPictureBox0.Visible = True
    '        txtitemid.FocusedLineColor = Color.FromArgb(201, 0, 0)
    '    Else
    '        GunaPictureBox0.Visible = False
    '        txtitemid.FocusedLineColor = Color.FromArgb(31, 61, 64)
    '    End If
    'End Sub

    'Private Sub txtprodname_TextChanged(sender As Object, e As EventArgs)
    '    If txtprodname.Text.Contains("""") Or txtprodname.Text.Contains("'") Then
    '        MsgBox("Using Double Quotes and Single Quotes are Prohibited")
    '        txtprodname.Text = ""
    '    End If
    'End Sub

    'Private Sub txtstock_TextChanged(sender As Object, e As EventArgs)
    '    If checkstr(txtstock.Text, "letterspecial") = False Then
    '        txtstock.FocusedLineColor = Color.FromArgb(201, 0, 0)
    '    Else
    '        txtstock.FocusedLineColor = Color.FromArgb(31, 61, 64)
    '    End If
    'End Sub

    'Private Sub txtprice_TextChanged(sender As Object, e As EventArgs)
    '    If checkstr(txtprice.Text, "letterspecials") = False Then
    '        txtprice.FocusedLineColor = Color.FromArgb(201, 0, 0)
    '    Else
    '        txtprice.FocusedLineColor = Color.FromArgb(31, 61, 64)
    '    End If

    '    Dim price As String = txtprice.Text
    '    Dim result() As String
    '    result = price.Split(".")

    '    If result.Count > 2 Then
    '        MsgBox("Please Input Proper Value!", vbInformation)
    '        txtprice.Text = ""
    '    End If
    'End Sub

    Private Sub lbloprofit_TextChanged(sender As Object, e As EventArgs) Handles lbloprofit.TextChanged
        If Val(lbloprofit.Text) < 0 Then
            lbloprofit.ForeColor = Color.FromArgb(217, 23, 40)
        Else
            lbloprofit.ForeColor = Color.FromArgb(15, 115, 0)
        End If
    End Sub

    'Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    GunaPictureBox3.Visible = False
    'End Sub

    Dim reportHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
    Dim reportColorSwitcher As Boolean = True
    Private Sub btncsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsales.Click

        Dim controlOffset As Integer = 18
        Dim creport As New Creportdata
        With creport
            .Margin = New Padding(0)
            .Width = pnlReportHeader.Size.Width - controlOffset

            .lbltransid.Text = "123456789"
            .lbldate.Text = "dd-MMMM-YYYY"
            .lblcosid.Text = "987654321"
            .lblcashier.Text = "Unknown Handler"
            .lbldiscount.Text = "5000.00"
            .lblearnings.Text = "100000"

            Dim i As Integer = 0
            For Each ctrl As Control In creport.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = reportHeaderLabels(i).Size
                ctrl.Location = reportHeaderLabels(i).Location
                i += 1
            Next

            If reportColorSwitcher Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            reportColorSwitcher = Not reportColorSwitcher


        End With
        FlowlayoutCREPORT.Controls.Add(creport)

        'cashsearch.Show()
        'shadowback.Show()
        'cashsearch.TopMost = True
    End Sub

    Private Sub btnmsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmsales.Click

        cashsearch.Show()
        shadowback.Show()
        cashsearch.TopMost = True
        cashsearch.pnlmonth.Visible = True
        cashsearch.lblind.Text = 1
    End Sub

    Private Sub pnlPosLabelHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlPosLabelHeader.Paint
        Dim p As New Pen(Color.FromArgb(235, 235, 235))
        Dim startLine As New Point(0, 0)
        Dim endLine As New Point(pnlPosLabelHeader.Width - 1, 0)
        e.Graphics.DrawLine(p, startLine, endLine)

        'startLine = New Point(0, pnlPosLabelHeader.Height - 1)
        'endLine = New Point(pnlPosLabelHeader.Width - 1, pnlPosLabelHeader.Height - 1)
        'e.Graphics.DrawLine(p, startLine, endLine)
    End Sub

    Private Sub btncashprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncashprint.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connect.Open()
        connection.Open()
        Dim reader As SqlDataReader

        Dim search As New SqlDataAdapter("select * from tbltrans where date like '%" & lblcrprtdate.Text & "%'", connection)
        Dim searchtable As New DataTable
        search.Fill(searchtable)

        If searchtable.Rows.Count > 0 Then

            command = New SqlCommand("select * from tbltrans where date like '%" & lblcrprtdate.Text & "%'", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim save As New SqlCommand("insert into tblcashreport" & "(date,transid,cosid,discount,earnings)values(@date,@transid,@cosid,@discount,@earnings)", connect)
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = reader.GetDateTime(9)
                save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NChar)).Value = reader.GetString(0)
                save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = reader.GetString(1)
                save.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = reader.GetString(5)
                save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NChar)).Value = reader.GetString(4)
                save.ExecuteNonQuery()
            End While

            Cashreport.Show()
            shadowback.Show()
            Cashreport.TopMost = True

            connect.Close()
            connection.Close()
            connect.Open()
            connection.Open()

            command = New SqlCommand("select * from tblcashreport", connection)
            reader = command.ExecuteReader

            While reader.Read
                Dim delete As New SqlDataAdapter("delete from tblcashreport where transid='" & reader.GetString(1) & "'", connect)
                Dim deltable As New DataTable
                delete.Fill(deltable)
            End While
        Else
            MsgBox("Please Search A Record!", vbInformation)
        End If
    End Sub


    Private Sub lbltotalsalesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotalsalesc.TextChanged
        lbltotalsalesc.Text = LTrim(lbltotalsalesc.Text)
    End Sub

    Private Sub lbltotalexpenses_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotalexpenses.TextChanged
        lbltotalexpenses.Text = LTrim(lbltotalexpenses.Text)
    End Sub

    Private Sub lbltotalsalese_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotalsalese.TextChanged
        lbltotalsalese.Text = LTrim(lbltotalsalese.Text)
    End Sub

    Dim logColorSwitch As Boolean = True
    Private Sub btninvlog_Click(sender As Object, e As EventArgs) Handles btninvlog.Click
        'loglbl1.Location = New System.Drawing.Point(210, 10)
        'loglbl2.Location = New System.Drawing.Point(455, 10)
        'loglbl3.Location = New System.Drawing.Point(728, 10)
        'loglbl4.Visible = False

        'loglbl1.Text = "PRODUCT NAME"
        'loglbl2.Text = "ACTION"
        'loglbl3.Text = "DATE"
        Dim headerLabels() As String = {"LOG ID", "PRODUCT NAME", "HISTORY", "DATE", "ACTION"}

        Dim headerOffset As Integer = 17
        Dim headerWidth As Integer = pnlLogHeader.Width - headerOffset
        Dim labelCount As Integer = headerLabels.Length
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlLogHeader.Height / 2

        Dim logHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlLogHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse

            If i < headerLabels.Length Then
                ctrl.Text = headerLabels(i)
                ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
                ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
                ctrl.Visible = True
                logHeaderLabels.Add(ctrl)
            Else
                ctrl.Visible = False
            End If

            i += 1
            xP += workingArea
        Next

        Dim pOffset() As Integer = {-(logHeaderLabels(0).Size.Width / 3), (logHeaderLabels(1).Size.Width / 2), (logHeaderLabels(2).Size.Width / 1.5), (logHeaderLabels(4).Size.Width / 3)}
        For j As Integer = 0 To logHeaderLabels.Count - 2
            'current text label
            logHeaderLabels(j).Size = New Size(logHeaderLabels(j).Size.Width + pOffset(j), logHeaderLabels(j).Size.Height)

            'next text label
            logHeaderLabels(j + 1).Location = New Point(logHeaderLabels(j + 1).Location.X + pOffset(j), logHeaderLabels(j + 1).Location.Y)
            logHeaderLabels(j + 1).Size = New Size(logHeaderLabels(j + 1).Size.Width - pOffset(j), logHeaderLabels(j + 1).Size.Height)
        Next

        Dim logcontrol As New Logdata
        With logcontrol
            .Margin = New Padding(0)
            .Width = headerWidth

            .lblLogId.Text = "123456789"
            .lblProdName.Text = "product shit qweasd xcaseqwpeojqpsdj paoepqowe"
            .lblHistory.Text = "3....2.....1.....Action"
            .lblDate.Text = "date to day motherfucker"

            Dim j As Integer = 0
            For Each ctrl As Control In logcontrol.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                ctrl.Size = logHeaderLabels(j).Size
                ctrl.Location = logHeaderLabels(j).Location
                j += 1
            Next

            .btndelete.Size = New Size(logHeaderLabels(j).Size.Width, .btndelete.Size.Height)
            .btndelete.Location = New Point(logHeaderLabels(j).Location.X, (.Size.Height / 2) - (.btndelete.Size.Height / 2))

            If logColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            logColorSwitch = Not logColorSwitch

        End With
        flowlayoutLOG.Controls.Add(logcontrol)

        'Return

        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim reader As SqlDataReader
        'connection.Open()

        'log = 0

        'flowlayoutLOG.Controls.Clear()

        'command = New SqlCommand("select * from tblinvlog", connection)
        'reader = command.ExecuteReader

        'While reader.Read
        '    Dim logcontrol As Logdata
        '    logcontrol = New Logdata
        '    logcontrol.Margin = New Padding(0)

        '    ctr = ctr + 1

        '    If ctr = 1 Then
        '        With logcontrol
        '            'Dim dt As Date = reader.GetDateTime(2).ToString
        '            'MsgBox(reader.GetDateTime(2))
        '            .BackColor = Color.GhostWhite
        '            .lblprod.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '    Else
        '        With logcontrol
        '            'Dim dt As Date = reader.GetDateTime(2).ToString

        '            .BackColor = Color.White
        '            .lblprod.Text = reader.GetString(0)
        '            .lblaction.Text = reader.GetString(1)
        '            .lbldate.Text = Format(reader.GetDateTime(2), "dddd, dd MMMM yyyy hh:mm tt")
        '        End With
        '        ctr = 0
        '    End If

        '    flowlayoutLOG.Controls.Add(logcontrol)
        'End While

        'gen = 0
    End Sub

    Private Sub btnchartprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchartprint.Click

        Try
            SalesChart.Printing.PrintPreview()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim accColorSwitch As Boolean = True
    Private Sub btncreateacc_Click(sender As Object, e As EventArgs) Handles btncreateacc.Click

        Dim controlOffset As Integer = 0
        Dim accData As New Accountdata
        With accData
            .Margin = New Padding(0)
            .Width = pnlAccHeader.Size.Width - controlOffset

            .lblaccid.Text = "123456789"
            '.profileimg.Image = Image.FromStream(img)
            .lblName.Text = "Unknown Name"
            .lblUsername.Text = "scooby doo papa"
            .lblPassword.Text = "Test password"
            .lblAccType.Text = "Hellelujah"

            Dim headerOffset As Integer = 17
            Dim headerWidth As Integer = .Size.Width - headerOffset
            Dim labelCount As Integer = pnlAccHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
            Dim workingArea As Integer = headerWidth / labelCount

            Dim xP As Integer = workingArea / 2
            Dim yP As Integer = .Size.Height / 2
            'Console.WriteLine(alignLabels)
            Dim i As Integer = 0
            Dim labelOffset As Integer = 10
            For Each ctrl As Control In accData.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse

                If i = 1 Then
                    .profileimg.Location = New Point(xP - (.profileimg.Size.Width / 2), (.Size.Height / 2) - (.profileimg.Size.Height / 2))
                    xP += workingArea
                    i += 1
                End If

                ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
                ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
                xP += workingArea
                i += 1
            Next

            .btnedit.Size = New Size(workingArea - labelOffset, .btnedit.Size.Height)
            .btnedit.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (.btnedit.Size.Height / 2))

            .pnlbtn.Size = New Size(workingArea - labelOffset, .Size.Height)
            .pnlbtn.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (.pnlbtn.Size.Height / 2))
            .btndelete.Location = New Point((.pnlbtn.Size.Width / 2) - (.btndelete.Size.Width / 2), (.pnlbtn.Size.Height / 2) - (.btndelete.Size.Height / 2))

            If accColorSwitch Then
                .BackColor = Color.White
            Else
                .BackColor = Color.GhostWhite
            End If
            accColorSwitch = Not accColorSwitch

        End With
        flowlayoutACC.Controls.Add(accData)



        'Dim accdata As Accountdata
        'accData = New Accountdata
        'accData.Margin = New Padding(0)

        'ctr = ctr + 1

        'Dim byt() As Byte
        'byt = reader(1)
        'Dim img As New MemoryStream(byt)

        'If ctr = 1 Then

        '    With accData
        '        .lblaccid.Text = reader.GetString(0)
        '        .profileimg.Image = Image.FromStream(img)
        '        .lblname.Text = reader.GetString(2)
        '        .lblusername.Text = reader.GetString(3)
        '        .lblpassword.Text = reader.GetString(4)
        '        .lblacctype.Text = reader.GetString(5)
        '        .BackColor = Color.White
        '    End With

        'Else
        '    With accData
        '        .lblaccid.Text = reader.GetString(0)
        '        .profileimg.Image = Image.FromStream(img)
        '        .lblname.Text = reader.GetString(2)
        '        .lblusername.Text = reader.GetString(3)
        '        .lblpassword.Text = reader.GetString(4)
        '        .lblacctype.Text = reader.GetString(5)
        '        .BackColor = Color.GhostWhite
        '        ctr = 0
        '    End With

        'End If

        'flowlayoutACC.Controls.Add(accData)

        'Createaccount.lblconfirmp.Visible = True
        'Createaccount.txtconfirmp.Visible = True
        'Createaccount.lblaccesstype.Location = New System.Drawing.Point(113, 571)
        'Createaccount.cbaccesstype.Location = New System.Drawing.Point(21, 591)
        'Createaccount.pnledit.Visible = False


        'Createaccount.Show()
        'shadowback.Show()
        'Createaccount.TopMost = True

    End Sub

    Private Function DecimalToStringFormat(ByVal d As Double) As String

        If d = Int(d) Then
            Return d.ToString("N")
        Else
            Return d.ToString("N", CultureInfo.InvariantCulture)
        End If

    End Function

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click

        shadowback.Show()
        Defectform.SetState(True)
        Defectform.ShowDialog()

    End Sub

    Private Enum InventoryButtonState As Integer
        None = -1
        Item = 0
        OutOfStock = 1
        Defect = 2
        Expired = 3
    End Enum

    Dim inventoryState As InventoryButtonState
    '0 col = currentPage, 1 col = maxpage, 2 col = pageEntities (row count that will be displayed at the table)
    Dim inventoryPage() As Integer = {0, 0, 2}

    Private Sub btnStartPage_Click(sender As Object, e As EventArgs) Handles btnStartPage.Click

        'start kana dito
        inventoryPage(0) = 0
        btnStartPage.Enabled = False
        btnPrevPage.Enabled = False

        'if the inventory page is greater than or equal to the maxpage we can disable the next and end button
        If Not (inventoryPage(0) = inventoryPage(1)) Then
            btnNextPage.Enabled = True
            btnEndPage.Enabled = True
        Else
            btnNextPage.Enabled = False
            btnEndPage.Enabled = False
        End If

        If inventoryState = InventoryButtonState.Item Then
            Me.btninvref.PerformClick()
        ElseIf inventoryState = InventoryButtonState.OutOfStock Then
            Me.btnoutofstock.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Defect Then
            Me.btndefect.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Expired Then
            Me.btnexpired.PerformClick()
        End If

    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click

        'decrement when page is > 0
        If inventoryPage(0) > 0 Then
            inventoryPage(0) -= 1
        End If

        'disable start and prev button when inventory page = 0
        If inventoryPage(0) <= 0 Then
            btnStartPage.Enabled = False
            btnPrevPage.Enabled = False
        End If

        'if the current page is less than the maxPage then we need to enable next and end
        If inventoryPage(0) < inventoryPage(1) Then
            btnNextPage.Enabled = True
            btnEndPage.Enabled = True
        End If

        If inventoryState = InventoryButtonState.Item Then
            Me.btninvref.PerformClick()
        ElseIf inventoryState = InventoryButtonState.OutOfStock Then
            Me.btnoutofstock.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Defect Then
            Me.btndefect.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Expired Then
            Me.btnexpired.PerformClick()
        End If

    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click

        'if currentpage is less than the maxpage we can increment
        If inventoryPage(0) < inventoryPage(1) Then
            inventoryPage(0) += 1
        End If

        'if the inventory page is greater than 0 we can enable the start and prev buttons
        If inventoryPage(0) > 0 Then
            btnStartPage.Enabled = True
            btnPrevPage.Enabled = True
        End If

        'if the inventory page is greater than or equal to the maxpage we can disable the next and end button
        If inventoryPage(0) >= inventoryPage(1) Then
            btnNextPage.Enabled = False
            btnEndPage.Enabled = False
        End If

        If inventoryState = InventoryButtonState.Item Then
            Me.btninvref.PerformClick()
        ElseIf inventoryState = InventoryButtonState.OutOfStock Then
            Me.btnoutofstock.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Defect Then
            Me.btndefect.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Expired Then
            Me.btnexpired.PerformClick()
        End If

    End Sub

    Private Sub btnEndPage_Click(sender As Object, e As EventArgs) Handles btnEndPage.Click

        inventoryPage(0) = inventoryPage(1)
        btnNextPage.Enabled = False
        btnEndPage.Enabled = False

        If inventoryPage(0) = inventoryPage(1) Then
            btnStartPage.Enabled = True
            btnPrevPage.Enabled = True
        End If

        If inventoryState = InventoryButtonState.Item Then
            Me.btninvref.PerformClick()
        ElseIf inventoryState = InventoryButtonState.OutOfStock Then
            Me.btnoutofstock.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Defect Then
            Me.btndefect.PerformClick()
        ElseIf inventoryState = InventoryButtonState.Expired Then
            Me.btnexpired.PerformClick()
        End If

    End Sub

    Private Sub RePositionTableLabelColumns()

        RepoPOSHeaderLabels()
        'RepoINVHeaderLabels()

    End Sub

    Private Sub RepoPOSHeaderLabels()

        'Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim screenWidthOffset As Integer = 22
        Dim screenWidth As Integer = pnlPosLabelHeader.Size.Width - screenWidthOffset
        Dim labelCount As Integer = pnlPosLabelHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingAreaWidth = screenWidth / labelCount

        'Location
        Dim xP As Integer = workingAreaWidth / 2
        Dim yP As Integer = pnlPosLabelHeader.Height / 2

        Dim labelOffset As Integer = 10
        For Each ctrl As Control In pnlPosLabelHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Size = New Size(workingAreaWidth - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingAreaWidth / 2), yP - (ctrl.Size.Height / 2))
            'Console.WriteLine(ctrl.Location.X)
            xP += workingAreaWidth

            If Not POSHeaderLabels.Contains(ctrl) Then
                POSHeaderLabels.Add(ctrl)
            End If
        Next

        Dim pOffset() As Integer = {-(POSHeaderLabels(0).Size.Width / 3), (POSHeaderLabels(1).Size.Width * 1), (POSHeaderLabels(2).Size.Width / 2)}
        For j As Integer = 0 To pnlPosLabelHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count - 2
            'current text label
            POSHeaderLabels(j).Size = New Size(POSHeaderLabels(j).Size.Width + pOffset(j), POSHeaderLabels(j).Size.Height)

            'next text label
            POSHeaderLabels(j + 1).Location = New Point(POSHeaderLabels(j + 1).Location.X + pOffset(j), POSHeaderLabels(j + 1).Location.Y)
            POSHeaderLabels(j + 1).Size = New Size(POSHeaderLabels(j + 1).Size.Width - pOffset(j), POSHeaderLabels(j + 1).Size.Height)
        Next

    End Sub

    Private Sub RepoINVHeaderLabels()

        'pnlSearchBar.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2) - (pnlSearchBar.Location.X / 2), pnlSearchBar.Location.Y)

        Dim headerOffset As Integer = 0
        Dim headerWidth As Integer = Screen.PrimaryScreen.Bounds.Width - headerOffset
        'Console.WriteLine("HW: " & headerWidth)
        Dim labelCount As Integer = pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingAreaWidth As Integer = headerWidth / labelCount

        'Location
        Dim xP As Integer = workingAreaWidth / 2
        Dim yP As Integer = pnlInvHeader.Height / 2

        For Each ctrl As Control In pnlInvHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Location = New Point(xP, yP - (ctrl.Height / 2))
            'Console.WriteLine(xP & " " & yP)
            xP += workingAreaWidth
        Next

        'Console.WriteLine()

    End Sub

    Private Sub RepoSalesHeaderLabels()

        Dim headerOffset As Integer = 22
        Dim headerWidth As Integer = pnlSalesHeader.Size.Width - headerOffset
        Dim labelCount As Integer = pnlSalesHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlSalesHeader.Height / 2

        Dim labelOffset As Integer = 10
        For Each ctrl As Control In pnlSalesHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'ctrl.Location = New Point(xP - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'Console.WriteLine(xP & "   " & yP)
            xP += workingArea
            If Not SalesHeaderLabels.Contains(ctrl) Then
                SalesHeaderLabels.Add(ctrl)
            End If
        Next

        Dim pOffset() As Integer = {-(SalesHeaderLabels(0).Size.Width / 3), (SalesHeaderLabels(1).Size.Width * 0.9), (SalesHeaderLabels(2).Size.Width / 2), (SalesHeaderLabels(3).Size.Width * 0.4), (SalesHeaderLabels(4).Size.Width / 3)}
        For j As Integer = 0 To SalesHeaderLabels.Count - 2
            'current text label
            SalesHeaderLabels(j).Size = New Size(SalesHeaderLabels(j).Size.Width + pOffset(j), SalesHeaderLabels(j).Size.Height)

            'next text label
            SalesHeaderLabels(j + 1).Location = New Point(SalesHeaderLabels(j + 1).Location.X + pOffset(j), SalesHeaderLabels(j + 1).Location.Y)
            SalesHeaderLabels(j + 1).Size = New Size(SalesHeaderLabels(j + 1).Size.Width - pOffset(j), SalesHeaderLabels(j + 1).Size.Height)
        Next

    End Sub

    Private Sub RepoTransHeaderLabels()

        Dim headerOffset As Integer = 18
        Dim headerWidth As Integer = pnlTransHeader.Width - headerOffset
        Dim labelCount As Integer = pnlTransHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlTransHeader.Height / 2

        Dim labelOffset As Integer = 10
        For Each ctrl As Control In pnlTransHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'ctrl.Location = New Point(xP - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'Console.WriteLine(xP & "   " & yP)
            xP += workingArea
        Next

    End Sub

    Private Sub RepoAccHeaderLabels()

        Dim headerOffset As Integer = 18
        Dim headerWidth As Integer = pnlAccHeader.Width - headerOffset
        Dim labelCount As Integer = pnlAccHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlAccHeader.Height / 2

        Dim headerLabelTexts() As String = {"ACCOUNT ID", "PROFILE", "NAME", "USERNAME", "PASSWORD", "ACCESS TYPE", "ACTION"}

        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlAccHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Text = headerLabelTexts(i)
            ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'ctrl.Location = New Point(xP - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            'Console.WriteLine(xP & "   " & yP)
            xP += workingArea
            i += 1
        Next

    End Sub

    Private Sub RepoReportHeaderLabels()
        Dim headerOffset As Integer = 18
        Dim headerWidth As Integer = pnlReportHeader.Width - headerOffset
        Dim labelCount As Integer = pnlReportHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlAccHeader.Height / 2

        Dim headerLabelTexts() As String = {"TRANSACTION ID", "DATE", "CUSTOMER ID", "CASHIER", "DISCOUNT", "EARNINGS"}

        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlReportHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Text = headerLabelTexts(i)
            ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            reportHeaderLabels.Add(ctrl)
            xP += workingArea
            i += 1
        Next
    End Sub

End Class