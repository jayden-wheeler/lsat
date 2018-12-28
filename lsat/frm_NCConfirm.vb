Public Class frm_NCConfirm
    Private Sub frm_NCConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_lcTypeInfo.Text = frm_NewCohort.cbox_lcType.Text
        lbl_lcStartDate.Text = frm_NewCohort.lbl_lcStartDate.Text
        lbl_lcEndDate.Text = frm_NewCohort.lbl_lcEndDate.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_NewCohort.Show()
        Me.Hide()
    End Sub
End Class