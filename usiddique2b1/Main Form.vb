'Name: Cranston Berries Project
'Purpose: Calculates Projected Sales
'Programmer" Ummer Siddique on 10/08/2017

Option Strict On
Option Explicit On
Option Infer Off

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
        Dim intStrawberries As Integer
        Dim intBlueberries As Integer
        Dim intRaspberries As Integer
        Dim decProjectedIncrease As Decimal
        Dim decProjstraw As Decimal
        Dim decProjrasp As Decimal
        Dim decProjblue As Decimal

        Integer.TryParse(txtStraw.Text, intStrawberries)
        Integer.TryParse(txtBlue.Text, intBlueberries)
        Integer.TryParse(txtRasp.Text, intRaspberries)
        Decimal.TryParse(txtProjIncrease.Text, decProjectedIncrease)

        decProjstraw = intStrawberries + (intStrawberries * decProjectedIncrease)
        decProjrasp = intRaspberries + (intRaspberries * decProjectedIncrease)
        decProjblue = intBlueberries + (intBlueberries * decProjectedIncrease)

        lblStraw.Text = decProjstraw.ToString("C2")
        lblBlue.Text = decProjblue.ToString("C2")
        lblRasp.Text = decProjrasp.ToString("C2")
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click
        frmRetirement.Show()
    End Sub
End Class
