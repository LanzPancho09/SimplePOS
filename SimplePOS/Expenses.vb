Imports System.Data.SqlClient
Public Class Expenses
    Dim gen As Integer
    Private Sub txtdes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdes.Enter
        If txtdes.Text = "Description..." Then
            txtdes.Text = ""
            txtdes.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtdes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdes.Leave
        If txtdes.Text = "" Then
            txtdes.Text = "Description..."
            txtdes.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtprice_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.Enter
        If txtprice.Text = "Enter Price..." Then
            txtprice.Text = ""
            txtprice.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtprice_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.Leave
        If txtprice.Text = "" Then
            txtprice.Text = "Enter Price..."
            txtprice.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Expenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlshad, Color.Black, 40, 8, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()

        gen = 1
        While gen > 0
            Dim search As New SqlDataAdapter("select * from tblexpenses where no='" & gen & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then
                gen = gen + 1
            Else
                lblind.Text = gen
                gen = 0
            End If
        End While


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        shadowback.Close()
        Form2.Show()
    End Sub



    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()


        If Not txtdes.Text = "" And Not txtprice.Text Then
            Dim save As New SqlCommand("insert into tblexpenses" & "(no,exp,price,date,month) values (@no,@exp,@price,@date,@month)", connection)
            save.Parameters.Add(New SqlParameter("@no", SqlDbType.NChar)).Value = Val(lblind.Text)
            save.Parameters.Add(New SqlParameter("@exp", SqlDbType.NVarChar)).Value = txtdes.Text
            save.Parameters.Add(New SqlParameter("@price", SqlDbType.NChar)).Value = txtprice.Text
            save.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = TimeOfDay & " " & Format(Today, "dddd dd MMMM yyyy")
            save.Parameters.Add(New SqlParameter("@month", SqlDbType.NVarChar)).Value = Format(Today, "MMMM yyyy")
            save.ExecuteNonQuery()

            Dim add As New SqlCommand("insert into tblchart" & "(no,exp,date) values (@no,@exp,@date)", connection)
            add.Parameters.Add(New SqlParameter("@no", SqlDbType.NChar)).Value = "expenses"
            add.Parameters.Add(New SqlParameter("@exp", SqlDbType.NChar)).Value = Val(txtprice.Text) * -1
            add.Parameters.Add(New SqlParameter("@date", SqlDbType.NVarChar)).Value = TimeOfDay & " " & Format(Today, "dd MMMM yyyy")
            add.ExecuteNonQuery()

            MsgBox("Record Added!", vbInformation)

            gen = 1
            While gen > 0
                Dim search As New SqlDataAdapter("select * from tblexpenses where no='" & gen & "'", connection)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count > 0 Then
                    gen = gen + 1
                Else
                    lblind.Text = gen
                    gen = 0
                End If
            End While
            txtdes.Text = ""
            txtprice.Text = ""

            Me.Close()
            shadowback.Close()
            Form2.Show()

            Form2.btnexpenses.PerformClick()
        Else
            MsgBox("Please Fill Up Blank Spaces", vbInformation)
        End If
        

    End Sub
End Class