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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_weekDetails = New System.Windows.Forms.DataGridView()
        Me.weekNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtb_cohortD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_cohortEndD = New System.Windows.Forms.DateTimePicker()
        Me.dtp_cohortStartD = New System.Windows.Forms.DateTimePicker()
        Me.cbox_lcType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_CohortStats = New System.Windows.Forms.GroupBox()
        Me.lbl_lcEndDate = New System.Windows.Forms.Label()
        Me.lbl_lcStartDate = New System.Windows.Forms.Label()
        Me.lbl_lcTypeInfo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Create = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_weekDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_CohortStats.SuspendLayout()
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
        'dg_weekDetails
        '
        Me.dg_weekDetails.AllowUserToAddRows = False
        Me.dg_weekDetails.AllowUserToDeleteRows = False
        Me.dg_weekDetails.AllowUserToResizeColumns = False
        Me.dg_weekDetails.AllowUserToResizeRows = False
        Me.dg_weekDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dg_weekDetails.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg_weekDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_weekDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg_weekDetails.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dg_weekDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_weekDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_weekDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_weekDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.weekNum, Me.startDate, Me.endDate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_weekDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_weekDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_weekDetails.EnableHeadersVisualStyles = False
        Me.dg_weekDetails.GridColor = System.Drawing.SystemColors.Window
        Me.dg_weekDetails.Location = New System.Drawing.Point(484, 128)
        Me.dg_weekDetails.MultiSelect = False
        Me.dg_weekDetails.Name = "dg_weekDetails"
        Me.dg_weekDetails.ReadOnly = True
        Me.dg_weekDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_weekDetails.RowHeadersVisible = False
        Me.dg_weekDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg_weekDetails.RowTemplate.Height = 24
        Me.dg_weekDetails.RowTemplate.ReadOnly = True
        Me.dg_weekDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_weekDetails.ShowCellErrors = False
        Me.dg_weekDetails.ShowCellToolTips = False
        Me.dg_weekDetails.ShowEditingIcon = False
        Me.dg_weekDetails.ShowRowErrors = False
        Me.dg_weekDetails.Size = New System.Drawing.Size(450, 425)
        Me.dg_weekDetails.TabIndex = 10
        Me.dg_weekDetails.Visible = False
        '
        'weekNum
        '
        Me.weekNum.HeaderText = "Week"
        Me.weekNum.Name = "weekNum"
        Me.weekNum.ReadOnly = True
        '
        'startDate
        '
        Me.startDate.HeaderText = "Start Date"
        Me.startDate.Name = "startDate"
        Me.startDate.ReadOnly = True
        '
        'endDate
        '
        Me.endDate.HeaderText = "End Date"
        Me.endDate.Name = "endDate"
        Me.endDate.ReadOnly = True
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
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(245, 597)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 49
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(83, 597)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 48
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "months"
        '
        'txtb_cohortD
        '
        Me.txtb_cohortD.Location = New System.Drawing.Point(199, 455)
        Me.txtb_cohortD.Name = "txtb_cohortD"
        Me.txtb_cohortD.Size = New System.Drawing.Size(51, 22)
        Me.txtb_cohortD.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 458)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Duration:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "End Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 507)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Start Date:"
        '
        'dtp_cohortEndD
        '
        Me.dtp_cohortEndD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cohortEndD.Location = New System.Drawing.Point(199, 549)
        Me.dtp_cohortEndD.Name = "dtp_cohortEndD"
        Me.dtp_cohortEndD.Size = New System.Drawing.Size(121, 22)
        Me.dtp_cohortEndD.TabIndex = 42
        '
        'dtp_cohortStartD
        '
        Me.dtp_cohortStartD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_cohortStartD.Location = New System.Drawing.Point(199, 504)
        Me.dtp_cohortStartD.Name = "dtp_cohortStartD"
        Me.dtp_cohortStartD.Size = New System.Drawing.Size(121, 22)
        Me.dtp_cohortStartD.TabIndex = 41
        Me.dtp_cohortStartD.Value = New Date(2018, 12, 27, 0, 0, 0, 0)
        '
        'cbox_lcType
        '
        Me.cbox_lcType.FormattingEnabled = True
        Me.cbox_lcType.Items.AddRange(New Object() {"Healthcare", "Technology"})
        Me.cbox_lcType.Location = New System.Drawing.Point(199, 409)
        Me.cbox_lcType.Name = "cbox_lcType"
        Me.cbox_lcType.Size = New System.Drawing.Size(121, 24)
        Me.cbox_lcType.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Learning Center Type:"
        '
        'gb_CohortStats
        '
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcEndDate)
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcStartDate)
        Me.gb_CohortStats.Controls.Add(Me.lbl_lcTypeInfo)
        Me.gb_CohortStats.Controls.Add(Me.Label9)
        Me.gb_CohortStats.Controls.Add(Me.Label8)
        Me.gb_CohortStats.Controls.Add(Me.Label7)
        Me.gb_CohortStats.Location = New System.Drawing.Point(44, 227)
        Me.gb_CohortStats.Name = "gb_CohortStats"
        Me.gb_CohortStats.Size = New System.Drawing.Size(248, 140)
        Me.gb_CohortStats.TabIndex = 51
        Me.gb_CohortStats.TabStop = False
        Me.gb_CohortStats.Text = "New Cohort Statistics:"
        Me.gb_CohortStats.Visible = False
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
        'btn_Create
        '
        Me.btn_Create.Enabled = False
        Me.btn_Create.Location = New System.Drawing.Point(164, 597)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(75, 23)
        Me.btn_Create.TabIndex = 52
        Me.btn_Create.Text = "Create"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'frm_NewCohort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.gb_CohortStats)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtb_cohortD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_cohortEndD)
        Me.Controls.Add(Me.dtp_cohortStartD)
        Me.Controls.Add(Me.cbox_lcType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_weekDetails)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frm_NewCohort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSAT :: Start New Cohort"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_weekDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_CohortStats.ResumeLayout(False)
        Me.gb_CohortStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dg_weekDetails As DataGridView
    Friend WithEvents weekNum As DataGridViewTextBoxColumn
    Friend WithEvents startDate As DataGridViewTextBoxColumn
    Friend WithEvents endDate As DataGridViewTextBoxColumn
    Friend WithEvents btn_OK As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtb_cohortD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_cohortEndD As DateTimePicker
    Friend WithEvents dtp_cohortStartD As DateTimePicker
    Friend WithEvents cbox_lcType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gb_CohortStats As GroupBox
    Friend WithEvents lbl_lcEndDate As Label
    Friend WithEvents lbl_lcStartDate As Label
    Friend WithEvents lbl_lcTypeInfo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_Create As Button
End Class
