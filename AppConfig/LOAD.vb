﻿Public Class LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2ProgressBar1.Value += 5
        If Guna2ProgressBar1.Value = 100 Then
            Timer1.Stop()
            LOGIN.Show()
            Me.Hide()
        End If
    End Sub
End Class
