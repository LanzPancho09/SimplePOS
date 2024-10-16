Imports System.Data.SqlClient
Public Class InvDatapanel
    Dim ctr As Integer
    Dim command As SqlCommand
    Private itemData As Object()

    Public Sub ControlData(ByVal d As Object())
        Me.itemData = d
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'Updateitem.txtitemid.Text = RTrim(lblitemid.Text)
        'Updateitem.txtprodname.Text = lblproductn.Text
        'Updateitem.txtstock.Text = RTrim(lblstock.Text)
        'Updateitem.txtprice.Text = RTrim(lblprice.Text)

        'Updateitem.Show()
        'shadowback.Show()
        'Updateitem.TopMost = True

        shadowback.Show()
        InventoryManager.TabControl1.SelectedTab = InventoryManager.tabItems
        InventoryManager.lblTitle.Text = "Edit Item"
        InventoryManager.SetSaveState(False)
        InventoryManager.PopulateItemData(itemData)
        'POPULATE DATA


        InventoryManager.ShowDialog()


    End Sub

    Private Sub btnaddstk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstk.Click
        'Addstock.lblitemid.Text = RTrim(lblitemid.Text)
        'Addstock.txtprodname.Text = lblproductn.Text
        'Addstock.txtstock.Text = RTrim(lblstock.Text)

        'Addstock.Show()
        'shadowback.Show()
        'Addstock.TopMost = True
        'Addstock.txtaddstock.Text = ""
        'Addstock.txtaddstock.Select()

        shadowback.Show()
        InventoryManager.TabControl1.SelectedTab = InventoryManager.tabItemStock
        InventoryManager.lblTitle.Text = "Add Item Stock"
        InventoryManager.PopulateStockData(itemData)
        InventoryManager.ShowDialog()

    End Sub


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader
        Dim result As MsgBoxResult
        result = MsgBox("Are You Sure To Delete Item Id " & RTrim(lblitemid.Text) & " ?", MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then
            Dim delete As New SqlDataAdapter("delete from tblinventory where itemid='" & RTrim(lblitemid.Text) & "'", connection)
            Dim table As New DataTable
            delete.Fill(table)

            connection.Close()
            Form2.flowlayoutinv.Controls.Clear()
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
                    Form2.flowlayoutinv.Controls.Add(inv)
                End While
                ctr = 0
                connection.Close()
                connection.Open()

                Dim save As New SqlCommand("insert into tblinvlog" & "(product,action,date) values (@product,@action,@date)", connection)
                save.Parameters.Add(New SqlParameter("@product", SqlDbType.NVarChar)).Value = lblproductn.Text
                save.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Delete"
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = Today & " " & Format(TimeOfDay, "hh:mm tt")
                save.ExecuteNonQuery()

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub InvDatapanel_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(235, 235, 235))
            Dim startP As New Point(0, Me.Height - 1)
            Dim endP As New Point(Me.Width - 1, Me.Height - 1)
            g.DrawLine(p, startP, endP)
        End Using
    End Sub
End Class
