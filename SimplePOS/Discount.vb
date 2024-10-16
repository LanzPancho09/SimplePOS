Imports System.Globalization
Public Class Discount
    Dim total, localprice, finalprice As Double
    Dim discounted As Boolean = False

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
    Private Sub txtrate_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.Enter
        If txtrate.Text = "0%" Then
            txtrate.Text = ""
            txtrate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtrate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.Leave
        If txtrate.Text = "" Then
            txtrate.Text = "0%"
            txtrate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnsolve.PerformClick()
        End If
    End Sub

    Private Sub Discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim price As String
        price = Form2.lbltotal.Text
        localprice = price.Replace(",", String.Empty)

        lblcomputed.Text = Form2.lbltotal.Text
    End Sub

    Private Sub btnsolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsolve.Click

        If isvalid(txtrate.Text) = True Then
            Dim value, comp As Double
            value = Val(txtrate.Text) / 100
            total = value * localprice
            comp = localprice - total

            If comp = Int(comp) Then
                lblcomputed.Text = comp.ToString("N")
            Else
                lblcomputed.Text = comp.ToString("N", CultureInfo.InvariantCulture)
            End If

            txtrate.Text = txtrate.Text & "%"

            btnsubmit.PerformClick()

            txtrate.Enabled = False
            btnsolve.Enabled = False
            btnsubmit.Enabled = True
            btnsolve.Visible = False
        Else
            MsgBox("Invalid Input", vbInformation)
            txtrate.Text = ""
            txtrate.Select()
        End If



    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click


        Me.Close()
        SavePOS.Show()
        SavePOS.TopMost = True
        Dim price As String
        price = SavePOS.lbltotal.Text
        finalprice = price.Replace(",", String.Empty)

        If total = Int(total) Then
            SavePOS.lbltotal.Text = finalprice - total & ".00"
            SavePOS.lbldiscount.Text = total * -1 & ".00"
        Else
            SavePOS.lbltotal.Text = finalprice - total
            SavePOS.lbldiscount.Text = total * -1
        End If

        total = 0
        localprice = 0

        SavePOS.btndiscount.Enabled = False
        SavePOS.btnundo.Visible = True




    End Sub


    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        SavePOS.Show()
        SavePOS.TopMost = True

    End Sub

    Private Sub txtrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.TextChanged

        If isvalid(txtrate.Text) = True Then
            txtrate.FocusedBorderColor = Color.FromArgb(100, 88, 255)
            btnsolve.Enabled = True

            If Val(txtrate.Text) > 100 Then
                txtrate.Text = "100"
            End If

            If txtrate.Text = "" Then
                lblcomputed.Text = Form2.lbltotal.Text
            End If
        Else
            txtrate.FocusedBorderColor = Color.FromArgb(201, 0, 0)
            btnsolve.Enabled = False
        End If


    End Sub
End Class