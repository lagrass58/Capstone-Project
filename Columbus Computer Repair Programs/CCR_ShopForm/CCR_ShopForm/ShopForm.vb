'Project:       Columbus Computer Repair
'Form:          Shop Form
'Date:          November 6, 2011
'Purpose:       Allows user to update shop revenue and expenses and to view shop statistics.
'               Allows user to produce Summary Report.

Public Class ShopForm
    'Module-level declarations.
    Private AShopDataTier As ShopDataTier
    Private ShopDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private WithEvents ShopBindingSource As BindingSource
    Private AShopTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
    Private EditingBoolean As Boolean = False
    

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ExitToolStripMenuItem.Click, CloseButton.Click
        'Closes the program.

        Me.Close()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ViewToolStripMenuItem.Click
        'Display the report in the ShopReportForm

        ShopReportForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles AboutToolStripMenuItem.Click
        'Display the About Box form.

        CCR_AboutBox.Show()
    End Sub

    Private Sub ShopForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Display the date and time in the status bar.
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
        SetControlsReadOnly(True)
        Try
            AShopDataTier = New ShopDataTier
            ShopDataSet = New ColumbusComputerRepair_DatabaseDataSet
            AShopTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
            AShopTableAdapter.Fill(ShopDataSet.Shop)

            'Set up the BindingSource.
            ShopBindingSource = New BindingSource
            With ShopBindingSource
                .DataSource = ShopDataSet
                .DataMember = "Shop"
                .Sort = "Shop_Name"
            End With

            'Bind the controls.
            With ShopNameComboBox
                .DataSource = ShopBindingSource
                .DisplayMember = "Shop_Name"
                .DataBindings.Add("text", ShopBindingSource, "Shop_Name", False, DataSourceUpdateMode.Never)
            End With
            ShopIDTextBox.DataBindings.Add("text", ShopBindingSource, "Shop_ID")
            ShopAddressTextBox.DataBindings.Add("text", ShopBindingSource, "Shop_Address")
            ShopPhoneTextBox.DataBindings.Add("text", ShopBindingSource, "Shop_Phone")
            RevenueTextBox.DataBindings.Add("text", ShopBindingSource, "Revenue")
            ExpensesTextBox.DataBindings.Add("text", ShopBindingSource, "Expenses")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetButtonsForEdit()
        'Set up buttons for Update operation.

        UpdateButton.Text = "Save U&pdate"
        With CancelUpdateButton
            .Visible = True
            .Enabled = True
        End With
        DateToolStripStatusLabel.Text = "Updating Shop Information"
        TimeToolStripStatusLabel.Text = ""
    End Sub

    Private Sub ResetButtonsAfterEdit()
        'Reset buttons after Update operation.

        UpdateButton.Enabled = True
        UpdateButton.Text = "&Update Shop"
        ShopNameComboBox.Enabled = True
        UpdateButton.Enabled = True
        With CancelUpdateButton
            .Visible = False
            .Enabled = False
        End With
        DateToolStripStatusLabel.Text = Now.ToShortDateString
        TimeToolStripStatusLabel.Text = Now.ToShortTimeString
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Allow editing to the current record.

        If UpdateButton.Text = "&Update Shop" Then
            EditingBoolean = True
            SetControlsReadOnly(False)
            SetButtonsForEdit()
        Else
            'Save button clicked
            Try
                ShopBindingSource.EndEdit()
                AShopTableAdapter.Adapter.Update(ShopDataSet.Shop)
                DateToolStripStatusLabel.Text = "Record added."
                EditingBoolean = False
                SetControlsReadOnly(True)
                ResetButtonsAfterEdit()
            Catch ex As Exception
                'Catch duplicate records and constraint violations.
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)
        'Lock or unlock controls.

        ShopNameComboBox.Enabled = ValueBoolean
        RevenueTextBox.ReadOnly = ValueBoolean
        ExpensesTextBox.ReadOnly = ValueBoolean
    End Sub
    
    Private Sub CancelUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CancelUpdateButton.Click

        'Cancel button clicked.
        ShopBindingSource.CancelEdit()
        EditingBoolean = False
        SetControlsReadOnly(True)
        ResetButtonsAfterEdit()
        ShopNameComboBox.Enabled = True
    End Sub

    Private Sub ShopForm_FormClosing(ByVal sender As Object, ByVal e As  _
        System.Windows.Forms.FormClosingEventArgs) Handles _
        Me.FormClosing
        'Check for unsaved changes.
        Dim AnswerDialogResult As DialogResult
        If ShopDataSet.HasChanges() Then
            'Query user to save changes.
            AnswerDialogResult = MessageBox.Show("Do you want to save the changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Select Case AnswerDialogResult
                Case Windows.Forms.DialogResult.Yes
                    'Save the DataSet.
                    ShopBindingSource.EndEdit()
                    AShopTableAdapter.Adapter.Update(ShopDataSet)
                Case Windows.Forms.DialogResult.Cancel
                    'Cancel the closing.
                    e.Cancel = True
            End Select
        End If
    End Sub
End Class
