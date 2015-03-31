'Project:       Columbus Computer Repair
'Class:         CustomerDataTier
'Date:          November 6, 2011
'Purpose:       Data-tier component for Columbus Computer Repair's Customer Form. 
'               Includes the code for database access.

Public Class CustomerDataTier

    'Declarations
    Private CustomerDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private ACustomerTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter

    Public Function GetCustomerData() As ColumbusComputerRepair_DatabaseDataSet
        'Fill and return the DataSet.

        CustomerDataSet = New ColumbusComputerRepair_DatabaseDataSet
        ACustomerTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
        ACustomerTableAdapter.Fill(CustomerDataSet.Customer)
        Return CustomerDataSet
    End Function
End Class
