<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NewCohort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_NewCohort))
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Months")
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_lcType = New System.Windows.Forms.ComboBox()
        Me.dtp_cohortStartD = New System.Windows.Forms.DateTimePicker()
        Me.dtp_cohortEndD = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtb_cohortD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cohortEndD = New System.Windows.Forms.Label()
        Me.lbl_cohortStartD = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_cohortDuration = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_cohortType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(65, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(698, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LSAT :: New Cohort"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Learning Center Type:"
        '
        'cbox_lcType
        '
        Me.cbox_lcType.FormattingEnabled = True
        Me.cbox_lcType.Items.AddRange(New Object() {"Healthcare", "Technology"})
        Me.cbox_lcType.Location = New System.Drawing.Point(221, 260)
        Me.cbox_lcType.Name = "cbox_lcType"
        Me.cbox_lcType.Size = New System.Drawing.Size(121, 24)
        Me.cbox_lcType.TabIndex = 4
        '
        'dtp_cohortStartD
        '
        Me.dtp_cohortStartD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cohortStartD.Location = New System.Drawing.Point(221, 355)
        Me.dtp_cohortStartD.Name = "dtp_cohortStartD"
        Me.dtp_cohortStartD.Size = New System.Drawing.Size(121, 22)
        Me.dtp_cohortStartD.TabIndex = 5
        Me.dtp_cohortStartD.Value = New Date(2018, 12, 27, 0, 0, 0, 0)
        '
        'dtp_cohortEndD
        '
        Me.dtp_cohortEndD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cohortEndD.Location = New System.Drawing.Point(221, 400)
        Me.dtp_cohortEndD.Name = "dtp_cohortEndD"
        Me.dtp_cohortEndD.Size = New System.Drawing.Size(121, 22)
        Me.dtp_cohortEndD.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Duration:"
        '
        'txtb_cohortD
        '
        Me.txtb_cohortD.Location = New System.Drawing.Point(221, 306)
        Me.txtb_cohortD.Name = "txtb_cohortD"
        Me.txtb_cohortD.Size = New System.Drawing.Size(51, 22)
        Me.txtb_cohortD.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "months"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_cohortEndD)
        Me.GroupBox1.Controls.Add(Me.lbl_cohortStartD)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_cohortDuration)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_cohortType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Location = New System.Drawing.Point(557, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 336)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Cohort Information:"
        '
        'lbl_cohortEndD
        '
        Me.lbl_cohortEndD.AutoSize = True
        Me.lbl_cohortEndD.Location = New System.Drawing.Point(104, 126)
        Me.lbl_cohortEndD.Name = "lbl_cohortEndD"
        Me.lbl_cohortEndD.Size = New System.Drawing.Size(59, 17)
        Me.lbl_cohortEndD.TabIndex = 9
        Me.lbl_cohortEndD.Text = "Label15"
        Me.lbl_cohortEndD.Visible = False
        '
        'lbl_cohortStartD
        '
        Me.lbl_cohortStartD.AutoSize = True
        Me.lbl_cohortStartD.Location = New System.Drawing.Point(104, 95)
        Me.lbl_cohortStartD.Name = "lbl_cohortStartD"
        Me.lbl_cohortStartD.Size = New System.Drawing.Size(59, 17)
        Me.lbl_cohortStartD.TabIndex = 8
        Me.lbl_cohortStartD.Text = "Label14"
        Me.lbl_cohortStartD.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "End Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Start Date:"
        '
        'lbl_cohortDuration
        '
        Me.lbl_cohortDuration.AutoSize = True
        Me.lbl_cohortDuration.Location = New System.Drawing.Point(104, 64)
        Me.lbl_cohortDuration.Name = "lbl_cohortDuration"
        Me.lbl_cohortDuration.Size = New System.Drawing.Size(59, 17)
        Me.lbl_cohortDuration.TabIndex = 5
        Me.lbl_cohortDuration.Text = "Label11"
        Me.lbl_cohortDuration.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Duration:"
        '
        'lbl_cohortType
        '
        Me.lbl_cohortType.AutoSize = True
        Me.lbl_cohortType.Location = New System.Drawing.Point(104, 33)
        Me.lbl_cohortType.Name = "lbl_cohortType"
        Me.lbl_cohortType.Size = New System.Drawing.Size(51, 17)
        Me.lbl_cohortType.TabIndex = 2
        Me.lbl_cohortType.Text = "Label8"
        Me.lbl_cohortType.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Type:"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(107, 163)
        Me.TreeView1.Name = "TreeView1"
        TreeNode5.Name = "Node0"
        TreeNode5.Text = "Months"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.TreeView1.Size = New System.Drawing.Size(249, 154)
        Me.TreeView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(870, 631)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(661, 655)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(187, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Back to Cohort Management"
        '
        'frm_NewCohort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtb_cohortD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_cohortEndD)
        Me.Controls.Add(Me.dtp_cohortStartD)
        Me.Controls.Add(Me.cbox_lcType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frm_NewCohort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSAT :: Start New Cohort"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbox_lcType As ComboBox
    Friend WithEvents dtp_cohortStartD As DateTimePicker
    Friend WithEvents dtp_cohortEndD As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtb_cohortD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents lbl_cohortEndD As Label
    Friend WithEvents lbl_cohortStartD As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_cohortDuration As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_cohortType As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
End Class
