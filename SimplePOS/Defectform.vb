Imports System.Data.SqlClient
Public Class Defectform

    Dim defectid As Integer = -1
    Dim isSaveState As Boolean = True
    Public Sub PopulateData(ByVal r As Object())
        defectid = Convert.ToInt32(r(0))
        txtItemId.Text = r(1).ToString.Trim
        txtpname.Text = r(2).ToString()
        txtAffectedStock.Text = r(3).ToString
        txtValue.Text = r(4).ToString()
        txtDescription.Text = r(5).ToString()
    End Sub

    Public Sub SetState(ByVal b As Boolean)
        isSaveState = b

        If isSaveState Then
            txtItemId.Enabled = b
        End If
        txtItemId.Enabled = b

    End Sub

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

    Private Function GenerateDefectID(ByVal c As SqlConnection) As Integer

        Dim i As Integer = 0
        While True
            Dim adapter As New SqlDataAdapter("SELECT * FROM tbldefect WHERE defid='" & i & "'", c)
            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                i += 1
            Else
                Exit While
            End If

        End While
        Return i

    End Function

    Private Sub ExitForm()
        Me.Close()
        shadowback.Close()
        Form2.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ExitForm()
        ClearForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        If isSaveState Then

            Dim save As New SqlCommand("INSERT INTO tbldefect (defid,itemid,pname,affstock,value,descp,date) values (@defid,@itemid,@pname,@affstock,@value,@descp,@date)", connection)
            save.Parameters.Add(New SqlParameter("@defid", SqlDbType.Int)).Value = GenerateDefectID(connection)
            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.Int)).Value = txtItemId.Text
            save.Parameters.Add(New SqlParameter("@pname", SqlDbType.NVarChar)).Value = txtpname.Text
            save.Parameters.Add(New SqlParameter("@affstock", SqlDbType.Int)).Value = Val(txtAffectedStock.Text)
            save.Parameters.Add(New SqlParameter("@value", SqlDbType.Decimal)).Value = Val(txtValue.Text)
            save.Parameters.Add(New SqlParameter("@descp", SqlDbType.Text)).Value = txtDescription.Text
            save.Parameters.Add(New SqlParameter("@date", SqlDbType.Date)).Value = DateTime.Today
            save.ExecuteNonQuery()

            MsgBox("Record Added Successfully!", vbInformation, "Save Records")
            defectid = -1

        Else

            Dim update As New SqlCommand("UPDATE tbldefect SET pname=@pname, affstock=@affstock, value=@value, descp=@descp, date=@date WHERE defid=@defid", connection)
            update.Parameters.Add(New SqlParameter("@defid", SqlDbType.Int)).Value = defectid
            update.Parameters.Add(New SqlParameter("@pname", SqlDbType.NVarChar)).Value = txtpname.Text
            update.Parameters.Add(New SqlParameter("@affstock", SqlDbType.Int)).Value = Val(txtAffectedStock.Text)
            update.Parameters.Add(New SqlParameter("@value", SqlDbType.Decimal)).Value = Val(txtValue.Text)
            update.Parameters.Add(New SqlParameter("@descp", SqlDbType.Text)).Value = txtDescription.Text
            update.Parameters.Add(New SqlParameter("@date", SqlDbType.Date)).Value = DateTime.Today
            update.ExecuteNonQuery()

            MsgBox("Record Updated Successfuly!", vbInformation, "Update Records")
            defectid = -1

        End If
        connection.Close()

        ExitForm()
        ClearForm()
    End Sub

    Private Sub ClearForm()

        txtpname.Text = ""
        txtValue.Text = ""
        txtAffectedStock.Text = ""
        txtDescription.Text = ""

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ExitForm()
        ClearForm()
    End Sub

    'Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If Form2.cbscan.Checked = True Then
    '        Form2.txtitemcode.Select()
    '    Else
    '        Form2.txtprodn.Select()
    '    End If

    '    Me.Close()
    '    shadowback.Close()
    '    Form2.Show()

    'End Sub


    'Private Sub txtitemid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()


    '    If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
    '        e.Handled = True
    '    End If

    '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '        Dim search As New SqlDataAdapter("select * from tblcart where itemid like '%" & txtitemid.Text & "%'", connection)
    '        Dim table As New DataTable
    '        search.Fill(table)

    '        Dim find As New SqlDataAdapter("select * from tblcart where prodn='" & txtprodn.Text & "'", connection)
    '        Dim tblfind As New DataTable
    '        find.Fill(tblfind)

    '        If tblfind.Rows.Count > 0 Then
    '            txtitemid.Text = ""
    '            txtitemid.Text = RTrim(tblfind.Rows(0)(1))
    '        End If

    '        txtstock.Select()
    '    End If

    '    If e.KeyChar = Convert.ToChar(Keys.Escape) Then
    '        btnback.PerformClick()
    '    End If
    'End Sub

    'Private Sub txtdes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '        btnok.PerformClick()
    '    End If

    '    If e.KeyChar = Convert.ToChar(Keys.Escape) Then
    '        btnback.PerformClick()
    '    End If
    'End Sub

    'Private Sub cart_refresh()
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim ctr As Integer
    '    Dim reader As SqlDataReader
    '    Form2.flowlayoutPOS.Controls.Clear()

    '    Try
    '        command = New SqlCommand("select * from tblcart", connection)
    '        reader = command.ExecuteReader
    '        Form2.lbltotal.Text = "0"
    '        While reader.Read
    '            Dim datapanel As Datapanel1
    '            datapanel = New Datapanel1

    '            ctr = ctr + 1
    '            If ctr = 1 Then
    '                With datapanel
    '                    .BackColor = Color.GhostWhite
    '                    .lblpcode.Text = reader.GetString(1)
    '                    .lblprodn.Text = reader.GetString(2)
    '                    .lblquantity.Text = reader.GetString(4)
    '                    .lblprice.Text = reader.GetString(5)
    '                End With
    '            Else
    '                With datapanel
    '                    .BackColor = Color.White
    '                    .lblpcode.Text = reader.GetString(1)
    '                    .lblprodn.Text = reader.GetString(2)
    '                    .lblquantity.Text = reader.GetString(4)
    '                    .lblprice.Text = reader.GetString(5)
    '                End With
    '                ctr = 0
    '            End If
    '            Form2.flowlayoutPOS.Controls.Add(datapanel)

    '            Dim sale As Double = RTrim(Val(reader.GetString(5)))
    '            Dim totals As Double

    '            totals = sale + totals

    '            If totals = Int(totals) Then
    '                Form2.lbltotal.Text = totals & ".00"
    '            Else
    '                Form2.lbltotal.Text = totals
    '            End If

    '        End While

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    If Form2.cbscan.Checked = True Then
    '        Form2.txtitemcode.Select()
    '    Else
    '        Form2.txtprodn.Select()
    '    End If

    '    Me.Close()
    '    shadowback.Close()
    '    Form2.Show()

    'End Sub

    'Private Sub item_check()
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim check As New SqlDataAdapter("select * from tbldefect where itemid='" & txtitemid.Text & "'", connection)
    '    Dim table As New DataTable
    '    check.Fill(table)

    '    If table.Rows.Count > 0 Then
    '        Dim stock As Integer = table.Rows(0)(2) + Val(txtstock.Text)

    '        Dim update As New SqlDataAdapter("update tbldefect set stock='" & stock & "',des='" & txtdes.Text & "' where itemid='" & txtitemid.Text & "'", connection)
    '        Dim updatetable As New DataTable
    '        update.Fill(updatetable)

    '    Else
    '        Dim save As New SqlCommand("insert into tbldefect" & "(itemid,prod,stock,des,name) values (@itemid,@prod,@stock,@des,@name)", connection)
    '        save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtitemid.Text
    '        save.Parameters.Add(New SqlParameter("@prod", SqlDbType.NVarChar)).Value = txtprodn.Text
    '        save.Parameters.Add(New SqlParameter("@stock", SqlDbType.NChar)).Value = txtstock.Text
    '        save.Parameters.Add(New SqlParameter("@des", SqlDbType.Text)).Value = txtdes.Text
    '        save.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = Form2.lbluser.Text
    '        save.ExecuteNonQuery()
    '    End If

    '    MsgBox("Data has been Added!", vbInformation)
    'End Sub

    'Private Sub btnok_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim move As New SqlDataAdapter("select * from tblcart where itemid='" & txtitemid.Text & "'", connection)
    '    Dim movetable As New DataTable
    '    move.Fill(movetable)

    '    Dim item As New SqlDataAdapter("select * from tblinventory where itemid='" & txtitemid.Text & "'", connection)
    '    Dim itemtable As New DataTable
    '    item.Fill(itemtable)

    '    Dim quan As Integer = movetable.Rows(0)(4)
    '    Dim price As Double = itemtable.Rows(0)(6)
    '    Dim total As Double = movetable.Rows(0)(5)

    '    If Val(txtstock.Text) = quan Then
    '        item_check()

    '        Dim delete As New SqlDataAdapter("delete from tblcart where itemid='" & txtitemid.Text & "'", connection)
    '        Dim deltable As New DataTable
    '        delete.Fill(deltable)

    '        cart_refresh()
    '    End If

    '    If Val(txtstock.Text) < quan And Val(txtstock.Text) > 0 Then
    '        item_check()

    '        Dim stockleft As Integer
    '        stockleft = quan - Val(txtstock.Text)

    '        Dim takeout As Double = price * Val(txtstock.Text)
    '        Dim priceleft As Double = total - takeout

    '        Dim update As New SqlDataAdapter("update tblcart set quan='" & stockleft & "',price='" & priceleft & "' where itemid='" & txtitemid.Text & "'", connection)
    '        Dim tableupdate As New DataTable
    '        update.Fill(tableupdate)

    '        cart_refresh()
    '    Else
    '        MsgBox("Please Input Valid Number", vbInformation)
    '    End If

    '    'bukas yung defect na tapusin mo 

    'End Sub

    'Private Sub txtdes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtdes.Text = "Description..." Then
    '        txtdes.Text = ""
    '        txtdes.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtdes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtdes.Text = "" Then
    '        txtdes.Text = "Description..."
    '        txtdes.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub txtdes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtdes.Text.Contains("""") Or txtdes.Text.Contains("'") Then
    '        MsgBox("Double And Single Quotes Are Prohibited!", vbCritical)
    '        txtdes.Text = ""
    '    End If
    'End Sub

    'Private Sub txtitemid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim search As New SqlDataAdapter("select * from tblcart where itemid like '%" & txtitemid.Text & "%'", connection)
    '    Dim table As New DataTable
    '    search.Fill(table)

    '    If table.Rows.Count > 0 Then
    '        txtprodn.Text = table.Rows(0)(2)
    '    Else
    '        txtprodn.Text = ""
    '    End If

    '    If txtitemid.Text = "" Then
    '        txtprodn.Text = ""
    '    End If


    'End Sub


    'Private Sub txtstock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '        txtdes.Select()
    '    End If

    '    If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtstock_TextChanged(sender As Object, e As EventArgs)
    '    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
    '    connection.Open()

    '    Dim check As New SqlDataAdapter("select * from tblcart where itemid='" & txtitemid.Text & "'", connection)
    '    Dim table As New DataTable
    '    check.Fill(table)

    '    Dim quan As Integer = table.Rows(0)(4)

    '    If Val(txtstock.Text) > quan Then
    '        MsgBox("You can't move items higher than the Quantity", vbInformation)
    '        txtstock.Text = ""
    '    End If

    '    If Val(txtstock.Text) < 0 Then
    '        MsgBox("You can't move items lower than Zero", vbInformation)
    '        txtstock.Text = ""
    '    End If

    'End Sub
End Class