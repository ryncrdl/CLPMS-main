Imports MetroFramework.Controls

Module Validation2
    Public Function ValidateFieldsNotEmptyAdmin(data As List(Of MetroTextBox), ByRef validData As Boolean)
        ' Check if any of the fields are empty or null
        validData = True


        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter your name.")
            validData = False
            Return False
        End If

        Dim ageValue As Integer
        If Not Integer.TryParse(data(2).Text, ageValue) Or ageValue <= 0 Then
            MessageBox.Show("Please enter a valid age.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(3).Text.Trim()) Then
            MessageBox.Show("Please enter your email.")
            validData = False
            Return False
        End If

        If (String.IsNullOrEmpty(data(4).Text.Trim())) Then
            MessageBox.Show("Please enter your contact number.")
            Return False
        End If

        If String.IsNullOrEmpty(data(5).Text.Trim()) Then
            MessageBox.Show("Please enter your address.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(6).Text.Trim()) Then
            MessageBox.Show("Please enter your username.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(7).Text.Trim()) Then
            MessageBox.Show("Please enter your password.")
            validData = False
            Return False
        End If
    End Function

    Public Function ValidatePropertyData(data As List(Of MetroTextBox), ByRef validData As Boolean)
        ' Check if any of the fields are empty or null
        validData = True


        If String.IsNullOrEmpty(data(0).Text.Trim()) Then
            MessageBox.Show("Select row to update.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter a valid property name.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(2).Text.Trim()) Then
            MessageBox.Show("Please enter lessor.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(3).Text.Trim()) Then
            MessageBox.Show("Please enter floors.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(4).Text.Trim()) Then
            MessageBox.Show("Please enter floors Occu.")
            validData = False
            Return False
        End If


        If String.IsNullOrEmpty(data(5).Text.Trim()) Then
            MessageBox.Show("Please enter image file name.")
            validData = False
            Return False
        End If

    End Function

    Public Function ValidateFieldsNotEmptyLessee(data As List(Of MetroTextBox), gender As List(Of MetroComboBox), ByRef validData As Boolean)
        ' Check if any of the fields are empty or null
        validData = True

        If String.IsNullOrEmpty(data(0).Text.Trim()) Then
            MessageBox.Show("Select row to update.")
            validData = False
            Return False
        End If


        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter your name.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(gender(0).Text.Trim()) Then
            MessageBox.Show("Please enter a valid gender.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(2).Text.Trim()) Then
            MessageBox.Show("Please enter your email.")
            validData = False
            Return False
        End If

        If (String.IsNullOrEmpty(data(3).Text.Trim())) Then
            MessageBox.Show("Please enter your password.")
            Return False
        End If

    End Function

End Module
