Public Class ARCHIVEFILES
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnRecover.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to recover?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            CONFIRMPASS.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class