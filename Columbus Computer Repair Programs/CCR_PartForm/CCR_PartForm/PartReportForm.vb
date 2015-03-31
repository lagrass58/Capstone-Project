'Project:       Columbus Computer Repair
'Class:         PartReportForm
'Date:          November 6, 2011
'Purpose:       Displays the Parts Report.

Public Class PartReportForm

    'Declarations
    Private PartDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private APartTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter

    Private Sub PartReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill the dataset and set up the report.
        Try
            PartDataSet = New ColumbusComputerRepair_DatabaseDataSet
            APartTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter
            APartTableAdapter.Fill(PartDataSet.Part)

            'Set up the report.
            Dim APartReport As New PartsReport
            APartReport.SetDataSource(PartDataSet)

            'Set the report viewer.
            CrystalReportViewer1.ReportSource = APartReport
        Catch ex As Exception
            MessageBox.Show("Error encountered: " & ex.Message)
        End Try
    End Sub
End Class
