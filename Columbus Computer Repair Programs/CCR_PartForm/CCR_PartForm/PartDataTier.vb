'Project:       Columbus Computer Repair
'Class:         PartDataTier
'Date:          November 6, 2011
'Purpose:       Data-tier component for Columbus Computer Repair's Part Form. 
'               Includes the code for database access.

Public Class PartDataTier

    'Declarations
    Private PartDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private APartTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter

    Public Function GetPartData() As ColumbusComputerRepair_DatabaseDataSet
        'Fill and return the DataSet.

        PartDataSet = New ColumbusComputerRepair_DatabaseDataSet
        APartTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter
        APartTableAdapter.Fill(PartDataSet.Part)
        Return PartDataSet
    End Function
End Class
