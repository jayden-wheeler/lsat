Public Class frm_Login
    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        frm_ConnProp.Show()
        Me.Hide()
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        frm_Main.Show()
        Me.Hide()

    End Sub
End Class
