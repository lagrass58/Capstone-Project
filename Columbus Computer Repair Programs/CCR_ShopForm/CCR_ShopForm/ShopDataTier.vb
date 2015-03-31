'Project:       Columbus Computer Repair
'Class:         ShopDataTier
'Date:          November 14, 2011
'Purpose:       Data-tier component for Columbus Computer Repair's Shop Form. 
'               Includes the code for database access.

Public Class ShopDataTier

    'Declarations
    Private ShopDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private AShopTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter

    Public Function GetCustomerData() As ColumbusComputerRepair_DatabaseDataSet
        'Fill and return the DataSet.

        ShopDataSet = New ColumbusComputerRepair_DatabaseDataSet
        AShopTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
        AShopTableAdapter.Fill(ShopDataSet.Shop)
        Return ShopDataSet
    End Function
End Class
