Imports MongoDB.Driver

Public Class LOGIN
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox1.Text = "Hide"
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            CheckBox1.Text = "Show"
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If (Guna2TextBox1.Text = "") Then
            MsgBox("Please enter your username")
            Guna2TextBox1.Focus()

        ElseIf (Guna2Textbox2.Text = "") Then
            MsgBox("Please enter your password")
            Guna2TextBox2.Focus()

        Else
            Try
                Dim username As String = Guna2TextBox1.Text
                Dim password As String = Guna2TextBox2.Text

                ' Retrieve the existing admin data from MongoDB
                Dim adminsCollection = Connection1.GetAdminsCollection()

                ' Build the filter to find the admin with the specified username and password
                Dim filter = Builders(Of ADMINREGISISTRATION.Admin).Filter.And(
                Builders(Of ADMINREGISISTRATION.Admin).Filter.Eq(Function(a) a.Username, username),
                Builders(Of ADMINREGISISTRATION.Admin).Filter.Eq(Function(a) a.Password, password)
            )

                ' Check if an admin with the given credentials exists
                Dim admin As ADMINREGISISTRATION.Admin = adminsCollection.Find(filter).FirstOrDefault()

                If admin IsNot Nothing Then
                    ' Successfully logged in
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Guna2TextBox1.Clear()
                    Guna2TextBox2.Clear()
                    Me.Close()
                    DASHBOARD.Show()
                Else
                    ' Invalid credentials
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Guna2TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to logout ?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
End Class