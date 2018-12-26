Public Class frm_ConnProp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close out the connection properties window and re-display the login form.
        ' This action does not save any of the modifications or additions to the form
        ' to the applications user properties.
        frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtb_dbUser.TextChanged

    End Sub
End Class