Imports System.Data.SqlClient
Public Class Defectitem
    'Dim ctr As Integer
    'Dim command As SqlCommand
    Dim rawData As Object() = Nothing

    Public Sub AssignData(ByVal r As Object())
        Me.rawData = r
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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        If rawData Is Nothing Then
            Return
        End If

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim result As MsgBoxResult = MsgBox("Item id '" & rawData(1).ToString.Trim & "' will be PERMANENTLY deleted. Are you sure?", vbQuestion + vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then
            Dim delete As New SqlCommand("DELETE FROM tbldefect WHERE defid='" & Convert.ToInt32(rawData(0)) & "'", connection)
            delete.ExecuteNonQuery()
            Form2.btndefect.PerformClick()
        End If

        connection.Close()


        'shadowback.Show()
        'Defectform.PopulateDeleteData(rawData)
        'Defectform.lblTitle.Text = "Delete Defect Item"
        'Defectform.FormStatus(False)
        'Defectform.TabControl1.SelectedTab = Defectform.TabPage2
        'Defectform.ShowDialog()

        'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        'connection.Open()
        'Dim reader As SqlDataReader

        '    Dim delete As New SqlDataAdapter("delete from tbldefect where itemid='" & RTrim(lblpname.Text) & "'", connection)
        '    Dim deltbl As New DataTable
        '    delete.Fill(deltbl)

        '    Form2.flowlayoutinv.Controls.Clear()
        '    Try
        '        command = New SqlCommand("select * from tbldefect", connection)
        '        reader = command.ExecuteReader
        '        While reader.Read
        '            Dim defectpanel As Defectitem
        '            defectpanel = New Defectitem

        '            ctr = ctr + 1

        '            If ctr = 1 Then
        '                With defectpanel
        '                    .lblpname.Text = reader.GetString(0)
        '                    .lblAffstock.Text = reader.GetString(1)
        '                    .lblValue.Text = reader.GetString(2)
        '                    .lbldesc.Text = reader.GetString(3)
        '                '.lblaname.Text = reader.GetString(4)
        '                .BackColor = Color.White
        '                End With
        '            Else
        '                With defectpanel
        '                    .lblpname.Text = reader.GetString(0)
        '                    .lblAffstock.Text = reader.GetString(1)
        '                    .lblValue.Text = reader.GetString(2)
        '                    .lbldesc.Text = reader.GetString(3)
        '                '.lblaname.Text = reader.GetString(4)
        '                .BackColor = Color.GhostWhite
        '                End With
        '                ctr = 0
        '            End If

        '            Form2.flowlayoutinv.Controls.Add(defectpanel)

        '        End While
        '        ctr = 0
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try



    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        shadowback.Show()
        Defectform.PopulateData(rawData)
        Defectform.lblTitle.Text = "Edit Defect Item"
        Defectform.SetState(False)
        Defectform.ShowDialog()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If rawData Is Nothing Then
            Return
        End If

        Dim connection As SqlConnection = SQLConnect()
        If connection Is Nothing Then
            MsgBox("There's an error connecting to the database.", vbCritical, "Database Connection")
            Return
        End If

        Dim result As MsgBoxResult = MsgBox("Item id '" & rawData(1).ToString.Trim & "' will return to inventory including all of its stocks. Are you sure?", vbQuestion + vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then
            Dim update As New SqlCommand("UPDATE tblinventory SET stock=((SELECT stock FROM tblinventory WHERE itemid=" & Val(rawData(1).ToString.Trim) & ") + " & Val(Convert.ToInt32(rawData(3))) & ") WHERE itemid=" & Val(rawData(1).ToString.Trim) & "", connection)
            update.ExecuteNonQuery()

            Dim delete As New SqlCommand("DELETE FROM tbldefect WHERE defid='" & Convert.ToInt32(rawData(0)) & "'", connection)
            delete.ExecuteNonQuery()

            Form2.btndefect.PerformClick()
        End If

        connection.Close()

    End Sub
End Class
