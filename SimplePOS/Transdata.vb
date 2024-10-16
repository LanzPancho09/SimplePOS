Imports System.Data.SqlClient
Imports System.Globalization
Public Class Transdata
    Dim command As SqlCommand
    Dim transid As String
    Dim ctr As Integer
    Public Shared query As String

    Private Sub trans_selection()
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        If query = "" Then
            query = "select * from tbltrans"
        End If

        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader

        Form2.flowlayoutTRANS.Controls.Clear()
        While reader.Read
            Dim trans As Transdata
            trans = New Transdata
            trans.Margin = New Padding(0)

            If transid = reader.GetString(0) Then
                With trans
                    Dim price As Double

                    .BackColor = Color.FromArgb(26, 87, 86)
                    .lbltransactionID.ForeColor = Color.White
                    .lblcashier.ForeColor = Color.White
                    .lblcosid.ForeColor = Color.White
                    .lbldate.ForeColor = Color.White
                    .lblsubtotal.ForeColor = Color.White
                    .lbldiscount.ForeColor = Color.White
                    .lblchange.ForeColor = Color.White
                    .lblpay.ForeColor = Color.White

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
            End If

            Form2.flowlayoutTRANS.Controls.Add(trans)

        End While

    End Sub
    Private Sub btnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselect.Click
        Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS;Database=SMPOS;Trusted_Connection=True;")
        connection.Open()
        Dim reader As SqlDataReader

        Form2.btntransprint.Visible = True

        'Form2.lbltransind.Text = lbltransactionID.Text
        'Form2.lblcosidnum.Text = lblcosid.Text
        transid = lbltransactionID.Text

        command = New SqlCommand("select * from tblsales where cosid='" & lblcosid.Text & "'", connection)
        reader = command.ExecuteReader

        'Form2.flowlayoutCOS.Controls.Clear()
        While reader.Read
            Dim cos As Costumerdata
            cos = New Costumerdata
            cos.Margin = New Padding(0)

            ctr = ctr + 1

            If ctr = 1 Then
                With cos
                    Dim price As Double

                    .BackColor = Color.GhostWhite
                    .lblitemid.Text = reader.GetString(1)
                    .lblproductname.Text = reader.GetString(2)

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblearnings.Text = price.ToString("N")
                    Else
                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                End With
            Else
                With cos
                    Dim price As Double

                    .BackColor = Color.White
                    .lblitemid.Text = reader.GetString(1)
                    .lblproductname.Text = reader.GetString(2)

                    price = reader.GetString(6)
                    If price = Int(price) Then
                        .lblearnings.Text = price.ToString("N")
                    Else
                        .lblearnings.Text = price.ToString("N", CultureInfo.InvariantCulture)
                    End If

                End With
                ctr = 0
            End If
            'Form2.flowlayoutCOS.Controls.Add(cos)
        End While

        trans_selection()

    End Sub

    

End Class
