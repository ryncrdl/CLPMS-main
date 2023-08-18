Imports MetroFramework.Controls

Public Class LESSORACCOUNT
    Private data As List(Of MetroTextBox)
    Private Sub LESSORACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of MetroTextBox) From {txtname, txtage, txtemail, txtcontact, txtaddress, txtproperties, txtusername, txtpassword}
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextBox(data)
    End Sub
End Class