Public Class Datapanel1

    Private Sub Datapanel1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblprodn.AutoSize = False
        lblprodn.AutoEllipsis = True
    End Sub

    Private Sub Datapanel1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(235, 235, 235))
            Dim startP As New Point(0, Me.Height - 1)
            Dim endP As New Point(Me.Width - 1, Me.Height - 1)
            g.DrawLine(p, startP, endP)
        End Using
    End Sub

    Private Sub lblprodn_Click(sender As Object, e As EventArgs) Handles lblprodn.Click

    End Sub

    Private Sub lblquantity_Click(sender As Object, e As EventArgs) Handles lblquantity.Click

    End Sub

    Private Sub lblpcode_Click(sender As Object, e As EventArgs) Handles lblpcode.Click

    End Sub
End Class
