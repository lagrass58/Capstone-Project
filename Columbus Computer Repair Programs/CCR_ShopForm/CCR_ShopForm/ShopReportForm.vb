'Project:       Columbus Computer Repair
'Class:         ShopReportForm
'Date:          November 6, 2011
'Purpose:       Displays the Shop Report.

Public Class ShopReportForm

    'Declarations
    Private ShopDataSet As ColumbusComputerRepair_DatabaseDataSet
    Private AShopTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter

    Private Sub ShopReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill the dataset and set up the report.
        Try
            ShopDataSet = New ColumbusComputerRepair_DatabaseDataSet
            AShopTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
            AShopTableAdapter.Fill(ShopDataSet.Shop)

            'Set up the report.
            Dim AShopReport As New ShopReport
            AShopReport.SetDataSource(ShopDataSet)

            'Set the report viewer.
            CrystalReportViewer1.ReportSource = AShopReport
        Catch ex As Exception
            MessageBox.Show("Error encountered: " & ex.Message)
        End Try
    End Sub
End Class