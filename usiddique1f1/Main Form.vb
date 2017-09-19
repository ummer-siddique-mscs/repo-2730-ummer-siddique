'Name: Cranston Berries Project
'Purpose: Calculates Projected Sales
'Programmer" Ummer Siddique on 09/18/2017

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next projected sales calculation
        txtProjIncrease.Text = "0.01"
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        ' send the focus to the projected increase box
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate projected sales
        lblStraw.Text = Format(Val(txtStraw.Text) + (Val(txtProjIncrease.Text) * Val(txtStraw.Text)), "currency")
        lblBlue.Text = Format(Val(txtBlue.Text) + (Val(txtProjIncrease.Text) * Val(txtBlue.Text)), "currency")
        lblRasp.Text = Format(Val(txtRasp.Text) + (Val(txtProjIncrease.Text) * Val(txtRasp.Text)), "currency")
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
