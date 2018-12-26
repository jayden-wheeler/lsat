Public Class frm_Prefs
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub frm_Prefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load preferences from the system settings object and populate the associated
        ' text boxes.
        txtb_dbUser.Text = My.Settings.dbUser
        txtb_dbPass.Text = My.Settings.dbPass
        txtb_dbHost.Text = My.Settings.dbHost
        txtb_dbName.Text = My.Settings.dbName
        txtb_dbPort.Text = My.Settings.dbPort
    End Sub

End Class