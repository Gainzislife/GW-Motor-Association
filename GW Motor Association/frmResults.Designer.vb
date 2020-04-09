<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResults
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbxSelectMember = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxSelectRace = New System.Windows.Forms.ComboBox()
        Me.pnlResult = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudResult = New System.Windows.Forms.NumericUpDown()
        Me.lsbHistory = New System.Windows.Forms.ListBox()
        Me.pnlDisplay.SuspendLayout()
        Me.pnlResult.SuspendLayout()
        CType(Me.nudResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Results"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(192, 343)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cbxSelectMember
        '
        Me.cbxSelectMember.FormattingEnabled = True
        Me.cbxSelectMember.Location = New System.Drawing.Point(105, 54)
        Me.cbxSelectMember.Name = "cbxSelectMember"
        Me.cbxSelectMember.Size = New System.Drawing.Size(208, 21)
        Me.cbxSelectMember.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Select Member:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(74, 91)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'pnlDisplay
        '
        Me.pnlDisplay.Controls.Add(Me.lsbHistory)
        Me.pnlDisplay.Controls.Add(Me.pnlResult)
        Me.pnlDisplay.Controls.Add(Me.cbxSelectRace)
        Me.pnlDisplay.Controls.Add(Me.Label4)
        Me.pnlDisplay.Controls.Add(Me.Label3)
        Me.pnlDisplay.Location = New System.Drawing.Point(18, 86)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(434, 251)
        Me.pnlDisplay.TabIndex = 19
        Me.pnlDisplay.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Enter Race Results"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Select Race:"
        '
        'cbxSelectRace
        '
        Me.cbxSelectRace.FormattingEnabled = True
        Me.cbxSelectRace.Location = New System.Drawing.Point(81, 53)
        Me.cbxSelectRace.Name = "cbxSelectRace"
        Me.cbxSelectRace.Size = New System.Drawing.Size(142, 21)
        Me.cbxSelectRace.TabIndex = 20
        '
        'pnlResult
        '
        Me.pnlResult.Controls.Add(Me.nudResult)
        Me.pnlResult.Controls.Add(Me.btnUpdate)
        Me.pnlResult.Controls.Add(Me.Label5)
        Me.pnlResult.Location = New System.Drawing.Point(9, 100)
        Me.pnlResult.Name = "pnlResult"
        Me.pnlResult.Size = New System.Drawing.Size(214, 141)
        Me.pnlResult.TabIndex = 21
        Me.pnlResult.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enter Result"
        '
        'nudResult
        '
        Me.nudResult.Location = New System.Drawing.Point(58, 47)
        Me.nudResult.Name = "nudResult"
        Me.nudResult.Size = New System.Drawing.Size(120, 20)
        Me.nudResult.TabIndex = 1
        Me.nudResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lsbHistory
        '
        Me.lsbHistory.FormattingEnabled = True
        Me.lsbHistory.Location = New System.Drawing.Point(241, 4)
        Me.lsbHistory.Name = "lsbHistory"
        Me.lsbHistory.Size = New System.Drawing.Size(190, 238)
        Me.lsbHistory.TabIndex = 22
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 378)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxSelectMember)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.pnlDisplay.ResumeLayout(False)
        Me.pnlDisplay.PerformLayout()
        Me.pnlResult.ResumeLayout(False)
        Me.pnlResult.PerformLayout()
        CType(Me.nudResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents cbxSelectMember As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents cbxSelectRace As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlResult As Panel
    Friend WithEvents nudResult As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents lsbHistory As ListBox
End Class
