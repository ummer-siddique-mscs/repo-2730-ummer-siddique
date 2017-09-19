' Name:             Bakery Project
' Purpose:          Calculates the total number of items sold and total sales
'Programmer:        Ummer Siddique on 09/10/2017
Option Strict On
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale
        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

        ' send the focus to the Doughnuts box
        txtDonuts.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        lblTotalItems.Text = Format(Val(txtDonuts.Text) + Val(txtMuffins.Text), "0")
        lblTotalSales.Text = Format(Val(lblTotalItems.Text) * 0.5, "currency")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
