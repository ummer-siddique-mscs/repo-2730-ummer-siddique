'Name: Exercise 3D: Array subscripts, totals, avg, min
'Purpose:      Display the average number sold
'Programmer:   Ummer Siddique on 12/09/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}
    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        'Declare and initialize the daysInMonth array
        Dim intdaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intMonth As Integer
        Integer.TryParse(txtMonth.Text, intMonth)
        'IF month entered by user is valid, display days for selected month
        If intMonth > 0 AndAlso intMonth < 13 Then
            lblDays.Text = intdaysInMonth(intMonth - 1).ToString
            'otherwsie display the error message
        Else
            lblDays.Text = "Error"
        End If
        'set focus to txtMonth
        txtMonth.Focus()
    End Sub
    Private Sub txtMonth_Enter(sender As Object, e As EventArgs) Handles txtMonth.Enter
        'select all text for txtMonth
        txtMonth.SelectAll()
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays the average number sold
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intsub As Integer
        Dim intsub2 As Integer
        Dim dblTotal As Double
        Dim dblAverage As Double
        Do While intsub <= intHighSub
            dblTotal += intSold(intsub)
            intsub += 1
        Loop

        dblAverage = dblTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString
        ' displays all the values less than the average value
        Do While intsub2 <= intHighSub
            If intSold(intsub2) < dblAverage Then
                lblLessThanAvg.Text &= intSold(intsub2).ToString & ", "
            End If
            intsub2 += 1
        Loop
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays the average number sold
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim dblTotal As Double
        Dim dblAverage As Double
        For intsub As Integer = 0 To intHighSub
            dblTotal += intSold(intsub)
        Next intsub
        dblAverage = dblTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString

        ' displays all the values less than the average value
        For intsub As Integer = 0 To intHighSub
            If intSold(intsub) < dblAverage Then
                lblLessThanAvg.Text &= intSold(intsub).ToString & ", "
            End If
        Next intsub
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        ' displays the average number sold
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim dblTotal As Double
        Dim dblAverage As Double
        For Each dblValue As Double In intSold
            dblTotal += dblValue
        Next dblValue
        dblAverage = dblTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString

        ' displays all the values less than the average value
        For Each dblValue As Double In intSold
            If dblValue < dblAverage Then
                lblLessThanAvg.Text &= dblValue.ToString & ", "
            End If
        Next dblValue
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        lstRetail.Items.Clear()
        ' updates each array value and displays the updated values in lstRetail
        Dim dblInput As Double
        Dim strInput As String
        strInput = InputBox("Markup Rate %", "Enter Markup Rate", "50")
        Double.TryParse(strInput, dblInput)
        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = dblWholesale(intSub) + (dblWholesale(intSub) * (dblInput / 100))
            lstRetail.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub

    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub
End Class
