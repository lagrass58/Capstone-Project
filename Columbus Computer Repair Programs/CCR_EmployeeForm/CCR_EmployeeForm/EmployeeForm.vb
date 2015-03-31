'Project:       Columbus Computer Repair
'Form:          Employee Form
'Date:          November 18, 2011
'Purpose:       Allows user to add employees to the database, update employee information, and delete employees 
'               from the database.

Public Class EmployeeForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ExitToolStripMenuItem.Click
        'Closes the program

        Me.Close()
    End Sub

    Private Sub ShopBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ShopBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.ShopBindingSource.EndEdit()
            Me.EmployeeBindingSource.EndEdit()
            If ColumbusComputerRepair_DatabaseDataSet.HasChanges Then
                Me.TableAdapterManager.UpdateAll(Me.ColumbusComputerRepair_DatabaseDataSet)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save the changes. " & ex.Message, "Data Error")
        End Try
    End Sub

    Private Sub EmployeeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ShopTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Shop)
        Me.EmployeeTableAdapter.Fill(Me.ColumbusComputerRepair_DatabaseDataSet.Employee)
    End Sub

    Private Sub EmployeeForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
        Handles MyBase.FormClosing
        'Check for unsaved changes.

        If ColumbusComputerRepair_DatabaseDataSet.HasChanges Then
            Dim ResponseDialogResult As DialogResult
            ResponseDialogResult = MessageBox.Show("Save the database changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Question)
            Select Case ResponseDialogResult
                Case Windows.Forms.DialogResult.Yes
                    ShopBindingNavigatorSaveItem_Click(sender, e)
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub


    Private Sub EmployeeDataGridView_DataError(ByVal sender As System.Object, ByVal e As  _
        System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles EmployeeDataGridView.DataError

        'Handle an error in the grid.
        Dim CurrentRow As DataGridViewRow = EmployeeDataGridView.Rows(e.RowIndex)

        'Display an error icon and message.
        CurrentRow.ErrorText = "Error in the data. Unable to save."

        'Keep the data in the row.
        e.Cancel = True
    End Sub

    Private Sub EmployeeDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As  _
        System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.RowLeave
        'Reset any error messages for an accepted row.

        Dim CurrentRow As DataGridViewRow = EmployeeDataGridView.Rows(e.RowIndex)
        CurrentRow.ErrorText = ""
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles AboutToolStripMenuItem.Click
        'Show the About Box.

        CCR_AboutBox.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ViewToolStripMenuItem.Click
        'Display the Employee Report

        EmployeeReportForm.Show()
    End Sub
End Class
