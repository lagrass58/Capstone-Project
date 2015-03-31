'Project:       Columbus Computer Repair
'Form:          Login Screen
'Date:          November 13, 2011
'Purpose:       Login screen for Customer Form users.

Public Class CCR_LoginScreen
    'Declarations
    Const HRREPUSERNAME_STRING As String = "hrrep"
    Const MAXLOGINATTEMPTS_INTEGER As Integer = 2
    Private FailedLoginAttemptsInteger As Integer = 0


    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click

        If UsernameTextBox.Text = HRREPUSERNAME_STRING And PasswordTextBox.Text = HRREPUSERNAME_STRING Then
            EmployeeForm.Show()
            Me.Visible = False
        ElseIf FailedLoginAttemptsInteger = MAXLOGINATTEMPTS_INTEGER Then
            MessageBox.Show("You have exhausted the number of login attempts. Contact your system administrator.", "Login Failed", _
                    MessageBoxButtons.OK, MessageBoxIcon.Hand)
            UsernameTextBox.ReadOnly = True
            PasswordTextBox.ReadOnly = True
            LoginButton.Enabled = False
        Else
            MessageBox.Show("Invalid username or password.", "Retry Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FailedLoginAttemptsInteger += 1
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub
End Class