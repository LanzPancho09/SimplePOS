Public Class Loading

    Private Sub tmloading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmloading.Tick

        If GunaProgressBar1.Value = 100 Then
            tmloading.Stop()
            Me.Close()
        Else
            GunaProgressBar1.Increment(10)
        End If

    End Sub

    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmloading.Start()
    End Sub
End Class