<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConnProp
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtb_dbPort = New System.Windows.Forms.TextBox()
        Me.txtb_dbHost = New System.Windows.Forms.TextBox()
        Me.txtb_dbName = New System.Windows.Forms.TextBox()
        Me.txtb_dbPass = New System.Windows.Forms.TextBox()
        Me.txtb_dbUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Test = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter your connection information below:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtb_dbPort)
        Me.GroupBox1.Controls.Add(Me.txtb_dbHost)
        Me.GroupBox1.Controls.Add(Me.txtb_dbName)
        Me.GroupBox1.Controls.Add(Me.txtb_dbPass)
        Me.GroupBox1.Controls.Add(Me.txtb_dbUser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(147, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 289)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Properties"
        '
        'txtb_dbPort
        '
        Me.txtb_dbPort.Location = New System.Drawing.Point(158, 200)
        Me.txtb_dbPort.Name = "txtb_dbPort"
        Me.txtb_dbPort.Size = New System.Drawing.Size(65, 22)
        Me.txtb_dbPort.TabIndex = 10
        '
        'txtb_dbHost
        '
        Me.txtb_dbHost.Location = New System.Drawing.Point(158, 165)
        Me.txtb_dbHost.Name = "txtb_dbHost"
        Me.txtb_dbHost.Size = New System.Drawing.Size(188, 22)
        Me.txtb_dbHost.TabIndex = 9
        '
        'txtb_dbName
        '
        Me.txtb_dbName.Location = New System.Drawing.Point(158, 130)
        Me.txtb_dbName.Name = "txtb_dbName"
        Me.txtb_dbName.Size = New System.Drawing.Size(188, 22)
        Me.txtb_dbName.TabIndex = 8
        '
        'txtb_dbPass
        '
        Me.txtb_dbPass.Location = New System.Drawing.Point(158, 92)
        Me.txtb_dbPass.Name = "txtb_dbPass"
        Me.txtb_dbPass.Size = New System.Drawing.Size(188, 22)
        Me.txtb_dbPass.TabIndex = 7
        '
        'txtb_dbUser
        '
        Me.txtb_dbUser.Location = New System.Drawing.Point(158, 55)
        Me.txtb_dbUser.Name = "txtb_dbUser"
        Me.txtb_dbUser.Size = New System.Drawing.Size(188, 22)
        Me.txtb_dbUser.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Host:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Database:"
        '
        'btn_Test
        '
        Me.btn_Test.Location = New System.Drawing.Point(193, 386)
        Me.btn_Test.Name = "btn_Test"
        Me.btn_Test.Size = New System.Drawing.Size(75, 23)
        Me.btn_Test.TabIndex = 4
        Me.btn_Test.Text = "Test"
        Me.btn_Test.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(274, 386)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(355, 386)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'frm_ConnProp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(622, 433)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frm_ConnProp"
        Me.Text = "frm_ConnProp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtb_dbPort As TextBox
    Friend WithEvents txtb_dbHost As TextBox
    Friend WithEvents txtb_dbName As TextBox
    Friend WithEvents txtb_dbPass As TextBox
    Friend WithEvents txtb_dbUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Test As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_OK As Button
End Class
