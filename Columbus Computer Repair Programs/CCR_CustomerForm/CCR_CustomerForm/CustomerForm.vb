'Project:       Columbus Computer Repair
'Form:          Customer Form
'Date:          November 6, 2011
'Purpose:       Allows user to add customers to the database, update customer information, and delete customers 
'               from the database.

Public Class CustomerForm

    'Module-level declarations.
    Private ACustomerDataTier As CustomerDataTier
    Private CustomerDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private WithEvents CustomerBindingSource As BindingSource
    Private ACustomerTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
    Private AddingBoolean As Boolean = False
    Private EditingBoolean As Boolean = False
    Private PreviousSelectedIndex As Integer
    Private SetupCompleteBoolean As Boolean = False

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles AboutToolStripMenuItem.Click
        'Display the About Box form.

        Dim AnAboutBox As New CCR_AboutBox
        AnAboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ExitToolStripMenuItem.Click, CloseButton.Click
        'Exits the program.

        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Display the date and time in the status bar.
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
        SetControlsReadOnly(True)
        Try
            ACustomerDataTier = New CustomerDataTier
            CustomerDataSet = New ColumbusComputerRepair_DatabaseDataSet
            ACustomerTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
            ACustomerTableAdapter.Fill(CustomerDataSet.Customer)

            'Set up the BindingSource.
            CustomerBindingSource = New BindingSource
            With CustomerBindingSource
                .DataSource = CustomerDataSet
                .DataMember = "Customer"
                .Sort = "Customer_Name"
            End With

            'Bind the controls.
            With CustomerNameComboBox
                .DataSource = CustomerBindingSource
                .DisplayMember = "Customer_Name"
                .DataBindings.Add("text", CustomerBindingSource, "Customer_Name", False, DataSourceUpdateMode.Never)
            End With
            CustomerNameTextBox.DataBindings.Add("text", CustomerBindingSource, "Customer_Name")
            CustomerIDTextBox.DataBindings.Add("text", CustomerBindingSource, "Customer_ID")
            CustomerAddressTextBox.DataBindings.Add("text", CustomerBindingSource, "Customer_Address")
            CustomerPhoneTextBox.DataBindings.Add("text", CustomerBindingSource, "Customer_Phone")
            EmailAddressTextBox.DataBindings.Add("text", CustomerBindingSource, "Email_Address")
            CustomerTypeComboBox.DataBindings.Add("text", CustomerBindingSource, "Customer_Type", True, _
                DataSourceUpdateMode.OnValidation, Nothing, "d")
            CustomerTypeComboBox.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSaveButton.Click
        'Begin an Add operation or cancel the current operation.

        If AddSaveButton.Text = "&Add Customer" Then
            With CustomerBindingSource
                .EndEdit()
                .AddNew()
            End With
            AddingBoolean = True
            SetUpCustomerNameTextBox(True)
            SetControlsReadOnly(False)
            SetButtonsForEdit()
            If CustomerNameComboBox.SelectedIndex <> -1 Then
                'Save index of the new record.
                PreviousSelectedIndex = CustomerNameComboBox.Items.Count - 1
            Else
                PreviousSelectedIndex = 0
            End If
            CustomerIDTextBox.Text = CustomerNameComboBox.Items.Count.ToString
        Else
            'Save button clicked.
            Try
                CustomerBindingSource.EndEdit()
                ACustomerTableAdapter.Adapter.Update(CustomerDataSet.Customer)
                DateToolStripStatusLabel.Text = "Record added."
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(True)
                SetUpCustomerNameTextBox(False)
                ResetButtonsAfterEdit()
                CustomerNameComboBox.SelectedIndex = PreviousSelectedIndex
            Catch ex As Exception
                'Catch duplicate records and constraint violations.
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SetButtonsForEdit()
        'Set up buttons for Add or Edit operations.

        AddSaveButton.Text = "Sa&ve Customer"
        DeleteCancelButton.Text = "Cance&l Operation"
        UpdateButton.Enabled = False
        If AddingBoolean Then
            DateToolStripStatusLabel.Text = "Adding Customer"
            TimeToolStripStatusLabel.Text = ""
        Else
            DateToolStripStatusLabel.Text = "Editing Customer"
            TimeToolStripStatusLabel.Text = ""
        End If
    End Sub

    Private Sub ResetButtonsAfterEdit()
        'Reset buttons after Add or Edit operations.

        AddSaveButton.Text = "&Add Customer"
        DeleteCancelButton.Text = "&Delete Customer"
        CustomerNameComboBox.Enabled = True
        UpdateButton.Enabled = True
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
    End Sub

    Private Sub SetTextBoxBinding()
        'Sets the Customer ID combo box to save changes.
        'Saves for Add or Edit, doesn't save during navigation.

        With CustomerNameTextBox
            If (AddingBoolean Or EditingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
            End If
        End With
        
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)
        'Lock or unlock controls.

        CustomerAddressTextBox.ReadOnly = ValueBoolean
        CustomerPhoneTextBox.ReadOnly = ValueBoolean
        EmailAddressTextBox.ReadOnly = ValueBoolean
        CustomerTypeComboBox.Enabled = Not ValueBoolean
    End Sub

    Private Sub DeleteCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCancelButton.Click
        'Delete current record after confirming or cancelling Add or Edit operations.
        Dim DeleteDialogResult As DialogResult

        Try
            If DeleteCancelButton.Text = "&Delete Customer" Then
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    CustomerBindingSource.RemoveCurrent()
                    ACustomerTableAdapter.Adapter.Update(CustomerDataSet.Customer)
                    DateToolStripStatusLabel.Text = "Record deleted"
                    TimeToolStripStatusLabel.Text = ""
                End If
            Else
                'Cancel button clicked.
                CustomerBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetUpCustomerNameTextBox(False)
                SetControlsReadOnly(True)
                ResetButtonsAfterEdit()
                CustomerNameComboBox.Enabled = True
            End If
        Catch ex As Exception
            Dim MessageString As String
            MessageString = "Unable to complete the delete/cancel operation: " & ex.Message
            MessageBox.Show(MessageString, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CustomerForm_FormClosing(ByVal sender As Object, ByVal e As  _
        System.Windows.Forms.FormClosingEventArgs) Handles _
        Me.FormClosing
        'Check for unsaved changes.
        Dim AnswerDialogResult As DialogResult
        If CustomerDataSet.HasChanges() Then
            'Query user to save changes.
            AnswerDialogResult = MessageBox.Show("Do you want to save the changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Select Case AnswerDialogResult
                Case Windows.Forms.DialogResult.Yes
                    'Save the DataSet.
                    CustomerBindingSource.EndEdit()
                    ACustomerTableAdapter.Adapter.Update(CustomerDataSet)
                Case Windows.Forms.DialogResult.Cancel
                    'Cancel the closing.
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Allow editing to the current record.

        EditingBoolean = True
        SetControlsReadOnly(False)
        SetButtonsForEdit()
    End Sub

    Private Sub CustomerNameComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
            Handles CustomerNameComboBox.KeyDown
        'Cancel Add or Edit if Escape key is pressed.

        If (AddingBoolean Or EditingBoolean) And e.KeyData = Keys.Escape Then
            DeleteCancelButton_Click(sender, e)
        End If
    End Sub

    Private Sub SaveChangesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveChangesButton.Click
        'Save the DataSet to original data source.

        If CustomerDataSet.HasChanges() Then
            Try
                Validate()
                CustomerBindingSource.EndEdit()
                ACustomerTableAdapter.Adapter.Update(CustomerDataSet)
            Catch ex As Exception
                MessageBox.Show("Unable to save the changes: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub SetUpCustomerNameTextBox(ByVal ValueBoolean As Boolean)
        'Set up CustomerNameTextBox for editing.

        CustomerNameComboBox.Visible = Not ValueBoolean
        CustomerNameTextBox.Visible = ValueBoolean
        CustomerNameTextBox.Focus()
    End Sub
End Class
