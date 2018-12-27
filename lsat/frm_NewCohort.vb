Public Class frm_NewCohort
    Private Sub cbox_lcType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_lcType.SelectedIndexChanged
        ' If the cohort type is modified, change the informational text label value and show to the user.
        '
        lbl_cohortType.Text = cbox_lcType.Text
        lbl_cohortType.Visible = True
    End Sub

    Private Sub txtb_cohortD_TextChanged(sender As Object, e As EventArgs) Handles txtb_cohortD.TextChanged
        ' If the cohort duration is modified, change the informational text label value and show to the user.
        '
        lbl_cohortDuration.Text = txtb_cohortD.Text
        lbl_cohortDuration.Visible = True
    End Sub

    Private Sub dtp_cohortStartD_ValueChanged(sender As Object, e As EventArgs) Handles dtp_cohortStartD.ValueChanged
        ' If the cohort start date is modified, change the informational text label value and show to the user.
        '
        lbl_cohortStartD.Text = dtp_cohortStartD.Text
        lbl_cohortStartD.Visible = True
    End Sub

    Private Sub dtp_cohortEndD_ValueChanged(sender As Object, e As EventArgs) Handles dtp_cohortEndD.ValueChanged
        ' If the cohort end date is modified, change the informational text label value and show to the user.
        '
        lbl_cohortEndD.Text = dtp_cohortEndD.Text
        lbl_cohortEndD.Visible = True
    End Sub
End Class