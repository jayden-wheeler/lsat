<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Prefs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Prefs))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Database = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtb_dbPort = New System.Windows.Forms.TextBox()
        Me.txtb_dbHost = New System.Windows.Forms.TextBox()
        Me.txtb_dbName = New System.Windows.Forms.TextBox()
        Me.lbl_dbPort = New System.Windows.Forms.Label()
        Me.lbl_dbHost = New System.Windows.Forms.Label()
        Me.lbl_dbName = New System.Windows.Forms.Label()
        Me.txtb_dbPass = New System.Windows.Forms.TextBox()
        Me.lbl_dbPass = New System.Windows.Forms.Label()
        Me.txtb_dbUser = New System.Windows.Forms.TextBox()
        Me.lbl_dbUser = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Database.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(683, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LSAT :: Preferences"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Database)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(38, 232)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 375)
        Me.TabControl1.TabIndex = 2
        '
        'Database
        '
        Me.Database.Controls.Add(Me.Button2)
        Me.Database.Controls.Add(Me.Button1)
        Me.Database.Controls.Add(Me.GroupBox1)
        Me.Database.Location = New System.Drawing.Point(4, 30)
        Me.Database.Name = "Database"
        Me.Database.Padding = New System.Windows.Forms.Padding(3)
        Me.Database.Size = New System.Drawing.Size(857, 341)
        Me.Database.TabIndex = 0
        Me.Database.Text = "Database"
        Me.Database.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(621, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Defaults"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(719, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtb_dbPort)
        Me.GroupBox1.Controls.Add(Me.txtb_dbHost)
        Me.GroupBox1.Controls.Add(Me.txtb_dbName)
        Me.GroupBox1.Controls.Add(Me.lbl_dbPort)
        Me.GroupBox1.Controls.Add(Me.lbl_dbHost)
        Me.GroupBox1.Controls.Add(Me.lbl_dbName)
        Me.GroupBox1.Controls.Add(Me.txtb_dbPass)
        Me.GroupBox1.Controls.Add(Me.lbl_dbPass)
        Me.GroupBox1.Controls.Add(Me.txtb_dbUser)
        Me.GroupBox1.Controls.Add(Me.lbl_dbUser)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Properties:"
        '
        'txtb_dbPort
        '
        Me.txtb_dbPort.Location = New System.Drawing.Point(137, 211)
        Me.txtb_dbPort.Name = "txtb_dbPort"
        Me.txtb_dbPort.Size = New System.Drawing.Size(67, 28)
        Me.txtb_dbPort.TabIndex = 9
        '
        'txtb_dbHost
        '
        Me.txtb_dbHost.Location = New System.Drawing.Point(137, 167)
        Me.txtb_dbHost.Name = "txtb_dbHost"
        Me.txtb_dbHost.Size = New System.Drawing.Size(163, 28)
        Me.txtb_dbHost.TabIndex = 8
        '
        'txtb_dbName
        '
        Me.txtb_dbName.Location = New System.Drawing.Point(137, 123)
        Me.txtb_dbName.Name = "txtb_dbName"
        Me.txtb_dbName.Size = New System.Drawing.Size(163, 28)
        Me.txtb_dbName.TabIndex = 7
        '
        'lbl_dbPort
        '
        Me.lbl_dbPort.AutoSize = True
        Me.lbl_dbPort.Location = New System.Drawing.Point(25, 218)
        Me.lbl_dbPort.Name = "lbl_dbPort"
        Me.lbl_dbPort.Size = New System.Drawing.Size(68, 21)
        Me.lbl_dbPort.TabIndex = 6
        Me.lbl_dbPort.Text = "DB Port:"
        '
        'lbl_dbHost
        '
        Me.lbl_dbHost.AutoSize = True
        Me.lbl_dbHost.Location = New System.Drawing.Point(22, 174)
        Me.lbl_dbHost.Name = "lbl_dbHost"
        Me.lbl_dbHost.Size = New System.Drawing.Size(71, 21)
        Me.lbl_dbHost.TabIndex = 5
        Me.lbl_dbHost.Text = "DB Host:"
        '
        'lbl_dbName
        '
        Me.lbl_dbName.AutoSize = True
        Me.lbl_dbName.Location = New System.Drawing.Point(14, 130)
        Me.lbl_dbName.Name = "lbl_dbName"
        Me.lbl_dbName.Size = New System.Drawing.Size(79, 21)
        Me.lbl_dbName.TabIndex = 4
        Me.lbl_dbName.Text = "DB Name:"
        '
        'txtb_dbPass
        '
        Me.txtb_dbPass.Location = New System.Drawing.Point(137, 79)
        Me.txtb_dbPass.Name = "txtb_dbPass"
        Me.txtb_dbPass.Size = New System.Drawing.Size(163, 28)
        Me.txtb_dbPass.TabIndex = 3
        '
        'lbl_dbPass
        '
        Me.lbl_dbPass.AutoSize = True
        Me.lbl_dbPass.Location = New System.Drawing.Point(23, 86)
        Me.lbl_dbPass.Name = "lbl_dbPass"
        Me.lbl_dbPass.Size = New System.Drawing.Size(70, 21)
        Me.lbl_dbPass.TabIndex = 2
        Me.lbl_dbPass.Text = "DB Pass:"
        '
        'txtb_dbUser
        '
        Me.txtb_dbUser.Location = New System.Drawing.Point(137, 35)
        Me.txtb_dbUser.Name = "txtb_dbUser"
        Me.txtb_dbUser.Size = New System.Drawing.Size(163, 28)
        Me.txtb_dbUser.TabIndex = 1
        '
        'lbl_dbUser
        '
        Me.lbl_dbUser.AutoSize = True
        Me.lbl_dbUser.Location = New System.Drawing.Point(23, 42)
        Me.lbl_dbUser.Name = "lbl_dbUser"
        Me.lbl_dbUser.Size = New System.Drawing.Size(70, 21)
        Me.lbl_dbUser.TabIndex = 0
        Me.lbl_dbUser.Text = "DB User:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(857, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(839, 631)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(726, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Back to Main"
        '
        'frm_Prefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frm_Prefs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSAT :: Preferences"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Database.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Database As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtb_dbPort As TextBox
    Friend WithEvents txtb_dbHost As TextBox
    Friend WithEvents txtb_dbName As TextBox
    Friend WithEvents lbl_dbPort As Label
    Friend WithEvents lbl_dbHost As Label
    Friend WithEvents lbl_dbName As Label
    Friend WithEvents txtb_dbPass As TextBox
    Friend WithEvents lbl_dbPass As Label
    Friend WithEvents txtb_dbUser As TextBox
    Friend WithEvents lbl_dbUser As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
