'Project:       Columbus Computer Repair
'Form:          Login Screen
'Date:          November 13, 2011
'Purpose:       Login screen for Part Form users.

Public Class CCR_LoginScreen
    'Declarations
    Const MANAGERUSERNAME_STRING As String = "manager"
    Const INVENTORYUSERNAME_STRING As String = "inventory"
    Const MAXLOGINATTEMPTS_INTEGER As Integer = 2
    Private FailedLoginAttemptsInteger As Integer = 0


    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click

        If UsernameTextBox.Text = MANAGERUSERNAME_STRING And PasswordTextBox.Text = MANAGERUSERNAME_STRING Or
            UsernameTextBox.Text = INVENTORYUSERNAME_STRING And PasswordTextBox.Text = INVENTORYUSERNAME_STRING Then
            PartForm.Show()
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