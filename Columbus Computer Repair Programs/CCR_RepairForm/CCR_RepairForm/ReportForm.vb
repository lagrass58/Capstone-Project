'Project:       Columbus Computer Repair
'Form:          Report Form
'Date:          November 21, 2011
'Purpose:       Allows user view Columbus Computer Repair Technician Detail and Customer Summary Reports

Public Class ReportForm

    'Declarations
    Private SelectedReportType As ReportType
    Private RepairDataSet As New ColumbusComputerRepair_DatabaseDataSet
    Private AnEmployeeTableAdapater As New ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter
    Private ACustomerTableAdapter As New ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
    Private ARepairTableAdapter As New ColumbusComputerRepair_DatabaseDataSetTableAdapters.RepairTableAdapter

    'Selection for report type.
    Public Enum ReportType
        Technician
        Customer
    End Enum

    WriteOnly Property SelectedReport() As ReportType
        Set(ByVal value As ReportType)
            SelectedReportType = value
        End Set
    End Property

    Private Sub ReportForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Display the selected report.

        Try
            RepairDataSet = New ColumbusComputerRepair_DatabaseDataSet
            ACustomerTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
            AnEmployeeTableAdapater = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter
            ARepairTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.RepairTableAdapter
            ACustomerTableAdapter.Fill(RepairDataSet.Customer)
            AnEmployeeTableAdapater.Fill(RepairDataSet.Employee)
            ARepairTableAdapter.Fill(RepairDataSet.Repair)

            If SelectedReportType = ReportType.Customer Then
                Dim ACustomerReport As New CustomerReport
                ACustomerReport.SetDataSource(RepairDataSet)
                CrystalReportViewer1.ReportSource = ACustomerReport
            Else
                Dim ATechnicianReport As New TechnicianReport
                ATechnicianReport.SetDataSource(RepairDataSet)
                CrystalReportViewer1.ReportSource = ATechnicianReport
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class