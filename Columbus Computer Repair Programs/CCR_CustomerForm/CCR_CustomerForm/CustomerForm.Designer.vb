<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Customer_AddressLabel As System.Windows.Forms.Label
        Dim Customer_PhoneLabel As System.Windows.Forms.Label
        Dim Customer_TypeLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSaveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteCancelButton = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameComboBox = New System.Windows.Forms.ComboBox()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Customer_AddressLabel = New System.Windows.Forms.Label()
        Customer_PhoneLabel = New System.Windows.Forms.Label()
        Customer_TypeLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(56, 82)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 14
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(86, 51)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(38, 13)
        Customer_NameLabel.TabIndex = 13
        Customer_NameLabel.Text = "Name:"
        '
        'Customer_AddressLabel
        '
        Customer_AddressLabel.AutoSize = True
        Customer_AddressLabel.Location = New System.Drawing.Point(76, 112)
        Customer_AddressLabel.Name = "Customer_AddressLabel"
        Customer_AddressLabel.Size = New System.Drawing.Size(48, 13)
        Customer_AddressLabel.TabIndex = 15
        Customer_AddressLabel.Text = "Address:"
        '
        'Customer_PhoneLabel
        '
        Customer_PhoneLabel.AutoSize = True
        Customer_PhoneLabel.Location = New System.Drawing.Point(83, 142)
        Customer_PhoneLabel.Name = "Customer_PhoneLabel"
        Customer_PhoneLabel.Size = New System.Drawing.Size(41, 13)
        Customer_PhoneLabel.TabIndex = 16
        Customer_PhoneLabel.Text = "Phone:"
        '
        'Customer_TypeLabel
        '
        Customer_TypeLabel.AutoSize = True
        Customer_TypeLabel.Location = New System.Drawing.Point(43, 172)
        Customer_TypeLabel.Name = "Customer_TypeLabel"
        Customer_TypeLabel.Size = New System.Drawing.Size(81, 13)
        Customer_TypeLabel.TabIndex = 17
        Customer_TypeLabel.Text = "Customer Type:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(89, 203)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(35, 13)
        Email_AddressLabel.TabIndex = 18
        Email_AddressLabel.Text = "Email:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'AddSaveButton
        '
        Me.AddSaveButton.Location = New System.Drawing.Point(398, 45)
        Me.AddSaveButton.Name = "AddSaveButton"
        Me.AddSaveButton.Size = New System.Drawing.Size(100, 25)
        Me.AddSaveButton.TabIndex = 25
        Me.AddSaveButton.Text = "&Add Customer"
        Me.AddSaveButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(398, 77)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(100, 23)
        Me.UpdateButton.TabIndex = 26
        Me.UpdateButton.Text = "&Update Customer"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelButton
        '
        Me.DeleteCancelButton.Location = New System.Drawing.Point(398, 107)
        Me.DeleteCancelButton.Name = "DeleteCancelButton"
        Me.DeleteCancelButton.Size = New System.Drawing.Size(100, 23)
        Me.DeleteCancelButton.TabIndex = 27
        Me.DeleteCancelButton.Text = "&Delete Customer"
        Me.DeleteCancelButton.UseVisualStyleBackColor = True
        '
        'SaveChangesButton
        '
        Me.SaveChangesButton.Location = New System.Drawing.Point(398, 167)
        Me.SaveChangesButton.Name = "SaveChangesButton"
        Me.SaveChangesButton.Size = New System.Drawing.Size(100, 23)
        Me.SaveChangesButton.TabIndex = 28
        Me.SaveChangesButton.Text = "&Save Changes"
        Me.SaveChangesButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(398, 198)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 23)
        Me.CloseButton.TabIndex = 29
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripStatusLabel, Me.TimeToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateToolStripStatusLabel
        '
        Me.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel"
        Me.DateToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        Me.DateToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimeToolStripStatusLabel
        '
        Me.TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel"
        Me.TimeToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeToolStripStatusLabel.RightToLeftAutoMirrorImage = True
        Me.TimeToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        Me.TimeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(149, 48)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.CustomerNameTextBox.TabIndex = 13
        Me.CustomerNameTextBox.Visible = False
        '
        'CustomerAddressTextBox
        '
        Me.CustomerAddressTextBox.Location = New System.Drawing.Point(149, 109)
        Me.CustomerAddressTextBox.Name = "CustomerAddressTextBox"
        Me.CustomerAddressTextBox.Size = New System.Drawing.Size(189, 20)
        Me.CustomerAddressTextBox.TabIndex = 21
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(149, 139)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(74, 20)
        Me.CustomerPhoneTextBox.TabIndex = 22
        '
        'CustomerTypeComboBox
        '
        Me.CustomerTypeComboBox.FormattingEnabled = True
        Me.CustomerTypeComboBox.Items.AddRange(New Object() {"Residential", "Small Business", "Medium Business", "Enterprise"})
        Me.CustomerTypeComboBox.Location = New System.Drawing.Point(149, 169)
        Me.CustomerTypeComboBox.Name = "CustomerTypeComboBox"
        Me.CustomerTypeComboBox.Size = New System.Drawing.Size(117, 21)
        Me.CustomerTypeComboBox.TabIndex = 23
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(149, 200)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(189, 20)
        Me.EmailAddressTextBox.TabIndex = 24
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(149, 79)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIDTextBox.TabIndex = 20
        '
        'CustomerNameComboBox
        '
        Me.CustomerNameComboBox.FormattingEnabled = True
        Me.CustomerNameComboBox.Location = New System.Drawing.Point(149, 48)
        Me.CustomerNameComboBox.Name = "CustomerNameComboBox"
        Me.CustomerNameComboBox.Size = New System.Drawing.Size(189, 21)
        Me.CustomerNameComboBox.TabIndex = 19
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.CustomerNameComboBox)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Customer_AddressLabel)
        Me.Controls.Add(Me.CustomerAddressTextBox)
        Me.Controls.Add(Customer_PhoneLabel)
        Me.Controls.Add(Me.CustomerPhoneTextBox)
        Me.Controls.Add(Customer_TypeLabel)
        Me.Controls.Add(Me.CustomerTypeComboBox)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveChangesButton)
        Me.Controls.Add(Me.DeleteCancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddSaveButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(550, 350)
        Me.MinimumSize = New System.Drawing.Size(550, 350)
        Me.Name = "CustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSaveButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCancelButton As System.Windows.Forms.Button
    Friend WithEvents SaveChangesButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DateToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameComboBox As System.Windows.Forms.ComboBox

End Class
