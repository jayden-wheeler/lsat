<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.pbox_logoPic = New System.Windows.Forms.PictureBox()
        Me.lbl_sysTitle1 = New System.Windows.Forms.Label()
        Me.lbl_sysTitle2 = New System.Windows.Forms.Label()
        Me.lbl_Title3 = New System.Windows.Forms.Label()
        Me.lbl_usernameTxt = New System.Windows.Forms.Label()
        Me.lbl_passwdTxt = New System.Windows.Forms.Label()
        Me.txtb_uName = New System.Windows.Forms.TextBox()
        Me.txtb_pWord = New System.Windows.Forms.TextBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.pbox_logoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbox_logoPic
        '
        Me.pbox_logoPic.Image = CType(resources.GetObject("pbox_logoPic.Image"), System.Drawing.Image)
        Me.pbox_logoPic.Location = New System.Drawing.Point(38, 55)
        Me.pbox_logoPic.Name = "pbox_logoPic"
        Me.pbox_logoPic.Size = New System.Drawing.Size(207, 155)
        Me.pbox_logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_logoPic.TabIndex = 0
        Me.pbox_logoPic.TabStop = False
        '
        'lbl_sysTitle1
        '
        Me.lbl_sysTitle1.AutoSize = True
        Me.lbl_sysTitle1.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sysTitle1.Location = New System.Drawing.Point(683, 55)
        Me.lbl_sysTitle1.Name = "lbl_sysTitle1"
        Me.lbl_sysTitle1.Size = New System.Drawing.Size(279, 35)
        Me.lbl_sysTitle1.TabIndex = 1
        Me.lbl_sysTitle1.Text = "Larkin Street Academy"
        '
        'lbl_sysTitle2
        '
        Me.lbl_sysTitle2.AutoSize = True
        Me.lbl_sysTitle2.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sysTitle2.Location = New System.Drawing.Point(757, 90)
        Me.lbl_sysTitle2.Name = "lbl_sysTitle2"
        Me.lbl_sysTitle2.Size = New System.Drawing.Size(205, 35)
        Me.lbl_sysTitle2.TabIndex = 2
        Me.lbl_sysTitle2.Text = "Tracking System"
        '
        'lbl_Title3
        '
        Me.lbl_Title3.AutoSize = True
        Me.lbl_Title3.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title3.Location = New System.Drawing.Point(875, 125)
        Me.lbl_Title3.Name = "lbl_Title3"
        Me.lbl_Title3.Size = New System.Drawing.Size(87, 35)
        Me.lbl_Title3.TabIndex = 3
        Me.lbl_Title3.Text = "(LSAT)"
        '
        'lbl_usernameTxt
        '
        Me.lbl_usernameTxt.AutoSize = True
        Me.lbl_usernameTxt.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usernameTxt.Location = New System.Drawing.Point(408, 306)
        Me.lbl_usernameTxt.Name = "lbl_usernameTxt"
        Me.lbl_usernameTxt.Size = New System.Drawing.Size(70, 17)
        Me.lbl_usernameTxt.TabIndex = 4
        Me.lbl_usernameTxt.Text = "Username:"
        '
        'lbl_passwdTxt
        '
        Me.lbl_passwdTxt.AutoSize = True
        Me.lbl_passwdTxt.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passwdTxt.Location = New System.Drawing.Point(413, 342)
        Me.lbl_passwdTxt.Name = "lbl_passwdTxt"
        Me.lbl_passwdTxt.Size = New System.Drawing.Size(65, 17)
        Me.lbl_passwdTxt.TabIndex = 5
        Me.lbl_passwdTxt.Text = "Password:"
        '
        'txtb_uName
        '
        Me.txtb_uName.Location = New System.Drawing.Point(498, 301)
        Me.txtb_uName.Name = "txtb_uName"
        Me.txtb_uName.Size = New System.Drawing.Size(100, 22)
        Me.txtb_uName.TabIndex = 6
        '
        'txtb_pWord
        '
        Me.txtb_pWord.Location = New System.Drawing.Point(498, 337)
        Me.txtb_pWord.Name = "txtb_pWord"
        Me.txtb_pWord.Size = New System.Drawing.Size(100, 22)
        Me.txtb_pWord.TabIndex = 7
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(554, 386)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(89, 33)
        Me.btn_OK.TabIndex = 8
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(459, 386)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(89, 33)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.AutoSize = True
        Me.btn_Connect.Location = New System.Drawing.Point(364, 386)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(89, 33)
        Me.btn_Connect.TabIndex = 10
        Me.btn_Connect.Text = "Connection"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 631)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Version:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 631)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 671)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "© 2018-2019 All Rights Reserved"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 652)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Larkin Street Youth Services"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(586, 671)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(376, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "This software is protected by US and International copyright laws."
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txtb_pWord)
        Me.Controls.Add(Me.txtb_uName)
        Me.Controls.Add(Me.lbl_passwdTxt)
        Me.Controls.Add(Me.lbl_usernameTxt)
        Me.Controls.Add(Me.lbl_Title3)
        Me.Controls.Add(Me.lbl_sysTitle2)
        Me.Controls.Add(Me.lbl_sysTitle1)
        Me.Controls.Add(Me.pbox_logoPic)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LSAT :: Login"
        CType(Me.pbox_logoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbox_logoPic As PictureBox
    Friend WithEvents lbl_sysTitle1 As Label
    Friend WithEvents lbl_sysTitle2 As Label
    Friend WithEvents lbl_Title3 As Label
    Friend WithEvents lbl_usernameTxt As Label
    Friend WithEvents lbl_passwdTxt As Label
    Friend WithEvents txtb_uName As TextBox
    Friend WithEvents txtb_pWord As TextBox
    Friend WithEvents btn_OK As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Connect As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
