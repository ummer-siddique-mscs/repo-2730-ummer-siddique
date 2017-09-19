'Name:          Average Scores Project
'Purpose:       Calculates the values of 3 test scores
'Programmer:    Ummer Siddique on 09/18/2017

Option Strict On
Public Class frmName
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next set of scores
        txtscore1.Text = String.Empty
        txtscore2.Text = String.Empty
        txtscore3.Text = String.Empty
        lblAvgScore.Text = String.Empty
        ' send the focus to the Test Score 1 box
        txtscore1.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAvgScore.Text = Format((Val(txtscore1.Text) + Val(txtscore2.Text) + Val(txtscore3.Text)) / 3, "standard")
    End Sub
End Class
