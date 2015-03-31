'Project:       Columbus Computer Repair
'Form:          Part Form
'Date:          November 6, 2011
'Purpose:       Allows user to add parts to the database, update part information, and delete parts 
'               from the database.

Public Class PartForm

    'Module-level declarations.
    Private APartDataTier As PartDataTier
    Private PartDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private WithEvents PartBindingSource As BindingSource
    Private APartTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter
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

    Private Sub PartForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Display the date and time in the status bar.
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
        SetControlsReadOnly(True)
        Try
            APartDataTier = New PartDataTier
            PartDataSet = New ColumbusComputerRepair_DatabaseDataSet
            APartTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter
            APartTableAdapter.Fill(PartDataSet.Part)

            'Set up the BindingSource.
            PartBindingSource = New BindingSource
            With PartBindingSource
                .DataSource = PartDataSet
                .DataMember = "Part"
                .Sort = "Part_Name"
            End With

            'Bind the controls.
            With PartNameComboBox
                .DataSource = PartBindingSource
                .DisplayMember = "Part_Name"
                .DataBindings.Add("text", PartBindingSource, "Part_Name", False, DataSourceUpdateMode.Never)
            End With
            PartNameTextBox.DataBindings.Add("text", PartBindingSource, "Part_Name")
            PartIDTextBox.DataBindings.Add("text", PartBindingSource, "Part_ID")
            PartDescriptionTextBox.DataBindings.Add("text", PartBindingSource, "Part_Description")
            QuantityTextBox.DataBindings.Add("text", PartBindingSource, "Quantity")
            LocationTextBox.DataBindings.Add("text", PartBindingSource, "Location")
            PriceTextBox.DataBindings.Add("text", PartBindingSource, "Price")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSaveButton.Click
        'Begin an Add operation or cancel the current operation.

        If AddSaveButton.Text = "&Add Part" Then
            With PartBindingSource
                .EndEdit()
                .AddNew()
            End With
            AddingBoolean = True
            SetUpPartNameTextBox(True)
            SetControlsReadOnly(False)
            SetButtonsForEdit()
            If PartNameComboBox.SelectedIndex <> -1 Then
                'Save index of the new record.
                PreviousSelectedIndex = PartNameComboBox.Items.Count - 1
            Else
                PreviousSelectedIndex = 0
            End If
            PartIDTextBox.Text = PartNameComboBox.Items.Count.ToString
        Else
            'Save button clicked.
            Try
                PartBindingSource.EndEdit()
                APartTableAdapter.Adapter.Update(PartDataSet.Part)
                DateToolStripStatusLabel.Text = "Record added."
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(True)
                SetUpPartNameTextBox(False)
                ResetButtonsAfterEdit()
            Catch ex As Exception
                'Catch duplicate records and constraint violations.
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SetButtonsForEdit()
        'Set up buttons for Add or Edit operations.

        AddSaveButton.Text = "Sa&ve Part"
        DeleteCancelButton.Text = "Cance&l Operation"
        UpdateButton.Enabled = False
        If AddingBoolean Then
            DateToolStripStatusLabel.Text = "Adding Part"
            TimeToolStripStatusLabel.Text = ""
        Else
            DateToolStripStatusLabel.Text = "Editing Part"
            TimeToolStripStatusLabel.Text = ""
        End If
    End Sub

    Private Sub ResetButtonsAfterEdit()
        'Reset buttons after Add or Edit operations.

        AddSaveButton.Text = "&Add Part"
        DeleteCancelButton.Text = "&Delete Part"
        PartNameComboBox.Enabled = True
        UpdateButton.Enabled = True
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
    End Sub

    Private Sub SetTextBoxBinding()
        'Sets the Part ID combo box to save changes.
        'Saves for Add or Edit, doesn't save during navigation.

        With PartNameTextBox
            If (AddingBoolean Or EditingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
            End If
        End With
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)
        'Lock or unlock controls.

        PartDescriptionTextBox.ReadOnly = ValueBoolean
        QuantityTextBox.ReadOnly = ValueBoolean
        LocationTextBox.ReadOnly = ValueBoolean
        PriceTextBox.ReadOnly = ValueBoolean
    End Sub

    Private Sub DeleteCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCancelButton.Click
        'Delete current record after confirming or cancelling Add or Edit operations.
        Dim DeleteDialogResult As DialogResult

        Try
            If DeleteCancelButton.Text = "&Delete Part" Then
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    PartBindingSource.RemoveCurrent()
                    APartTableAdapter.Adapter.Update(PartDataSet.Part)
                    DateToolStripStatusLabel.Text = "Record deleted"
                    TimeToolStripStatusLabel.Text = ""
                End If
            Else
                'Cancel button clicked.
                PartBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetUpPartNameTextBox(False)
                SetControlsReadOnly(True)
                ResetButtonsAfterEdit()
                PartNameComboBox.Enabled = True
            End If
        Catch ex As Exception
            Dim MessageString As String
            MessageString = "Unable to complete the delete/cancel operation: " & ex.Message
            MessageBox.Show(MessageString, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub PartForm_FormClosing(ByVal sender As Object, ByVal e As  _
        System.Windows.Forms.FormClosingEventArgs) Handles _
        Me.FormClosing
        'Check for unsaved changes.
        Dim AnswerDialogResult As DialogResult
        If PartDataSet.HasChanges() Then
            'Query user to save changes.
            AnswerDialogResult = MessageBox.Show("Do you want to save the changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Select Case AnswerDialogResult
                Case Windows.Forms.DialogResult.Yes
                    'Save the DataSet.
                    PartBindingSource.EndEdit()
                    APartTableAdapter.Adapter.Update(PartDataSet)
                Case Windows.Forms.DialogResult.Cancel
                    'Cancel the closing.
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Allow editing to the current record.

        SetUpPartNameTextBox(True)
        EditingBoolean = True
        SetControlsReadOnly(False)
        SetButtonsForEdit()
    End Sub

    Private Sub PartNameComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
            Handles PartNameComboBox.KeyDown
        'Cancel Add or Edit if Escape key is pressed.

        If (AddingBoolean Or EditingBoolean) And e.KeyData = Keys.Escape Then
            DeleteCancelButton_Click(sender, e)
        End If
    End Sub

    Private Sub SaveChangesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveChangesButton.Click
        'Save the DataSet to original data source.

        If PartDataSet.HasChanges() Then
            Try
                Validate()
                PartBindingSource.EndEdit()
                APartTableAdapter.Adapter.Update(PartDataSet)
            Catch ex As Exception
                MessageBox.Show("Unable to save the changes: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub SetUpPartNameTextBox(ByVal ValueBoolean As Boolean)
        'Set up PartNameTextBox for editing.

        PartNameComboBox.Visible = Not ValueBoolean
        PartNameTextBox.Visible = ValueBoolean
        PartNameTextBox.Focus()
    End Sub


    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ViewToolStripMenuItem.Click
        'Displays the Part Report in separate window.

        PartReportForm.Show()
    End Sub
End Class
