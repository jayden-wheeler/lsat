Module Common
    Function CalcSemWeekStartDates(startDate As Date, endDate As Date) As List(Of Date)
        Dim result As New List(Of Date)
        Dim checkDate = startDate
        Dim Is1stWeek As Boolean = True

        Do While checkDate <= endDate
            If checkDate.DayOfWeek = DayOfWeek.Friday Then
                result.Add(checkDate)
                If Is1stWeek Then Is1stWeek = False
            Else
                If Is1stWeek Then
                    result.Add(checkDate.AddDays(-checkDate.DayOfWeek + 1))
                    Is1stWeek = False
                End If
            End If
            checkDate = checkDate.AddDays(1)
        Loop
        Return result
    End Function

    Function CalcSemWeekEndDates(startDate As Date, endDate As Date) As List(Of Date)
        Dim result As New List(Of Date)
        Dim checkDate = startDate
        Dim Is1stWeek As Boolean = True

        Do While checkDate <= endDate
            If checkDate.DayOfWeek = DayOfWeek.Friday Then
                result.Add(checkDate.AddDays(6))
                If Is1stWeek Then Is1stWeek = False
            Else
                If Is1stWeek Then
                    result.Add(checkDate.AddDays(-checkDate.DayOfWeek + 1))
                    Is1stWeek = False
                End If
            End If
            checkDate = checkDate.AddDays(1)
        Loop
        Return result
    End Function
End Module
