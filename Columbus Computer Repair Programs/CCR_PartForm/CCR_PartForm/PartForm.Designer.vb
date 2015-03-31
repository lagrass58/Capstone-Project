<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartForm
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
        Dim Part_IDLabel As System.Windows.Forms.Label
        Dim Part_NameLabel As System.Windows.Forms.Label
        Dim Part_DescriptionLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PartIDTextBox = New System.Windows.Forms.TextBox()
        Me.PartNameComboBox = New System.Windows.Forms.ComboBox()
        Me.PartDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.AddSaveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteCancelButton = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PartNameTextBox = New System.Windows.Forms.TextBox()
        Part_IDLabel = New System.Windows.Forms.Label()
        Part_NameLabel = New System.Windows.Forms.Label()
        Part_DescriptionLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Part_IDLabel
        '
        Part_IDLabel.AutoSize = True
        Part_IDLabel.Location = New System.Drawing.Point(66, 91)
        Part_IDLabel.Name = "Part_IDLabel"
        Part_IDLabel.Size = New System.Drawing.Size(43, 13)
        Part_IDLabel.TabIndex = 6
        Part_IDLabel.Text = "Part ID:"
        '
        'Part_NameLabel
        '
        Part_NameLabel.AutoSize = True
        Part_NameLabel.Location = New System.Drawing.Point(49, 60)
        Part_NameLabel.Name = "Part_NameLabel"
        Part_NameLabel.Size = New System.Drawing.Size(60, 13)
        Part_NameLabel.TabIndex = 5
        Part_NameLabel.Text = "Part Name:"
        '
        'Part_DescriptionLabel
        '
        Part_DescriptionLabel.AutoSize = True
        Part_DescriptionLabel.Location = New System.Drawing.Point(24, 121)
        Part_DescriptionLabel.Name = "Part_DescriptionLabel"
        Part_DescriptionLabel.Size = New System.Drawing.Size(85, 13)
        Part_DescriptionLabel.TabIndex = 7
        Part_DescriptionLabel.Text = "Part Description:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(60, 151)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 8
        QuantityLabel.Text = "Quantity:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(58, 181)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 9
        LocationLabel.Text = "Location:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(75, 211)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "Price:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
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
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripStatusLabel, Me.TimeToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 1
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
        'PartIDTextBox
        '
        Me.PartIDTextBox.Location = New System.Drawing.Point(151, 88)
        Me.PartIDTextBox.Name = "PartIDTextBox"
        Me.PartIDTextBox.ReadOnly = True
        Me.PartIDTextBox.Size = New System.Drawing.Size(81, 20)
        Me.PartIDTextBox.TabIndex = 12
        '
        'PartNameComboBox
        '
        Me.PartNameComboBox.FormattingEnabled = True
        Me.PartNameComboBox.Location = New System.Drawing.Point(151, 57)
        Me.PartNameComboBox.Name = "PartNameComboBox"
        Me.PartNameComboBox.Size = New System.Drawing.Size(218, 21)
        Me.PartNameComboBox.TabIndex = 11
        '
        'PartDescriptionTextBox
        '
        Me.PartDescriptionTextBox.Location = New System.Drawing.Point(151, 118)
        Me.PartDescriptionTextBox.Name = "PartDescriptionTextBox"
        Me.PartDescriptionTextBox.Size = New System.Drawing.Size(218, 20)
        Me.PartDescriptionTextBox.TabIndex = 13
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(151, 148)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(81, 20)
        Me.QuantityTextBox.TabIndex = 14
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Location = New System.Drawing.Point(151, 178)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(121, 20)
        Me.LocationTextBox.TabIndex = 15
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(151, 208)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(81, 20)
        Me.PriceTextBox.TabIndex = 16
        '
        'AddSaveButton
        '
        Me.AddSaveButton.Location = New System.Drawing.Point(414, 54)
        Me.AddSaveButton.Name = "AddSaveButton"
        Me.AddSaveButton.Size = New System.Drawing.Size(89, 25)
        Me.AddSaveButton.TabIndex = 17
        Me.AddSaveButton.Text = "&Add Part"
        Me.AddSaveButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(414, 85)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(89, 25)
        Me.UpdateButton.TabIndex = 18
        Me.UpdateButton.Text = "&Update Part"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelButton
        '
        Me.DeleteCancelButton.Location = New System.Drawing.Point(414, 116)
        Me.DeleteCancelButton.Name = "DeleteCancelButton"
        Me.DeleteCancelButton.Size = New System.Drawing.Size(89, 25)
        Me.DeleteCancelButton.TabIndex = 19
        Me.DeleteCancelButton.Text = "&Delete Part"
        Me.DeleteCancelButton.UseVisualStyleBackColor = True
        '
        'SaveChangesButton
        '
        Me.SaveChangesButton.Location = New System.Drawing.Point(414, 176)
        Me.SaveChangesButton.Name = "SaveChangesButton"
        Me.SaveChangesButton.Size = New System.Drawing.Size(89, 25)
        Me.SaveChangesButton.TabIndex = 20
        Me.SaveChangesButton.Text = "&Save Changes"
        Me.SaveChangesButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(414, 206)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(89, 25)
        Me.CloseButton.TabIndex = 21
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PartNameTextBox
        '
        Me.PartNameTextBox.Location = New System.Drawing.Point(151, 57)
        Me.PartNameTextBox.Name = "PartNameTextBox"
        Me.PartNameTextBox.Size = New System.Drawing.Size(218, 20)
        Me.PartNameTextBox.TabIndex = 11
        Me.PartNameTextBox.Visible = False
        '
        'PartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.PartNameTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveChangesButton)
        Me.Controls.Add(Me.DeleteCancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddSaveButton)
        Me.Controls.Add(Part_IDLabel)
        Me.Controls.Add(Me.PartIDTextBox)
        Me.Controls.Add(Part_NameLabel)
        Me.Controls.Add(Me.PartNameComboBox)
        Me.Controls.Add(Part_DescriptionLabel)
        Me.Controls.Add(Me.PartDescriptionTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(550, 350)
        Me.MinimumSize = New System.Drawing.Size(550, 350)
        Me.Name = "PartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Part Form"
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
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DateToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PartIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PartDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddSaveButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCancelButton As System.Windows.Forms.Button
    Friend WithEvents SaveChangesButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents PartNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
