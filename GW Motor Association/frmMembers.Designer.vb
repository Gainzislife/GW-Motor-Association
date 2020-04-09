<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlModify = New System.Windows.Forms.Panel()
        Me.nudOutstandingFee = New System.Windows.Forms.NumericUpDown()
        Me.gbxGender = New System.Windows.Forms.GroupBox()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsbMembers = New System.Windows.Forms.ListBox()
        Me.pnlModify.SuspendLayout()
        CType(Me.nudOutstandingFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlModify
        '
        Me.pnlModify.Controls.Add(Me.nudOutstandingFee)
        Me.pnlModify.Controls.Add(Me.gbxGender)
        Me.pnlModify.Controls.Add(Me.Label6)
        Me.pnlModify.Controls.Add(Me.dtpBirthDate)
        Me.pnlModify.Controls.Add(Me.Label5)
        Me.pnlModify.Controls.Add(Me.txtLastName)
        Me.pnlModify.Controls.Add(Me.Label4)
        Me.pnlModify.Controls.Add(Me.Label3)
        Me.pnlModify.Controls.Add(Me.txtFirstName)
        Me.pnlModify.Controls.Add(Me.Label2)
        Me.pnlModify.Controls.Add(Me.btnUpdate)
        Me.pnlModify.Location = New System.Drawing.Point(228, 169)
        Me.pnlModify.Name = "pnlModify"
        Me.pnlModify.Size = New System.Drawing.Size(281, 187)
        Me.pnlModify.TabIndex = 16
        Me.pnlModify.Visible = False
        '
        'nudOutstandingFee
        '
        Me.nudOutstandingFee.Location = New System.Drawing.Point(104, 128)
        Me.nudOutstandingFee.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudOutstandingFee.Name = "nudOutstandingFee"
        Me.nudOutstandingFee.Size = New System.Drawing.Size(160, 20)
        Me.nudOutstandingFee.TabIndex = 12
        Me.nudOutstandingFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxGender
        '
        Me.gbxGender.Controls.Add(Me.rbnFemale)
        Me.gbxGender.Controls.Add(Me.rbnMale)
        Me.gbxGender.Location = New System.Drawing.Point(76, 89)
        Me.gbxGender.Name = "gbxGender"
        Me.gbxGender.Size = New System.Drawing.Size(188, 32)
        Me.gbxGender.TabIndex = 11
        Me.gbxGender.TabStop = False
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Location = New System.Drawing.Point(99, 9)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbnFemale.TabIndex = 1
        Me.rbnFemale.TabStop = True
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Location = New System.Drawing.Point(17, 9)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(48, 17)
        Me.rbnMale.TabIndex = 0
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Outstanding Fee:"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Location = New System.Drawing.Point(76, 67)
        Me.dtpBirthDate.MaxDate = New Date(2002, 3, 23, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(188, 20)
        Me.dtpBirthDate.TabIndex = 9
        Me.dtpBirthDate.Value = New Date(2002, 3, 23, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gender:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(76, 37)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(188, 20)
        Me.txtLastName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Birth Date:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(76, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(188, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(102, 161)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(330, 53)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(179, 110)
        Me.txtDisplay.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(228, 53)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(228, 140)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(228, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(228, 82)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Members"
        '
        'lsbMembers
        '
        Me.lsbMembers.FormattingEnabled = True
        Me.lsbMembers.Location = New System.Drawing.Point(12, 53)
        Me.lsbMembers.Name = "lsbMembers"
        Me.lsbMembers.Size = New System.Drawing.Size(181, 303)
        Me.lsbMembers.TabIndex = 9
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 367)
        Me.Controls.Add(Me.pnlModify)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsbMembers)
        Me.Name = "frmMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMembers"
        Me.pnlModify.ResumeLayout(False)
        Me.pnlModify.PerformLayout()
        CType(Me.nudOutstandingFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGender.ResumeLayout(False)
        Me.gbxGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlModify As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lsbMembers As ListBox
    Friend WithEvents gbxGender As GroupBox
    Friend WithEvents rbnMale As RadioButton
    Friend WithEvents rbnFemale As RadioButton
    Friend WithEvents nudOutstandingFee As NumericUpDown
End Class
