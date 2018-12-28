<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NCConfirm
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
        Me.gb_CohortStats = New System.Windows.Forms.GroupBox()
        Me.lbl_lcEndDate = New System.Windows.Forms.Label()
        Me.lbl_lcStartDate = New System.Windows.Forms.Label()
        Me.lbl_lcTypeInfo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gb_CohortStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_CohortStats
        '
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcEndDate)
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcStartDate)
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcTypeInfo)
        Me.gb_CohortStats.Controls.Add(Me.Label9)
        Me.gb_CohortStats.Controls.Add(Me.Label8)
        Me.gb_CohortStats.Controls.Add(Me.Label7)
        Me.gb_CohortStats.Location = New System.Drawing.Point(151, 160)
        Me.gb_CohortStats.Name = "gb_CohortStats"
        Me.gb_CohortStats.Size = New System.Drawing.Size(248, 140)
        Me.gb_CohortStats.TabIndex = 52
        Me.gb_CohortStats.TabStop = False
        Me.gb_CohortStats.Text = "New Cohort Statistics:"
        '
        'lbl_lcEndDate
        '
        Me.lbl_lcEndDate.AutoSize = True
        Me.lbl_lcEndDate.Location = New System.Drawing.Point(129, 101)
        Me.lbl_lcEndDate.Name = "lbl_lcEndDate"
        Me.lbl_lcEndDate.Size = New System.Drawing.Size(59, 17)
        Me.lbl_lcEndDate.TabIndex = 5
        Me.lbl_lcEndDate.Text = "Label12"
        '
        'lbl_lcStartDate
        '
        Me.lbl_lcStartDate.AutoSize = True
        Me.lbl_lcStartDate.Location = New System.Drawing.Point(129, 67)
        Me.lbl_lcStartDate.Name = "lbl_lcStartDate"
        Me.lbl_lcStartDate.Size = New System.Drawing.Size(59, 17)
        Me.lbl_lcStartDate.TabIndex = 4
        Me.lbl_lcStartDate.Text = "Label11"
        '
        'lbl_lcTypeInfo
        '
        Me.lbl_lcTypeInfo.AutoSize = True
        Me.lbl_lcTypeInfo.Location = New System.Drawing.Point(129, 33)
        Me.lbl_lcTypeInfo.Name = "lbl_lcTypeInfo"
        Me.lbl_lcTypeInfo.Size = New System.Drawing.Size(59, 17)
        Me.lbl_lcTypeInfo.TabIndex = 3
        Me.lbl_lcTypeInfo.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "End:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Start:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "LC Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 35)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Warning! This process cannot be reversed."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(529, 21)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "You are about to create a new cohort with the characteristics given below."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(627, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Please verify the information given, the start/end date, and the weekly date brea" &
    "kdown."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Please note that you can assign students to the cohort later."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Abort"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(477, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(429, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "NOTE: You MUST hit the 'Create' button on this dialog"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 23)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "and on the 'New Cohort' screen to create the cohort."
        '
        'frm_NCConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(723, 389)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gb_CohortStats)
        Me.Name = "frm_NCConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSAT :: New Cohort :: Confirmation"
        Me.gb_CohortStats.ResumeLayout(False)
        Me.gb_CohortStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_CohortStats As GroupBox
    Friend WithEvents lbl_lcEndDate As Label
    Friend WithEvents lbl_lcStartDate As Label
    Friend WithEvents lbl_lcTypeInfo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
