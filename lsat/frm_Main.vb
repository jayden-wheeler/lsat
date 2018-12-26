Public Class frm_Main
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frm_CohortMgmt.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_Prefs.Show()
        Me.Hide()
    End Sub
End Class