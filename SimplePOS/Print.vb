Imports System.Data.SqlClient
Public Class Print
    Dim command As SqlCommand
    Dim ind As Boolean = False
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        shadowback.Close()
    End Sub

    Private Sub btnreprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreprint.Click
        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connect.Open()
        'connection.Open()
        'Dim reader As SqlDataReader

        'Dim search As New SqlDataAdapter("select * from tbltrans where transid='" & Form2.lbltransind.Text & "'", connection)
        'Dim table As New DataTable
        'search.Fill(table)

        'If table.Rows.Count > 0 Then

        '    command = New SqlCommand("select * from tblsales where cosid='" & table.Rows(0)(1) & "'", connect)
        '    reader = command.ExecuteReader

        '    While reader.Read

        '        If ind = False Then
        '            Dim save As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount)values(@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connection)
        '            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '            save.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
        '            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NVarChar)).Value = reader.GetString(6)
        '            save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NVarChar)).Value = Form2.lbltransind.Text
        '            save.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NVarChar)).Value = table.Rows(0)(8)
        '            save.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = table.Rows(0)(6)
        '            save.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = table.Rows(0)(7)
        '            save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = CDate(table.Rows(0)(9))
        '            save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = table.Rows(0)(1)
        '            save.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = table.Rows(0)(5)
        '            save.ExecuteNonQuery()

        '            ind = True
        '        Else
        '            Dim save As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount)values(@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connection)
        '            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '            save.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
        '            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NVarChar)).Value = reader.GetString(6)
        '            save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NVarChar)).Value = Form2.lbltransind.Text
        '            save.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NVarChar)).Value = table.Rows(0)(8)
        '            save.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = CDate(table.Rows(0)(9))
        '            save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = table.Rows(0)(1)
        '            save.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = table.Rows(0)(5)
        '            save.ExecuteNonQuery()
        '        End If


        '    End While

        '    Me.Close()
        '    CartReport.Show()
        '    CartReport.TopMost = True
        '    CartReport.lblcloseind.Text = 1

        '    connect.Close()
        '    connection.Close()
        '    connect.Open()
        '    connection.Open()

        '    command = New SqlCommand("select * from tblreport", connection)
        '    reader = command.ExecuteReader

        '    While reader.Read
        '        Dim find As New SqlDataAdapter("delete from tblreport where itemid='" & reader.GetString(0) & "'", connect)
        '        Dim tablefind As New DataTable
        '        find.Fill(tablefind)
        '    End While

        'End If

        'ind = False

        'connect.Close()
        'connection.Close()
    End Sub

    Private Sub btnptrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnptrans.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        Dim connect As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connect.Open()
        connection.Open()
        Dim reader As SqlDataReader

        'Dim search As New SqlDataAdapter("select * from tbltrans where transid='" & Form2.lbltransind.Text & "'", connection)
        'Dim table As New DataTable
        'search.Fill(table)

        'If table.Rows.Count > 0 Then

        '    command = New SqlCommand("select * from tblsales where cosid='" & table.Rows(0)(1) & "'", connect)
        '    reader = command.ExecuteReader

        '    While reader.Read

        '        If ind = False Then
        '            Dim save As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount) values (@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connection)
        '            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '            save.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
        '            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NVarChar)).Value = reader.GetString(6)
        '            save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NVarChar)).Value = Form2.lbltransind.Text
        '            save.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NVarChar)).Value = table.Rows(0)(8)
        '            save.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = table.Rows(0)(6)
        '            save.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = table.Rows(0)(7)
        '            save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = CDate(table.Rows(0)(9))
        '            save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = table.Rows(0)(1)
        '            save.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = table.Rows(0)(5)
        '            save.ExecuteNonQuery()

        '            ind = True
        '        Else
        '            Dim save As New SqlCommand("insert into tblreport" & "(itemid,prodn,quan,earnings,transid,cashier,cash,change,date,row,cosid,discount) values (@itemid,@prodn,@quan,@earnings,@transid,@cashier,@cash,@change,@date,@row,@cosid,@discount)", connection)
        '            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = reader.GetString(1)
        '            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = reader.GetString(2)
        '            save.Parameters.Add(New SqlParameter("@quan", SqlDbType.NChar)).Value = reader.GetString(4)
        '            save.Parameters.Add(New SqlParameter("@earnings", SqlDbType.NVarChar)).Value = reader.GetString(6)
        '            save.Parameters.Add(New SqlParameter("@transid", SqlDbType.NVarChar)).Value = Form2.lbltransind.Text
        '            save.Parameters.Add(New SqlParameter("@cashier", SqlDbType.NVarChar)).Value = table.Rows(0)(8)
        '            save.Parameters.Add(New SqlParameter("@cash", SqlDbType.NChar)).Value = 0
        '            save.Parameters.Add(New SqlParameter("@change", SqlDbType.NChar)).Value = 0
        '            save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = CDate(table.Rows(0)(9))
        '            save.Parameters.Add(New SqlParameter("@row", SqlDbType.NChar)).Value = "0"
        '            save.Parameters.Add(New SqlParameter("@cosid", SqlDbType.NChar)).Value = table.Rows(0)(1)
        '            save.Parameters.Add(New SqlParameter("@discount", SqlDbType.NChar)).Value = table.Rows(0)(5)
        '            save.ExecuteNonQuery()
        '        End If


        '    End While

        '    Me.Close()

        '    Printtrans.Show()
        '    Printtrans.TopMost = True

        '    connect.Close()
        '    connection.Close()
        '    connect.Open()
        '    connection.Open()

        'command = New SqlCommand("select * from tblreport", connection)
        '    reader = command.ExecuteReader

        '    While reader.Read
        '        Dim find As New SqlDataAdapter("delete from tblreport where itemid='" & reader.GetString(0) & "'", connect)
        '        Dim tablefind As New DataTable
        '        find.Fill(tablefind)
        '    End While

        'End If

        connect.Close()
        connection.Close()
    End Sub

    Private Sub GunaPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GunaPanel1.Paint

    End Sub
End Class