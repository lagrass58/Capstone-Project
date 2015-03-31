<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim Completion_DateLabel As System.Windows.Forms.Label
        Dim Total_ChargesLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Employee_NameLabel As System.Windows.Forms.Label
        Dim Employee_TypeLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Part_NameLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Part_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepairForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumbusComputerRepair_DatabaseDataSet = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSet()
        Me.RepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairTableAdapter = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.RepairTableAdapter()
        Me.TableAdapterManager = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter()
        Me.EmployeeTableAdapter = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter()
        Me.PartTableAdapter = New CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter()
        Me.RepairBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RepairBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerRepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeRepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CompletionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalChargesTextBox = New System.Windows.Forms.TextBox()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartRepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.RepairGroupBox = New System.Windows.Forms.GroupBox()
        Me.PartNameComboBox = New System.Windows.Forms.ComboBox()
        Me.PartNameTextBox = New System.Windows.Forms.TextBox()
        Me.PartIDComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TechnicianNameComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeTypeTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeRepairBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Order_DateLabel = New System.Windows.Forms.Label()
        Completion_DateLabel = New System.Windows.Forms.Label()
        Total_ChargesLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Employee_NameLabel = New System.Windows.Forms.Label()
        Employee_TypeLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Part_NameLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Part_IDLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ColumbusComputerRepair_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RepairBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartRepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RepairGroupBox.SuspendLayout()
        Me.EmployeeGroupBox.SuspendLayout()
        Me.CustomerGroupBox.SuspendLayout()
        CType(Me.EmployeeRepairBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Location = New System.Drawing.Point(32, 45)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(62, 13)
        Order_DateLabel.TabIndex = 2
        Order_DateLabel.Text = "Order Date:"
        '
        'Completion_DateLabel
        '
        Completion_DateLabel.AutoSize = True
        Completion_DateLabel.Location = New System.Drawing.Point(6, 72)
        Completion_DateLabel.Name = "Completion_DateLabel"
        Completion_DateLabel.Size = New System.Drawing.Size(88, 13)
        Completion_DateLabel.TabIndex = 3
        Completion_DateLabel.Text = "Completion Date:"
        '
        'Total_ChargesLabel
        '
        Total_ChargesLabel.AutoSize = True
        Total_ChargesLabel.Location = New System.Drawing.Point(21, 180)
        Total_ChargesLabel.Name = "Total_ChargesLabel"
        Total_ChargesLabel.Size = New System.Drawing.Size(76, 13)
        Total_ChargesLabel.TabIndex = 7
        Total_ChargesLabel.Text = "Total Charges:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(60, 151)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 6
        PriceLabel.Text = "Price:"
        '
        'Employee_NameLabel
        '
        Employee_NameLabel.AutoSize = True
        Employee_NameLabel.Location = New System.Drawing.Point(6, 57)
        Employee_NameLabel.Name = "Employee_NameLabel"
        Employee_NameLabel.Size = New System.Drawing.Size(94, 13)
        Employee_NameLabel.TabIndex = 10
        Employee_NameLabel.Text = "Technician Name:"
        '
        'Employee_TypeLabel
        '
        Employee_TypeLabel.AutoSize = True
        Employee_TypeLabel.Location = New System.Drawing.Point(17, 81)
        Employee_TypeLabel.Name = "Employee_TypeLabel"
        Employee_TypeLabel.Size = New System.Drawing.Size(83, 13)
        Employee_TypeLabel.TabIndex = 11
        Employee_TypeLabel.Text = "Employee Type:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(15, 56)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 14
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Part_NameLabel
        '
        Part_NameLabel.AutoSize = True
        Part_NameLabel.Location = New System.Drawing.Point(32, 124)
        Part_NameLabel.Name = "Part_NameLabel"
        Part_NameLabel.Size = New System.Drawing.Size(60, 13)
        Part_NameLabel.TabIndex = 5
        Part_NameLabel.Text = "Part Name:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(32, 29)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 13
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(23, 30)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(77, 13)
        Employee_IDLabel.TabIndex = 9
        Employee_IDLabel.Text = "Technician ID:"
        '
        'Part_IDLabel
        '
        Part_IDLabel.AutoSize = True
        Part_IDLabel.Location = New System.Drawing.Point(51, 96)
        Part_IDLabel.Name = "Part_IDLabel"
        Part_IDLabel.Size = New System.Drawing.Size(43, 13)
        Part_IDLabel.TabIndex = 4
        Part_IDLabel.Text = "Part ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.TechnicianToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'TechnicianToolStripMenuItem
        '
        Me.TechnicianToolStripMenuItem.Name = "TechnicianToolStripMenuItem"
        Me.TechnicianToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TechnicianToolStripMenuItem.Text = "&Technician"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'ColumbusComputerRepair_DatabaseDataSet
        '
        Me.ColumbusComputerRepair_DatabaseDataSet.DataSetName = "ColumbusComputerRepair_DatabaseDataSet"
        Me.ColumbusComputerRepair_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepairBindingSource
        '
        Me.RepairBindingSource.DataMember = "Repair"
        Me.RepairBindingSource.DataSource = Me.ColumbusComputerRepair_DatabaseDataSet
        '
        'RepairTableAdapter
        '
        Me.RepairTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.PartTableAdapter = Me.PartTableAdapter
        Me.TableAdapterManager.RepairTableAdapter = Me.RepairTableAdapter
        Me.TableAdapterManager.UpdateOrder = CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'PartTableAdapter
        '
        Me.PartTableAdapter.ClearBeforeFill = True
        '
        'RepairBindingNavigator
        '
        Me.RepairBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RepairBindingNavigator.BindingSource = Me.RepairBindingSource
        Me.RepairBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RepairBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RepairBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RepairBindingNavigatorSaveItem, Me.CancelToolStripButton})
        Me.RepairBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.RepairBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RepairBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RepairBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RepairBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RepairBindingNavigator.Name = "RepairBindingNavigator"
        Me.RepairBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RepairBindingNavigator.Size = New System.Drawing.Size(634, 25)
        Me.RepairBindingNavigator.TabIndex = 25
        Me.RepairBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add Record"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete Record"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.ReadOnly = True
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RepairBindingNavigatorSaveItem
        '
        Me.RepairBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RepairBindingNavigatorSaveItem.Image = CType(resources.GetObject("RepairBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RepairBindingNavigatorSaveItem.Name = "RepairBindingNavigatorSaveItem"
        Me.RepairBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RepairBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = CType(resources.GetObject("CancelToolStripButton.Image"), System.Drawing.Image)
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolStripButton.Text = "Cancel "
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.ColumbusComputerRepair_DatabaseDataSet
        '
        'CustomerRepairBindingSource
        '
        Me.CustomerRepairBindingSource.DataMember = "CustomerRepair"
        Me.CustomerRepairBindingSource.DataSource = Me.CustomerBindingSource
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.ColumbusComputerRepair_DatabaseDataSet
        '
        'EmployeeRepairBindingSource
        '
        Me.EmployeeRepairBindingSource.DataMember = "EmployeeRepair"
        Me.EmployeeRepairBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'OrderDateDateTimePicker
        '
        Me.OrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RepairBindingSource, "Order_Date", True))
        Me.OrderDateDateTimePicker.Enabled = False
        Me.OrderDateDateTimePicker.Location = New System.Drawing.Point(103, 39)
        Me.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker"
        Me.OrderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateDateTimePicker.TabIndex = 15
        '
        'CompletionDateDateTimePicker
        '
        Me.CompletionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RepairBindingSource, "Completion_Date", True))
        Me.CompletionDateDateTimePicker.Enabled = False
        Me.CompletionDateDateTimePicker.Location = New System.Drawing.Point(103, 66)
        Me.CompletionDateDateTimePicker.Name = "CompletionDateDateTimePicker"
        Me.CompletionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CompletionDateDateTimePicker.TabIndex = 16
        '
        'TotalChargesTextBox
        '
        Me.TotalChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalChargesTextBox.Location = New System.Drawing.Point(103, 173)
        Me.TotalChargesTextBox.Name = "TotalChargesTextBox"
        Me.TotalChargesTextBox.ReadOnly = True
        Me.TotalChargesTextBox.Size = New System.Drawing.Size(67, 20)
        Me.TotalChargesTextBox.TabIndex = 20
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataMember = "Part"
        Me.PartBindingSource.DataSource = Me.ColumbusComputerRepair_DatabaseDataSet
        '
        'PartRepairBindingSource
        '
        Me.PartRepairBindingSource.DataMember = "PartRepair"
        Me.PartRepairBindingSource.DataSource = Me.PartBindingSource
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.PriceTextBox.Location = New System.Drawing.Point(103, 148)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(67, 20)
        Me.PriceTextBox.TabIndex = 19
        '
        'RepairGroupBox
        '
        Me.RepairGroupBox.Controls.Add(Me.PartNameComboBox)
        Me.RepairGroupBox.Controls.Add(PriceLabel)
        Me.RepairGroupBox.Controls.Add(Me.TotalChargesTextBox)
        Me.RepairGroupBox.Controls.Add(Me.PriceTextBox)
        Me.RepairGroupBox.Controls.Add(Total_ChargesLabel)
        Me.RepairGroupBox.Controls.Add(Part_NameLabel)
        Me.RepairGroupBox.Controls.Add(Me.CompletionDateDateTimePicker)
        Me.RepairGroupBox.Controls.Add(Me.PartNameTextBox)
        Me.RepairGroupBox.Controls.Add(Completion_DateLabel)
        Me.RepairGroupBox.Controls.Add(Part_IDLabel)
        Me.RepairGroupBox.Controls.Add(Me.OrderDateDateTimePicker)
        Me.RepairGroupBox.Controls.Add(Me.PartIDComboBox)
        Me.RepairGroupBox.Controls.Add(Order_DateLabel)
        Me.RepairGroupBox.Location = New System.Drawing.Point(14, 68)
        Me.RepairGroupBox.Name = "RepairGroupBox"
        Me.RepairGroupBox.Size = New System.Drawing.Size(319, 220)
        Me.RepairGroupBox.TabIndex = 1
        Me.RepairGroupBox.TabStop = False
        Me.RepairGroupBox.Text = "Repair Information"
        '
        'PartNameComboBox
        '
        Me.PartNameComboBox.DataSource = Me.PartBindingSource
        Me.PartNameComboBox.DisplayMember = "Part_Name"
        Me.PartNameComboBox.FormattingEnabled = True
        Me.PartNameComboBox.Location = New System.Drawing.Point(103, 121)
        Me.PartNameComboBox.Name = "PartNameComboBox"
        Me.PartNameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PartNameComboBox.TabIndex = 18
        Me.PartNameComboBox.Visible = False
        '
        'PartNameTextBox
        '
        Me.PartNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartBindingSource, "Part_Name", True))
        Me.PartNameTextBox.Location = New System.Drawing.Point(103, 120)
        Me.PartNameTextBox.Name = "PartNameTextBox"
        Me.PartNameTextBox.ReadOnly = True
        Me.PartNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PartNameTextBox.TabIndex = 18
        '
        'PartIDComboBox
        '
        Me.PartIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepairBindingSource, "Part_ID", True))
        Me.PartIDComboBox.DataSource = Me.PartBindingSource
        Me.PartIDComboBox.DisplayMember = "Part_ID"
        Me.PartIDComboBox.Enabled = False
        Me.PartIDComboBox.FormattingEnabled = True
        Me.PartIDComboBox.Location = New System.Drawing.Point(103, 93)
        Me.PartIDComboBox.Name = "PartIDComboBox"
        Me.PartIDComboBox.Size = New System.Drawing.Size(67, 21)
        Me.PartIDComboBox.TabIndex = 17
        '
        'EmployeeGroupBox
        '
        Me.EmployeeGroupBox.Controls.Add(Me.TechnicianNameComboBox)
        Me.EmployeeGroupBox.Controls.Add(Employee_TypeLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.EmployeeTypeTextBox)
        Me.EmployeeGroupBox.Controls.Add(Employee_IDLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.EmployeeIDComboBox)
        Me.EmployeeGroupBox.Controls.Add(Me.EmployeeNameTextBox)
        Me.EmployeeGroupBox.Controls.Add(Employee_NameLabel)
        Me.EmployeeGroupBox.Location = New System.Drawing.Point(349, 68)
        Me.EmployeeGroupBox.Name = "EmployeeGroupBox"
        Me.EmployeeGroupBox.Size = New System.Drawing.Size(273, 122)
        Me.EmployeeGroupBox.TabIndex = 8
        Me.EmployeeGroupBox.TabStop = False
        Me.EmployeeGroupBox.Text = "Technician"
        '
        'TechnicianNameComboBox
        '
        Me.TechnicianNameComboBox.DataSource = Me.EmployeeBindingSource
        Me.TechnicianNameComboBox.DisplayMember = "Employee_Name"
        Me.TechnicianNameComboBox.FormattingEnabled = True
        Me.TechnicianNameComboBox.Location = New System.Drawing.Point(113, 54)
        Me.TechnicianNameComboBox.Name = "TechnicianNameComboBox"
        Me.TechnicianNameComboBox.Size = New System.Drawing.Size(154, 21)
        Me.TechnicianNameComboBox.TabIndex = 22
        Me.TechnicianNameComboBox.Visible = False
        '
        'EmployeeTypeTextBox
        '
        Me.EmployeeTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Type", True))
        Me.EmployeeTypeTextBox.Location = New System.Drawing.Point(113, 78)
        Me.EmployeeTypeTextBox.Name = "EmployeeTypeTextBox"
        Me.EmployeeTypeTextBox.ReadOnly = True
        Me.EmployeeTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeTypeTextBox.TabIndex = 23
        '
        'EmployeeIDComboBox
        '
        Me.EmployeeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepairBindingSource, "Employee_ID", True))
        Me.EmployeeIDComboBox.DataSource = Me.EmployeeBindingSource
        Me.EmployeeIDComboBox.DisplayMember = "Employee_ID"
        Me.EmployeeIDComboBox.Enabled = False
        Me.EmployeeIDComboBox.FormattingEnabled = True
        Me.EmployeeIDComboBox.Location = New System.Drawing.Point(113, 27)
        Me.EmployeeIDComboBox.Name = "EmployeeIDComboBox"
        Me.EmployeeIDComboBox.Size = New System.Drawing.Size(71, 21)
        Me.EmployeeIDComboBox.TabIndex = 21
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_Name", True))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(113, 54)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.ReadOnly = True
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.EmployeeNameTextBox.TabIndex = 22
        '
        'CustomerGroupBox
        '
        Me.CustomerGroupBox.Controls.Add(Me.CustomerNameComboBox)
        Me.CustomerGroupBox.Controls.Add(Customer_IDLabel)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerIDComboBox)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerNameTextBox)
        Me.CustomerGroupBox.Controls.Add(Customer_NameLabel)
        Me.CustomerGroupBox.Location = New System.Drawing.Point(349, 204)
        Me.CustomerGroupBox.Name = "CustomerGroupBox"
        Me.CustomerGroupBox.Size = New System.Drawing.Size(273, 84)
        Me.CustomerGroupBox.TabIndex = 12
        Me.CustomerGroupBox.TabStop = False
        Me.CustomerGroupBox.Text = "Customer Information"
        '
        'CustomerNameComboBox
        '
        Me.CustomerNameComboBox.DataSource = Me.CustomerBindingSource
        Me.CustomerNameComboBox.DisplayMember = "Customer_Name"
        Me.CustomerNameComboBox.FormattingEnabled = True
        Me.CustomerNameComboBox.Location = New System.Drawing.Point(113, 52)
        Me.CustomerNameComboBox.Name = "CustomerNameComboBox"
        Me.CustomerNameComboBox.Size = New System.Drawing.Size(154, 21)
        Me.CustomerNameComboBox.TabIndex = 25
        Me.CustomerNameComboBox.Visible = False
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepairBindingSource, "Customer_ID", True))
        Me.CustomerIDComboBox.DataSource = Me.CustomerBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Customer_ID"
        Me.CustomerIDComboBox.Enabled = False
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(113, 26)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(71, 21)
        Me.CustomerIDComboBox.TabIndex = 24
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer_Name", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(113, 53)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.ReadOnly = True
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.CustomerNameTextBox.TabIndex = 25
        '
        'EmployeeRepairBindingSource1
        '
        Me.EmployeeRepairBindingSource1.DataMember = "EmployeeRepair"
        Me.EmployeeRepairBindingSource1.DataSource = Me.EmployeeBindingSource
        '
        'RepairForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(634, 312)
        Me.Controls.Add(Me.CustomerGroupBox)
        Me.Controls.Add(Me.EmployeeGroupBox)
        Me.Controls.Add(Me.RepairGroupBox)
        Me.Controls.Add(Me.RepairBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(650, 350)
        Me.MinimumSize = New System.Drawing.Size(650, 350)
        Me.Name = "RepairForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repair Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ColumbusComputerRepair_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RepairBindingNavigator.ResumeLayout(False)
        Me.RepairBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartRepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RepairGroupBox.ResumeLayout(False)
        Me.RepairGroupBox.PerformLayout()
        Me.EmployeeGroupBox.ResumeLayout(False)
        Me.EmployeeGroupBox.PerformLayout()
        Me.CustomerGroupBox.ResumeLayout(False)
        Me.CustomerGroupBox.PerformLayout()
        CType(Me.EmployeeRepairBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechnicianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumbusComputerRepair_DatabaseDataSet As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSet
    Friend WithEvents RepairBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepairTableAdapter As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.RepairTableAdapter
    Friend WithEvents TableAdapterManager As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RepairBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RepairBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PartTableAdapter As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.PartTableAdapter
    Friend WithEvents OrderDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CompletionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalChargesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As CCR_RepairForm.ColumbusComputerRepair_DatabaseDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerRepairBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeRepairBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartRepairBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepairGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EmployeeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EmployeeTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PartIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PartNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TechnicianNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeRepairBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CancelToolStripButton As System.Windows.Forms.ToolStripButton

End Class
