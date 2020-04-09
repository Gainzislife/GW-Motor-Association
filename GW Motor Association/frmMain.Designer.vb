<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewEvent = New System.Windows.Forms.Button()
        Me.btnNewMember = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewEvents = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gauteng West Motoring Association"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewEvent
        '
        Me.btnNewEvent.Location = New System.Drawing.Point(39, 122)
        Me.btnNewEvent.Name = "btnNewEvent"
        Me.btnNewEvent.Size = New System.Drawing.Size(102, 23)
        Me.btnNewEvent.TabIndex = 1
        Me.btnNewEvent.Text = "Add New Event"
        Me.btnNewEvent.UseVisualStyleBackColor = True
        '
        'btnNewMember
        '
        Me.btnNewMember.Location = New System.Drawing.Point(244, 122)
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(102, 23)
        Me.btnNewMember.TabIndex = 2
        Me.btnNewMember.Text = "Add New Member"
        Me.btnNewMember.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(142, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Manage Events"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Manage Members"
        '
        'btnViewEvents
        '
        Me.btnViewEvents.Location = New System.Drawing.Point(39, 151)
        Me.btnViewEvents.Name = "btnViewEvents"
        Me.btnViewEvents.Size = New System.Drawing.Size(102, 23)
        Me.btnViewEvents.TabIndex = 6
        Me.btnViewEvents.Text = "View Events"
        Me.btnViewEvents.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.Location = New System.Drawing.Point(244, 151)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(102, 23)
        Me.btnMembers.TabIndex = 7
        Me.btnMembers.Text = "View Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(142, 200)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(102, 23)
        Me.btnResults.TabIndex = 8
        Me.btnResults.Text = "View/Add Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 285)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnViewEvents)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewMember)
        Me.Controls.Add(Me.btnNewEvent)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewEvent As Button
    Friend WithEvents btnNewMember As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnViewEvents As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnResults As Button
End Class
