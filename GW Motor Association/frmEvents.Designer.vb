<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
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
        Me.lsbEvents = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.pnlModify = New System.Windows.Forms.Panel()
        Me.nudLaps = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.pnlModify.SuspendLayout()
        CType(Me.nudLaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsbEvents
        '
        Me.lsbEvents.FormattingEnabled = True
        Me.lsbEvents.Location = New System.Drawing.Point(12, 54)
        Me.lsbEvents.Name = "lsbEvents"
        Me.lsbEvents.Size = New System.Drawing.Size(181, 303)
        Me.lsbEvents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Events"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(228, 83)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 2
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(228, 112)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(228, 141)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(228, 54)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(330, 54)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(179, 110)
        Me.txtDisplay.TabIndex = 7
        '
        'pnlModify
        '
        Me.pnlModify.Controls.Add(Me.nudLaps)
        Me.pnlModify.Controls.Add(Me.Label6)
        Me.pnlModify.Controls.Add(Me.dtpDate)
        Me.pnlModify.Controls.Add(Me.txtLocation)
        Me.pnlModify.Controls.Add(Me.Label5)
        Me.pnlModify.Controls.Add(Me.txtRegFee)
        Me.pnlModify.Controls.Add(Me.Label4)
        Me.pnlModify.Controls.Add(Me.Label3)
        Me.pnlModify.Controls.Add(Me.txtTitle)
        Me.pnlModify.Controls.Add(Me.Label2)
        Me.pnlModify.Controls.Add(Me.btnUpdate)
        Me.pnlModify.Location = New System.Drawing.Point(228, 170)
        Me.pnlModify.Name = "pnlModify"
        Me.pnlModify.Size = New System.Drawing.Size(281, 187)
        Me.pnlModify.TabIndex = 8
        Me.pnlModify.Visible = False
        '
        'nudLaps
        '
        Me.nudLaps.Location = New System.Drawing.Point(114, 128)
        Me.nudLaps.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudLaps.Name = "nudLaps"
        Me.nudLaps.Size = New System.Drawing.Size(150, 20)
        Me.nudLaps.TabIndex = 11
        Me.nudLaps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Number Of Laps"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(64, 37)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(64, 97)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(200, 20)
        Me.txtLocation.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Location:"
        '
        'txtRegFee
        '
        Me.txtRegFee.Location = New System.Drawing.Point(114, 67)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(150, 20)
        Me.txtRegFee.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Registration Fee: R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(64, 7)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(200, 20)
        Me.txtTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title:"
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
        'frmEvents
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
        Me.Controls.Add(Me.lsbEvents)
        Me.Name = "frmEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Events"
        Me.pnlModify.ResumeLayout(False)
        Me.pnlModify.PerformLayout()
        CType(Me.nudLaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbEvents As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents pnlModify As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRegFee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudLaps As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDate As DateTimePicker
End Class
