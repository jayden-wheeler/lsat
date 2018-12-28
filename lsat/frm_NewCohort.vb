Public Class frm_NewCohort
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Dim SemStartDates As List(Of Date)
        Dim SemEndDates As List(Of Date)
        Dim StartDate As Date
        Dim EndDate As Date

        StartDate = dtp_cohortStartD.Value
        EndDate = dtp_cohortEndD.Value

        SemStartDates = CalcSemWeekStartDates(StartDate, EndDate)
        SemEndDates = CalcSemWeekEndDates(StartDate, EndDate)

        dg_weekDetails.Visible = True

        For i As Integer = 0 To CalcSemWeekStartDates(StartDate, EndDate).Count - 1
            Dim rowData As String() = New String() {(i), SemStartDates(i), SemEndDates(i)}
            dg_weekDetails.Rows.Add(rowData)
            'MsgBox(SemStartDates(i) & " through " & SemEndDates(i))
        Next

        lbl_lcTypeInfo.Text = cbox_lcType.Text
        lbl_lcStartDate.Text = StartDate.ToShortDateString
        lbl_lcEndDate.Text = EndDate.ToShortDateString
        gb_CohortStats.Visible = True

        frm_NCConfirm.Show()

    End Sub
End Class