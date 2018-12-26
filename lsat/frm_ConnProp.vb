Public Class frm_ConnProp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close out the connection properties window and re-display the login form.
        ' This action does not save any of the modifications or additions to the form
        ' to the applications user properties.
        frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtb_dbUser_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbUser.TextChanged
        ' Save the text entered in the dbUser text box into the user settings.
        '
        My.Settings.dbUser = txtb_dbUser.Text
    End Sub

    Private Sub txtb_dbPass_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbPass.TextChanged
        ' Save the text entered in the dbPass text box into the user settings.
        '
        My.Settings.dbPass = txtb_dbPass.Text
    End Sub

    Private Sub txtb_dbName_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbName.TextChanged
        ' Save the text entered in the dbName text box into the user settings.
        '
        My.Settings.dbName = txtb_dbName.Text
    End Sub

    Private Sub txtb_dbHost_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbHost.TextChanged
        ' Save the text entered in the dbHost text box into the user settings.
        '
        My.Settings.dbHost = txtb_dbHost.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Write the new values to the system preferences object then close the form.
        My.Settings.Save()
        frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtb_dbPort_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbPort.TextChanged
        ' Save the text entered in the dbPort text box into the user settings.
        '
        My.Settings.dbPort = txtb_dbPort.Text
    End Sub
End Class