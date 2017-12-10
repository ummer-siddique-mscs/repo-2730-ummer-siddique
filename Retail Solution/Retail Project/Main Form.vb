' Name:         Retail Project
' Purpose:      Increases each array value and displays the results
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        ' updates each array value and displays the updated values in lstRetail


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

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub
End Class
