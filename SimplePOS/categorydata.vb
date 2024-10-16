Imports System.Data.SqlClient

Public Class categorydata

    Private rawData As Object()

    Public Sub AssignData(ByVal r As Object())
        Me.rawData = r
    End Sub

    Private Sub categorydata_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(245, 245, 245))
            Dim offset As Integer = 20
            Dim startPos As New Point(0, Me.Height - 1)
            Dim endPos As New Point(Me.Width - 1, Me.Height - 1)
            g.DrawLine(p, startPos, endPos)
        End Using

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        InventoryManager.TabControl1.SelectedTab = InventoryManager.tabCatItems
        InventoryManager.lblTitle.Text = "Edit Category"
        InventoryManager.SetCategoryState(False)
        InventoryManager.SetCategoryId(rawData(0))
        InventoryManager.txtCategory.Text = rawData(1).ToString.Trim
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim connection As New SqlConnection("Data Source=DESKTOP-J94MAMS\SQLEXPRESS;Initial Catalog=SMPOS;User ID=sa;Password=1234")

        Try
            connection.Open()
            Console.WriteLine("Connection Succeeded! SQL Connection")
        Catch ex As Exception
            Console.WriteLine("Connection Error! SQL Connection")
            Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
        End Try

        Dim result As MsgBoxResult = MsgBox("Are you sure to PERMANENTLY delete '" & rawData(1).ToString.Trim & "'? This action cannot be undone.", vbExclamation + vbYesNo, "Category Deletion")

        If result = MsgBoxResult.Yes Then

            Dim adaptor As New SqlDataAdapter("SELECT * FROM tblinventory WHERE cat='" & rawData(1).ToString.Trim & "'", connection)
            Dim table As New DataTable
            adaptor.Fill(table)

            If table.Rows.Count > 0 Then
                MsgBox("Category '" & rawData(1).ToString.Trim & "' cannot be deleted because it is used in another table.", vbCritical, "Deletion Error")
                Return
            End If

            Dim delete As New SqlCommand("DELETE FROM tblcat WHERE catId='" & rawData(0) & "'", connection)
            delete.ExecuteNonQuery()
            MsgBox("Category deleted successfully!", vbInformation, "Category Deletion")
            InventoryManager.LoadCategoryTable()
        End If

    End Sub
End Class
