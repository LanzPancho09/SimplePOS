Imports System.Data.SqlClient
Public Class Expireditemdata
    Dim rdata As Object() = Nothing

    Public Sub AssignData(ByVal r As Object())
        Me.rdata = r
    End Sub
    Private Sub btnMoveDefect_Click(sender As Object, e As EventArgs) Handles btnMoveDefect.Click

        If rdata Is Nothing Then
            MsgBox("No assigned data values.", vbCritical, "No Data Values")
            Return
        End If

        Dim connection As New SqlConnection("Data Source=DESKTOP-J94MAMS\SQLEXPRESS;Initial Catalog=SMPOS;User ID=sa;Password=1234")

        Try
            connection.Open()
            Console.WriteLine("Connection Succeeded! SQL Connection")
        Catch ex As Exception
            Console.WriteLine("Connection Error! SQL Connection")
            Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
        End Try

        Dim result As MsgBoxResult = MsgBox("This item will be moved to defect items. Including all of the stocks and it will be an expense. Are you sure?", vbQuestion + vbYesNo, "Action Confirmation")
        If result = MsgBoxResult.Yes Then

            Dim save As New SqlCommand("INSERT INTO tbldefect (defid,itemid,pname,affstock,value,descp,date) values (@defid,@itemid,@pname,@affstock,@value,@descp,@date)", connection)
            save.Parameters.Add(New SqlParameter("@defid", SqlDbType.Int)).Value = GenerateDefectID(connection)
            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.Int)).Value = rdata(1).ToString.Trim
            save.Parameters.Add(New SqlParameter("@pname", SqlDbType.NVarChar)).Value = rdata(2).ToString.Trim
            save.Parameters.Add(New SqlParameter("@affstock", SqlDbType.Int)).Value = Convert.ToInt32(rdata(5))
            save.Parameters.Add(New SqlParameter("@value", SqlDbType.Decimal)).Value = Convert.ToDecimal(rdata(6))
            save.Parameters.Add(New SqlParameter("@descp", SqlDbType.Text)).Value = "EXPIRED ITEM"
            save.Parameters.Add(New SqlParameter("@date", SqlDbType.Date)).Value = DateTime.Parse(rdata(4))
            save.ExecuteNonQuery()

            Dim update As New SqlCommand("UPDATE tblinventory SET expdt=@expdt,stock=@stock,isExp=@isExp WHERE invid=@invid", connection)
            update.Parameters.Add(New SqlParameter("@invid", SqlDbType.Int)).Value = Convert.ToInt32(rdata(0))
            update.Parameters.Add(New SqlParameter("@expdt", SqlDbType.Date)).Value = DBNull.Value
            update.Parameters.Add(New SqlParameter("@stock", SqlDbType.Int)).Value = 0
            update.Parameters.Add(New SqlParameter("@isExp", SqlDbType.Bit)).Value = False
            update.ExecuteNonQuery()

            Form2.btnexpired.PerformClick()
        End If

        connection.Close()

    End Sub

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

End Class
