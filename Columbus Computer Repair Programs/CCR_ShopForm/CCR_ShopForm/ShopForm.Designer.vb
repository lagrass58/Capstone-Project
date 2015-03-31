<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopForm
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
        Dim Shop_IDLabel As System.Windows.Forms.Label
        Dim Shop_NameLabel As System.Windows.Forms.Label
        Dim Shop_AddressLabel As System.Windows.Forms.Label
        Dim Shop_PhoneLabel As System.Windows.Forms.Label
        Dim RevenueLabel As System.Windows.Forms.Label
        Dim ExpensesLabel As System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopIDTextBox = New System.Windows.Forms.TextBox()
        Me.ShopNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ShopAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShopPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RevenueTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesTextBox = New System.Windows.Forms.TextBox()
        Me.CancelUpdateButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Shop_IDLabel = New System.Windows.Forms.Label()
        Shop_NameLabel = New System.Windows.Forms.Label()
        Shop_AddressLabel = New System.Windows.Forms.Label()
        Shop_PhoneLabel = New System.Windows.Forms.Label()
        RevenueLabel = New System.Windows.Forms.Label()
        ExpensesLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Shop_IDLabel
        '
        Shop_IDLabel.AutoSize = True
        Shop_IDLabel.Location = New System.Drawing.Point(83, 111)
        Shop_IDLabel.Name = "Shop_IDLabel"
        Shop_IDLabel.Size = New System.Drawing.Size(49, 13)
        Shop_IDLabel.TabIndex = 6
        Shop_IDLabel.Text = "Shop ID:"
        '
        'Shop_NameLabel
        '
        Shop_NameLabel.AutoSize = True
        Shop_NameLabel.Location = New System.Drawing.Point(66, 84)
        Shop_NameLabel.Name = "Shop_NameLabel"
        Shop_NameLabel.Size = New System.Drawing.Size(66, 13)
        Shop_NameLabel.TabIndex = 5
        Shop_NameLabel.Text = "Shop Name:"
        '
        'Shop_AddressLabel
        '
        Shop_AddressLabel.AutoSize = True
        Shop_AddressLabel.Location = New System.Drawing.Point(84, 137)
        Shop_AddressLabel.Name = "Shop_AddressLabel"
        Shop_AddressLabel.Size = New System.Drawing.Size(48, 13)
        Shop_AddressLabel.TabIndex = 7
        Shop_AddressLabel.Text = "Address:"
        '
        'Shop_PhoneLabel
        '
        Shop_PhoneLabel.AutoSize = True
        Shop_PhoneLabel.Location = New System.Drawing.Point(91, 163)
        Shop_PhoneLabel.Name = "Shop_PhoneLabel"
        Shop_PhoneLabel.Size = New System.Drawing.Size(41, 13)
        Shop_PhoneLabel.TabIndex = 8
        Shop_PhoneLabel.Text = "Phone:"
        '
        'RevenueLabel
        '
        RevenueLabel.AutoSize = True
        RevenueLabel.Location = New System.Drawing.Point(78, 188)
        RevenueLabel.Name = "RevenueLabel"
        RevenueLabel.Size = New System.Drawing.Size(54, 13)
        RevenueLabel.TabIndex = 9
        RevenueLabel.Text = "Revenue:"
        '
        'ExpensesLabel
        '
        ExpensesLabel.AutoSize = True
        ExpensesLabel.Location = New System.Drawing.Point(76, 214)
        ExpensesLabel.Name = "ExpensesLabel"
        ExpensesLabel.Size = New System.Drawing.Size(56, 13)
        ExpensesLabel.TabIndex = 10
        ExpensesLabel.Text = "Expenses:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripStatusLabel, Me.TimeToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateToolStripStatusLabel
        '
        Me.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel"
        Me.DateToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TimeToolStripStatusLabel
        '
        Me.TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel"
        Me.TimeToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem.Text = "&View"
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
        'ShopIDTextBox
        '
        Me.ShopIDTextBox.Location = New System.Drawing.Point(148, 108)
        Me.ShopIDTextBox.Name = "ShopIDTextBox"
        Me.ShopIDTextBox.ReadOnly = True
        Me.ShopIDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.ShopIDTextBox.TabIndex = 12
        '
        'ShopNameComboBox
        '
        Me.ShopNameComboBox.FormattingEnabled = True
        Me.ShopNameComboBox.Location = New System.Drawing.Point(148, 81)
        Me.ShopNameComboBox.Name = "ShopNameComboBox"
        Me.ShopNameComboBox.Size = New System.Drawing.Size(174, 21)
        Me.ShopNameComboBox.TabIndex = 11
        '
        'ShopAddressTextBox
        '
        Me.ShopAddressTextBox.Location = New System.Drawing.Point(148, 134)
        Me.ShopAddressTextBox.Name = "ShopAddressTextBox"
        Me.ShopAddressTextBox.ReadOnly = True
        Me.ShopAddressTextBox.Size = New System.Drawing.Size(174, 20)
        Me.ShopAddressTextBox.TabIndex = 13
        '
        'ShopPhoneTextBox
        '
        Me.ShopPhoneTextBox.Location = New System.Drawing.Point(148, 160)
        Me.ShopPhoneTextBox.Name = "ShopPhoneTextBox"
        Me.ShopPhoneTextBox.ReadOnly = True
        Me.ShopPhoneTextBox.Size = New System.Drawing.Size(62, 20)
        Me.ShopPhoneTextBox.TabIndex = 14
        '
        'RevenueTextBox
        '
        Me.RevenueTextBox.Location = New System.Drawing.Point(148, 185)
        Me.RevenueTextBox.Name = "RevenueTextBox"
        Me.RevenueTextBox.Size = New System.Drawing.Size(86, 20)
        Me.RevenueTextBox.TabIndex = 15
        '
        'ExpensesTextBox
        '
        Me.ExpensesTextBox.Location = New System.Drawing.Point(148, 211)
        Me.ExpensesTextBox.Name = "ExpensesTextBox"
        Me.ExpensesTextBox.Size = New System.Drawing.Size(86, 20)
        Me.ExpensesTextBox.TabIndex = 16
        '
        'CancelUpdateButton
        '
        Me.CancelUpdateButton.Enabled = False
        Me.CancelUpdateButton.Location = New System.Drawing.Point(375, 144)
        Me.CancelUpdateButton.Name = "CancelUpdateButton"
        Me.CancelUpdateButton.Size = New System.Drawing.Size(93, 25)
        Me.CancelUpdateButton.TabIndex = 18
        Me.CancelUpdateButton.Text = "&Cancel Update"
        Me.CancelUpdateButton.UseVisualStyleBackColor = True
        Me.CancelUpdateButton.Visible = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(375, 100)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(93, 25)
        Me.UpdateButton.TabIndex = 17
        Me.UpdateButton.Text = "&Update Shop"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(375, 188)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(93, 25)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.CancelUpdateButton)
        Me.Controls.Add(Shop_IDLabel)
        Me.Controls.Add(Me.ShopIDTextBox)
        Me.Controls.Add(Shop_NameLabel)
        Me.Controls.Add(Me.ShopNameComboBox)
        Me.Controls.Add(Shop_AddressLabel)
        Me.Controls.Add(Me.ShopAddressTextBox)
        Me.Controls.Add(Shop_PhoneLabel)
        Me.Controls.Add(Me.ShopPhoneTextBox)
        Me.Controls.Add(RevenueLabel)
        Me.Controls.Add(Me.RevenueTextBox)
        Me.Controls.Add(ExpensesLabel)
        Me.Controls.Add(Me.ExpensesTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(550, 350)
        Me.MinimumSize = New System.Drawing.Size(550, 350)
        Me.Name = "ShopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shop Form"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DateToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShopIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShopNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShopAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShopPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RevenueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelUpdateButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button

End Class
