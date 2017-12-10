'Name: Exercise 3E: Arrays, Functions -  Search Commission Array
'Purpose:     Display counts of salespeople commissions
'Programmer:   Ummer Siddique on 12/09/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900, 150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()
        For intSub As Integer = 0 To intCommission.GetUpperBound(0)
            lblCommissions.Text &= intCommission(intSub).ToString & ", "
        Next intSub
        If lblCommissions.Text.EndsWith(", ") Then
            lblCommissions.Text = lblCommissions.Text.Substring(0, lblCommissions.Text.Length - 2)
        End If
    End Sub

    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged
        Dim intSearchValue As Integer
        Dim strSearchValue As String

        strSearchValue = cboSearchValues.Text
        Integer.TryParse(strSearchValue, intSearchValue)
        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            lblValueCount.Text = CountValue(intSearchValue).ToString()
        Else
            MessageBox.Show("Invalid Search Value. Please Enter a value from 0 to 1000.", "Search Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function CountValue(ByVal intSearchValueFunc As Integer) As Integer
        Dim intLastSub As Integer = intCommission.GetUpperBound(0)
        Dim intCount As Integer
        For intSub As Integer = 0 To intLastSub
            If intCommission(intSub) = intSearchValueFunc Then
                intCount += 1
            End If
        Next intsub
        Return intCount
    End Function



    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub

    Private Function CountRange(ByVal intSearchMinFunc As Integer, ByVal intSearchMaxFunc As Integer) As Integer
        Dim intLastSub As Integer = intCommission.GetUpperBound(0)
        Dim intCount As Integer
        For intSub As Integer = 0 To intLastSub
            If intCommission(intSub) >= intSearchMinFunc AndAlso intCommission(intSub) <= intSearchMaxFunc Then
                intCount += 1
            End If
        Next intSub
        Return intCount
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
