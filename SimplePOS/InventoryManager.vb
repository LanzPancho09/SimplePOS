Imports System.Data.SqlClient

Public Class InventoryManager

    Dim categoryHeaderLabels As New List(Of Guna.UI.WinForms.GunaLabel)
    Dim isItemSave As Boolean = True

    Public Sub SetSaveState(ByVal b As Boolean)
        isItemSave = b
    End Sub

    Public Sub SetCategoryId(ByVal id As Integer)
        Me.categoryId = id
    End Sub

    Public Sub SetCategoryState(ByVal b As Boolean)
        Me.isSaveCategory = b
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ExitForm()
    End Sub

    Private Sub InventoryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlSeperator, Color.Black, 40, 10, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlItemFooter, Color.Black, 40, 1, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlMcategoryFooter, Color.Black, 40, 1, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'RepoCategory()

    End Sub

    Private Sub InventoryManager_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        'Using g As Graphics = e.Graphics
        '    Dim p As New Pen(Color.Silver)
        '    Dim offset As Integer = 20
        '    Dim startPos As New Point((Me.Width - 1) / 2, offset)
        '    Dim endPos As New Point((Me.Width - 1) / 2, (Me.Height - 1) - offset)
        '    g.DrawLine(p, startPos, endPos)
        'End Using

    End Sub

    Private Sub RepoCategory()
        Dim headerOffset As Integer = 18
        Dim headerWidth As Integer = pnlCategoryHeader.Width - headerOffset
        Dim labelCount As Integer = pnlCategoryHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
        Dim workingArea As Integer = headerWidth / labelCount

        Dim xP As Integer = workingArea / 2
        Dim yP As Integer = pnlCategoryHeader.Height / 2

        Dim headerLabelTexts() As String = {"CATEGORY ID", "NAME", "ACTION"}

        Dim labelOffset As Integer = 10
        Dim i As Integer = 0
        For Each ctrl As Control In pnlCategoryHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
            ctrl.Text = headerLabelTexts(i)
            ctrl.Size = New Size(workingArea - labelOffset, ctrl.Size.Height)
            ctrl.Location = New Point((xP + (labelOffset / 2)) - (workingArea / 2), yP - (ctrl.Size.Height / 2))
            categoryHeaderLabels.Add(ctrl)
            xP += workingArea
            i += 1
        Next
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        TabControl1.SelectedTab = tabCatItems
        lblTitle.Text = "Add Category"
        SetCategoryState(True)
    End Sub

    Dim isSaveCategory As Boolean = True
    Dim categoryId As Integer = -1
    Private Sub btnCategorySave_Click(sender As Object, e As EventArgs) Handles btnCategorySave.Click

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        If isSaveCategory Then
            Dim save As New SqlCommand("INSERT INTO tblcat" & "(catId,cat) VALUES (@catId,@cat)", connection)
            save.Parameters.Add(New SqlParameter("@catId", SqlDbType.Int)).Value = GenerateCategoryID(connection)
            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = txtCategory.Text
            save.ExecuteNonQuery()

            MsgBox("Category Added Successfully!", vbInformation)
        Else

            Dim adapter As New SqlDataAdapter("SELECT * FROM tblinventory WHERE cat=(SELECT cat FROM tblcat WHERE catId='" & categoryId & "')", connection)
            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim result As MsgBoxResult = MsgBox("There are items associated with the current category, those category items will be updated once you accept. Are you sure to confirm this action?", vbExclamation + vbYesNo, "Updating Category Values")
                If result = MsgBoxResult.Yes Then
                    Dim command As New SqlCommand("UPDATE tblinventory SET cat= REPLACE(cat,(SELECT cat FROM tblcat WHERE catId='" & categoryId & "'),'" & txtCategory.Text & "') WHERE cat=(SELECT cat FROM tblcat WHERE catId='" & categoryId & "')", connection)
                    command.ExecuteNonQuery()
                Else
                    Return
                End If
            End If

            Dim update As New SqlCommand("UPDATE tblcat SET cat='" & txtCategory.Text & "' WHERE catId='" & categoryId & "'", connection)
            update.ExecuteNonQuery()

            MsgBox("Category Updated Succesfully!", vbInformation)
        End If
        connection.Close()

        TabControl1.SelectedTab = tabCategory
        lblTitle.Text = "Categories"
        LoadCategoryTable()

    End Sub

    Private Sub btnCategoryCancel_Click(sender As Object, e As EventArgs) Handles btnCategoryCancel.Click

        TabControl1.SelectedTab = tabCategory
        lblTitle.Text = "Categories"
        LoadCategoryTable()

    End Sub

    Dim editInventoryId As Integer = -1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        If isItemSave Then

            Dim save As New SqlCommand("INSERT INTO tblinventory" & "(invid,itemid,prodn,cat,expdt,stock,price,isExp) VALUES (@invid,@itemid,@prodn,@cat,@expdt,@stock,@price,@isExp)", connection)
            save.Parameters.Add(New SqlParameter("@invid", SqlDbType.Int)).Value = GenerateInventoryID(connection)
            save.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtItemid.Text
            save.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtProductName.Text
            save.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbCategory.SelectedItem.ToString()

            If chkbExpire.Checked Then
                save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.Date)).Value = DBNull.Value
            Else
                Dim dt As DateTime = DateTime.Parse(dtpExpire.Value)
                save.Parameters.Add(New SqlParameter("@expdt", SqlDbType.Date)).Value = dt
            End If

            save.Parameters.Add(New SqlParameter("@stock", SqlDbType.Int)).Value = Convert.ToInt32(txtStock.Text)
            save.Parameters.Add(New SqlParameter("@price", SqlDbType.Decimal)).Value = Convert.ToDecimal(txtPrice.Text)

            If chkbExpire.Checked Then
                save.Parameters.Add(New SqlParameter("@isExp", SqlDbType.Bit)).Value = False
            Else
                save.Parameters.Add(New SqlParameter("@isExp", SqlDbType.Bit)).Value = True
            End If

            save.ExecuteNonQuery()

        Else

            If editInventoryId = -1 Then
                MsgBox("No item selected!", vbInformation)
                Return
            End If

            'Dim update As New SqlCommand("Update tblacc set name=@name,profile=@profile,username=@username,password=@password,accesstype=@accesstype where accid=@id", connection)
            'update.Parameters.AddWithValue("@id", txtaccid.Text)
            'update.Parameters.AddWithValue("@name", txtname.Text)
            'update.Parameters.AddWithValue("@profile", MS.ToArray)
            'update.Parameters.AddWithValue("@username", txtusername.Text)
            'update.Parameters.AddWithValue("@password", txtpassword.Text)
            'update.Parameters.AddWithValue("@accesstype", cbaccesstype.Text)
            'update.ExecuteNonQuery()

            Dim update As New SqlCommand("UPDATE tblinventory SET itemid=@itemid, prodn=@prodn,cat=@cat,expdt=@expdt,stock=@stock,price=@price,isExp=@isExp WHERE invid=@invid", connection)
            update.Parameters.Add(New SqlParameter("@itemid", SqlDbType.NChar)).Value = txtItemid.Text
            update.Parameters.Add(New SqlParameter("@prodn", SqlDbType.NVarChar)).Value = txtProductName.Text
            update.Parameters.Add(New SqlParameter("@cat", SqlDbType.NVarChar)).Value = cbCategory.SelectedItem.ToString

            If chkbExpire.Checked Then
                update.Parameters.Add(New SqlParameter("@expdt", SqlDbType.Date)).Value = DBNull.Value
                update.Parameters.Add(New SqlParameter("@isExp", SqlDbType.Bit)).Value = False
            Else
                update.Parameters.Add(New SqlParameter("@expdt", SqlDbType.Date)).Value = dtpExpire.Value
                update.Parameters.Add(New SqlParameter("@isExp", SqlDbType.Bit)).Value = True
            End If

            update.Parameters.Add(New SqlParameter("@stock", SqlDbType.Int)).Value = Convert.ToInt32(txtStock.Text)
            update.Parameters.Add(New SqlParameter("@price", SqlDbType.Decimal)).Value = Convert.ToDecimal(txtPrice.Text)
            update.Parameters.Add(New SqlParameter("@invid", SqlDbType.Int)).Value = editInventoryId
            update.ExecuteNonQuery()

            editInventoryId = -1

            MsgBox("Item edited successfully")

        End If

        connection.Close()
        ExitForm()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If Not isItemSave Then
            editInventoryId = -1
        End If
        ClearItemForm()

        ExitForm()

    End Sub

    Dim stockInventoryID As Integer = -1
    Private Sub btnStockSave_Click(sender As Object, e As EventArgs) Handles btnStockSave.Click

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim update As New SqlCommand("UPDATE tblinventory SET stock=@stock WHERE invid=@invid", connection)
        update.Parameters.Add(New SqlParameter("@stock", SqlDbType.Int)).Value = Convert.ToInt32(Val(txtSCurrentStock.Text) + Val(txtSAddStock.Text))
        update.Parameters.Add(New SqlParameter("@invid", SqlDbType.Int)).Value = stockInventoryID
        update.ExecuteNonQuery()
        stockInventoryID = -1

        MsgBox("Stock Added Successfully!", vbInformation)
        connection.Close()

        ExitForm()

    End Sub

    Private Sub btnStockCancel_Click(sender As Object, e As EventArgs) Handles btnStockCancel.Click
        stockInventoryID = -1
        ClearItemForm()
        ExitForm()
    End Sub

    Private Function GenerateInventoryID(ByVal c As SqlConnection) As Integer

        Dim i As Integer = 0
        While True
            Dim adapter As New SqlDataAdapter("SELECT * FROM tblinventory WHERE invid='" & i & "'", c)
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

    Private Function GenerateCategoryID(ByVal c As SqlConnection) As Integer

        Dim i As Integer = 0
        While True
            Dim adapter As New SqlDataAdapter("SELECT * FROM tblcat WHERE catId='" & i & "'", c)
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

    Public Sub LoadCategoryTable()

        RepoCategory()

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        While flpCategory.Controls.Count > 0
            Dim ctrl As categorydata = flpCategory.Controls(0)
            flpCategory.Controls.Remove(ctrl)
            ctrl.Dispose()
        End While

        Dim command As New SqlCommand("SELECT * FROM tblcat", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read

            Dim categoryControl As New categorydata
            With categoryControl
                .Margin = New Padding(0)
                Dim controlOffset As Integer = 18
                .Width -= controlOffset

                Dim rowData(1) As Object
                rowData(0) = reader.GetInt32(0)
                rowData(1) = reader.GetString(1)
                .AssignData(rowData)

                .lblno.Text = reader.GetInt32(0).ToString()
                .lblcat.Text = reader.GetString(1).Trim()

                Dim j As Integer = 0
                For Each c As Control In categoryControl.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Reverse
                    c.Size = categoryHeaderLabels(j).Size
                    c.Location = categoryHeaderLabels(j).Location
                    j += 1
                Next

                Dim workingArea As Integer = .Width / pnlCategoryHeader.Controls.OfType(Of Guna.UI.WinForms.GunaLabel).Count
                Dim buttonArea As Integer = .btnUpdate.Size.Width + .btnDelete.Size.Width + 5
                .btnUpdate.Location = New Point(((workingArea / 2) - buttonArea / 2) + categoryHeaderLabels(j).Location.X, (.Size.Height / 2) - .btnUpdate.Size.Height / 2)
                .btnDelete.Location = New Point(.btnUpdate.Location.X + .btnDelete.Size.Width + 5, (.Size.Height / 2) - .btnDelete.Size.Height / 2)


            End With
            flpCategory.Controls.Add(categoryControl)

        End While

        connection.Close()

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

    Public Sub PopulateItemData(ByVal data As Object())

        editInventoryId = data(0)

        txtItemid.Text = data(1).ToString.Trim
        txtProductName.Text = data(2).ToString.Trim
        'kapag ung category is nag eexists sa inventory table bawal burahin
        cbCategory.SelectedItem = data(3).ToString.Trim

        If Not (data(4) = Nothing) Then
            dtpExpire.Value = DateTime.Parse(data(4))
        End If

        txtStock.Text = data(5)
        txtPrice.Text = data(6)
        chkbExpire.Checked = Convert.ToBoolean(data(7))

    End Sub

    Public Sub PopulateStockData(ByVal data As Object())
        stockInventoryID = data(0)
        txtSItemID.Text = data(1).ToString.Trim
        txtSProdName.Text = data(2).ToString.Trim
        txtSCurrentStock.Text = data(5)
    End Sub

    Private Sub ClearItemForm()

        txtItemid.Text = ""
        txtProductName.Text = ""
        cbCategory.SelectedIndex = -1
        dtpExpire.Value = DateTime.Today
        txtStock.Text = ""
        txtPrice.Text = ""

        txtSItemID.Text = ""
        txtSProdName.Text = ""
        txtSCurrentStock.Text = ""
        txtSAddStock.Text = ""

    End Sub

    Private Sub ExitForm()
        'closing
        Me.Close()
        shadowback.Close()
        Form2.Select()
    End Sub

    Private Sub pnlCategoryHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlCategoryHeader.Paint

        'Using g As Graphics = e.Graphics
        '    Dim p As New Pen(Color.FromArgb(220, 220, 220))
        '    Dim offset As Integer = 0
        '    Dim startPos As New Point(0, 0)
        '    Dim endPos As New Point(Me.Width - 1, 0)
        '    g.DrawLine(p, startPos, endPos)
        'End Using

    End Sub
End Class