'Name:          Average Scores Project
'Purpose:       Calculates and displays the gross pay, FWT, FICA, State income tax and net pay
'Programmer:    Ummer Siddique on 09/24/2017
Option Strict On
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next set of values
        txtHours.Text = "0.00"
        txtPayRate.Text = "0.00"
        txtName.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        ' send the focus to the Name box
        txtName.Focus()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, withholdings, and net pay
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - (Val(lblFWT.Text) + Val(lblFICA.Text) + Val(lblState.Text)), "fixed")
    End Sub
End Class