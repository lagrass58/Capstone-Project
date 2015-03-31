'Project:       Columbus Computer Repair
'Form:          Employee Form
'Date:          November 21, 2011
'Purpose:       Allows user to add repair orders to the database, update repair order information, and delete repair orders
'               from the database.


Public Class RepairForm
    'Declarations
    Private ValueBoolean As Boolean = False

    Private Sub RepairForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PartTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Part)
        Me.EmployeeTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Employee)
        Me.CustomerTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Customer)
        Me.RepairTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Repair)
    End Sub

    Private Sub RepairBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Me.Validate()
            Me.PartBindingSource.EndEdit()
            Me.EmployeeBindingSource.EndEdit()
            Me.CustomerBindingSource.EndEdit()
            Me.RepairBindingSource.EndEdit()
            If ColumbusComputerRepair_DatabaseDataSet.HasChanges Then
                Me.TableAdapterManager.UpdateAll(Me.ColumbusComputerRepair_DatabaseDataSet)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save the changes. " & ex.Message, "Data Error")
        End Try
        SetButtonsForEditing(True)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ExitToolStripMenuItem.Click
        'Closes the program.

        Me.Close()
    End Sub

    Private Sub RepairForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
        Handles MyBase.FormClosing
        'Check for unsaved changes.

        If ColumbusComputerRepair_DatabaseDataSet.HasChanges Then
            Dim ResponseDialogResult As DialogResult
            ResponseDialogResult = MessageBox.Show("Save the database changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Question)
            Select Case ResponseDialogResult
                Case Windows.Forms.DialogResult.Yes
                    RepairBindingNavigatorSaveItem_Click(sender, e)
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles BindingNavigatorAddNewItem.Click
        'Add a new record to the repair database.
        
        SetButtonsForEditing(False)
    End Sub

    Private Sub SetButtonsForEditing(ByVal ValueBoolean As Boolean)
        'Set up the form's buttons for adding and editing records.

        PartNameTextBox.Visible = ValueBoolean
        EmployeeNameTextBox.Visible = ValueBoolean
        CustomerNameTextBox.Visible = ValueBoolean
        PartNameComboBox.Visible = Not ValueBoolean
        CustomerNameComboBox.Visible = Not ValueBoolean
        TechnicianNameComboBox.Visible = Not ValueBoolean
        OrderDateDateTimePicker.Enabled = Not ValueBoolean
        CompletionDateDateTimePicker.Enabled = Not ValueBoolean
    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CancelToolStripButton.Click
        'Cancels editing.

        RepairBindingSource.EndEdit()
        SetButtonsForEditing(True)
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles BindingNavigatorMoveNextItem.Click, BindingNavigatorMoveLastItem.Click, BindingNavigatorMoveFirstItem.Click, _
        BindingNavigatorMovePreviousItem.Click
        'Cancels editing.

        RepairBindingSource.EndEdit()
        SetButtonsForEditing(True)
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CustomerToolStripMenuItem.Click
        'Displays the Customer Report.
        Dim AReportForm As New ReportForm

        With AReportForm
            .SelectedReport = ReportForm.ReportType.Customer
            .Show()
        End With
    End Sub

    Private Sub TechnicianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TechnicianToolStripMenuItem.Click
        'Displays the Technician Report.
        Dim AReportForm As New ReportForm

        With AReportForm
            .SelectedReport = ReportForm.ReportType.Technician
            .Show()
        End With
    End Sub
End Class