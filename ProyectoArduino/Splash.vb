Public Class Splash
    
    ' Aumenta el valor de la barra de progreso hasta llegar a 100 y muestra la ventana principal
    Private Sub ClockProgress_Tick(sender As Object, e As EventArgs) Handles ClockProgress.Tick
        ProgressLoading.Value += 2

        If ProgressLoading.Value = 100 Then
            ClockProgress.Stop()
            Me.Hide()
            Main.Show()
        End If
    End Sub
End Class