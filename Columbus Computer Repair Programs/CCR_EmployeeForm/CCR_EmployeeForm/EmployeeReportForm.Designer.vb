<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.EmployeeReport1 = New CCR_EmployeeForm.EmployeeReport()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(534, 312)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'EmployeeReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "EmployeeReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeReportForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EmployeeReport1 As CCR_EmployeeForm.EmployeeReport

    Private Sub EmployeeReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Declarations
        Dim ShopDataSet As ColumbusComputerRepair_DatabaseDataSet
        Dim AShopTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
        Dim AnEmployeeTableAdapter As ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter


        'Fill the dataset and set up the report.
        Try
            ShopDataSet = New ColumbusComputerRepair_DatabaseDataSet
            AShopTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.ShopTableAdapter
            AnEmployeeTableAdapter = New ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter
            AShopTableAdapter.Fill(ShopDataSet.Shop)
            AnEmployeeTableAdapter.Fill(ShopDataSet.Employee)


            'Set up the report.
            Dim AnEmployeeReport As New EmployeeReport
            AnEmployeeReport.SetDataSource(ShopDataSet)

            'Set the report viewer.
            CrystalReportViewer1.ReportSource = AnEmployeeReport
        Catch ex As Exception
            MessageBox.Show("Error encountered: " & ex.Message)
        End Try
    End Sub
End Class
